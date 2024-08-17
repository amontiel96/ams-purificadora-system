/*en esta clase se consultan los gastos de produccion*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjPurificadora.Vista;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Modelo.DAO;
using System.Threading.Tasks;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;



namespace prjPurificadora.Controlador
{
    class cls_CGastosProduccion
    {
        frmReporteGProduccion frm = new frmReporteGProduccion();
        cls_ReportesDAO mtd = new cls_ReportesDAO();
        cls_ReporteVO dts = new cls_ReporteVO();
        Cls_Validaciones validar = new Cls_Validaciones();


        int d, m, a;
        string fechaI, fechaF;
        float total = 0, n = 0, m1 = 0, m2 = 0, toBote = 0, canVentas;
        double sellos, tapones,prsello=0,prtapon=0;

        /*
         fechaI día inicial
         * fechaF dái final
         * d-m-a son para obtener fecha inicial y fecha final
         * n se refiere a la canidad de unidades vendidas al precio normal
         * m1 se refiere a la cantidad de unidades vendidas al precio mayoreo1
         * m2 se refiere a la cantidad de unidades vendidas al precio mayoreo2
         * canVentas es la suma de n+m1+m2 para obtener las unidades totales
         * sellos es el total q se gasto en sellos
         * tapones es el total q se gasto en tapones
         * prsello es el precio del sello
         * prtopon es el precio del tapon
         */

        public void frm_load()
        {
            frm.btnContinuar.Click += btnContinuar_Click;
            frm.btnPDF.Click += btnPDF_Click;
            obtenerPreciosSellosYTapones();
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }

        void btnPDF_Click(object sender, EventArgs e)/*aqui se genera el archivo pdf*/
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
                    parrafo.Add("REPORTE DE GASTOS DE PRODUCCIÓN");
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
                    Tabla.SetWidthPercentage(new float[] { 90, 85, 80, 80, 85, 200 }, PageSize.A4);
                    Tabla.AddCell(new Paragraph("Proveedor"));
                    Tabla.AddCell(new Paragraph("Producto"));
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
                    parrafo.Alignment = Element.ALIGN_LEFT;
                    parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                    parrafo.Add("TOTAL PRODUCTOS: " + frm.lblProductos.Text);
                    doc.Add(parrafo);
                    parrafo.Clear();


                    doc.Add(new Paragraph("\n"));
                    parrafo.Add("TOTAL BOTELLONES: " + frm.lblBotellones.Text);
                    doc.Add(parrafo);
                    parrafo.Clear();

                    doc.Add(new Paragraph("\n"));
                    parrafo.Add("TOTAL SELLOS: " + frm.lblSellos.Text);
                    doc.Add(parrafo);
                    parrafo.Clear();

                    doc.Add(new Paragraph("\n"));
                    parrafo.Add("TOTAL TAPONES: " + frm.lblTapones.Text);
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
                 frm.tblBote.DataSource = null;
                 frm.tblReporte.DataSource = null;
                 frm.tblSellosyTapones.DataSource = null;
                 frm.btnPDF.Enabled = false;
             }
             else
             {
                 dts.setFechai(fechaI);
                 dts.setFechaf(fechaF);
                 llenarTabla();
             }
           
            calTotalTodo();
        }
        public void fechaInicial()
        {
            d = frm.dtFechai.Value.Day;
            m = frm.dtFechai.Value.Month;
            a = frm.dtFechai.Value.Year;
            fechaI = a + "-" + m + "-" + d;
        }/*se extrae la fecha inicial*/

        public void fechaFinal()
        {
            d = frm.dtFechaf.Value.Day;
            m = frm.dtFechaf.Value.Month;
            a = frm.dtFechaf.Value.Year;
            fechaF = a + "-" + m + "-" + d;
        }/*se extrae la fecha final*/
        public void llenarTabla()
        {
            try
            {
                frm.tblReporte.DataSource = mtd.mtdllenartabla(dts);
                frm.tblReporte.Columns[0].Visible = false;
                frm.tblReporte.Columns[2].Visible = false;
                frm.tblBote.DataSource = mtd.mtdllenartablaBotellonesProd(dts);
                frm.tblSellosyTapones.DataSource = mtd.mtdllenartablaVentas(dts);
                if(frm.tblReporte.Rows.Count <=1)
                {
                    MessageBox.Show("Aún no hay registros :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.btnPDF.Enabled = false;
                }else
                {
                    frm.btnPDF.Enabled = true;
                }
               
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
        public void calTotalTodo()/*una vez q ya se realizaron los calculos se ejecuta este metodo para sumar todo y obtener el total final*/
        {
            calBotelllones();
            calcularTotalSellos();
            calTotalProductos();
            frm.lblTotal.Text = "$ " + (float.Parse(frm.lblBotellones.Text) + float.Parse(frm.lblProductos.Text) + float.Parse(frm.lblSellos.Text) + float.Parse(frm.lblTapones.Text)).ToString();
        }
        public void calcularTotalSellos()/*este metodo obtenie lo q se gasto en sellos y tapones*/
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
            frm.lblSellos.Text =sellos.ToString();
            frm.lblTapones.Text = tapones.ToString();
        }
        public void calTotalProductos()/*este metodo obtiene lo q se gasto en las compras de los otros poductos*/
        {
            total = 0;
            for (int x = 0; x < frm.tblReporte.Rows.Count - 1;x++)
            {
                total = total + float.Parse(frm.tblReporte.Rows[x].Cells[6].Value.ToString());
            }
            frm.lblProductos.Text = total.ToString();
        }
        public void calBotelllones()/*este metodo es para obtener lo q se gasto en las compras unicamente de botellones*/
        {
            toBote = 0;
            for (int x = 0; x < frm.tblBote.Rows.Count - 1;x++)
            {
                toBote = toBote + float.Parse(frm.tblBote.Rows[x].Cells[5].Value.ToString());
            }
            frm.lblBotellones.Text = toBote.ToString();
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

    }
}
