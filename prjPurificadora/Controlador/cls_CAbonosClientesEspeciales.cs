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
    class cls_CAbonosClientesEspeciales
    {
        frmAbonosEspeciales frm = new frmAbonosEspeciales();//instanciamos el formulario de abonos
        cls_AbonosDAO mtd = new cls_AbonosDAO();//instanciamos un objeto para la clase abonosDAO
        cls_AbonosVO dts = new cls_AbonosVO();//instanciamos un objeto para la clase abonosVO donde se encapsulan las variables
        Cls_Validaciones validar = new Cls_Validaciones();//instanciamos un objeto para la clase validaciones 

        //decaramos variables a utilizar
        int d, m, a, idvendedor, idcliente, iddeuda;
        float abonar, debe, cantidad;
        string fecha;
        DialogResult respuesta;
        /*
         d = dia paa obtener fecha
         *m es el mes
         *a es el año
         *fecha es el resultado de d-m-a junto
         *idvendedor es el valor del combo seleccionado
         *idcliente es el id del cliente seleccionado de la tabla
         *iddeuda es el id para identifiar el registro al cual se ara el abono
         */


        public void frm_load()//creamos el metodo load para iniciar los controles del formulario
        {
            d = frm.dtFecha.Value.Day;
            m = frm.dtFecha.Value.Month;
            a = frm.dtFecha.Value.Year;
            fecha = a + "-" + m + "-" + d;//obtenemos la fecha actual
            //iniciamos los eventos clic de cada boton del formulario
            frm.btnRegistrar.Click += btnRegistrar_Click;
            //frm.btnAceptar.Click += btnAceptar_Click;
            frm.tblDeudas.CellClick += tblDeudas_CellClick;//evento para cuando le demos clic a una celda de la tabla
            frm.txtAbono.KeyPress += txtAbono_KeyPress;//evento keypress para cuando se ingresa un valor ala caja de texto
            //frm.cmbVendedor.TextChanged += cmbVendedor_TextChanged;
            Application.EnableVisualStyles();//esta funcion aplica los estilos alos controles del formulario
            llenatabla();
            //llenacombo();//llamamos al metodo para que cuando se inicie el formlario tambien se llene el combobox respectivo
            frm.ShowDialog();//muestra el formulario
        }

        void cmbVendedor_TextChanged(object sender, EventArgs e)
        {
            frm.tblDeudas.DataSource = null;
            frm.txtAbono.Text = "0";
            frm.txtAbono.Enabled = false;
        }

        void txtAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtAbono.Text, e);//enviamos lo que se va ingresando en la caja de texto a la clase validaciones por medio del objeto validar
        }

        //cuando seleccionamos una fila de la tabla de datos
        void tblDeudas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iddeuda = Convert.ToInt32(frm.tblDeudas.Rows[frm.tblDeudas.CurrentRow.Index].Cells[0].Value.ToString());//pasamos el valor de la primera fila ala variable
                frm.txtIdCliente.Text = frm.tblDeudas.Rows[frm.tblDeudas.CurrentRow.Index].Cells[2].Value.ToString();//pasamos el valor de la columna2 ala caja de texto para despues usar
                frm.txtDeuda.Text = frm.tblDeudas.Rows[frm.tblDeudas.CurrentRow.Index].Cells[3].Value.ToString();//pasamos el valor de la columna3 ala caja de texto para despues usar
                frm.txtAbono.Focus();//enviamos el focus ala caja de texto que se desea
                frm.txtAbono.Enabled = true;//habilitamos la caja para que de esta manera ya se pueda ingresar la cantidad que se va a abonar
                frm.btnRegistrar.Enabled = true;//habilitamos el boton registrar por que solo se habilita cuando ya se ha seleccionado un cliente para asi poder registrar su abono
            }
            catch
            {

            }

        }

        //al dar clic en el boton aceptar
        void btnAceptar_Click(object sender, EventArgs e)
        {
            //idvendedor = Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString());//igualamos el valor que tiene el combo vendedor ala variable para posteriormente utilizar
            //dts.setIdVendedor(idvendedor);//pasamos el id de vendedor seleccionado y lo enviamos ala clase de encapsulacion
            llenatabla();//posteriormente ejecutamos el metodo para llenar la consulta de acuerdo al id obtenido
        }

        void btnRegistrar_Click(object sender, EventArgs e)
        {
            registrar();//ejecutamos nuestro metodo de registrar que esta abajo
        }
        public void registrar()//en este metodo primero vamos verificando qu todo este bien, y cuando ya este validado todo ya poder seguir con el registro 
        {
            try
            {
                if (frm.txtAbono.Text == "")//verifiacmos que la caja no este vacia para no causar problemas en la base de datos
                {
                    MessageBox.Show("Ingrese la cantidad a abonar :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //sino esta vacia la caja
                    debe = float.Parse(frm.txtDeuda.Text);//igualamos los valores de las cajas de texto a las variables declaradas
                    abonar = float.Parse(frm.txtAbono.Text);
                    cantidad = debe - abonar;//hacemos una resta donde restamos la cantidad que se esta abonando por lo que se debe hasta ese momento

                    if (abonar <= 0)//verificamos sila cantidad a abonar es menor o igual a 0 para no cuasar conflictos
                    {
                        MessageBox.Show("Nose puede abonar cantidades menores ó iguales a 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (abonar > debe)//la cantidad a abonar no puede ser mayor alo que se debe
                        {
                            MessageBox.Show("Debes menos de lo que quieres abonar :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            respuesta = MessageBox.Show("¿Desea continuar?", "Responda la pregunta...!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (respuesta == DialogResult.Yes)
                            {
                                //encapsulamos los valores de las variables 
                                dts.setDeuda(cantidad);
                                dts.setIdDeuda(iddeuda);
                                dts.setFecha(fecha);
                                //ejecutamos el metodo para actualizar con las variables encapsuladas
                                mtd.mtdActualizarEspeciales(dts);
                                MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                llenatabla();
                                limpiar();
                                //una ves que se realizo la operacion correspondiente de deshabilita la caja de texto abono y el boton de registrar para que quede como un inicio
                                frm.txtAbono.Enabled = false;
                                frm.btnRegistrar.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Accion cancelada :)", "Aviso...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }

                    }


                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error al intentar guardar :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public void llenatabla()//aqui llenamos la consulta de la tabla deudas de la bd para ver los clientes que han quedado ha deber dinero
        {
            try
            {
                frm.tblDeudas.DataSource = mtd.mtdllenarEspeciales();
                //escondemos estas columnas yaque no son necesarias para la vista 
                frm.tblDeudas.Columns[1].Visible = false;
                frm.tblDeudas.Columns[0].Visible = false;

                if (!(frm.tblDeudas.Rows.Count >= 1))//preguntamos si hay registros, delo contrario se avisa con el menseje de que no tiene deudas
                {
                    frm.btnRegistrar.Enabled = false;
                    frm.txtAbono.Enabled = false;
                    MessageBox.Show("No hay registros de deudas :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //metodo para limpiar controles del formulario
        public void limpiar()
        {
            frm.txtAbono.Clear();
            frm.txtDeuda.Clear();
            frm.txtIdCliente.Clear();
        }
    }
}
