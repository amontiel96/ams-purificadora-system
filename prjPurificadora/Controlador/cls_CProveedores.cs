/*en esta clase se registran, actualizan y eliminan a los proveedores*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjPurificadora.Vista;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;
using System.Threading.Tasks;

namespace prjPurificadora.Controlador
{
    class cls_CProveedores
    {
       
        frmProveedores frm = new frmProveedores();
        Cls_proveedorDAO mtd = new Cls_proveedorDAO();
        Cls_ProveedorVO dts = new Cls_ProveedorVO();
        Cls_Validaciones validar = new Cls_Validaciones();

        int id;
        string nom;
        int idp;

        /*
         id es el id de un proveedor existente seleccionado
         * nom es el nombre a buscar
         * idp es el id a buscar
         */

        public void frm_load()
        {
            frm.btnGuardar.Click += btnGuardar_Click;
            frm.btnCancelar.Click += btnCancelar_Click;
            frm.btnEliminar.Click += btnEliminar_Click;
            frm.btnModificar.Click += btnModificar_Click;
            frm.btnNuevo.Click += btnNuevo_Click;
            frm.btnSalir.Click += btnSalir_Click;
            frm.tblProveedores.CellClick += tblProveedores_CellClick;
            frm.txtid.TextChanged += txtid_TextChanged;
            frm.txtTelefono.KeyPress += txtTelefono_KeyPress;
            frm.txtNombre.KeyPress += txtNombre_KeyPress;
            frm.txtDireccion.KeyPress += txtDireccion_KeyPress;      
            Application.EnableVisualStyles();
            cargaTabla();
            frm.ShowDialog();
        }

        void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras_numeros(e);
        }

        void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras(e);
        }

        void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }
        
        void txtid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                idp = Convert.ToInt32(frm.txtid.Text);
                nom = frm.txtid.Text;
            }
            catch {
                idp = 0;
                nom = frm.txtid.Text;
            }

            try
            {
                dts.setNombre(nom);
                dts.setId(idp);
                frm.tblProveedores.DataSource = mtd.MTD_buscar(dts);
                if (frm.tblProveedores.Rows.Count >= 1)
                {
                    id = Convert.ToInt32(frm.tblProveedores.Rows[0].Cells[0].Value.ToString());
                    frm.txtNombre.Text = frm.tblProveedores.Rows[0].Cells[1].Value.ToString();
                    frm.txtDireccion.Text = frm.tblProveedores.Rows[0].Cells[2].Value.ToString();
                    frm.txtTelefono.Text = frm.tblProveedores.Rows[0].Cells[3].Value.ToString();
                    botenes(3);
                    cajas(3);

                }
                else
                {
                    botenes(2);
                    cajas(2);
                    limpiar();
                }
                
               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        void tblProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(frm.tblProveedores.Rows[frm.tblProveedores.CurrentRow.Index].Cells[0].Value);
                frm.txtNombre.Text = frm.tblProveedores.Rows[frm.tblProveedores.CurrentRow.Index].Cells[1].Value.ToString();
                frm.txtDireccion.Text = frm.tblProveedores.Rows[frm.tblProveedores.CurrentRow.Index].Cells[2].Value.ToString();
                frm.txtTelefono.Text = frm.tblProveedores.Rows[frm.tblProveedores.CurrentRow.Index].Cells[3].Value.ToString();
                botenes(3);
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
            botenes(1);
            cajas(1);
        }

        void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                /*primero se verifica q todo este bien antes de enviar los datos a la base de datos*/
                if (frm.txtDireccion.Text == "" || frm.txtNombre.Text == "" || frm.txtTelefono.Text == "")
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(validar.mtd_mensaje()==1)
                    {
                        dts.setId(id);
                        enviar();
                        mtd.MTD_EditarProveedor(dts);
                        MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        botenes(2);
                        cajas(2);
                        cargaTabla();
                        limpiar();
                    }
                    
                }
               
            }
            catch
            {
                MessageBox.Show("Verifique su conexion :(", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(validar.mtd_mensaje()==1)
                {
                    dts.setId(id);
                    mtd.MTD_EliminarProveedor(dts);
                    MessageBox.Show("Ación exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    botenes(2);
                    cajas(2);
                    cargaTabla();
                    limpiar();
                }
                
            }
            catch
            {
                MessageBox.Show("Verifique su conexion :(", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            if (validar.mtd_mensajeCancelar() == 1)
            {
                botenes(2);
                cajas(2);
                cargaTabla();
                limpiar();
            }
           
        }

        public void cargaTabla()
        {
            try
            {
                frm.tblProveedores.DataSource = mtd.MTD_LlenarData();
                frm.tblProveedores.Columns[0].Visible = false;
                frm.tblProveedores.Columns[4].Visible = false;
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta...!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                /*primero se va verificando q todo este bien antes de enviar los datos a la base de datos*/
                if (!(frm.txtDireccion.Text == "" || frm.txtNombre.Text == "" || frm.txtTelefono.Text == ""))
                {
                    if(validar.mtd_mensaje()==1)
                    {
                        enviar();
                        mtd.MTD_InsertarProveedor(dts);
                        MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        botenes(2);
                        cajas(2);
                        limpiar();
                        cargaTabla();
                    }
                    
                }
                else
                {
                    MessageBox.Show("No dejar campos vacios :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                
            }
            catch
            {
                MessageBox.Show("Verifique su conexion :(", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public void enviar()
        {
            dts.setNombre(frm.txtNombre.Text);
            dts.setDomicilio(frm.txtDireccion.Text);
            dts.setTelefono(frm.txtTelefono.Text);
        }

        public void limpiar()
        {
            frm.txtDireccion.Clear();
            frm.txtid.Clear();
            frm.txtNombre.Clear();
            frm.txtTelefono.Clear();
            cargaTabla();
        }
        public void botenes(int op)
        {
            switch (op)
            {
                case 1:
                    frm.btnNuevo.Enabled = false;
                    frm.btnGuardar.Enabled = true;
                    frm.btnModificar.Enabled = false;
                    frm.btnEliminar.Enabled = false;
                    frm.btnCancelar.Enabled = true;
                    frm.txtNombre.Focus();
                    break;
                case 2:
                    frm.btnNuevo.Enabled = true;
                    frm.btnGuardar.Enabled = false;
                    frm.btnModificar.Enabled = false;
                    frm.btnEliminar.Enabled = false;
                    frm.btnCancelar.Enabled = false;
                   
                    break;
                case 3:
                    frm.btnNuevo.Enabled = false;
                    frm.btnGuardar.Enabled = false;
                    frm.btnModificar.Enabled = true;
                    frm.btnEliminar.Enabled = true;
                    frm.btnCancelar.Enabled = true;
                    break;
            }
            
        }
        public void cajas(int op)
        {
            switch (op)
            {
                case 1:
                    frm.txtNombre.Focus();
                    frm.txtDireccion.Enabled = true;
                    frm.txtNombre.Enabled = true;
                    frm.txtTelefono.Enabled = true;
                    break;
                case 2:
                    frm.txtDireccion.Enabled =false;
                    frm.txtNombre.Enabled = false;
                    frm.txtTelefono.Enabled = false;
                    break;
            }
        }
       
    }
}
