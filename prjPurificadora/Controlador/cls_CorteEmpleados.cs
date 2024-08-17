/*en esta clase se realiza el pago de la semana a los empleados*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjPurificadora.Vista;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Modelo.DAO;
using System.Windows.Forms;

namespace prjPurificadora.Controlador
{
    class cls_CorteEmpleados
    {
        frmCorteEmpleados frm = new frmCorteEmpleados();
        cls_CorteVO dts = new cls_CorteVO();
        cls_CorteDAO mtd = new cls_CorteDAO();
        Cls_Validaciones validar = new Cls_Validaciones();

        int d, m, a,id;
        string fechaI, fechaF, fecha, nombre;
        float deuda=0, bono=0, despensa=0, salario, sueldototal;

        /*
         * fechaI día inicial
         * fechF día final
         d-m-a son para obtener la fecha inicial y fecha final y fecha actual
         * nombre es el nombre del día obtenido para verificar q sea sabado
         * deuda es lo q se descuenta al sueldo
         * bono es lo q se suma al salario
         * despensa es la q se suma al salario
         * sueldototal es el total a pagar
         */

        public void frm_load()
        {
            frm.txtBono.KeyPress += txtBono_KeyPress;
            frm.txtDespensa.KeyPress += txtDespensa_KeyPress;
            frm.txtDeuda.KeyPress += txtDeuda_KeyPress;
            frm.txtBono.TextChanged += txtBono_TextChanged;
            frm.txtDespensa.TextChanged += txtDespensa_TextChanged;
            frm.txtDeuda.TextChanged += txtDeuda_TextChanged;
            frm.tblEmpleados.CellClick += tblEmpleados_CellClick;
            frm.btnAceptar.Click += btnAceptar_Click;
            frm.btnComfirmar.Click += btnComfirmar_Click;
            fechaActual();
            llenarTabla();
            frm.ShowDialog();
        }

        void btnComfirmar_Click(object sender, EventArgs e)
        { 
            fechaInicial();
            fechaFinal();
           
            comfirmarPago();
        }

        void txtDeuda_TextChanged(object sender, EventArgs e)/*se indica cuando tiene de deuda y se va restando al salario*/
        {
            try
            {
                deuda = float.Parse(frm.txtDeuda.Text);
            }
            catch
            {
                deuda = 0;
            }
            calTotal();
        }

        void txtDespensa_TextChanged(object sender, EventArgs e)/*se indica cuando se va a sumar de despensa*/
        {
            try
            {
                despensa = float.Parse(frm.txtDespensa.Text);
            }
            catch
            {
                despensa = 0;
            }
            calTotal();
        }

        void txtBono_TextChanged(object sender, EventArgs e)/*se va indicando cuanto se va a sumar al salario de bono*/
        {
            try
            {
                bono = float.Parse(frm.txtBono.Text);
            }
            catch
            {
                bono = 0;
            }
            calTotal();
        }

        void tblEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[0].Value.ToString());
                frm.txtSalario.Text = frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[9].Value.ToString();
                cajas(1);
                calTotal();
                frm.btnComfirmar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Seleccione un registro porfavor :(","Error...",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        void txtDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtDeuda.Text, e);
        }

        void txtDespensa_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtDespensa.Text, e);
        }

        void txtBono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtBono.Text,e);
        }

        void btnAceptar_Click(object sender, EventArgs e)
        {
            llenarTabla();
        }

        public void llenarTabla()
        {
            try
            {
                frm.tblEmpleados.DataSource = mtd.mtdllenarTablaEmpleados();
                frm.tblEmpleados.Columns[0].Visible = false;
                frm.tblEmpleados.Columns[6].Visible = false;
                frm.tblEmpleados.Columns[8].Visible = false;
                if (frm.tblEmpleados.Rows.Count >= 1)
                {
                    //frm.tblEmpleados.Columns[0].Visible = false;
                    nombre = frm.dtFecha.Value.Date.DayOfWeek.ToString();

                    frm.btnComfirmar.Enabled = true;
                }
                
                
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta...!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
        public void calTotal()/*este metodo ees para calcular el sueldo total a pagar al empleado*/
        {
            sueldototal = (bono + despensa + float.Parse(frm.txtSalario.Text))-(deuda);
            frm.txtSueldoTotal.Text = sueldototal.ToString();
        }
        int idSueldoExi;
        public void comfirmarPago()/*en este metodo primero verifica q todo este bien y luego envia los datos a la base de datos*/
        {
            try
            {
                if (frm.txtDespensa.Text == "" || frm.txtBono.Text == ""||frm.txtDeuda.Text=="")
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bono = float.Parse(frm.txtBono.Text);
                    despensa = float.Parse(frm.txtDespensa.Text);
                    deuda = float.Parse(frm.txtDeuda.Text);
                    if (bono < 0 || despensa < 0 || deuda < 0)
                    {
                        MessageBox.Show("No puede haber cantidades negativas :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(validar.mtd_mensaje()==1)
                        {
                            fechaActual();
                            dts.setIdVendedor(id);
                            dts.setSalario(float.Parse(frm.txtSalario.Text));
                            dts.setDeuda(float.Parse(frm.txtDeuda.Text));
                            dts.setBono(bono);
                            dts.setDespensa(despensa);
                            dts.setSueldo(float.Parse(frm.txtSueldoTotal.Text));
                            dts.setFecha(fecha);
                            frm.tblExiste.DataSource = mtd.mtdVerificaSueldoEmpleado(dts);
                            if (frm.tblExiste.Rows.Count >= 1)
                            {
                                if (MessageBox.Show("Ya se ha realizo el pago a este vendedor, Desea continuar para cambiarlo??", "Responda la pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    idSueldoExi = Convert.ToInt32(frm.tblExiste.Rows[0].Cells[0].Value.ToString());
                                    //metodo para modificar el sueldo
                                    dts.setiIdSueldo(idSueldoExi);
                                    //dts.setComision(float.Parse(frm.lblSueldo.Text));
                                    dts.setDeuda(float.Parse(frm.txtDeuda.Text));
                                    dts.setBono(bono);
                                    dts.setDespensa(despensa);
                                    dts.setSueldo(float.Parse(frm.txtSueldoTotal.Text));
                                    mtd.mtdUpdateEmpleado(dts);
                                    MessageBox.Show("Registro actualizado exitosamente :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    frm.btnComfirmar.Enabled = false;
                                }
                            }
                            else
                            {
                                mtd.mtdInsertarSueldoEmpleados(dts);//una ves enviado todos los datos, llamamos al metodo insertar sueldo
                                MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frm.btnComfirmar.Enabled = false;
                            }
                            
                            limpiar();
                            cajas(2);
                        }
                        
                    }

                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error al intentar guardar  :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void fechaActual()/*obtiene fecha actual*/
        {
            d = frm.dtFecha.Value.Day;
            m = frm.dtFecha.Value.Month;
            a = frm.dtFecha.Value.Year;
            fecha = a + "-" + m + "-" + d;
        }
        public void fechaInicial()/*obtiene fecha inicial*/
        {
            d = frm.dtFechaInicial.Value.Day;
            m = frm.dtFechaInicial.Value.Month;
            a = frm.dtFechaInicial.Value.Year;
            fechaI = a + "-" + m + "-" + d;
        }

        public void fechaFinal()/*obtiene fecha final*/
        {
            d = frm.dtFechaFinal.Value.Day;
            m = frm.dtFechaFinal.Value.Month;
            a = frm.dtFechaFinal.Value.Year;
            fechaF = a + "-" + m + "-" + d;
        }

        public void cajas(int op)
        {
            switch (op)
            {
                case 1:
                    frm.txtDeuda.Enabled = true;
                    frm.txtDespensa.Enabled = true;
                    frm.txtBono.Enabled = true;
                    break;
                case 2:
                    frm.txtDeuda.Enabled = false;
                    frm.txtDespensa.Enabled = false;
                    frm.txtBono.Enabled = false;
                    frm.btnComfirmar.Enabled = false;
                    break;
            }
        }

        public void limpiar()
        {
            frm.txtBono.Text = "0";
            frm.txtDespensa.Text = "0";
            frm.txtDeuda.Text = "0";
            frm.txtSalario.Text = "0";
            frm.txtSueldoTotal.Text = "0";
        }
    }
}
