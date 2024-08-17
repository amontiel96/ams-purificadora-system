/*en esta clase se configuran los precios del botellon asi como tambien las comiciones q ganan los vendedores*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjPurificadora.Vista;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Modelo.DAO;
using System.Threading.Tasks;

namespace prjPurificadora.Controlador
{
    class cls_CPrecios
    {
        frmConfigPrecios frm = new frmConfigPrecios();
        cls_PreciosDAO mtd = new cls_PreciosDAO();
        cls_PreciosVO dts = new cls_PreciosVO();
        Cls_Validaciones validar = new Cls_Validaciones();

        DialogResult respuesta;
        float p, c;
        int id;

        /*p es el valor del precio de venta del botellon
         c es la comision q gana ada vendedor
         * id es el id del registro de precios
         */

        public void frm_load()
        {
            frm.btnCancelar.Click += btnCancelar_Click;
            frm.btnGuardar.Click += btnGuardar_Click;
            frm.txtCom1.KeyPress += txtCom1_KeyPress;
            frm.txtP1.KeyPress += txtP1_KeyPress;
            frm.tblPrecios.CellClick += tblPrecios_CellClick;
            Application.EnableVisualStyles();
            llenarprecios();
            frm.ShowDialog();
        }

        void txtP1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtP1.Text,e);
        }

        void txtCom1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtCom1.Text,e);
        }

        void tblPrecios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(frm.tblPrecios.Rows[frm.tblPrecios.CurrentRow.Index].Cells[0].Value.ToString());
                frm.txtCom1.Text = frm.tblPrecios.Rows[frm.tblPrecios.CurrentRow.Index].Cells[3].Value.ToString();
                frm.txtP1.Text = frm.tblPrecios.Rows[frm.tblPrecios.CurrentRow.Index].Cells[2].Value.ToString();

                frm.txtCom1.Enabled = true;
                frm.txtP1.Enabled = true;
                frm.btnGuardar.Enabled = true;
                frm.btnCancelar.Enabled = true;
                frm.txtP1.Focus();
            }
            catch
            {
                frm.txtP1.Enabled = false;
                frm.txtCom1.Enabled = false;
                frm.btnGuardar.Enabled = false;
            }
            

        }

        void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               /*se va verificando q todo este bien antes de enviar los datos a la base de datos para no tener conflictos*/
                try
                {
                    if (frm.txtP1.Text == "" || frm.txtCom1.Text == "")
                    {
                        MessageBox.Show("No Dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        p = float.Parse(frm.txtCom1.Text);
                        c = float.Parse(frm.txtP1.Text);

                        if (p <= 0 || c <= 0)
                        {
                            MessageBox.Show("las cantidades no pueden ser 0 :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else
                        {
                            respuesta = MessageBox.Show("Esta seguro de realizar los cambios???", "Responda a la pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (respuesta == DialogResult.Yes)
                            {
                                dts.setId(id);
                                dts.setComision(float.Parse(frm.txtCom1.Text));
                                dts.setPrecio(float.Parse(frm.txtP1.Text));
                                mtd.mtdEditar(dts);
                                MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                llenarprecios();
                                limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Acción cancelada... :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiar();
                            }
                        }
                        

                    }
                }
                catch
                {
                    MessageBox.Show("Verifique su conexion :(", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {
                MessageBox.Show("Solo ingrresar numeros :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                frm.txtP1.Focus();
            }
            
            
            
        }
        public void limpiar()
        {
            frm.txtP1.Clear();
            frm.txtCom1.Clear();
            frm.txtCom1.Enabled = false;
            frm.txtP1.Enabled = false;
            frm.btnCancelar.Enabled = false;
            frm.btnGuardar.Enabled = false;
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            if(validar.mtd_mensajeCancelar()==1)
            {
                limpiar();
            }
            
        }
        public void llenarprecios()
        {
            frm.tblPrecios.DataSource = mtd.mtdllenarPrecios();
            frm.tblPrecios.Columns[0].Visible = false;
            frm.tblPrecios.Columns[1].Visible = false;
        }
    }
}
