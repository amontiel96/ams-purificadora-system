/*en esta clase se realizan el cote de caja de cada vendedor indicando primero la semana en q trabajo para 
 obtener cuantas ventas realizo,,  tambien sumar si hay algo extra o tiene deudas
 */
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
    class cls_CCorteCaja
    {

        frmCorteDeCaja frm = new frmCorteDeCaja();
        cls_CorteDAO mtd = new cls_CorteDAO();
        cls_CorteVO dts = new cls_CorteVO();
        Cls_Validaciones validar = new Cls_Validaciones();



        float p1, p2, p3, n=0, m1=0, m2=0,c1,c2,c3,deuda=0,t,bono,despensa,total;
        int d, m, a,idvendedor;
        string fechaI,fechaF,fecha,nombre;

        /*
         * fechaI día inicial de semana
         * fechaF día final de semana
         * fecha fecha actual de semana
         * d-m-a se utilizan para obtener la fecha
         * p1 se refiere al precio normal del botellon
         * p2 se refiere al pfecio de mayoreo 1
         * p3 se refiere al precio de mayoreo 2
         * n se refiere a la cantidad de unidades q vendio al precio normal
         * m1 se refiere a la cantidad de unidades q vendio al preocio de mayoreo 1
         * m2 se refiere a la cantidad de unidades q vendio al precio de mayoreo 2
         * c1 se refiere a la comision q gana el vendedor por vender una unidad al precio normal
         * c2 se refiere a la comision q gana el vendedor por vender una unidad al precio de mayoreo 1
         * c3 se refiere a la comision q gana el vendedor por vender una unidad al precio de mayoreo 2
         * deuda es lo q se le descuenta al suldo totl del vendedor
         * bono se suma a lo q gano de las comisiones
         * despensa se suma a lo q gano de las comisiones
         * total es el suldo final del venedor
         * idvendedor es el id del vendedor seleccionado del combo
         */

        
        public void frm_load()//aqui inicializamos los eventos necesarios de los controlos que se desean, asi como tambien inicializar metodos
        {
            llenacombo();
            llenarprecios();
            fechaActual();
            frm.txtDespensa.TextChanged += txtDespensa_TextChanged;
            frm.txtDeuda.TextChanged += txtDeuda_TextChanged;
            frm.txtBono.TextChanged += txtBono_TextChanged;
            frm.btnAceptar.Click += btnAceptar_Click;
            frm.btnConfirmar.Click += btnConfirmar_Click;
            frm.txtDespensa.KeyPress += txtDespensa_KeyPress;
            frm.txtBono.KeyPress += txtBono_KeyPress;
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }

        //todas las cajas que tengan el metodo keypress es para validar lo que se va ingresando
        void txtBono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtBono.Text,e);
        }

        void txtDespensa_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtDespensa.Text,e);
        }

        void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                deuda = float.Parse(frm.txtDeuda.Text);
                if (deuda < 0)
                {
                    deuda = 0;
                    frm.txtDeuda.Text = "";
                }
                
            }
            catch
            {
                deuda = 0;
                frm.txtDeuda.Text = "";
            }
            calSueldo();
        }

        void txtDespensa_TextChanged(object sender, EventArgs e)
        {
            //cada que se va ingresando una cantidad se va calculando automaticamente el sueldo
            try
            {
                despensa = float.Parse(frm.txtDespensa.Text);
            }
            catch
            {
                despensa = 0;
            }
            calSueldo();
        }

        void txtBono_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //cada que se va ingresando una cantidad se va calcualndo el total
                bono = float.Parse(frm.txtBono.Text);
                if (bono < 0)
                {
                    bono = 0;
                }
               
            }
            catch {
                bono = 0;
            }
            calSueldo();
        }

        void btnConfirmar_Click(object sender, EventArgs e)
        {
            comfirmar();
            
        }

        void btnAceptar_Click(object sender, EventArgs e)
        {

            fechaInicial();
            fechaFinal();
            fechaActual();
            DateTime f1 = Convert.ToDateTime(fechaI);
            DateTime f2 = Convert.ToDateTime(fechaF);
            if (f1 > f2)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
            else
            {
                idvendedor = Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString());
                dts.setIdVendedor(idvendedor);
                dts.setFechai(fechaI);
                dts.setFechaf(fechaF);
                llenarTabla();
            }
            

        }
        public void llenarTabla()
        {
            try
            {
                frm.tblVentas.DataSource = mtd.mtdllenartabla(dts);
                if (frm.tblVentas.Rows.Count >= 1)//si hay datos en la tabla
                {
                    //ocualtamos estas columnas que no son requeridas por el administrador
                    //pero si se utilizan para realizar otras funciones
                    frm.tblVentas.Columns[0].Visible = false;
                    frm.tblVentas.Columns[1].Visible = false;
                    frm.tblVentas.Columns[2].Visible = false;
                    frm.tblVentas.Columns[3].Visible = false;
                    frm.tblVentas.Columns[5].Visible = false;
                    frm.tblVentas.Columns[7].Visible = false;
                    frm.tblVentas.Columns[9].Visible = false;
                    Obtenerdeuda();
                    calcularTotal();
                    calSueldo();
                    frm.txtBono.Enabled = true;
                    frm.txtDespensa.Enabled = true;
                    nombre = frm.dtFecha.Value.Date.DayOfWeek.ToString();

                    frm.btnConfirmar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No hay ventas para este vendedor","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    limpiar();
                    frm.btnConfirmar.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }         
            
        }
        public void fechaActual()
        {
            d = frm.dtFecha.Value.Day;
            m = frm.dtFecha.Value.Month;
            a = frm.dtFecha.Value.Year;
            fecha = a + "-" + m + "-" + d;
        }
        public void fechaInicial()
        {
            d = frm.dtFechaInicial.Value.Day;
            m = frm.dtFechaInicial.Value.Month;
            a = frm.dtFechaInicial.Value.Year;
            fechaI = a + "-" + m + "-" + d;
        }

        public void fechaFinal()
        {
            d = frm.dtFechaFinal.Value.Day;
            m = frm.dtFechaFinal.Value.Month;
            a = frm.dtFechaFinal.Value.Year;
            fechaF = a + "-" + m + "-" + d;
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
        //en este metodo obtenemos los precios de venta del botellon
        //asi como tambien obtenemos las comisiones que gana cada vendedor por cada unidad que vende
        public void llenarprecios()
        {
            try
            {
                frm.tblPrecios.DataSource = mtd.mtdllenarPrecios();
                frm.lblNormal.Text = "$" + frm.tblPrecios.Rows[0].Cells[2].Value.ToString() + ":";
                frm.lblM1.Text = "$" + frm.tblPrecios.Rows[1].Cells[2].Value.ToString() + ":";
                frm.lblM2.Text = "$" + frm.tblPrecios.Rows[2].Cells[2].Value.ToString() + ":";
                p1 = float.Parse(frm.tblPrecios.Rows[0].Cells[2].Value.ToString());
                p2 = float.Parse(frm.tblPrecios.Rows[1].Cells[2].Value.ToString());
                p3 = float.Parse(frm.tblPrecios.Rows[2].Cells[2].Value.ToString());

                c1 = float.Parse(frm.tblPrecios.Rows[0].Cells[3].Value.ToString());
                c2 = float.Parse(frm.tblPrecios.Rows[1].Cells[3].Value.ToString());
                c3 = float.Parse(frm.tblPrecios.Rows[2].Cells[3].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Primero tiene que configurar los precios de botellón  :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        //se hace una consulta ala tabla deudas para obtener las deudas que tenga ese vendedor
        public void Obtenerdeuda()
        {
            try
            {
                deuda = 0;
                frm.tblDeuda.DataSource = mtd.mtdObtenerDeuda(dts);
                for (int x = 0; x < frm.tblDeuda.Rows.Count; x++)
                {
                    deuda = deuda + float.Parse(frm.tblDeuda.Rows[x].Cells[0].Value.ToString());
                }
            }
            catch
            {
                deuda = 0;
            }
            
            frm.txtDeuda.Text = deuda.ToString();
        }
        
        public void calSueldo()//este metodo calcula cuanto gano en comisiones de las ventas
        {
            try
            {
                t = (float.Parse(frm.txtNormal.Text) * c1) + (float.Parse(frm.txtM1.Text) * c2) + (float.Parse(frm.txtM2.Text) * c3);
                total = t + (despensa) + (bono) - (deuda);
                frm.lblSueldo.Text = t.ToString();
                frm.lblTotal.Text = total.ToString();
            }
            catch
            {
                despensa = 0;
            }
            
        }
        public void calcularTotal()//aqui obtenemos cauntas ventas realizo en la semana para postaeriromente multiplicarlo por las comisiones correspondientes y obtener el suldo
        {
            n = 0;
            m1 = 0;
            m2 = 0;
            //este ciclo suma las unidades que vendio el vendedor en la semana y los va sumando
            for (int x = 0; x < frm.tblVentas.Rows.Count;x++)
            {
                n = n + float.Parse(frm.tblVentas.Rows[x].Cells[5].Value.ToString());
                m1 = m1 + float.Parse(frm.tblVentas.Rows[x].Cells[7].Value.ToString());
                m2 = m2 + float.Parse(frm.tblVentas.Rows[x].Cells[9].Value.ToString());
            }
            frm.txtNormal.Text = n.ToString();
            frm.txtM1.Text = m1.ToString();
            frm.txtM2.Text = m2.ToString();
        }
        int idvenExiste, idSueldoExi, idSueldoVenExi;
        public void comfirmar()
        {
            try
            {
                /*aqui primermente se va verificando q todod este bien antes de enviar los datos a la base de datos y no tener errores*/
                if (frm.txtDespensa.Text == "" || frm.txtBono.Text == "")
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bono = float.Parse(frm.txtBono.Text);
                    despensa = float.Parse(frm.txtDespensa.Text);
                    if (bono < 0 || despensa < 0)
                    {
                        MessageBox.Show("No puede haber cantidades negativas :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (float.Parse(frm.lblTotal.Text) <= 0)
                        {
                            MessageBox.Show("Si el vendedor no gano esta semana, nose puede registrar esta acción yaque nose permiten valores negativos :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if(validar.mtd_mensaje()==1)
                            {
                                fechaActual();
                                dts.setIdVendedor(idvendedor);
                                dts.setComision(float.Parse(frm.lblSueldo.Text));
                                dts.setDeuda(float.Parse(frm.txtDeuda.Text));
                                dts.setBono(bono);
                                dts.setDespensa(despensa);
                                dts.setSueldo(float.Parse(frm.lblTotal.Text));
                                dts.setFecha(fecha);
                                frm.tblExiste.DataSource = mtd.mtdVerificaSueldo(dts);
                                if (frm.tblExiste.Rows.Count >= 1)
                                {
                                    if (MessageBox.Show("Ya se ha realizo el pago a este vendedor, Desea continuar para cambiarlo??", "Responda la pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        idSueldoExi = Convert.ToInt32(frm.tblExiste.Rows[0].Cells[0].Value.ToString());
                                        idvenExiste = Convert.ToInt32(frm.tblExiste.Rows[0].Cells[1].Value.ToString());
                                        idSueldoVenExi = Convert.ToInt32(frm.tblExiste.Rows[0].Cells[2].Value.ToString());
                                        //metodo para modificar el sueldo
                                        dts.setiIdSueldo(idSueldoExi);
                                        dts.setComision(float.Parse(frm.lblSueldo.Text));
                                        dts.setDeuda(float.Parse(frm.txtDeuda.Text));
                                        dts.setBono(bono);
                                        dts.setDespensa(despensa);
                                        dts.setSueldo(float.Parse(frm.lblTotal.Text));
                                        mtd.mtdUpdateVendedor(dts);
                                        MessageBox.Show("Registro actualizado exitosamente :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        frm.btnConfirmar.Enabled = false;
                                    }
                                }
                                else
                                {
                                    mtd.mtdInsertarSueldo(dts);//una ves enviado todos los datos, llamamos al metodo insertar sueldo
                                    MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    frm.btnConfirmar.Enabled = false;
                                }  
                               
                                limpiar();
                            }
                            
                        }
                        
                    }
                    
                }
                
            }
            catch
            {
                MessageBox.Show("Se produjo un error al intentar guardar  :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }
       
        public void limpiar()
        {
            frm.txtBono.Text = "0";
            frm.txtDespensa.Text = "0";
            frm.txtDeuda.Text = "0";
            frm.txtM1.Text = "0";
            frm.txtM2.Text = "0";
            frm.lblSueldo.Text = "0";
            frm.txtNormal.Text = "0";
            frm.lblTotal.Text = "0";
            frm.txtBono.Enabled = false;
            frm.txtDespensa.Enabled = false;
            frm.tblVentas.DataSource = null;
            frm.tblDeuda.DataSource = null;
        }
    }
}
