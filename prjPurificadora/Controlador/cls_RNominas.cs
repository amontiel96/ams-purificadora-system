/*en esta clase se consultan las nominas de los empleados y vendedores por semana*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Vista;
using System.Threading.Tasks;


using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

namespace prjPurificadora.Controlador
{
    class cls_RNominas
    {
        frmRNominas frm = new frmRNominas();
        cls_ReportesDAO mtd = new cls_ReportesDAO();
        cls_ReporteVO dts = new cls_ReporteVO();


        int d, m, a;
        string fechaI, fechaF;

        /*
         * fechaI día inical
         * fechaF día final
         * d-m-a son para obtener las fechas inical y fecha final
         */

        public void frm_load()
        {
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
                Document doc = new Document(PageSize.A4.Rotate(), 90F, 90F, 30F, 30F);
                PdfWriter escrito = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate));
                doc.Open();
                string urls = @"C:\Purificadora\RECURSOS\bannerReporte.jpg";
                iTextSharp.text.Image jpgs = iTextSharp.text.Image.GetInstance(urls);

                jpgs.Alignment = Element.ALIGN_CENTER;
                doc.Add(jpgs);

                Paragraph parrafo = new Paragraph();
                parrafo.Alignment = Element.ALIGN_CENTER;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                parrafo.Add("REPORTE DE NOMINAS");
                doc.Add(parrafo);
                parrafo.Clear();


                doc.Add(new Paragraph("\n"));
                parrafo.Alignment = Element.ALIGN_CENTER;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                parrafo.Add("Realizado entre: " + frm.dtFechai.Value.ToShortDateString() + " Y " + frm.dtFechaf.Value.ToShortDateString());
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                PdfPTable Tabla = new PdfPTable(12);
                Tabla.SetWidthPercentage(new float[] { 68, 65, 65, 85, 70, 65, 60, 73, 58, 58, 80, 58 }, PageSize.A4.Rotate());
                Tabla.AddCell(new Paragraph("Nombre"));
                Tabla.AddCell(new Paragraph("AP"));
                Tabla.AddCell(new Paragraph("AM"));
                Tabla.AddCell(new Paragraph("CURP"));
                Tabla.AddCell(new Paragraph("Domicilio"));
                Tabla.AddCell(new Paragraph("Puesto"));
                Tabla.AddCell(new Paragraph("Salario"));
                Tabla.AddCell(new Paragraph("Comisión"));
                Tabla.AddCell(new Paragraph("Deuda"));
                Tabla.AddCell(new Paragraph("Bono"));
                Tabla.AddCell(new Paragraph("Despensa"));
                Tabla.AddCell(new Paragraph("Total"));


                foreach (PdfPCell celda in Tabla.Rows[0].GetCells())
                {
                    celda.BackgroundColor = BaseColor.LIGHT_GRAY;
                    celda.HorizontalAlignment = 1;
                    celda.Padding = 3;
                }


                for (int i = 0; i < frm.tblReporte.Rows.Count - 1; i++)
                {
                    PdfPCell celda1 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[0].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda2 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[1].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda3 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[2].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda4 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[3].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda5 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[4].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda6 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[5].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda7 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[6].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda8 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[7].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda9 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[8].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda10 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[9].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda11 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[10].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda12 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[11].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                   
                    


                    Tabla.AddCell(celda1);
                    Tabla.AddCell(celda2);
                    Tabla.AddCell(celda3);
                    Tabla.AddCell(celda4);
                    Tabla.AddCell(celda5);
                    Tabla.AddCell(celda6);
                    Tabla.AddCell(celda7);
                    Tabla.AddCell(celda8);
                    Tabla.AddCell(celda9);
                    Tabla.AddCell(celda10);
                    Tabla.AddCell(celda11);
                    Tabla.AddCell(celda12);



                }
                doc.Add(Tabla);
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
            try
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
            }
            else
            {
                llenarNominas();
            }
               
            }
            catch
            {
                MessageBox.Show("Verifique su conexion :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        public void llenarNominas()
        {
            try
            {
                dts.setFechai(fechaI);
                dts.setFechaf(fechaF);
                frm.tblReporte.DataSource = mtd.mtdNominas(dts);
                frm.tblReporte.Columns[12].Visible = false;
                if (frm.tblReporte.Rows.Count <= 1)
                {
                    MessageBox.Show("Aún no hay registros :)", "Aviso...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.btnPDF.Enabled = false;
                }
                else
                {
                    frm.btnPDF.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta...!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
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

    }
}
