/*este metodo es para consultar las ventas ya sea en general o por vendedor especifico*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Vista;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Modelo.DAO;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

namespace prjPurificadora.Controlador
{
    class cls_RVentas
    {
        frmRVentas frm = new frmRVentas();
        cls_ReportesDAO mtd = new cls_ReportesDAO();
        cls_ReporteVO dts = new cls_ReporteVO();


        int d, m, a, idvendedor,n=0,m1=0,m2=0,boni=0,toUni;
        string fechaI, fechaF, fecha;
        float total=0;

        /*
         * fechaI día inical
         * fechaF día final
         * d-m-a son para obtener las fechas inical y fecha final
         * idvendedor es el id del vendedor seleccionado del combo
         * n se refiere a las unidades vendidas al precio normal
         * m1 se refiere a las unidades vendidas al precio mayoreo1
         * m2 se refiere a las unidades vendidas al precio mayoreo2
         * toUni son las unidades totales vendidas
         */
        public void frm_load()
        {
            llenacombo();
            frm.btnContinuar.Click += btnContinuar_Click;
            frm.btnPDF.Click += btnPDF_Click;
            preciosBote();
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }

        void btnPDF_Click(object sender, EventArgs e)/*crea el archio pdf*/
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
                parrafo.Add("REPORTE DE VENTAS");
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
                    parrafo.Add("Reporte del vendedor: " + frm.cmbVendedor.Text);
                    doc.Add(parrafo);
                    parrafo.Clear();
                }

                doc.Add(new Paragraph("\n"));
                PdfPTable Tabla = new PdfPTable(6);
                Tabla.SetWidthPercentage(new float[] { 120, 85, 85, 120, 85, 200 }, PageSize.A4);
                Tabla.AddCell(new Paragraph("Normal"));
                Tabla.AddCell(new Paragraph("Mayoreo "+frm.lblM1.Text));
                Tabla.AddCell(new Paragraph("Mayoreo "+frm.lblM2.Text));
                Tabla.AddCell(new Paragraph("Bonificados"));
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
                    PdfPCell celda1 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[4].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda2 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[6].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda3 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[8].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda4 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[10].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda5 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[11].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda6 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[12].Value.ToString(), FontFactory.GetFont("Arial", 10)));

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
                parrafo.Add("TOTAL NORMAL: " + frm.lblNormal.Text);
                doc.Add(parrafo);
                parrafo.Clear();


                doc.Add(new Paragraph("\n"));
                parrafo.Add("TOTAL MAYOREO " + frm.lblM1.Text+" "+frm.lblMay1.Text);
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Add("TOTAL MAYOREO " + frm.lblM2.Text+" "+frm.lblMay2.Text);
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Add("BONIFICADOS: "+frm.txtBoni.Text);
                doc.Add(parrafo);
                parrafo.Clear();

                doc.Add(new Paragraph("\n"));
                parrafo.Add("TOTAL DE UNIDADES: " + frm.lblUnidades.Text);
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
                if (frm.rbtGeneral.Checked == true)
                {
                    enviar();
                    llenarTabla();
                    calTotal();
                }
                else if (frm.rbtEspecifico.Checked == true)
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
        public void bloquear()/*bloque las columnas q no son requeridas*/
        {
            frm.tblReporte.Columns[0].Visible = false;
            frm.tblReporte.Columns[1].Visible = false;
            frm.tblReporte.Columns[2].Visible = false;
            frm.tblReporte.Columns[3].Visible = false;

            frm.tblReporte.Columns[5].Visible = false;
            frm.tblReporte.Columns[7].Visible = false;
            frm.tblReporte.Columns[9].Visible = false;
        }
        public void llenarTabla()
        {
            try
            {
                frm.tblReporte.DataSource = mtd.mtdllenartablaVentas(dts);
                frm.tblReporte.Columns[6].HeaderText = "Mayoreo " + frm.lblM1.Text;
                frm.tblReporte.Columns[8].HeaderText = "Mayoreo " + frm.lblM2.Text;
                bloquear();
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
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta...!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
   
        }
        public void llenacombo()
        {
            frm.cmbVendedor.DataSource = mtd.mtdllenarVendedor();
            frm.cmbVendedor.DisplayMember = "vchNombre";
            frm.cmbVendedor.ValueMember = "intIdVendedorPK";
        }
        public void llenarTablaEspecifica()
        {
            try
            {
                frm.tblReporte.DataSource = mtd.mtdllenartablaVentasEspecifico(dts);
                bloquear();
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
                MessageBox.Show("Nose pudieron cargar los datos :(", "Alerta...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        public void calTotal()/*calcula el total de las ventas realizadas*/
        {
            total = 0;
            n = 0;
            m1 = 0;
            m2 = 0;
            boni = 0;
            for (int x = 0; x < frm.tblReporte.Rows.Count - 1; x++)
            {
                n = n + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[4].Value.ToString());
                m1 = m1 + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[6].Value.ToString());
                m2 = m2 + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[8].Value.ToString());
                boni = boni + Convert.ToInt32(frm.tblReporte.Rows[x].Cells[10].Value.ToString());
                total = total + float.Parse(frm.tblReporte.Rows[x].Cells[11].Value.ToString());
            }
            toUni = n + m1 + m2;
            frm.lblNormal.Text = n.ToString();
            frm.lblMay1.Text = m1.ToString();
            frm.lblMay2.Text = m2.ToString();
            frm.txtBoni.Text = boni.ToString();
            frm.lblUnidades.Text = toUni.ToString();
            frm.lblTotal.Text = "$ " + total.ToString();
        }
        public void preciosBote()/*obtenemos los precios del botellon*/
        {
            try
            {
                frm.tblPrecios.DataSource = mtd.mtdllenarPreciosBotellon();
                frm.lblM1.Text = "$"+frm.tblPrecios.Rows[1].Cells[0].Value.ToString()+":";
                frm.lblM2.Text = "$"+frm.tblPrecios.Rows[2].Cells[0].Value.ToString()+":";
            }
            catch
            {

            }
        }
    }
}
