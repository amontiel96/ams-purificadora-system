/*en esta clase se registran, modifican y eliminan los productos de la prodcuccion ejem. sal, detergente, etc...*/
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
    class cls_CInventario
    {
        frmInventario frm = new frmInventario();
        cls_ProductosDAO mtd = new cls_ProductosDAO();
        cls_ProductosVO dts = new cls_ProductosVO();
        Cls_Validaciones validar = new Cls_Validaciones();

        float pre;
        int id;

        /*
         pre es el precio de compra del producto
         * id es el id del producto seleccionado
         */

        public void frm_load()
        {
            llenarTabla();
            frm.btnCancelar.Click += btnCancelar_Click;
            frm.btnEliminar.Click += btnEliminar_Click;
            frm.btnGuardar.Click += btnGuardar_Click;
            frm.btnModificar.Click += btnModificar_Click;
            frm.btnNuevo.Click += btnNuevo_Click;
            frm.btnSalir.Click += btnSalir_Click;
            frm.tblProductos.CellClick += tblProductos_CellClick;
            frm.txtNombre.KeyPress += txtNombre_KeyPress;
            frm.txtPrecio.KeyPress += txtPrecio_KeyPress;
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }

        void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtPrecio.Text,e);
        }

        void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras(e);
        }

        void tblProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(frm.tblProductos.Rows[frm.tblProductos.CurrentRow.Index].Cells[0].Value.ToString());
                frm.txtNombre.Text = frm.tblProductos.Rows[frm.tblProductos.CurrentRow.Index].Cells[1].Value.ToString();
                frm.txtPrecio.Text = frm.tblProductos.Rows[frm.tblProductos.CurrentRow.Index].Cells[2].Value.ToString();
                botones(3);
                cajas(1);
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

        void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                /*primero se tiene q ir verificando q todo este bien antes de enviar los datos a la base de dato y no tener conflcitos*/
                if (frm.txtNombre.Text == "" || frm.txtPrecio.Text == "")
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pre = float.Parse(frm.txtPrecio.Text);
                    if (pre <= 0)
                    {
                        MessageBox.Show("El precio de compra tiene que ser mayor que 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(validar.mtd_mensaje()==1)
                        {
                            enviar();
                            dts.setId(id);
                            mtd.mtdEditaProductos(dts);
                            MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            botones(2);
                            cajas(2);
                            limpiar();
                            llenarTabla();
                        }
                        
                    }
                    
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error al intentar editar :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                /*se tiene q ir verificando q todo este bien antes de enviar los datos a la base de datos*/
                if (frm.txtNombre.Text == "" || frm.txtPrecio.Text == "")
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pre = float.Parse(frm.txtPrecio.Text);
                    if (pre <= 0)
                    {
                        MessageBox.Show("El precio de compra tiene que ser mayor que 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(validar.mtd_mensaje()==1)
                        {
                            enviar();
                            mtd.mtdInsertarProductos(dts);
                            MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            botones(2);
                            cajas(2);
                            limpiar();
                            llenarTabla();
                        }
                        
                    }
                    
                }
                
            }catch
            {
                MessageBox.Show("Se produjo un error al intentar guardar :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Seleccione un producto :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(validar.mtd_mensaje()==1)
                    {
                        dts.setId(id);
                        mtd.mtdEliminaProductos(dts);
                        MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        botones(2);
                        cajas(2);
                        limpiar();
                        llenarTabla();
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error al intentar eliminar :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void llenarTabla()/*llena la tabla con todos los productos registrados*/
        {
            try
            {
                frm.tblProductos.DataSource = mtd.mtdllenarProductos();
                frm.tblProductos.Columns[0].Visible = false;
                frm.tblProductos.Columns[3].Visible = false;
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
        public void enviar()
        {
            dts.setNombre(frm.txtNombre.Text);
            dts.setPrecio(float.Parse(frm.txtPrecio.Text));
        }

        public void botones(int op)
        {
            switch (op)
            {
                case 1:
                    frm.btnNuevo.Enabled = false;
                    frm.btnGuardar.Enabled = true;
                    frm.btnCancelar.Enabled = true;
                    frm.btnModificar.Enabled = false;
                    frm.btnEliminar.Enabled = false;
                    break;
                case 2:
                    frm.btnNuevo.Enabled = true;
                    frm.btnGuardar.Enabled = false;
                    frm.btnCancelar.Enabled = false;
                    frm.btnModificar.Enabled = false;
                    frm.btnEliminar.Enabled = false;
                    break;
                case 3:
                    frm.btnNuevo.Enabled = false;
                    frm.btnGuardar.Enabled = false;
                    frm.btnCancelar.Enabled = true;
                    frm.btnModificar.Enabled = true;
                    frm.btnEliminar.Enabled = true;
                    break;
            }
        }

        public void cajas(int op)
        {
            switch (op)
            {
                case 1:
                    frm.txtNombre.Enabled = true;
                    frm.txtPrecio.Enabled = true;
                    frm.txtNombre.Focus();
                    break;
                case 2:
                    frm.txtNombre.Enabled = false;
                    frm.txtPrecio.Enabled = false;
                    break;
            }
        }
        public void limpiar()
        {
            frm.txtNombre.Clear();
            frm.txtPrecio.Clear();
        }
    }
}
