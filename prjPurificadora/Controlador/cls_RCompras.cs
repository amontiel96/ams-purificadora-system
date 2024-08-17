/*en esta clase se consultan las compras realizadas de sellos y tapones unicamente*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Vista;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;


namespace prjPurificadora.Controlador
{
    class cls_RCompras
    {
        frmRCompras frm = new frmRCompras();
         cls_ReportesDAO mtd = new cls_ReportesDAO();
        cls_ReporteVO dts = new cls_ReporteVO();


        int d, m, a;
        string fechaI, fechaF;
        float total=0;

        /*
         fechaI día inicial
         * fechaF día final
         * d-m-a son para obtener las fechas inicial,final y actual
         * total es la suma de los subtotales de las compras
         */

        public void frm_load()
        {
            frm.btnContinuar.Click += btnContinuar_Click;
            frm.btnPDF.Click += btnPDF_Click;
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }

        void btnPDF_Click(object sender, EventArgs e)/*se crea el archivo pdf*/
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
                parrafo.Add("REPORTE DE COMPRAS");
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Alignment = Element.ALIGN_CENTER;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                parrafo.Add("Realizado entre: " + frm.dtFechai.Value.ToShortDateString() + " Y " + frm.dtFechaf.Value.ToShortDateString());
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                PdfPTable Tabla = new PdfPTable(6);
                Tabla.SetWidthPercentage(new float[] { 100, 100, 120, 100, 100, 200 }, PageSize.A4);
                Tabla.AddCell(new Paragraph("Producto"));
                Tabla.AddCell(new Paragraph("Proveedor"));
                Tabla.AddCell(new Paragraph("Cantidad"));
                Tabla.AddCell(new Paragraph("Precio"));
                Tabla.AddCell(new Paragraph("Subtotal"));
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
                    PdfPCell celda2 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[3].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda3 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[4].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda4 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[5].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda5 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[6].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda6 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[7].Value.ToString(), FontFactory.GetFont("Arial", 10)));

                    Tabla.AddCell(celda1);
                    Tabla.AddCell(celda2);
                    Tabla.AddCell(celda3);
                    Tabla.AddCell(celda4);
                    Tabla.AddCell(celda5);
                    Tabla.AddCell(celda6);


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
                dts.setFechai(fechaI);
                dts.setFechaf(fechaF);
                llenarTabla();
                calTotal();
            }

            
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
        public void llenarTabla()
        {
            try
            {
                frm.tblReporte.DataSource = mtd.mtdllenartablaBotellones(dts);
                frm.tblReporte.Columns[0].Visible = false;
                frm.tblReporte.Columns[2].Visible = false;
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
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
        public void calTotal()/*este metodo suma todos los totales de las compras*/
        {
            total = 0;
            for (int x = 0; x < frm.tblReporte.Rows.Count - 1; x++)
            {
                total = total +float.Parse(frm.tblReporte.Rows[x].Cells[6].Value.ToString());
            }
            frm.lblTotal.Text = "$ " + total.ToString();
        }
    }
}
