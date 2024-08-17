/*en esta clase se registran, actualizan y eliminan todos los tipos de empleados*/
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
    class cls_CEmpleados
    {
        frmEmpleados frm = new frmEmpleados();
        cls_EmpleadosDAO mtd = new cls_EmpleadosDAO();
        cls_EmpleadosVO dts = new cls_EmpleadosVO();
        Cls_Validaciones validar = new Cls_Validaciones();


        int op,idruta;
        int id;
        int dato;
        float salario;
        DialogResult respuesta;

        /*
         op es el tip de usuario seleccionado
         * idruta es el id de la ruta selaccionada del combo
         * dato es el id de resgistro de la tabla empleados
         * id es el id del empleado a actualizar
         * salario es el salario del empleado a registrar
         * respuesta es para realizar un mensaje con respuesta
         */

        public void frm_load()
        {
            
            frm.btnCancelar.Click += btnCancelar_Click;
            frm.btnEliminar.Click += btnEliminar_Click;
            frm.btnGuardar.Click += btnGuardar_Click;
            frm.btnModificar.Click += btnModificar_Click;
            frm.btnNuevo.Click += btnNuevo_Click;
            frm.btnSalir.Click += btnSalir_Click;
            frm.btnAceptar.Click += btnAceptar_Click;
            frm.tblEmpleados.CellClick += tblEmpleados_CellClick;
            frm.txtAm.KeyPress += txtAm_KeyPress;
            frm.txtAp.KeyPress += txtAp_KeyPress;
            frm.txtNombre.KeyPress += txtNombre_KeyPress;
            frm.txtCurp.KeyPress += txtCurp_KeyPress;
            frm.txtSalario.KeyPress += txtSalario_KeyPress;
            frm.txtDomicilio.KeyPress += txtDomicilio_KeyPress;
            frm.txtUser.KeyPress += txtUser_KeyPress;
            frm.txtPwd.KeyPress += txtPwd_KeyPress;
            cargaruta();
            cargaCombo();
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }

        void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras_numeros(e);
        }

        void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras_numeros(e);
        }

        void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras_numeros(e);
        }

        void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtSalario.Text,e);
        }

        void txtCurp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(frm.txtCurp.Text.Count() >= 16))
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && frm.txtCurp.Text.Count() < 4)
                {
                    MessageBox.Show("EJEMPLO DE CURP: MOSA991201HHGNLR08");
                    e.Handled = true;
                }
                else if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && frm.txtCurp.Text.Count() >= 4 && frm.txtCurp.Text.Count() < 10)
                {
                    MessageBox.Show("EJEMPLO DE CURP: MOSA991201HHGNLR08");
                    e.Handled = true;
                }
                else if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && frm.txtCurp.Text.Count() >= 10 && frm.txtCurp.Text.Count() <= 18)
                {
                    MessageBox.Show("EJEMPLO DE CURP: MOSA991201HHGNLR08");
                    e.Handled = true;
                }
                else if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && frm.txtCurp.Text.Count() >= 16)
                {
                    MessageBox.Show("EJEMPLO DE CURP: MOSA991201HHGNLR08");
                    e.Handled = true;
                }
            }
   
            return;
        }

        void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras(e);
        }

        void txtAp_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras(e);
        }

        void txtAm_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras(e);
        }

        void btnAceptar_Click(object sender, EventArgs e)
        {
            frm.btnNuevo.Enabled = true;
            cajasIgualesFalse();
            frm.txtSalario.Enabled = false;
            frm.txtPwd.Enabled = false;
            frm.txtUser.Enabled = false;
            frm.cmbRuta.Enabled = false;


            botenes(2);
            limpiar();

            frm.tblEmpleados.DataSource = null;
            op=Convert.ToInt32(frm.cmbTipo.SelectedValue.ToString());
            
            if (op == 1)
            {
                //carga administradores
                cargaAdmin();
            }
            else if (op == 2)
            {
                //carga supervisor
                cargaSupervisor();
            }
            else if(op==3)
            {
                //carga produccion
                cargaProduccion();
            }else if(op==4)
            {
                //carga vendedor
                cargaVendedor();
            }else if(op==5)
            {
                //carga ayudante
                cargaAyudante();
            }
            else if (op == 6)
            {
                //carga velador
                cargaVelador();
            }
            else if (op == 7)
            {
                //carga admin sucursal
                cargaAdminSucursal();
            }
            frm.tblEmpleados.Columns[0].Visible = false;
        }
        public void cargaAdminSucursal()
        {
            try
            {
                frm.tblEmpleados.DataSource = mtd.mtdLLenaTablaAdminSucursal();
                frm.tblEmpleados.Columns[6].Visible = false;
                frm.tblEmpleados.Columns[8].Visible = false;
            }
            catch
            {

            }
        }

        public void cargaAdmin()
        {
            try
            {
                frm.tblEmpleados.DataSource = mtd.mtdLLenaTablaAdmin();
                frm.tblEmpleados.Columns[6].Visible = false;
                frm.tblEmpleados.Columns[8].Visible = false;
            }
            catch
            {

            }
            
        }
        public void cargaEmpleados()
        {
            try
            {
                frm.tblEmpleados.DataSource = mtd.mtdLLenaTablaEmpleado();
                frm.tblEmpleados.Columns[6].Visible = false;
                frm.tblEmpleados.Columns[8].Visible = false;
            }
            catch
            {

            }
            
        }
        public void cargaVelador()
        {
            try
            {
                frm.tblEmpleados.DataSource = mtd.mtdLLenaTablaVelador();
                frm.tblEmpleados.Columns[6].Visible = false;
                frm.tblEmpleados.Columns[8].Visible = false;
            }
            catch
            {

            }
        }
        public void cargaAyudante()
        {
            try
            {
                frm.tblEmpleados.DataSource = mtd.mtdLLenaTablaAyudante();
                frm.tblEmpleados.Columns[6].Visible = false;
                frm.tblEmpleados.Columns[8].Visible = false;
            }
            catch
            {

            }
        }
        public void cargaProduccion()
        {
            try
            {
                frm.tblEmpleados.DataSource = mtd.mtdLLenaTablaProduccion();
                frm.tblEmpleados.Columns[6].Visible = false;
                frm.tblEmpleados.Columns[8].Visible = false;
            }
            catch
            {

            }
        }

        public void cargaSupervisor()
        {
            try
            {
                frm.tblEmpleados.DataSource = mtd.mtdLLenaTablaSupervisor();
                frm.tblEmpleados.Columns[6].Visible = false;
                frm.tblEmpleados.Columns[8].Visible = false;
            }
            catch
            {

            }
        }

        public void cargaVendedor()
        {
            try
            {
                frm.tblEmpleados.DataSource = mtd.mtdLLenaTablaVendedor();
                frm.tblEmpleados.Columns[6].Visible = false;
                frm.tblEmpleados.Columns[7].Visible = false;
                frm.tblEmpleados.Columns[8].Visible = false;
                
            }
            catch
            {

            }
            
        }

        public void iguales()
        {
            try
            {
                dato = Convert.ToInt32(frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[0].Value.ToString());
                frm.txtNombre.Text = frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[1].Value.ToString();
                frm.txtAp.Text = frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[2].Value.ToString();
                frm.txtAm.Text = frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[3].Value.ToString();
                frm.txtCurp.Text = frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[4].Value.ToString();
                frm.txtDomicilio.Text = frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[5].Value.ToString();
                
                botenes(1);
                cajas(1);
                
            }
            catch
            {

            }
            
        }

        void tblEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[0].Value);
                if (op == 1 || op==7)
                {
                    //carga administradores
                    iguales();
                    frm.txtUser.Text = frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[9].Value.ToString();
                    frm.txtPwd.Text = frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[10].Value.ToString();

                }
                else if (op == 2)
                {
                    //carga empleados
                    iguales();
                    frm.txtSalario.Text = frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[9].Value.ToString();
                }
                else if (op == 3)
                {
                    //carga empleados
                    iguales();
                    frm.txtSalario.Text = frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[9].Value.ToString();
                }
                else if (op == 4)
                {
                    //frm.cmbRuta.SelectedIndex = Convert.ToInt32(frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[8].Value.ToString()) - 1;
                    iguales();
                }
                else if (op == 5)
                {
                    //carga empleados
                    iguales();
                    frm.txtSalario.Text = frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[9].Value.ToString();
                }else if(op==6)
                {
                    //carga empleados
                    iguales();
                    frm.txtSalario.Text = frm.tblEmpleados.Rows[frm.tblEmpleados.CurrentRow.Index].Cells[9].Value.ToString();
                }
                botenes(3);
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
            cajas(1);
            botenes(1);
        }

        void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (op == 1 || op==7)
                {
                    //carga administradores
                    if (frm.txtAm.Text == "" || frm.txtAp.Text == "" || frm.txtCurp.Text == "" || frm.txtDomicilio.Text == "" || frm.txtNombre.Text == "" || frm.txtUser.Text == "" || frm.txtPwd.Text == "")
                    {
                        MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(validar.mtd_mensaje()==1)
                        {
                            enviar();
                            dts.setIdDato(dato);
                            dts.setUser(frm.txtUser.Text);
                            dts.setPwd(frm.txtPwd.Text);
                            mtd.mtdEditarAdmin(dts);
                            frm.tblEmpleados.DataSource = null;
                            MessageBox.Show("Se edito con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frm.txtPwd.Enabled = false;
                            frm.txtUser.Enabled = false;
                            accionExitosa();
                        }
                        
                    }
                    
                }
                else if (op == 4)
                {
                    //carga vendedores
                    //idruta = Convert.ToInt32(frm.cmbRuta.SelectedValue.ToString());
                    //dts.setIdRuta(idruta);
                    //enviar();
                    if (frm.txtAm.Text == "" || frm.txtAp.Text == "" || frm.txtCurp.Text == "" || frm.txtDomicilio.Text == "" || frm.txtNombre.Text == "")
                    {
                        MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(validar.mtd_mensaje()==1)
                        {
                            dts.setIdDato(dato);
                            dts.setIdRuta(Convert.ToInt32(frm.cmbRuta.SelectedValue.ToString()));
                            enviar();
                            mtd.mtdEditarVendedor(dts);
                            MessageBox.Show("Se edito con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frm.cmbRuta.Enabled = false;
                            accionExitosa();
                        }
                        
                    }
                    
                }
                else
                {
                    //carga empleados
                    if (frm.txtAm.Text == "" || frm.txtAp.Text == "" || frm.txtCurp.Text == "" || frm.txtDomicilio.Text == "" || frm.txtNombre.Text == "" || frm.txtSalario.Text == "")
                    {
                        MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //modificar

                        salario = float.Parse(frm.txtSalario.Text);
                        if (salario <= 0)
                        {
                            MessageBox.Show("El salario no puede ser menor ó igual a 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if(validar.mtd_mensaje()==1)
                            {
                                enviar();
                                dts.setIdDato(dato);
                                dts.setSalario(float.Parse(frm.txtSalario.Text));
                                mtd.mtdEditarEmpleado(dts);
                                cargaEmpleados();
                                MessageBox.Show("Se edito con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frm.txtSalario.Enabled = false;
                                accionExitosa();
                            }
                            
                        }
                        
                    }
                }
               

            }
            catch
            {
                MessageBox.Show("Se produjo un error...! al intentar editar :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void accionExitosa()//este metodo solo se ejecuta cuando todo esta bien y procede a realizar lo sigueinte
        {
            cajasIgualesFalse();
            botenes(4);
            frm.tblEmpleados.DataSource = null;
            limpiar();
        }

        void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (op==1 ||op==7)
                {
                    if (frm.txtAm.Text == "" || frm.txtAp.Text == "" || frm.txtCurp.Text == "" || frm.txtDomicilio.Text == "" || frm.txtNombre.Text == "" || frm.txtUser.Text == "" || frm.txtPwd.Text == "")
                    {
                        MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(validar.mtd_mensaje()==1)
                        {
                            enviar();
                            dts.setUser(frm.txtUser.Text);
                            dts.setPwd(frm.txtPwd.Text);
                            mtd.mtdInsertarAdmin(dts);
                            //cargaAdmin();
                            MessageBox.Show("Se guardo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frm.txtPwd.Enabled = false;
                            frm.txtUser.Enabled = false;
                            accionExitosa();
                        }
                        
                    }
                    

                }
                else if (op==4)
                {
                    if (frm.txtAm.Text == "" || frm.txtAp.Text == "" || frm.txtCurp.Text == "" || frm.txtDomicilio.Text == "" || frm.txtNombre.Text == "")
                    {
                        MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (validar.mtd_mensaje() == 1)
                        {
                            idruta = Convert.ToInt32(frm.cmbRuta.SelectedValue.ToString());
                            dts.setIdRuta(idruta);
                            enviar();
                            mtd.mtdInsertarVendedor(dts);
                            cargaVendedor();
                            MessageBox.Show("Se guardo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frm.cmbRuta.Enabled = false;
                            accionExitosa();
                        }
                        
                    }
                    
                }
                else
                {
                    if (frm.txtAm.Text == "" || frm.txtAp.Text == "" || frm.txtCurp.Text == "" || frm.txtDomicilio.Text == "" || frm.txtNombre.Text == "" || frm.txtSalario.Text == "")
                    {
                        MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        salario = float.Parse(frm.txtSalario.Text);
                        if (salario <= 0)
                        {
                            MessageBox.Show("El salario no puede ser menor ó igual a 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if(validar.mtd_mensaje()==1)
                            {
                                enviar();
                                dts.setSalario(float.Parse(frm.txtSalario.Text));
                                mtd.mtdInsertar(dts);
                                cargaEmpleados();
                                MessageBox.Show("Se guardo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frm.txtSalario.Enabled = false;
                                accionExitosa();
                            }
                            
                        }
                       
                    }
                   
                }

            }
            catch
            {
                MessageBox.Show("Se produjo en error al intentar editar :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                       
        }

        public void enviar()
        {
            dts.setAm(frm.txtAm.Text);
            dts.setAp(frm.txtAp.Text);
            dts.setCurp(frm.txtCurp.Text);
            dts.setDomicilio(frm.txtDomicilio.Text);
            dts.setIdTipo(Convert.ToInt32(frm.cmbTipo.SelectedValue.ToString()));
            dts.setNombre(frm.txtNombre.Text);
        }

        void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(validar.mtd_mensaje()==1)
                {
                    dts.setIdDato(dato);
                    mtd.mtdEliminarEmpleado(dts);
                    cargaEmpleados();
                    MessageBox.Show("Se elimino con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cajasIgualesFalse();
                    botenes(4);
                    frm.txtSalario.Enabled = false;
                    frm.tblEmpleados.DataSource = null;
                    limpiar();   
                }
                if(op==1)
                {
                    frm.txtUser.Enabled = false;
                    frm.txtPwd.Enabled = false;
                }
                else if (op == 4)
                {
                    frm.cmbRuta.Enabled = false;
                }
                else
                {
                    frm.txtSalario.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Verifique su conexion :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            respuesta = MessageBox.Show("Cancelar acción???","Responda a la pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                limpiar();
                frm.tblEmpleados.DataSource = null;
                cajasIgualesFalse();
                botenes(2);
                frm.btnNuevo.Enabled = false;
                frm.cmbRuta.Enabled = false;
                frm.txtUser.Enabled = false;
                frm.txtPwd.Enabled = false;
                frm.txtSalario.Enabled = false;
                MessageBox.Show("Acción Cancelada :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    
            
        }

      
        public void cargaCombo()
        {
            frm.cmbTipo.DataSource = mtd.mtdLLenarCombo();
            frm.cmbTipo.DisplayMember = "vchTipo";
            frm.cmbTipo.ValueMember = "intIdTipoUserPK";
        }
        public void cargaruta()
        {
            frm.cmbRuta.DataSource = mtd.mtdllenaRuta();
            frm.cmbRuta.DisplayMember = "vchNombre";
            frm.cmbRuta.ValueMember = "intIdRutaPK";
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
                case 4:
                    frm.btnNuevo.Enabled = false;
                    frm.btnGuardar.Enabled = false;
                    frm.btnModificar.Enabled = false;
                    frm.btnEliminar.Enabled = false;
                    frm.btnCancelar.Enabled = false;
                    break;
            }

        }
        public void cajasIgualesTrue()
        {
            frm.txtNombre.Focus();
            frm.txtNombre.Enabled = true;
            frm.txtAm.Enabled = true;
            frm.txtAp.Enabled = true;
            frm.txtCurp.Enabled = true;
            frm.txtDomicilio.Enabled = true;
        }
        public void cajasIgualesFalse()
        {
            frm.txtNombre.Enabled = false;
            frm.txtAm.Enabled = false;
            frm.txtAp.Enabled = false;
            frm.txtCurp.Enabled = false;
            frm.txtDomicilio.Enabled = false;
        }
        public void cajas(int opc)
        {
            switch (opc)
            {
                case 1:
                    cajasIgualesTrue();
                    break;
                case 2:
                    cajasIgualesFalse();
                    break;
            }

            if (op == 1 || op==7)
            {
                //carga administradores
                frm.txtUser.Enabled = true;
                frm.txtPwd.Enabled = true;
                frm.txtSalario.Enabled = false;
                frm.cmbRuta.Enabled = false;

            }
            else if (op == 4)
            {
                //carga vendedores
                frm.cmbRuta.Enabled = true;
                frm.txtUser.Enabled = false;
                frm.txtPwd.Enabled = false;
                frm.txtSalario.Enabled = false;
            }
            else
            {
                //carga empleados
                frm.txtSalario.Enabled = true;
                frm.cmbRuta.Enabled = false;
                frm.txtUser.Enabled = false;
                frm.txtPwd.Enabled = false;
            }

        }
        public void limpiar()
        {
            frm.txtNombre.Clear();
            frm.txtAm.Clear();
            frm.txtAp.Clear();
            frm.txtCurp.Clear();
            frm.txtDomicilio.Clear();
            frm.txtPwd.Clear();
            frm.txtSalario.Clear();
            frm.txtUser.Clear();
        }
    }
}
