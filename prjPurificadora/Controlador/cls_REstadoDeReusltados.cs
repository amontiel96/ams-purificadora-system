/*en esta clase se realiza el estado de resultados del mes actual*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Vista;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;
using System.Windows.Forms;
using System.Threading.Tasks;


using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

namespace prjPurificadora.Controlador
{
    class cls_REstadoDeReusltados
    {
        frmEstadoDeResultados frm = new frmEstadoDeResultados();
        cls_ReportesDAO mtd = new cls_ReportesDAO();
        cls_ReporteVO dts = new cls_ReporteVO();
        Cls_Validaciones validar = new Cls_Validaciones();

        DialogResult respuesta;
        int d, m, a;
        string fechaI, fechaF, fecha;
        float tVentas = 0, tCompra = 0, toBote = 0, total = 0, canVentas, n = 0, m1 = 0, m2 = 0,gventas=0;
        double sellos, tapones, prsello, prtapon;

        /*
         fecha es la fecha actual
         * fechaI día inicial del mes
         * fechaF día final del mes
         * tVentas son las ventas totales del mes
         * tCompra son las compras totales del mes
         * toBote es el total de botellones
         * total es para obtener el total gasto¿ado en produtos
         * canVentas son la cantidad de unidades vendidas
         * n se refiere a las unidades vendidas a precio normal
         * m1 se refiere a las unidades vendidas a precio mayoreo1
         * m2 se refiere a las unidades vendidas a precio mayoreo2
         * gVentas son los gastos de ventas de ese mes
         */

        public void frm_load()
        {
            frm.btnComfirmar.Click += btnComfirmar_Click;
            frm.btnContinuar.Click += btnContinuar_Click;
            obtenerPreciosSellosYTapones();
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }
        public void obtenerPreciosSellosYTapones()/*este metodo obtiene el recio del sello y tapon*/
        {
            try
            {
                frm.tblPrecios.DataSource = mtd.mtdllenarPreciosSyT();
                prsello = double.Parse(frm.tblPrecios.Rows[0].Cells[0].Value.ToString());
                prtapon = double.Parse(frm.tblPrecios.Rows[1].Cells[0].Value.ToString());
            }
            catch
            {

            }
        }

        void btnComfirmar_Click(object sender, EventArgs e)/*se crea el archivo pdf solamente si es el final del mes*/
        {
            MessageBox.Show("Antencion: es necesario que solo guarde este reporte al final del mes :)", "Aviso..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            respuesta = MessageBox.Show("¿Esta seguro de que es fin de mes?","Responda la pregunta...!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                GenerarPDF();
            }

        }

        void btnContinuar_Click(object sender, EventArgs e)
        {
            tVentas = 0;
            tCompra = 0;
            toBote = 0;
            total = 0;
            n = 0;
            m1 = 0;
            m2 = 0;
            gventas = 0;
            fechaInicial();
            fechaFinal();
            DateTime f1 = Convert.ToDateTime(fechaI);
            DateTime f2 = Convert.ToDateTime(fechaF);
            if (f1 > f2)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frm.tblVentas.DataSource = null;
                frm.tblCompras.DataSource = null;
                frm.tblAdministrador.DataSource = null;
                frm.tblGastosVenta.DataSource = null;
                frm.tblExtras.DataSource = null;
                calVentas();
                calCompras();
                llenarTabla();
                calTotalTodo();
                calAdmin();
                calGastosVentas();
                frm.tblinicioBote.DataSource = null;
                frm.tblFinalBote.DataSource = null;
                

                limpiar();
               
            }
            else
            {
                dts.setFechai(fechaI);
                dts.setFechaf(fechaF);
                frm.tblVentas.DataSource = mtd.mtdllenartablaVentas(dts);
                frm.tblCompras.DataSource = mtd.mtdllenartablaBotellones(dts);
                frm.tblAdministrador.DataSource = mtd.mtdllenartablaAdmin(dts);
                frm.tblGastosVenta.DataSource = mtd.mtdllenarGastosDeVentas(dts);
                frm.tblExtras.DataSource = mtd.mtdllenartablaExtras(dts);
                calVentas();
                calCompras();
                llenarTabla();
                calTotalTodo();
                calAdmin();
                calGastosVentas();
                InicialyFin();
                
            }
            

            frm.txtSumaMercancia.Text = frm.txtCompras.Text;
            frm.txtCostoVendido.Text = frm.txtCompras.Text;
            frm.txtUtilidadBruta.Text = (float.Parse(frm.txtVentasTotales.Text) - (float.Parse(frm.txtSumaMercancia.Text))).ToString();
            frm.txtGastosSumados.Text = ((float.Parse(frm.txtGastosProduccion.Text) + (float.Parse(frm.txtGastosAdmon.Text)) + (float.Parse(frm.txtGastosVenta.Text)))).ToString();
            frm.txtGastosFinancieros.Text = frm.txtGastosSumados.Text;
            frm.txtUtilidadOperacion.Text = (float.Parse(frm.txtUtilidadBruta.Text) - (float.Parse(frm.txtGastosFinancieros.Text))).ToString();
            frm.txtUtilidadNetaDelEjercicio.Text = (float.Parse(frm.txtUtilidadOperacion.Text) - (float.Parse(frm.txtTotaldeImpuestos.Text))).ToString();
       
                if (frm.txtVentasTotales.Text=="0"||frm.txtVentasTotales.Text=="")
                {
                    frm.btnComfirmar.Enabled = false;
                }
                else
                {
                    frm.btnComfirmar.Enabled = true;
                }
        
        }

        int iBote,fBote,iSello,fSello,iTapon,fTapon;
        public void InicialyFin()/*obtiene el inventario inicial y final del mes*/
        {
            dts.setIdBote(1);
            frm.tblinicioBote.DataSource = mtd.selInicialBote(dts);
            frm.tblFinalBote.DataSource = mtd.selFinalBote(dts);
            iBote = int.Parse(frm.tblinicioBote.Rows[0].Cells[0].Value.ToString());
            fBote = int.Parse(frm.tblFinalBote.Rows[0].Cells[0].Value.ToString());

            dts.setIdBote(2);
            frm.tblinicioBote.DataSource = mtd.selInicialBote(dts);
            frm.tblFinalBote.DataSource = mtd.selFinalBote(dts);
            iSello=int.Parse(frm.tblinicioBote.Rows[0].Cells[0].Value.ToString());
            fSello = int.Parse(frm.tblFinalBote.Rows[0].Cells[0].Value.ToString());


            dts.setIdBote(3);
            frm.tblinicioBote.DataSource = mtd.selInicialBote(dts);
            frm.tblFinalBote.DataSource = mtd.selFinalBote(dts);
            iTapon = int.Parse(frm.tblinicioBote.Rows[0].Cells[0].Value.ToString());
            fTapon = int.Parse(frm.tblFinalBote.Rows[0].Cells[0].Value.ToString());
            



            frm.txtInicioBote.Text = iBote.ToString();
            frm.txtInicioSello.Text = iSello.ToString();
            frm.txtInicioTapon.Text = iTapon.ToString();
            frm.txtFinalBote.Text = fBote.ToString();
            frm.txtFinalSello.Text = fSello.ToString();
            frm.txtFinalTapon.Text = fTapon.ToString();
        }

        public void fechaInicial()/*obtiene fecha inicial*/
        {
            d = frm.dtFechai.Value.Day;
            m = frm.dtFechai.Value.Month;
            a = frm.dtFechai.Value.Year;
            fechaI = a + "-" + m + "-" + d;
        }

        public void fechaFinal()/*obtiene fecha final*/
        {
            d = frm.dtFechaf.Value.Day;
            m = frm.dtFechaf.Value.Month;
            a = frm.dtFechaf.Value.Year;
            fechaF = a + "-" + m + "-" + d;
        }
        public void obtenerFecha()/*obtiene fecha actual*/
        {
            d = frm.dtFechaActual.Value.Day;
            m = frm.dtFechaActual.Value.Month;
            a = frm.dtFechaActual.Value.Year;
            fecha = a + "-" + m + "-" + d;
        }

        public void calGastosVentas()/*suma todos los gastos de ventas de ese mes*/
        {
            for (int x = 0; x < frm.tblGastosVenta.Rows.Count - 1;x++)
            {
                gventas = gventas + float.Parse(frm.tblGastosVenta.Rows[x].Cells[0].Value.ToString());
            }
            frm.txtGastosVenta.Text=gventas.ToString();
        }

        public void calVentas()/*obtiene as ventas totales*/
        {
            for (int x = 0; x < frm.tblVentas.Rows.Count - 1;x++)
            {
                tVentas = tVentas + float.Parse(frm.tblVentas.Rows[x].Cells[11].Value.ToString());
            }
            frm.txtVentasTotales.Text = tVentas.ToString();
        }
        public void calCompras()/*suma el total de las compras*/
        {
            for (int x = 0; x < frm.tblCompras.Rows.Count - 1;x++)
            {
                tCompra = tCompra + float.Parse(frm.tblCompras.Rows[x].Cells[6].Value.ToString());
            }
            frm.txtCompras.Text = tCompra.ToString();
        }


        double gastoProduccion;
        public void calTotalTodo()/*pasa a sumar todo lo q se calculo anteriormente*/
        {
            calBotelllones();
            calcularTotalSellos();
            calTotalProductos();
            gastoProduccion = toBote + total + sellos + tapones;
            frm.txtGastosProduccion.Text = gastoProduccion.ToString();
            
        }
        public void calcularTotalSellos()/*calula las compras de sellos y tapones*/
        {
            n = 0;
            m1 = 0;
            m2 = 0;
            for (int x = 0; x < frm.tblSellosyTapones.Rows.Count - 1; x++)
            {
                n = n + float.Parse(frm.tblSellosyTapones.Rows[x].Cells[4].Value.ToString());
                m1 = m1 + float.Parse(frm.tblSellosyTapones.Rows[x].Cells[5].Value.ToString());
                m2 = m2 + float.Parse(frm.tblSellosyTapones.Rows[x].Cells[6].Value.ToString());
            }
            canVentas = n + m1 + m2;
            sellos = canVentas * prsello;
            tapones = canVentas * prtapon;

        }
        public void calTotalProductos()/*calcula los q se gastos en las compras de productos*/
        {
            total = 0;
            for (int x = 0; x < frm.tblReporte.Rows.Count - 1; x++)
            {
                total = total + float.Parse(frm.tblReporte.Rows[x].Cells[5].Value.ToString());
            }

        }
        public void calBotelllones()/*calcula lo q se compro unicamente en botellones*/
        {
            toBote = 0;
            for (int x = 0; x < frm.tblBote.Rows.Count - 1; x++)
            {
                toBote = toBote + float.Parse(frm.tblBote.Rows[x].Cells[5].Value.ToString());
            }

        }
        float gastoadmin=0,gextra=0;
        public void calAdmin()/*suma todos los gastos del administrador del mes*/
        {
            gastoadmin = 0;
            gextra = 0;
            for (int x = 0; x < frm.tblAdministrador.Rows.Count - 1;x++)
            {
                gastoadmin = gastoadmin + float.Parse(frm.tblAdministrador.Rows[x].Cells[8].Value.ToString());
            }
            for (int x = 0; x < frm.tblExtras.Rows.Count - 1;x++ )
            {
                gextra = gextra + float.Parse(frm.tblExtras.Rows[x].Cells[3].Value.ToString());
            }
            frm.txtGastosAdmon.Text = (gastoadmin + gextra).ToString();
        }

        public void llenarTabla()
        {
            frm.tblReporte.DataSource = mtd.mtdllenartabla(dts);
            frm.tblBote.DataSource = mtd.mtdllenartablaBotellonesProd(dts);
            frm.tblSellosyTapones.DataSource = mtd.mtdllenartablaVentas(dts);
        }

        public void guardarInventario()/*este metodo hace una actualizacion a la base donde el inventario final pasa aser el inventario inicial del siguiente mes*/
        {
            dts.setIdBote(1);
            dts.setInicial(Convert.ToInt32(frm.txtFinalBote.Text));
            mtd.insControlInventario(dts);

            dts.setIdBote(2);
            dts.setInicial(Convert.ToInt32(frm.txtFinalSello.Text));
            mtd.insControlInventario(dts);

            dts.setIdBote(3);
            dts.setInicial(Convert.ToInt32(frm.txtFinalTapon.Text));
            mtd.insControlInventario(dts);
        }

        public void GenerarPDF()/*este metodo crea el archivo pdf solamente al final del mes*/
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
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                parrafo.Add("ESTADO DE RESULTADOS DEL MES");
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
                parrafo.Add("VENTAS TOTALES: " + frm.txtVentasTotales.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("COMPRAS: " + frm.txtCompras.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("SUMA TOTAL DE MERCANCIA: " + frm.txtSumaMercancia.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("COSTO DE LO VENDIDO: " + frm.txtCostoVendido.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("UTILIDAD BRUTA: " + frm.txtUtilidadBruta.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("GASTOS DE PRODUCCIÓN: " + frm.txtGastosProduccion.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("GASTOS DE ADMINISTRADOR: " + frm.txtGastosAdmon.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("GASTOS DE VENTAS: " + frm.txtGastosVenta.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("PRODUCTOS FINANCIEROS: " + frm.txtProductosFinancieros.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("GASTOS FINANCIEROS: " + frm.txtGastosFinancieros.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("UTILIDAD DE OPERACIÓN: " + frm.txtUtilidadOperacion.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("TOTAL DE IMPUESTOS: " + frm.txtTotaldeImpuestos.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("UTILIDAD NETA DEL EJERCICIO: " + frm.txtUtilidadNetaDelEjercicio.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Alignment = Element.ALIGN_CENTER;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                parrafo.Add("INVENTARIO INICIAL DE MES");
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));
                parrafo.Alignment = Element.ALIGN_LEFT;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);

                parrafo.Add("BOTELLONES : " + frm.txtInicioBote.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("SELLOS : " + frm.txtInicioSello.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("TAPONES : " + frm.txtInicioTapon.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Alignment = Element.ALIGN_CENTER;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                parrafo.Add("INVENTARIO FINAL DEL MES");
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));
                parrafo.Alignment = Element.ALIGN_LEFT;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);

                parrafo.Add("BOTELLONES : " + frm.txtFinalBote.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("SELLOS : " + frm.txtFinalSello.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                parrafo.Add("TAPONES : " + frm.txtFinalTapon.Text);
                doc.Add(parrafo);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));


                doc.Close();
                MessageBox.Show("Reporte Guardado exitosamente :) ","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                guardarInventario();
                System.Diagnostics.Process.Start(saveFileDialog1.FileName);
            }
            catch
            {
                MessageBox.Show("Acción cancelada :(","No se guardo el repore!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        public void limpiar()
        {
            frm.txtCompras.Text = "0";
            frm.txtCostoVendido.Text = "0";
            frm.txtFinalBote.Text = "0";
            frm.txtFinalSello.Text = "0";
            frm.txtFinalTapon.Text = "0";
            frm.txtGastosAdmon.Text = "0";
            frm.txtGastosFinancieros.Text = "0";
            frm.txtGastosProduccion.Text = "0";
            frm.txtGastosSumados.Text = "0";
            frm.txtGastosVenta.Text = "0";
            frm.txtInicioBote.Text = "0";
            frm.txtInicioSello.Text = "0";
            frm.txtInicioTapon.Text = "0";
            frm.txtProductosFinancieros.Text = "0";
            frm.txtSumaMercancia.Text = "0";
            frm.txtTotaldeImpuestos.Text = "0";
            frm.txtUtilidadBruta.Text = "0";
            frm.txtUtilidadNetaDelEjercicio.Text = "0";
            frm.txtUtilidadOperacion.Text = "0";
            frm.txtVentasTotales.Text = "0";
        }

    }
}
