/*en esta clase se consultan las unidades producidas al año y se genera una grafica*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Threading.Tasks;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Vista;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

namespace prjPurificadora.Controlador
{
    class cls_RUnidadesProducidas
    {
        frmRUnidadesProducidas frm = new frmRUnidadesProducidas();
        cls_ReportesDAO mtd = new cls_ReportesDAO();
        cls_ReporteVO dts = new cls_ReporteVO();

        int[] meses = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] UnidadesMes=new int[12];
        string fechaI, fechaF, fecha;
        int d, m, a;

        /*
         meses[] es para guardar las unidades producidas en cada mes
         * unidadesMes[] es para pasar los valores q tiene meses
         * fechaI día inical
         * fechaF día final
         * d-m-a son para obtener las fechas inical y fecha final
         */

        public void frm_load()
        {
            try
            {
                frm.btnGraficar.Click += btnGraficar_Click;
                frm.btnPDF.Click += btnPDF_Click;
                Application.EnableVisualStyles();
                frm.ShowDialog();
            }
            catch
            {
            }
            
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
                parrafo.Add("GRAFICA DE LAS UNIDADES PRODUCIDAS POR MES");
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Alignment = Element.ALIGN_CENTER;
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                parrafo.Add("Realizado entre: " + frm.dtFechai.Value.ToShortDateString() + " Y " + frm.dtFechaf.Value.ToShortDateString());
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                PdfPTable Tabla = new PdfPTable(12);
                Tabla.SetWidthPercentage(new float[] { 68, 68, 68, 85, 65, 65, 60, 58, 58, 58, 58, 58 }, PageSize.A4);
                Tabla.AddCell(new Paragraph("Ene"));
                Tabla.AddCell(new Paragraph("Feb"));
                Tabla.AddCell(new Paragraph("Mar"));
                Tabla.AddCell(new Paragraph("Abr"));
                Tabla.AddCell(new Paragraph("May"));
                Tabla.AddCell(new Paragraph("Jun"));
                Tabla.AddCell(new Paragraph("Jul"));
                Tabla.AddCell(new Paragraph("Ago"));
                Tabla.AddCell(new Paragraph("Sep"));
                Tabla.AddCell(new Paragraph("Oct"));
                Tabla.AddCell(new Paragraph("Nov"));
                Tabla.AddCell(new Paragraph("Dic"));

                foreach (PdfPCell celda in Tabla.Rows[0].GetCells())
                {
                    celda.BackgroundColor = BaseColor.LIGHT_GRAY;
                    celda.HorizontalAlignment = 1;
                    celda.Padding = 3;
                }
                
                PdfPCell celda1 = new PdfPCell(new Paragraph(frm.txtEnero.Text, FontFactory.GetFont("Arial", 10)));
                PdfPCell celda2 = new PdfPCell(new Paragraph(frm.txtFebrero.Text, FontFactory.GetFont("Arial", 10)));
                PdfPCell celda3 = new PdfPCell(new Paragraph(frm.txtMarzo.Text, FontFactory.GetFont("Arial", 10)));
                PdfPCell celda4 = new PdfPCell(new Paragraph(frm.txtAbril.Text, FontFactory.GetFont("Arial", 10)));
                PdfPCell celda5 = new PdfPCell(new Paragraph(frm.txtMayo.Text, FontFactory.GetFont("Arial", 10)));
                PdfPCell celda6 = new PdfPCell(new Paragraph(frm.txtJunio.Text, FontFactory.GetFont("Arial", 10)));
                PdfPCell celda7 = new PdfPCell(new Paragraph(frm.txtJulio.Text, FontFactory.GetFont("Arial", 10)));
                PdfPCell celda8 = new PdfPCell(new Paragraph(frm.txtAgosto.Text, FontFactory.GetFont("Arial", 10)));
                PdfPCell celda9 = new PdfPCell(new Paragraph(frm.txtSeptiembre.Text, FontFactory.GetFont("Arial", 10)));
                PdfPCell celda10 = new PdfPCell(new Paragraph(frm.txtOctubre.Text, FontFactory.GetFont("Arial", 10)));
                PdfPCell celda11 = new PdfPCell(new Paragraph(frm.txtNoviembre.Text, FontFactory.GetFont("Arial", 10)));
                PdfPCell celda12 = new PdfPCell(new Paragraph(frm.txtDiciembre.Text, FontFactory.GetFont("Arial", 10)));

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

                doc.Add(Tabla);
                parrafo.Clear();
                doc.Add(new Paragraph("\n"));

                frm.Cht_Poli.SaveImage("C:/Purificadora/RECURSOS/histograma.jpg", ChartImageFormat.Jpeg);
                doc.Add(new Paragraph("\n"));
                string url = "C:/Purificadora/RECURSOS/histograma.jpg";
                iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(url);
                jpg.ScaleToFit(400f, 350f);
                jpg.SpacingBefore = 10f;
                jpg.SpacingAfter = 1f;
                jpg.Alignment = Element.ALIGN_CENTER;
                doc.Add(jpg);
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

        void btnGraficar_Click(object sender, EventArgs e)
        {
            enviar();
             DateTime f1 = Convert.ToDateTime(fechaI);
            DateTime f2 = Convert.ToDateTime(fechaF);
            if (f1 > f2)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frm.btnPDF.Enabled = false;
                frm.btnGraficar.Enabled = true;
            }
            else
            {
                llenarTabla();
                
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
        public void enviar()
        {
            fechaInicial();
            fechaFinal();
            dts.setFechai(fechaI);
            dts.setFechaf(fechaF);
        }
        public void llenarTabla()
        {
            try
            {
                frm.tblReporte.DataSource = mtd.mtdllenarUnidades(dts);
                if (frm.tblReporte.Rows.Count <= 1)
                {
                    MessageBox.Show("No hay registros para esta fechas ", "Aviso...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.btnGraficar.Enabled = true;
                    frm.btnPDF.Enabled = false;
                }
                else
                {
                    irIgualando();
                    frm.btnGraficar.Enabled = false;
                    frm.btnPDF.Enabled = true;
                }
                
            }
            catch
            {

            }
        }
        private int nBu = 0;
        int aux;
        public int burbujaMejorada(int[] arreglo)/*este metodo es para ordenar el arreglo y obtener el numero mayor*/
        {
            nBu = 0;
            for (int i = 0; i < arreglo.Length; i++)//las n-1 pasadas
            {
                for (int j = 0; j < arreglo.Length - 1; j++)//el recorrido
                {
                    if (arreglo[j] > arreglo[j + 1]) //Si no están en orden
                    {
                        aux = arreglo[j];
                        arreglo[j] = arreglo[j + 1]; //Se intercambian
                        arreglo[j + 1] = aux;
                    }
                    nBu = nBu + 1;
                }
            }
            //MessageBox.Show("Maximo: " + arreglo[11].ToString());
            return arreglo[11];
        }

        int inter = 0;
        public int intervalos()/*es para obtener los intervalos q va a tener la grafica*/
        {
            inter = 0;
            for (int x = 0; x < UnidadesMes.Length; x++)
            {
                inter = inter + UnidadesMes[x];
            }  
            return inter;
        }

        int mes;
        int acEnero = 0, acFebrero = 0, acMarzo = 0, acAbril = 0, acMayo = 0, acJunio = 0, acJulio = 0, acAgosto = 0, acSeptiembre = 0, acOctubre = 0, acNoviembre = 0, acDiciembre = 0;
        public void irIgualando()/*este metodo va acumulando las unidades producidas en cada mes*/
        {
            acEnero = 0; acFebrero = 0; acMarzo = 0; acAbril = 0; acMayo = 0; acJunio = 0; acJulio = 0; acAgosto = 0; acSeptiembre = 0; acOctubre = 0; acNoviembre = 0; acDiciembre = 0;
            for (int x = 0; x < frm.tblReporte.Rows.Count - 1; x++)
            {
                DateTime f = Convert.ToDateTime(frm.tblReporte.Rows[x].Cells[1].Value.ToString());
                mes = Convert.ToInt32(f.Month);
               
                if (mes == 1)
                {
                    acEnero = acEnero + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[0].Value.ToString());
                }
                else if (mes == 2)
                {
                    acFebrero = acFebrero + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[0].Value.ToString());
                }
                else if (mes == 3)
                {
                    acMarzo = acMarzo + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[0].Value.ToString());
                }
                else if (mes == 4)
                {
                    acAbril = acAbril + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[0].Value.ToString());
                }
                else if (mes == 5)
                {
                    acMayo = acMayo + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[0].Value.ToString());
                }
                else if (mes == 6)
                {
                    acJunio = acJunio + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[0].Value.ToString());
                }
                else if (mes == 7)
                {
                    acJulio = acJulio + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[0].Value.ToString());
                }
                else if (mes == 8)
                {
                    acAgosto = acAgosto + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[0].Value.ToString());
                }
                else if (mes == 9)
                {
                    acSeptiembre = acSeptiembre + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[0].Value.ToString());
                }
                else if (mes == 10)
                {
                    acOctubre = acOctubre + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[0].Value.ToString());
                }
                else if (mes == 11)
                {
                    acNoviembre = acNoviembre + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[0].Value.ToString());
                }
                else if (mes == 12)
                {
                    acDiciembre = acDiciembre + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[0].Value.ToString());
                }
                
            }

            frm.txtEnero.Text = acEnero.ToString();
            frm.txtFebrero.Text = acFebrero.ToString();
            frm.txtMarzo.Text = acMarzo.ToString();
            frm.txtAbril.Text = acAbril.ToString();
            frm.txtMayo.Text = acMayo.ToString();
            frm.txtJunio.Text = acJunio.ToString();
            frm.txtJulio.Text = acJulio.ToString();
            frm.txtAgosto.Text = acAgosto.ToString();
            frm.txtSeptiembre.Text = acSeptiembre.ToString();
            frm.txtOctubre.Text = acOctubre.ToString();
            frm.txtNoviembre.Text = acNoviembre.ToString();
            frm.txtDiciembre.Text = acDiciembre.ToString();
           
            UnidadesMes[0] = acEnero;
            UnidadesMes[1] = acFebrero;
            UnidadesMes[2] = acMarzo;
            UnidadesMes[3] = acAbril;
            UnidadesMes[4] = acMayo;
            UnidadesMes[5] = acJunio;
            UnidadesMes[6] = acJulio;
            UnidadesMes[7] = acAgosto;
            UnidadesMes[8] = acSeptiembre;
            UnidadesMes[9] = acOctubre;
            UnidadesMes[10] = acNoviembre;
            UnidadesMes[11] = acDiciembre;

            frm.txtTotal.Text = intervalos().ToString();
            
            graficar();

        }

        public void graficar()/*este metodo es para crea la grafica una vez obtenido los valores*/
        {
            int[] arregloFrecuencias = new int[12] { int.Parse(frm.txtEnero.Text), int.Parse(frm.txtFebrero.Text), int.Parse(frm.txtMarzo.Text), int.Parse(frm.txtAbril.Text), int.Parse(frm.txtMayo.Text), int.Parse(frm.txtJunio.Text), int.Parse(frm.txtJulio.Text), int.Parse(frm.txtAgosto.Text), int.Parse(frm.txtSeptiembre.Text), int.Parse(frm.txtOctubre.Text), int.Parse(frm.txtNoviembre.Text), int.Parse(frm.txtDiciembre.Text) };
            frm.Cht_Poli.ChartAreas.Add("Poligrama");
            frm.Cht_Poli.ChartAreas["Poligrama"].AxisX.Minimum = 0;
            frm.Cht_Poli.ChartAreas["Poligrama"].AxisX.Maximum = 13;
            frm.Cht_Poli.ChartAreas["Poligrama"].AxisX.Interval = 1;
            frm.Cht_Poli.ChartAreas["Poligrama"].AxisY.Minimum = 0;
            frm.Cht_Poli.ChartAreas["Poligrama"].AxisY.Maximum = burbujaMejorada(UnidadesMes);
            frm.Cht_Poli.ChartAreas["Poligrama"].AxisY.Interval = intervalos() / 12;

            frm.Cht_Poli.Series.Add("Histograma");
            frm.Cht_Poli.Series.Add("Poligono de Frecuencias.");
            frm.Cht_Poli.Series["Poligono de Frecuencias."].ChartType = SeriesChartType.Column;
            frm.Cht_Poli.Series["Poligono de Frecuencias."].Color = Color.Red;
            frm.Cht_Poli.Series["Histograma"].Palette = ChartColorPalette.None;
            frm.Cht_Poli.Series["Poligono de Frecuencias."].ChartType = SeriesChartType.Line;
            frm.Cht_Poli.Series["Poligono de Frecuencias."].MarkerStyle = MarkerStyle.Circle;
            frm.Cht_Poli.Series["Poligono de Frecuencias."].MarkerSize = 7;
            frm.Cht_Poli.Series["Poligono de Frecuencias."].MarkerBorderColor = Color.Red;
            frm.Cht_Poli.Series["Poligono de Frecuencias."].MarkerBorderWidth = 10;
            frm.Cht_Poli.Series["Histograma"].MarkerBorderWidth = 3;

            string str_intervalos = "";
            Chart ChtPoliGS;
            string[] arregloTblLm = new string[12] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            string[] arregloTblLs = new string[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };


            for (int cont = 0; cont < 12; cont++)
            {
                //                                                  intervalos/frecuencias
                str_intervalos = "( " + arregloTblLm[cont] + " - " + arregloTblLs[cont] + " )";
                if (cont == 10 - 1)
                {
                    str_intervalos = "( " + arregloTblLm[cont] + " - " + arregloTblLs[cont] + " )";
                    frm.Cht_Poli.Series["Histograma"].Points.AddXY(str_intervalos, arregloFrecuencias[cont]);
                }
                else
                {
                    frm.Cht_Poli.Series["Histograma"].Points.AddXY(str_intervalos, arregloFrecuencias[cont]);
                }
            }
            ChtPoliGS = frm.Cht_Poli;
        }
    }
}
