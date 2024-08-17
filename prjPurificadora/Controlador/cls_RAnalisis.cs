/*en esta clase se realizan los analisis de los vendedores a la semana*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Modelo.Conexion;
using prjPurificadora.Vista;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

namespace prjPurificadora.Controlador
{
    class cls_RAnalisis
    {
        frmAnalisis frm = new frmAnalisis();
        cls_ReportesDAO mtd = new cls_ReportesDAO();
        cls_ReporteVO dts = new cls_ReporteVO();
        Cls_Validaciones validar = new Cls_Validaciones();

        int d, m, a, idvendedor;
        string fechaI, fechaF, fecha;
        float total, gasolina = 0, refaccion = 0, mecanico = 0, n = 0, m1 = 0, m2 = 0, toUni,sueldo=0;

        /*
         * fecha es la fecha actual
         * fechaI d+ia inical de la semana
         * fechaF día final de la semana
         d-m-a son para obtener las fechas inicial,final y actual
         * gasolina es el total q gasto en gasolina
         * refaccion es el total q gasto en refacciones
         * mecanico es el total q gasto en mecanico
         * n se refiere a la cantidad de unidades de precio normal
         * m1 se refiere a la cantidad de unidades de precio mayoreo1
         * m2 se refiere a la cantidad de unidades de precio mayoreo2
         * toUni se refiere a la cantidad de unidades total vendidas
         * sueldo es el sueldo registrado de esa semana del vendedor
         */

        public void frm_load()
        {
            llenacombo();
            frm.btnContinuar.Click += btnContinuar_Click;
            frm.btnComfirmarAnalisis.Click += btnComfirmarAnalisis_Click;
            frm.btnPDF.Click += btnPDF_Click;
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }

        void btnPDF_Click(object sender, EventArgs e)
        {
            generarPDF();
        }
        string nombre;//es el nombre obtenido de la fecha para verificar q ya sea sabado
        int idgastoexiste;
        void btnComfirmarAnalisis_Click(object sender, EventArgs e)
        {
            try
            {
                /*primero se verifica q sea sabado y q ya todo esta bien para enviar los datos a la base de datos*/
                //nombre = frm.dtFechaActual.Value.Date.DayOfWeek.ToString();
                //if (!(nombre == "Saturday" || nombre == "saturday" || nombre == "Sabado" || nombre == "sabado"))
                //{
                //    MessageBox.Show("Aún no es sabado para guardar este analisis :( ", "Verifique la fecha de su computador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //else
                //{
                    if (frm.txtCanVentas.Text == "0")
                    {
                        MessageBox.Show("Sino realizo ningun movimiento en esta semana, Nose puede guardar este ánalisis :(", "Alerta...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (frm.txtSueldo.Text == "0")
                        {
                            MessageBox.Show("Nose ha realizado el pago a este vendedor, Nose puede guardar este ánalisis :(", "Alerta...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if(validar.mtd_mensaje()==1)
                            {
                                obtenerFecha();
                                dts.setGasto(float.Parse(frm.txtGastosVentas.Text));
                                dts.setIdVendedor(Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString()));
                                dts.setFecha(fecha);
                                frm.tblExiste.DataSource = mtd.mtdVerificaAnalisis(dts);
                                if (frm.tblExiste.Rows.Count >= 1)
                                {
                                    if (MessageBox.Show("Ya se ha realizo el analisis a este vendedor, Desea continuar para cambiarlo??", "Responda la pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        idgastoexiste = Convert.ToInt32(frm.tblExiste.Rows[0].Cells[0].Value.ToString());
                                        //actualizar registro
                                        dts.setIdGasto(idgastoexiste);
                                        mtd.mtdUpdateAnalisis(dts);
                                        MessageBox.Show("Analisis actualizado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    mtd.mtdInsertarAnalisis(dts);
                                    MessageBox.Show("Analisis Guardado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                
                            }
                            
                        }
                        
                    }
                    
               // }
                
            }
            catch
            {
                MessageBox.Show("Verifique su conexion :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                fechaInicial();
                fechaFinal();
                DateTime f1 = Convert.ToDateTime(fechaI);
                DateTime f2 = Convert.ToDateTime(fechaF);
                if (f1 > f2)
               {
                    MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frm.tblGastosRuta.DataSource = null;
                    frm.tblSueldo.DataSource = null;
                    frm.tblVentas.DataSource = null;
                }
                else
                    {
                        llenarTablaGastos();
                        llenarTablaSueldo();
                        llenarTablaVentas();
                     }
               

                calSueldo();
                calTotal();
                calTotalGastos();
                calFinal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
           

        }
        public void enviar()
        {
            idvendedor = Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString());
            dts.setIdVendedor(idvendedor);
            fechaInicial();
            fechaFinal();
            dts.setFechai(fechaI);
            dts.setFechaf(fechaF);


        }
        public void fechaInicial()/*obtiene la fecha inicial*/
        {
            d = frm.dtFechai.Value.Day;
            m = frm.dtFechai.Value.Month;
            a = frm.dtFechai.Value.Year;
            fechaI = a + "-" + m + "-" + d;
        }

        public void fechaFinal()/*obtiene la fecha final*/
        {
            d = frm.dtFechaf.Value.Day;
            m = frm.dtFechaf.Value.Month;
            a = frm.dtFechaf.Value.Year;
            fechaF = a + "-" + m + "-" + d;
        }
        public void obtenerFecha()/*obtiene la fecha actual*/
        {
            d = frm.dtFechaActual.Value.Day;
            m = frm.dtFechaActual.Value.Month;
            a = frm.dtFechaActual.Value.Year;
            fecha = a + "-" + m + "-" + d;
        }
        public void llenarTablaSueldo()/*obtiene el suldo obtenido en esa semana*/
        {
            try
            {
                obtenerFecha();
                enviar();
                dts.setFecha(fecha);
                frm.tblSueldo.DataSource = mtd.mtdllenarSueldo(dts);
            }
            catch{}
            
        }
        public void llenarTablaVentas()/*obtiene sueldo de esa semana del vendedor*/
        {
            try
            {
                enviar();
                frm.tblVentas.DataSource = mtd.mtdllenartablaVentasEspecifico(dts);
            }
            catch{}
            
        }
        public void llenarTablaGastos()/*obtiene los gastos de esa semana del vendedor*/
        {
            try
            {
                enviar();
                frm.tblGastosRuta.DataSource = mtd.mtdllenartablaRutaEspecifico(dts);
            }
            catch{}
           
        }
        public void llenacombo()
        {
            try
            {
                frm.cmbVendedor.DataSource = mtd.mtdllenarVendedor();
                frm.cmbVendedor.DisplayMember = "vchNombre";
                frm.cmbVendedor.ValueMember = "intIdVendedorPK";
            }
            catch{}
            
        }

        public void calTotalGastos()/*suma los gastos del vendedor*/
        {
            total = 0;
            gasolina = 0;
            refaccion = 0;
            mecanico = 0;
            for (int x = 0; x < frm.tblGastosRuta.Rows.Count - 1; x++)
            {
                gasolina = gasolina + float.Parse(frm.tblGastosRuta.Rows[x].Cells[2].Value.ToString());
                refaccion = refaccion + float.Parse(frm.tblGastosRuta.Rows[x].Cells[3].Value.ToString());
                mecanico = mecanico + float.Parse(frm.tblGastosRuta.Rows[x].Cells[4].Value.ToString());
            }
            frm.txtGasolina.Text = gasolina.ToString();
            frm.txtMeca.Text = mecanico.ToString();
            frm.txtRefaccion.Text = refaccion.ToString();
            total = gasolina + refaccion + mecanico;
        }
        
        public void calSueldo()/*calcula el sueldo del vendedor*/
        {
            sueldo = 0;
            for (int x = 0; x < frm.tblSueldo.Rows.Count - 1;x++)
            {
                sueldo = sueldo + float.Parse(frm.tblSueldo.Rows[x].Cells[0].Value.ToString());
            }
            frm.txtSueldo.Text = sueldo.ToString();
        }

        public void calTotal()/*calcula el total de ventas*/
        {
            total = 0;
            n = 0;
            m1 = 0;
            m2 = 0;
            for (int x = 0; x < frm.tblVentas.Rows.Count - 1; x++)
            {
                n = n + Convert.ToInt32(frm.tblVentas.Rows[x].Cells[4].Value.ToString());
                m1 = m1 + Convert.ToInt32(frm.tblVentas.Rows[x].Cells[6].Value.ToString());
                m2 = m2 + Convert.ToInt32(frm.tblVentas.Rows[x].Cells[8].Value.ToString());
                total = total + float.Parse(frm.tblVentas.Rows[x].Cells[11].Value.ToString());
            }
            toUni = n + m1 + m2;
            frm.txtCanVentas.Text = toUni.ToString();    
            frm.txtMoney.Text = total.ToString();
        }

        public void calFinal()/*realiza los calculos finales del analisis*/
        {
            frm.txtGastosVentas.Text = (gasolina + refaccion + mecanico + sueldo).ToString();
            frm.txtUtilidadTrabajador.Text = (float.Parse(frm.txtMoney.Text) - (float.Parse(frm.txtGastosVentas.Text))).ToString();
            frm.txtCostoPorUnidad.Text = (float.Parse(frm.txtGastosVentas.Text) / toUni).ToString();
            if (float.Parse(frm.txtUtilidadTrabajador.Text) <= 0)
            {
                frm.txtUtilidadTrabajador.ForeColor = Color.Red;
            }
            else
            {
                frm.txtUtilidadTrabajador.ForeColor = Color.Black;
            }

        }

        public void generarPDF()/*este metodo genera el archivo en pdf*/
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "pdf Archivo|*.pdf";
                saveFileDialog1.Title = "Guardar Reporte en";
                saveFileDialog1.ShowDialog();
                Document doc = new Document(PageSize.A4, 90F, 90F, 30F, 30F);
                PdfWriter escrito = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate));
                doc.Open();
                string urls = @"C:\Purificadora\RECURSOS\bannerReporte.jpg";
                iTextSharp.text.Image jpgs = iTextSharp.text.Image.GetInstance(urls);
                jpgs.Alignment = Element.ALIGN_CENTER;
                doc.Add(jpgs);

                Paragraph parrafo = new Paragraph();
                parrafo.Alignment = Element.ALIGN_CENTER;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                parrafo.Add("ÁNALISIS DE VENDEDOR: "+frm.cmbVendedor.Text);
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Alignment = Element.ALIGN_CENTER;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                parrafo.Add("Realizado entre: " + frm.dtFechai.Value.ToShortDateString() + " Y " + frm.dtFechaf.Value.ToShortDateString());
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Alignment = Element.ALIGN_LEFT;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);

                doc.Add(new Paragraph("\n"));
                parrafo.Add("VENTAS : "+frm.txtCanVentas.Text+" ------ "+frm.txtMoney.Text);
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Add("GASOLINA : "+frm.txtGasolina.Text);
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Add("REFACCION : "+frm.txtRefaccion.Text);
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Add("MANTENIMIENTO : "+frm.txtMeca.Text);
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Add("SUELDO : "+frm.txtSueldo.Text);
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Add("GASTOS DE VENTAS : "+frm.txtGastosVentas.Text);
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Add("UTILIDAD DEL TRABAJADOR : "+frm.txtUtilidadTrabajador.Text);
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Add("COSTO POR UNIDAD : "+frm.txtCostoPorUnidad.Text);
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Close();
                MessageBox.Show("Archivo guardado exitosamente :)", "Aviso...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(saveFileDialog1.FileName);

            }
            catch (Exception m)
            {
                MessageBox.Show("Accion Cancelada :)", "Aviso...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
