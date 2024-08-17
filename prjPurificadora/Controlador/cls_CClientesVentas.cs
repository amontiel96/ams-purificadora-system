using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    class cls_CClientesVentas
    {
        frmClientesUnidades frm = new frmClientesUnidades();
        cls_ReportesDAO mtd = new cls_ReportesDAO();
        cls_ReporteVO dts = new cls_ReporteVO();

        int d, m, a, cliente;
        string fechaI, fechaF;
        int unidades = 0;

        public void frm_load()
        {
            frm.btnAceptar.Click += btnAceptar_Click;
            frm.tblClientes.Click += tblClientes_Click;
            frm.btnPDF.Click += btnPDF_Click;
            frm.cmbVendedor.TextChanged += cmbVendedor_TextChanged;
            llenarVendedor();
            frm.ShowDialog();
        }

        void btnPDF_Click(object sender, EventArgs e)
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
                parrafo.Add("REPORTE DE CLIENTES");
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
                parrafo.Add("Clientes del vendedor: " + frm.cmbVendedor.Text);
                doc.Add(parrafo);
                parrafo.Clear();

               
                doc.Add(new Paragraph("\n"));
                PdfPTable Tabla = new PdfPTable(2);
                Tabla.SetWidthPercentage(new float[] { 400, 400 }, PageSize.A4);
                Tabla.AddCell(new Paragraph("CLIENTE"));
                Tabla.AddCell(new Paragraph("UNIDADES"));





                foreach (PdfPCell celda in Tabla.Rows[0].GetCells())
                {
                    celda.BackgroundColor = BaseColor.LIGHT_GRAY;
                    celda.HorizontalAlignment = 1;
                    celda.Padding = 3;
                }


                for (int i = 0; i < frm.tblReporte.Rows.Count; i++)
                {
                    PdfPCell celda1 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[0].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    PdfPCell celda2 = new PdfPCell(new Paragraph(frm.tblReporte.Rows[i].Cells[1].Value.ToString(), FontFactory.GetFont("Arial", 10)));
                    

                    Tabla.AddCell(celda1);
                    Tabla.AddCell(celda2);



                }
                doc.Add(Tabla);
                parrafo.Clear();


                doc.Close();
                MessageBox.Show("Archivo guardado exitosamente :)", "Aviso...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(saveFileDialog1.FileName);

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
                MessageBox.Show("Accion Cancelada :)", "Aviso...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void cmbVendedor_TextChanged(object sender, EventArgs e)
        {
            limpiar();
            frm.tblClientes.DataSource = null;
            frm.tblUnidades.DataSource = null;
            frm.tblReporte.DataSource = null;
            frm.btnPDF.Enabled = false;
        }

        void tblClientes_Click(object sender, EventArgs e)
        {
            try
            {
                cliente = Convert.ToInt32(frm.tblClientes.Rows[frm.tblClientes.CurrentRow.Index].Cells[0].Value.ToString());
                frm.txtCliente.Text = frm.tblClientes.Rows[frm.tblClientes.CurrentRow.Index].Cells[1].Value.ToString();
                fechaInicial();
                fechaFinal();
                dts.setFechai(fechaI);
                dts.setFechaf(fechaF);
                dts.setIdCliente(cliente);
                frm.tblUnidades.DataSource = mtd.mtdllenarUnidadesClientes(dts);
                calcular();
            }
            catch
            {

            }
        }
        int[] arrUnidades;
        public void calUnidades()
        {
            arrUnidades=new int[Convert.ToInt32(frm.tblClientes.Rows.Count)];
            for (int x = 0; x < frm.tblClientes.Rows.Count;x++ )
            {
                cliente = Convert.ToInt32(frm.tblClientes.Rows[x].Cells[0].Value.ToString());
                fechaInicial();
                fechaFinal();
                dts.setFechai(fechaI);
                dts.setFechaf(fechaF);
                dts.setIdCliente(cliente);
                frm.tblUnidades.DataSource = mtd.mtdllenarUnidadesClientes(dts);
                arrUnidades[x] = calcular();
            }

        }


        public int calcular()
        {
            unidades = 0;
            for (int x = 0; x < frm.tblUnidades.RowCount; x++)
            {
                unidades = unidades + Convert.ToInt32(frm.tblUnidades.Rows[x].Cells[1].Value.ToString());
            }
            frm.txtUnidades.Text = unidades.ToString();
            return unidades;
        }

        void btnAceptar_Click(object sender, EventArgs e)
        {

            dts.setIdVendedor(Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString()));
            llenarTabla();
            frm.btnPDF.Enabled = true;
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
                frm.tblClientes.DataSource = mtd.mtdllenarClientes(dts);
                //frm.tblClientes.Columns[0].Visible = false;
                pasarClientes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string[] array;
        public void pasarClientes()
        {
            array = new string[Convert.ToInt32(frm.tblClientes.Rows.Count)];
            frm.tblReporte.RowCount = frm.tblClientes.RowCount;
            frm.tblReporte.ColumnCount = 2;

            frm.tblReporte.Columns[0].HeaderText = "Cliente";
            frm.tblReporte.Columns[1].HeaderText = "Unidades";

            for (int x = 0; x < frm.tblClientes.Rows.Count;x++ )
            {
               array[x]=frm.tblClientes.Rows[x].Cells[1].Value.ToString();
            }
            calUnidades();


            frm.tblReporte.RowCount = frm.tblClientes.RowCount;
            for (int x = 0; x < frm.tblReporte.Rows.Count; x++)
            {
                frm.tblReporte.Rows[x].Cells[0].Value = array[x].ToString();
                frm.tblReporte.Rows[x].Cells[1].Value = arrUnidades[x].ToString();
            }

            frm.tblReporte.Sort(frm.tblReporte.Columns[1], System.ComponentModel.ListSortDirection.Descending);

        }

        public void llenarVendedor()
        {
            try
            {
                frm.cmbVendedor.DataSource = mtd.mtdllenarVendedor();
                frm.cmbVendedor.DisplayMember = "vchNombre";
                frm.cmbVendedor.ValueMember = "intIdVendedorPK";
            }
            catch { }

        }

        public void limpiar()
        {
            frm.txtCliente.Clear();
            frm.txtUnidades.Clear();
        }


    }
}
