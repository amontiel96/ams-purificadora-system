/*en esta clase es donde deben estrar registrados los botellones, sellos y tapones unicamente, para 
 hacer sus registro de sus precios de compra
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Vista;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPurificadora.Controlador
{
    class cls_CBotellones
    {
        //creamos los objetos alas clases que se necesitan
        frmBotellones frm = new frmBotellones();
        cls_ProductosDAO mtd = new cls_ProductosDAO();
        cls_ProductosVO dts = new cls_ProductosVO();
        Cls_Validaciones validar = new Cls_Validaciones();
        
        //declaramos las variables
        int id;
        float pre;
        /*
         id es el id del producto seleccionado
         * pre es el valor del precio del producto
         */

        public void frm_load()//creamos el motodo load donde inicializamos los controles necesitados
        {
            llenarTabla();
            frm.tblProductos.CellClick += tblProductos_CellClick;
            frm.btnCancelar.Click += btnCancelar_Click;
            frm.btnGuardar.Click += btnGuardar_Click;
            frm.btnModificar.Click += btnModificar_Click;
            frm.btnNuevo.Click += btnNuevo_Click;
            frm.btnSalir.Click += btnSalir_Click;
            frm.txtNombre.KeyPress += txtNombre_KeyPress;
            frm.txtNombre.KeyPress +=txtNombre_KeyPress;
            frm.txtPrecio.KeyPress += txtPrecio_KeyPress;
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }

        void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtPrecio.Text,e);//enviamos lo que se va ingresando ala clase para validar
        }

        void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras(e);
        }

        //pasamos los valores de la celda seleccionada alas cajas de texto y activamos los botones y cajas correspondientes
        void tblProductos_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(frm.tblProductos.Rows[frm.tblProductos.CurrentRow.Index].Cells[0].Value.ToString());
                frm.txtNombre.Text = frm.tblProductos.Rows[frm.tblProductos.CurrentRow.Index].Cells[1].Value.ToString();
                frm.txtExistencia.Text = frm.tblProductos.Rows[frm.tblProductos.CurrentRow.Index].Cells[2].Value.ToString();
                frm.txtPrecio.Text = frm.tblProductos.Rows[frm.tblProductos.CurrentRow.Index].Cells[3].Value.ToString();
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
                /*aqui lo que se hace es ir verirficando q todo este bien par continuar con el proceso de editar*/
                if (frm.txtNombre.Text == "" || frm.txtPrecio.Text == "")//no permmitimos que se ingresen valores vacios
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pre = float.Parse(frm.txtPrecio.Text);
                    if (pre <= 0)//no puede haber ningun precio de compra que sea menor o igual a cero
                    {
                        MessageBox.Show("El precio de compra tiene que ser mayor que 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(validar.mtd_mensaje()==1)
                        {
                            enviar();//llamamos al metodo enviar datos que es en general
                            dts.setId(id);//aparte tambien enviamos el id seleccionado para actalizar el registro deacuerdo al id
                            mtd.mtdEditaBotellones(dts);//una ves enviado los parametros ejecutamos nuestro metodo para editar
                            MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            botones(2);
                            cajas(2);
                            limpiar();
                            llenarTabla();//despues de que actualizamos el registro con exito tenemos que volver a limpiar los controles del formulario asi como tambien habilitar y deshabilitar botones

                        }
                    }
             
                }
            }
            catch
            {
                MessageBox.Show("Error al intentar editar :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                /*aqui lo q se hace es ir verificando q todo este bien para continuar con el proceso de guardar*/
                if (frm.txtNombre.Text == "" || frm.txtPrecio.Text == "")//no podemos agregar valores vacios 
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pre = float.Parse(frm.txtPrecio.Text);
                    if (pre <= 0)//el precio de compra tiene que ser mayor a cero
                    {
                        MessageBox.Show("El precio de compra tiene que ser mayor que 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(validar.mtd_mensaje()==1)
                        {
                            enviar();//eviamos los parametros 
                            mtd.mtdInsertarBotellones(dts);//ejecutamos el metodo para insertar nuevo registro
                            MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            botones(2);
                            cajas(2);
                            limpiar();
                            llenarTabla();//cuando se registro exitosamente llenamos la tabla nuevamente para ver el registro agregado
                        }
                        
                    }          
                    
                }
            }
            catch
            {
                MessageBox.Show("Error al intentar guardar :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

            
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            if(validar.mtd_mensajeCancelar()==1)//si esto es igual  uno quiere decir q la respuesta fue si
            {
                botones(2);
                cajas(2);
                limpiar();
            }
            
        }
        public void llenarTabla()
        {
            try
            {
                frm.tblProductos.DataSource = mtd.mtdllenarBotellones();
                //llenamos la tabla con la consulta ala base de datos 
                //y ponemos invisibles estas dos columnas que no son necesarias para la vista del administrador y solo quiytarian espacio
                frm.tblProductos.Columns[0].Visible = false;
                frm.tblProductos.Columns[4].Visible = false;
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
        public void enviar()
        {
            //aqui encapsulamos los valores de las cajas
            //esta en un metodo para no repetir yaque este se utiliza dos veces que es 
            //ala hora de registrar uno nuevo y actualizar uno existente
            dts.setNombre(frm.txtNombre.Text);
            dts.setExistencia(Convert.ToInt32(frm.txtExistencia.Text));
            dts.setPrecio(float.Parse(frm.txtPrecio.Text));
            
        }
        //con este metodo habiltamos y deshabilitamos los botones
        //deacuerdo alas opciones que le enviemos
        public void botones(int op)
        {
            switch (op)
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

        //habilitamos y deshabilitamos las cajas deacuerdo ala opcion que se nesecite
        public void cajas(int op)
        {
            switch (op)
            {
                case 1:
                    frm.txtNombre.Enabled = true;
                    frm.txtPrecio.Enabled = true;
                    //frm.txtExistencia.Enabled = true;
                    frm.txtNombre.Focus();
                    break;
                case 2:
                    //frm.txtExistencia.Enabled = false;
                    frm.txtNombre.Enabled = false;
                    frm.txtPrecio.Enabled = false;
                    break;
            }
        }
        public void limpiar()
        {
            frm.txtNombre.Clear();
            frm.txtPrecio.Clear();
            frm.txtExistencia.Text = "0";
        }

    }
}
