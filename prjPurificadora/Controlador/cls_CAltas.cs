/*en esta clase se realizan las altas de productos obteniendo lo q hay actualmente en almacen y sumar una cantidad ingresada y posteriormente hacer una actualizacion a la base de datos*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjPurificadora.Vista;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;

namespace prjPurificadora.Controlador
{
    class cls_CAltas
    {
        frmAltas frm = new frmAltas();
        cls_AltasYBajasDAO mtd = new cls_AltasYBajasDAO();
        cls_AltasYBajasVO dts = new cls_AltasYBajasVO();
        Cls_Validaciones validar = new Cls_Validaciones();


        int id, existen=0, nueva=0, cantidad=0;
        /*
         id es el id del producto seleccionado
         * existen es la cantidad de producto q hay actualmente del producto seleccionado
         * nueva es el resultado de sumar la cantidad ingresada a lo existente
         * cantidad es la cantidad ingresada
         */
        public void frm_load()
        {
            frm.txtUnidades.KeyPress += txtUnidades_KeyPress;
            frm.tblProductos.CellClick += tblProductos_CellClick;
            frm.btnComfirmar.Click += btnComfirmar_Click;
            frm.txtUnidades.TextChanged += txtUnidades_TextChanged;
            
            llenarTabla();
            frm.ShowDialog();
        }

        void txtUnidades_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cantidad = Convert.ToInt32(frm.txtUnidades.Text);//cundo se va ingresando un valor a la caja de texto se tiene q ir convirtiendo 
                //para ir calculando automaticamente las unidades
            }
            catch
            {
                cantidad = 0;
            }
            calUnidades();
        }

        void tblProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(frm.tblProductos.Rows[frm.tblProductos.CurrentRow.Index].Cells[0].Value.ToString());
                frm.txtNombre.Text = frm.tblProductos.Rows[frm.tblProductos.CurrentRow.Index].Cells[1].Value.ToString();
                existen = Convert.ToInt32(frm.tblProductos.Rows[frm.tblProductos.CurrentRow.Index].Cells[2].Value.ToString());

                frm.btnComfirmar.Enabled = true;
                frm.txtUnidades.Enabled = true;
                frm.txtUnidades.Focus();
            }
            catch
            {

            }
        }

        void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void btnComfirmar_Click(object sender, EventArgs e)
        {
            comfirmar();
        }

        public void llenarTabla()
        {
            try
            {
                frm.tblProductos.DataSource = mtd.mtdllenarBotellones();
                frm.tblProductos.Columns[0].Visible = false;
                frm.tblProductos.Columns[4].Visible = false;
            }
            catch
            {

            }
        }

        public void calUnidades()
        {
            //aqui decimos q la cantidada nueva va aser lo q existe actualmente
            //que se extrae al momento de seleccionar el producto y se le suma la cantidad ingresada
            //para luego hacer solo una actualizacion del campo existencia en la base de datos
            nueva = existen + cantidad;
        }

        public void comfirmar()
        {
            //aqui primero se va verificando que todo este bien para continuar con el registro y no aiga problemas en la base de datos
            try
            {
                if (frm.txtUnidades.Text == "")
                {
                    MessageBox.Show("No dejar campo vacio :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cantidad <= 0)
                    {
                        MessageBox.Show("Nose puede agregar 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (validar.mtd_mensaje() == 1)
                        {
                            dts.setId(id);
                            dts.setUnidades(nueva);
                            mtd.mtdEditaBotellones(dts);
                            MessageBox.Show("Accion exitosa :)", "Aviso...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                        }

                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Se produjo un error inesperado :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            llenarTabla();
        }

        public void limpiar()
        {
            frm.txtNombre.Clear();
            frm.txtUnidades.Text = "0";
            frm.btnComfirmar.Enabled = false;
            frm.txtUnidades.Enabled = false;
        }
    }
}
