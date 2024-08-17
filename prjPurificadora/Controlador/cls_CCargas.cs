/*lo que se hace n esta clase es registrar las cargas y descargas de botellones para llevar un control y no ahigan perdidas de productos*/
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
    class cls_CCargas
    {
        //instanciamos los objetos que se necesitaran
        frmCargas frm = new frmCargas();
        cls_CargasDAO mtd = new cls_CargasDAO();
        cls_CargasVO dts = new cls_CargasVO();
        Cls_Validaciones validar = new Cls_Validaciones();

         //variables a utilizar para este formulario
         int d, m, a,idcarga,existe = 0;
         string fecha;
         int opc;

        /*
         d-m-a son para obtener la fecha
         * idcarga es el id de carga q se encuantra en la tabla y se utiliza para hacer una actualizacion a ese registro
         * existe es la cantidad q ya tiene registrado anterorimente un vendedor para que cuando ahiga otro registro 
         * primero se extraiga y se le sume o reste cantidad segun sea el caso
         * opc esta variable se utiliza como auxiliar para definir si tine registros previos o aun no tiene registros, si tiene su valor sera 1 de otro mod sera 2
         */

        public void frm_load()//cramos nuestro evento load del formulario para inizializar los evetos de los controles requeridos
        {
            frm.btnAceptar.Click += btnAceptar_Click;
            frm.btnRegistrar.Click += btnRegistrar_Click;
            frm.tblCargas.CellClick += tblCargas_CellClick;
            frm.txtCarga.KeyPress += txtCarga_KeyPress;
            frm.txtDescarga.KeyPress += txtDescarga_KeyPress;
            frm.cmbVendedor.TextChanged += cmbVendedor_TextChanged;
            Application.EnableVisualStyles();
            cargaruta();
            frm.ShowDialog();
        }

        void cmbVendedor_TextChanged(object sender, EventArgs e)
        {
            frm.tblCargas.DataSource = null;
            limpiar();
            frm.btnRegistrar.Enabled = false;
            frm.txtCarga.Enabled = false;
            frm.txtDescarga.Enabled = false;
        }

        //las cajas que cuentan con el evento keypres es para validar lo que se va ingresando en la caja de texto y no ahiga errores
        void txtDescarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void txtCarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void tblCargas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //una ves que ya se cargaron los datos en la tabla y seleccionamos el registro deseado y obtenemos si id para poder realizar las peticiones deacuerdo al id
                idcarga = Convert.ToInt32(frm.tblCargas.Rows[frm.tblCargas.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {

            }
        }
        //creamos nuestro metodo de enviar en general 
        //ya que se utiliza mas de una ves y asi no se repetiran las instrucciones
        public void enviar()
        {
            d = frm.dtFecha.Value.Day;
            m = frm.dtFecha.Value.Month;
            a = frm.dtFecha.Value.Year;
            fecha = a + "-" + m + "-" + d;
            dts.setCarga(float.Parse(frm.txtCarga.Text));
            dts.setDescarga(float.Parse(frm.txtDescarga.Text));
            dts.setFecha(fecha);
        }

        void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                /*aqquiprimero se va verificando q todo este bien para continuar con el proceso de registrar una carga*/
                if (opc == 1)//si no hay registros
                {
                    if (frm.txtCarga.Text == "" || frm.txtDescarga.Text == "")//no podemos enviar campos vacios ala base de datos
                    {
                        MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Convert.ToInt32(frm.txtCarga.Text) <= 0)//verificamos que la cantidad sea mayor a cero
                        {
                            MessageBox.Show("Nose puede registrar una cantidad menor ó igual a 0", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (validar.mtd_mensaje() == 1)
                            {
                                //guardar
                                enviar();
                                dts.setVendedor(Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString()));
                                mtd.mtdInsertar(dts);
                                MessageBox.Show("Resgistro exitoso :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                llenatabla();
                            }
                           
                        }
                    }
                }
                else if(opc==2) //si hay registros 
                {
                    if (frm.txtCarga.Text == "" || frm.txtDescarga.Text == "")
                    {
                        MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Convert.ToInt32(frm.txtCarga.Text) <= 0 && Convert.ToInt32(frm.txtDescarga.Text) <= 0)
                        {
                            MessageBox.Show("Por lo menos una cantidad tiene que ser mayor que 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (existe < Convert.ToInt32(frm.txtDescarga.Text))
                            {
                                MessageBox.Show("Nose puede descargar mas de lo que esta pendiente :)", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (validar.mtd_mensaje() == 1)
                                {
                                    //modificar existente
                                    enviar();
                                    dts.setIdCarga(idcarga);
                                    mtd.mtdActualizar(dts);
                                    MessageBox.Show("Resgistro exitoso :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    llenatabla();
                                }
                            }
                            
                            
                        }
                    }
                }

   
                
                
            }
            catch
            {
                MessageBox.Show("Se produjo un error al registrar :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
           
            
        }

        void btnAceptar_Click(object sender, EventArgs e)
        {
            llenatabla(); //al dar clic en el boton aceptar se tiene que hacer una consulta ala base para llenar la tabla deacuerdo al vendedor seleccionado  
        }
        public void llenatabla()
        {
            try
            {
                limpiar();//primero limpiamos todo para que empiece desde cero todo
                dts.setVendedor(Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString()));
                frm.tblCargas.DataSource = mtd.mtdllenar(dts);
                if (!(frm.tblCargas.Rows.Count >= 1))//preguntamos si hay registros en la tabla
                {
                    MessageBox.Show("No hay registros para este vendedor :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.txtCarga.Enabled = true;
                    frm.txtDescarga.Enabled = false;
                    opc = 1;//si no hay registros
                    existe = 0;
                }
                else
                {
                    idcarga = Convert.ToInt32(frm.tblCargas.Rows[0].Cells[0].Value.ToString());
                    frm.txtCarga.Enabled = true;
                    frm.txtDescarga.Enabled = true;
                    opc = 2;//si hay registros
                    existe = Convert.ToInt32(frm.tblCargas.Rows[0].Cells[2].Value.ToString());
                }

                frm.btnRegistrar.Enabled = true;
                //ocultamos estas dos columnas yaque no son requeridas para la vista del administrador pero son necesarias para realizar acciones
                frm.tblCargas.Columns[0].Visible = false;
                frm.tblCargas.Columns[1].Visible = false;
            }
            catch
            { 
            
            }
            
        }
        public void cargaruta()
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

        public void limpiar()
        {
            frm.txtDescarga.Text = "0";
            frm.txtCarga.Text = "0";
        }
    }
}
