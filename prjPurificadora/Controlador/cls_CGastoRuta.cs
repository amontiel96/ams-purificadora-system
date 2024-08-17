/*en esta clase se regisyran los gastos por ruta de los vendedores*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Vista;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace prjPurificadora.Controlador
{
    class cls_CGastoRuta
    {
        frmGastosRuta frm = new frmGastosRuta();
        cls_GastosRutaVO dts = new cls_GastosRutaVO();
        cls_GastosRutaDAO mtd = new cls_GastosRutaDAO();
        Cls_Validaciones validar = new Cls_Validaciones();

        int d, m, a,idGasto,vendedor;
        string fecha;
        float gas, refaccion, mecanico;

        /*
         d-m-a son para obtener la fecha actual
         * idGasto es para identificar el id de un gastoa anterior en caso de modificacion
         * vendedor es el id del vendedor seleccionado del combo
         * gas el lo que gasto en gasolina
         * refaccion es lo  gasto en refaccion
         * mecanico es lo q gasto en mecanico
         */

        public void frm_load()
        {
            frm.btnCancelar.Click += btnCancelar_Click;
            frm.btnGuardar.Click += btnGuardar_Click;
            frm.btnNuevo.Click += btnNuevo_Click;
            frm.btnSalir.Click += btnSalir_Click;
            frm.txtGasolina.KeyPress += txtGasolina_KeyPress;
            frm.txtMantenimiento.KeyPress += txtMantenimiento_KeyPress;
            frm.txtRefaccionaria.KeyPress += txtRefaccionaria_KeyPress;
            frm.tblGastosRuta.CellClick += tblGastosRuta_CellClick;
            frm.btnModificar.Click += btnModificar_Click;
            Application.EnableVisualStyles();
            llenacombo();
            llenartabla();
            frm.ShowDialog();
        }

        void txtRefaccionaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtRefaccionaria.Text,e);
        }

        void txtMantenimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtMantenimiento.Text,e);
        }

        void txtGasolina_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtGasolina.Text,e);
        }

        void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                /*primero se va verificando q todo este bien antes de enviar los datos a la base de datos y no tener conflictos*/
                if (frm.txtGasolina.Text == "" || frm.txtMantenimiento.Text == "" || frm.txtRefaccionaria.Text == "")
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        gas = float.Parse(frm.txtGasolina.Text);
                        refaccion = float.Parse(frm.txtRefaccionaria.Text);
                        mecanico = float.Parse(frm.txtMantenimiento.Text);
                        if (gas<=0 && mecanico<=0 && refaccion<=0)
                        {
                            MessageBox.Show("Por lo menos un valor tiene que ser mayor a 0 :( ", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                                if(validar.mtd_mensaje()==1)
                                {
                                    enviar();
                                    dts.setIdgasto(idGasto);
                                    dts.setIdVendedor(vendedor);
                                    mtd.mtdEditar(dts);
                                    llenartabla();
                                    MessageBox.Show("Accion realizada con exito... :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    botones(2);
                                    cajas(2);
                                    limpiar();
                                }
                                
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Solo Núneros :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Verifique su conexion a internet sea estable :(", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void tblGastosRuta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idGasto = Convert.ToInt32(frm.tblGastosRuta.Rows[frm.tblGastosRuta.CurrentRow.Index].Cells[0].Value.ToString());
                vendedor = Convert.ToInt32(frm.tblGastosRuta.Rows[frm.tblGastosRuta.CurrentRow.Index].Cells[1].Value.ToString());
                frm.txtGasolina.Text = frm.tblGastosRuta.Rows[frm.tblGastosRuta.CurrentRow.Index].Cells[3].Value.ToString();
                frm.txtRefaccionaria.Text = frm.tblGastosRuta.Rows[frm.tblGastosRuta.CurrentRow.Index].Cells[4].Value.ToString();
                frm.txtMantenimiento.Text = frm.tblGastosRuta.Rows[frm.tblGastosRuta.CurrentRow.Index].Cells[5].Value.ToString();
                cajas(1);
                botones(3);
            }
            catch
            {

            }
            
        }

        void btnSalir_Click(object sender, EventArgs e)
        {
            frm.Close();
        }

        void btnNuevo_Click(object sender, EventArgs e)
        {
            botones(1);
            cajas(1);
        }

        public void enviar()
        {
            d = frm.dtFecha.Value.Day;
            m = frm.dtFecha.Value.Month;
            a = frm.dtFecha.Value.Year;
            fecha = a + "-" + m + "-" + d;
            dts.setGasolina(gas);
            dts.setMante(mecanico);
            dts.setRefaccionaria(refaccion);
            dts.setFecha(fecha);
        }

        void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                /*primero se va verificando q todo este bien antes de enviar los datos a la base de datos y no tener conflictos*/
                if (frm.txtGasolina.Text == "" || frm.txtMantenimiento.Text == "" || frm.txtRefaccionaria.Text == "")
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (frm.txtGasolina.Text == "0" && frm.txtMantenimiento.Text == "0" && frm.txtRefaccionaria.Text == "0")
                        {
                            MessageBox.Show("Por lo menos un valor tiene que ser mayor a 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            gas = float.Parse(frm.txtGasolina.Text);
                            refaccion = float.Parse(frm.txtRefaccionaria.Text);
                            mecanico = float.Parse(frm.txtMantenimiento.Text);

                            if (gas < 0 || refaccion < 0 || mecanico < 0)
                            {
                                MessageBox.Show("No puede haber valores negativos :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if(validar.mtd_mensaje()==1)
                                {
                                    enviar();
                                    dts.setIdVendedor(Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString()));
                                    mtd.mtdInsertar(dts);
                                    llenartabla();
                                    MessageBox.Show("Accion realizada con exito... :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    botones(2);
                                    cajas(2);
                                    limpiar();
                                }
                               
                            }
                            
                        }
                        
                    }
                    catch
                    {
                        MessageBox.Show("Solo Números :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                
            }
            catch
            {
                MessageBox.Show("Verifique su conexion a internet sea estable :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }


        void btnCancelar_Click(object sender, EventArgs e)
        {
            if(validar.mtd_mensajeCancelar()==1)
            {
                botones(2);
                cajas(2);
                limpiar();
            }
            
        }

        public void llenacombo()
        {
            try
            {
                frm.cmbVendedor.DataSource = mtd.mtdllenarVendedor();
                frm.cmbVendedor.DisplayMember = "vchNombre";
                frm.cmbVendedor.ValueMember = "intIdVendedorPK";
            }
            catch
            {

            }
            
        }
        public void llenartabla()
        {
            try
            {
                frm.tblGastosRuta.DataSource = mtd.mtdllenartabla();
                frm.tblGastosRuta.Columns[0].Visible = false;
                frm.tblGastosRuta.Columns[1].Visible = false;
            }
            catch
            {
                MessageBox.Show("Nose se pudieron cargar los datos :( ","Alerta...!",MessageBoxButtons.OK,MessageBoxIcon.Warning);  
            }
            
        }
        public void llenaconsulta()
        {
            dts.setIdVendedor(Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString()));
            frm.tblGastosRuta.DataSource = mtd.mtdllenarBusqueda(dts);
        }

        public void cajas(int opc)
        {
            switch (opc)
            {
                case 1:
                    frm.txtGasolina.Enabled = true;
                    frm.txtMantenimiento.Enabled = true;
                    frm.txtRefaccionaria.Enabled = true;
                    frm.txtGasolina.Focus();
                    break;
                case 2:
                    frm.txtGasolina.Enabled = false;
                    frm.txtMantenimiento.Enabled = false;
                    frm.txtRefaccionaria.Enabled = false;
                    break;
            }
        }

        public void botones(int opc)
        {
            switch (opc)
            {
                case 1:
                    frm.btnNuevo.Enabled = false;
                    frm.btnGuardar.Enabled = true;
                    frm.btnCancelar.Enabled = true;
                    frm.btnModificar.Enabled = false;
                    break;

                case 2:
                    frm.btnNuevo.Enabled = true;
                    frm.btnGuardar.Enabled = false;
                    frm.btnCancelar.Enabled = false;
                    frm.btnModificar.Enabled = false;
                    break;
                case 3:
                    frm.btnNuevo.Enabled = false;
                    frm.btnGuardar.Enabled = false;
                    frm.btnCancelar.Enabled = true;
                    frm.btnModificar.Enabled = true;
                    break;
            }
        }
        public void limpiar()
        {
            frm.txtGasolina.Text = "0";
            frm.txtMantenimiento.Text = "0";
            frm.txtRefaccionaria.Text = "0";
        }
    }
}
