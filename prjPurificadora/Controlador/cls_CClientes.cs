/*en esta clase se hacen los registros, actualizaciones y eliminaciones de los clientes*/
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
    class cls_CClientes
    {
        //instanciamos los objetos de las clases necesarias
        frmClientes frm = new frmClientes();
        cls_ClientesVO dts = new cls_ClientesVO();
        cls_ClientesDAO mtd = new cls_ClientesDAO();
        Cls_Validaciones validar = new Cls_Validaciones();

        //declaramos nuestra variables a utilizar
        int id,idruta;
        string nom,tipo;
        int idp;
        DialogResult respuesta;
        /*id es el numero de registro de cliente
         idruta es el id de la ruta seleccionada del combo
         * nom es el nombre del cliente
         * idp ara buscar a un cliente
         */


        public void frm_load()//creamos el metodo load para el formulario para inicializar lso eventos de los controles necesarios
        {
            frm.btnCancelar.Click += btnCancelar_Click;
            frm.btnEliminar.Click += btnEliminar_Click;
            frm.btnGuardar.Click += btnGuardar_Click;
            frm.btnModificar.Click += btnModificar_Click;
            frm.btnNuevo.Click += btnNuevo_Click;
            frm.btnSalir.Click += btnSalir_Click;
            frm.tblClientes.CellClick += tblClientes_CellClick;
            frm.txtNombre.KeyPress += txtNombre_KeyPress;
            frm.txtid.TextChanged += txtBuscar_TextChanged;
            Application.EnableVisualStyles();
            cargaruta();
            cargaTabla();
            frm.ShowDialog();
        }


        void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                idp = Convert.ToInt32(frm.txtid.Text);
                nom = frm.txtid.Text;
            }
            catch
            {
                idp = 0;
                nom = frm.txtid.Text;
            }

            try
            {
                dts.setNombre(nom);
                dts.setId(idp);
                frm.tblClientes.DataSource = mtd.MTD_buscar(dts);
                frm.tblClientes.Columns[0].Visible = false;
                frm.tblClientes.Columns[3].Visible = false;
                if (frm.tblClientes.Rows.Count >= 1)
                {
                    id = Convert.ToInt32(frm.tblClientes.Rows[0].Cells[0].Value.ToString());
                    frm.txtNombre.Text = frm.tblClientes.Rows[0].Cells[1].Value.ToString();

                    botenes(3);
                    cajas(3);

                }
                else
                {
                    botenes(2);
                    cajas(2);
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //las cajas que cuentan con el evento keypress es para validar lo que se va ingresando en la caja
        void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras(e);
        }

        //al dar clic en el registro deseado pasamos los valores alas cajas de texto y activamos y desactivamos los botones y cajas necesarias
        void tblClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(frm.tblClientes.Rows[frm.tblClientes.CurrentRow.Index].Cells[0].Value);
                frm.txtNombre.Text = frm.tblClientes.Rows[frm.tblClientes.CurrentRow.Index].Cells[1].Value.ToString();
                //frm.cmbRuta.Text = "Ruta " + frm.tblClientes.Rows[frm.tblClientes.CurrentRow.Index].Cells[2].Value.ToString();
                //idruta = Convert.ToInt32(frm.tblClientes.Rows[frm.tblClientes.CurrentRow.Index].Cells[2].Value.ToString());
                //frm.cmbRuta.SelectedIndex = Convert.ToInt32(frm.tblClientes.Rows[frm.tblClientes.CurrentRow.Index].Cells[2].Value.ToString()) - 1;
                tipo = frm.tblClientes.Rows[frm.tblClientes.CurrentRow.Index].Cells[4].Value.ToString();
                if (tipo == "Si")
                {
                    frm.chbTipoCliente.Checked = true;
                    frm.chbTipoCliente.Enabled = true;
                }
                else
                {
                    frm.chbTipoCliente.Checked = false;
                    frm.chbTipoCliente.Enabled = false;
                }
                botenes(3);
                cajas(1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void cargaruta()
        {
            frm.cmbRuta.DataSource = mtd.mtdllenaRuta();
            frm.cmbRuta.DisplayMember = "vchNombre";
            frm.cmbRuta.ValueMember = "intIdRutaPK";
        }
        public void cargaTabla()
        {
            frm.tblClientes.DataSource = mtd.mtdllenaTabla();
            //ocultamos estas dos columnas que no son requeridas para la vista del administrador pero si son necesarias para realizar algunas acciones
            frm.tblClientes.Columns[0].Visible = false;
            frm.tblClientes.Columns[2].Visible = false;
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
                if (frm.txtNombre.Text == "")//no podemos guardar campos vacios en la base
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //antes de realizar la accion primero preguntamos si esta seguro de continuar
                    respuesta = MessageBox.Show("Desea modificar este registro???","Responda a la pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)//si la respuesta fue que si entonces ya se hacen las siguientes acciones
                    {
                        dts.setId(id);
                        //dts.setRuta(idruta);
                        enviar();
                        mtd.mtdEditar(dts);
                        MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        botenes(2);
                        cajas(2);
                        cargaTabla();
                        limpiar();
                    }
                    else
                    {
                        //si  la respuesta fue que no, entonces mandamos mensaje de que ha cancelado la accion y limpiamos el forumlario
                        MessageBox.Show("Acción cancelada :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (frm.txtNombre.Text == "")//no podemos guardar datos vacios en la base
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(validar.mtd_mensaje()==1)
                    {
                        
                        enviar();//enviamos los parametros y ejecutamos nuestro metodo para insertar
                        mtd.mtdInsertar(dts);
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
                MessageBox.Show("Verifique su conexion :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //cuando se ha seleccionado un registro y damos clic en el boton de eliminar
                //primero preguntamos se esta seguro de continuar con la accion
                respuesta = MessageBox.Show("Desea eliminar este registro???", "Responda a la pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)//si la respuesta fue que si, entonces se procede a enviar el id de registro y eliminarlo
                {
                    dts.setId(id);
                    mtd.mtdEliminar(dts);
                    MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //si la respuesta fue que no, se muestra un aviso para que se de cuenta de que ha cancelado la accion
                    MessageBox.Show("Acción cancelada :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                botenes(2);
                cajas(2);
                cargaTabla();
                limpiar();
            }
            catch
            {
                MessageBox.Show("Verifique su conexion :(", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
    

        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            if(validar.mtd_mensajeCancelar()==1)
            {
                botenes(2);
                cajas(2);
                limpiar();
                cargaTabla();
            }
            
        }
        //creamos el metodo enviar para no repetir codigo ya que esto se utiliza mas de una ves
        public void enviar()
        {
            dts.setNombre(frm.txtNombre.Text);
            dts.setRuta(Convert.ToInt32(frm.cmbRuta.SelectedValue.ToString()));
            if (frm.chbTipoCliente.Checked == true)
            {
                tipo = "Si";
            }
            else
            {
                tipo = "No";
            }
            dts.setEspecial(tipo);
        }

        //se habilitan y deshabilitan los botones deacuerdo ala opcion deseada
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
                    frm.chbTipoCliente.Enabled = true;
                    frm.chbTipoCliente.Checked = false;
                    frm.txtNombre.Focus();
                    break;
                case 2:
                    frm.btnNuevo.Enabled = true;
                    frm.btnGuardar.Enabled = false;
                    frm.btnModificar.Enabled = false;
                    frm.btnEliminar.Enabled = false;
                    frm.btnCancelar.Enabled = false;
                    frm.chbTipoCliente.Enabled = false;
                    break;
                case 3:
                    frm.btnNuevo.Enabled = false;
                    frm.btnGuardar.Enabled = false;
                    frm.btnModificar.Enabled = true;
                    frm.btnEliminar.Enabled = true;
                    frm.btnCancelar.Enabled = true;
                    frm.chbTipoCliente.Enabled = true;
                    break;
            }

        }
        //se habilitan y deshabltan las cajas deacuerdo ala opcion requerida
        public void cajas(int op)
        {
            switch (op)
            {
                case 1:
                    frm.txtNombre.Focus();
                    frm.txtNombre.Enabled = true;
                    frm.cmbRuta.Enabled = true;
                    break;
                case 2:
                    frm.txtNombre.Enabled = false;
                    frm.cmbRuta.Enabled = false;
                    break;
            }
        }
        public void limpiar()
        {
            frm.txtid.Clear();
            frm.txtNombre.Clear();
        }
    }
}
