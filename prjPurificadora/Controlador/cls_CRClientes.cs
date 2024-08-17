using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Vista;


namespace prjPurificadora.Controlador
{
    class cls_CRClientes
    {
        frmVentClientes frm = new frmVentClientes();
        cls_ReportesDAO mtd = new cls_ReportesDAO();
        cls_ReporteVO dts = new cls_ReporteVO();

        int d, m, a,cliente;
        string fechaI, fechaF;
        int unidades = 0;

        public void frm_load()
        {
            frm.btnAceptar.Click += btnAceptar_Click;
            frm.tblClientes.Click += tblClientes_Click;
            frm.cmbVendedor.TextChanged += cmbVendedor_TextChanged;
            llenarVendedor();
            frm.ShowDialog();
        }

        void cmbVendedor_TextChanged(object sender, EventArgs e)
        {
            limpiar();
            frm.tblClientes.DataSource = null;
            frm.tblUnidades.DataSource = null;
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

        public void calcular()
        {
            unidades = 0;
            for (int x = 0; x < frm.tblUnidades.RowCount;x++)
            {
                unidades=unidades+Convert.ToInt32(frm.tblUnidades.Rows[x].Cells[1].Value.ToString());
            }
            frm.txtUnidades.Text = unidades.ToString();
            
        }

        void btnAceptar_Click(object sender, EventArgs e)
        {
            
            dts.setIdVendedor(Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString()));
            llenarTabla();
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
                frm.tblClientes.Columns[0].Visible = false;
            }
            catch
            {

            }
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
