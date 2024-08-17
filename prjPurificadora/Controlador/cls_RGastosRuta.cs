/*en esta clase se hacen las consultas de los gastos de ruta ya sea en general o por vendedor especifico*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Vista;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

namespace prjPurificadora.Controlador
{
    class cls_RGastosRuta
    {
        frmRGastosRuta frm = new frmRGastosRuta();
        cls_ReportesDAO mtd = new cls_ReportesDAO();
        cls_ReporteVO dts = new cls_ReporteVO();


        int d, m, a, idvendedor;
        string fechaI, fechaF, fecha;
        float total,gasolina=0,refaccion=0,mecanico=0;

        /*
         fecha es la fecha actual
         * fechaI día inical
         * fechaF día final
         * d-m-a son para obtener las fechas inical,final y actual
         * gasolina es lo q gasto en total de gasolina
         * refaccion es lo q gasto en total en refaccionaria
         * mecanico es lo q gasto en total en mecanico
         */

        public void frm_load()
        {
            llenacombo();
            frm.btnContinuar.Click += btnContinuar_Click;
            frm.btnPDF.Click += btnPDF_Click;
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }

        void btnPDF_Click(object sender, EventArgs e)/*crea el archivo en pdf*/
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
                parrafo.Add("REPORTE DE GASTOS DE RUTA");
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Alignment = Element.ALIGN_CENTER;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                parrafo.Add("Realizado entre: " + frm.dtFechai.Value.ToShortDateString() + " Y " + frm.dtFechaf.Value.ToShortDateString());
                doc.Add(parrafo);
                parrafo.Clear();

                if (frm.rbtGeneral.Checked == true)
                {
                    doc.Add(new Paragraph("\n"));
                    parrafo.Alignment = Element.ALIGN_CENTER;
                    parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                    parrafo.Add("Reporte en General");
                    doc.Add(parrafo);
                    parrafo.Clear();
                }
                else
                {
                    doc.Add(new Paragraph("\n"));
                    parrafo.Alignment = Element.ALIGN_CENTER;
                    parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                    parrafo.Add("Reporte del vendedor: "+frm.cmbVendedor.Text);
                    doc.Add(parrafo);
                    parrafo.Clear();
                }
               

                doc.Add(new Paragraph("\n"));
                PdfPTable Tabla = new PdfPTable(5);
                Tabla.SetWidthPercentage(new float[] { 120, 85, 120, 85, 200 }, PageSize.A4);
                Tabla.AddCell(new Paragraph("Vendedor"));
                Tabla.AddCell(new Paragraph("Gasolina"));
                Tabla.AddCell(new Paragraph("Refacción"));
                Tabla.AddCell(new Paragraph("Mecanico"));
                Tabla.AddCell(new Paragraph("Fecha"));
             



                foreach (PdfPCell celda in Tabla.Rows[0].GetCells())
                {
                    celda.BackgroundColor = BaseColor.LIGHT_GRAY;
                    celda.HorizontalAlignment = 1;
                    celda.Padding = 3;
                }


                for (int i = 0; i < frm.tblReporte.Rows.Count - 1; i++)
                {
                    PdfPCell celda1 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[1].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda2 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[2].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda3 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[3].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda4 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[4].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda5 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[5].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                   

                    Tabla.AddCell(celda1);
                    Tabla.AddCell(celda2);
                    Tabla.AddCell(celda3);
                    Tabla.AddCell(celda4);
                    Tabla.AddCell(celda5);


                }
                doc.Add(Tabla);
                parrafo.Clear();


                doc.Add(new Paragraph("\n"));
                parrafo.Alignment = Element.ALIGN_CENTER;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13);
                parrafo.Add("TOTALES");
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Alignment = Element.ALIGN_LEFT;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                parrafo.Add("TOTAL GASOLINA: " + frm.lblGasolina.Text);
                doc.Add(parrafo);
                parrafo.Clear();


                doc.Add(new Paragraph("\n"));
                parrafo.Add("TOTAL REFACCIÓN: " + frm.lblRefaccion.Text);
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Add("TOTAL MECANICO: " + frm.lblMecanico.Text);
                doc.Add(parrafo);
                parrafo.Clear();

               
                doc.Add(new Paragraph("\n"));
                parrafo.Add("TOTAL EN GENERAL : " + frm.lblTotal.Text);
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

        void btnContinuar_Click(object sender, EventArgs e)
        {
            fechaInicial();
            fechaFinal();
            DateTime f1 = Convert.ToDateTime(fechaI);
            DateTime f2 = Convert.ToDateTime(fechaF);
            if (f1 > f2)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frm.tblReporte.DataSource = null;
                frm.btnPDF.Enabled = false;
                calTotal();
            }
            else
            {
                if (frm.rbtGeneral.Checked == true)//si el reporte va ser en general
                {
                    enviar();
                    llenarTabla();
                    calTotal();
                }
                else if (frm.rbtEspecifico.Checked == true)//si el reporte va ser de un vendedor especifico
                {
                    idvendedor = Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString());
                    dts.setIdVendedor(idvendedor);
                    enviar();
                    llenarTablaEspecifica();
                    calTotal();
                }
            }
            
            
        }
        public void enviar()
        {
            fechaInicial();
            fechaFinal();
            dts.setFechai(fechaI);
            dts.setFechaf(fechaF);
            
            
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
       
        public void llenarTabla()/*consulta de gastos en general*/
        {
            try
            {
                frm.tblReporte.DataSource = mtd.mtdllenartablaRuta(dts);
                frm.tblReporte.Columns[0].Visible = false;
                if(frm.tblReporte.Rows.Count<=1)
                {
                    MessageBox.Show("Aún no hay registros :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.btnPDF.Enabled = false;
                }
                else
                {
                    frm.btnPDF.Enabled = true;
                }
            }
            catch
            {

            }
            
        }
        public void llenacombo()
        {
            frm.cmbVendedor.DataSource = mtd.mtdllenarVendedor();
            frm.cmbVendedor.DisplayMember = "vchNombre";
            frm.cmbVendedor.ValueMember = "intIdVendedorPK";
        }
        public void llenarTablaEspecifica()/*consulta de gastos de vendedor especifico*/
        {
            try
            {
                frm.tblReporte.DataSource = mtd.mtdllenartablaRutaEspecifico(dts);
                frm.tblReporte.Columns[0].Visible = false;
                if (frm.tblReporte.Rows.Count <= 1)
                {
                    MessageBox.Show("Aún no hay registros :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.btnPDF.Enabled = false;
                }
                else
                {
                    frm.btnPDF.Enabled = true;
                }
            }
            catch
            {

            }
            
        }
        public void calTotal()/*suma todos los totales y muestra el total general en gastos*/
        {
            total = 0;
            gasolina = 0;
            refaccion = 0;
            mecanico = 0;
            for (int x = 0; x < frm.tblReporte.Rows.Count - 1; x++)
            {
                gasolina = gasolina + float.Parse(frm.tblReporte.Rows[x].Cells[2].Value.ToString());
                refaccion = refaccion + float.Parse(frm.tblReporte.Rows[x].Cells[3].Value.ToString());
                mecanico = mecanico + float.Parse(frm.tblReporte.Rows[x].Cells[4].Value.ToString());
            }
            frm.lblGasolina.Text = gasolina.ToString();
            frm.lblMecanico.Text = mecanico.ToString();
            frm.lblRefaccion.Text = refaccion.ToString();
            total = gasolina + refaccion + mecanico;
            frm.lblTotal.Text = "$ " + total.ToString();
        }
    }
}
