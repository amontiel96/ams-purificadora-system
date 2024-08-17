/*en esta clase se registran los prestamos de botellones a los clientes*/
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
    class cls_CPrestamosBote
    {
        frmPrestamos frm = new frmPrestamos();
        cls_PrestamosDAO mtd = new cls_PrestamosDAO();
        cls_PrestamosVO dts = new cls_PrestamosVO();
        Cls_Validaciones validar = new Cls_Validaciones();

        int idprestamo,idcliente=0,existe,opc,d,m,a,op=0,nuevo;
        string fecha;

        /*
         idprestamo es el id de un registro ya existente
         * idcliente es el id del cliente al q se le ara el prestamo
         * existe es la cantidad de unidades q tiene prestadas un cliente
         * opc es solo un auxilir para verificar q accion se realizara, si va ser guardar o modificar
         * d-m-a es para obtener la fecha
         * op es solo un auxilar para definir cuando se hace una consulta a clientes
         * nuevo es la cantidad de unidades a actualizar
         */

        public void frm_load()
        {
            frm.txtPrestar.KeyPress += txtPrestar_KeyPress;
            frm.txtRegresar.KeyPress += txtRegresar_KeyPress;
            frm.btnAceptar.Click += btnAceptar_Click;
            frm.btnContinuar.Click += btnContinuar_Click;
            frm.btnRegistrar.Click += btnRegistrar_Click;
            frm.tblClientes.CellClick += tblClientes_CellClick;
            frm.cmbVendedor.TextChanged += cmbVendedor_TextChanged;
            cargaruta();
            frm.btnRegistrar.Enabled = false;
            Application.EnableVisualStyles();//esta funcion aplica los estilos alos controles del formulario
            frm.ShowDialog();
        }

        void cmbVendedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                frm.tblClientes.DataSource = null;
                frm.tblPrestamos.DataSource = null;
                limpiar();
                cajas(2);
                botenes(4);
                cargaClientes();
            }
            catch
            {

            }
        }


        void tblClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idcliente = Convert.ToInt32(frm.tblClientes.Rows[frm.tblClientes.CurrentRow.Index].Cells[0].Value.ToString());
                frm.tblPrestamos.DataSource = null;
                botenes(1);
                cajas(2);
                limpiar();
                llenatablaPrestamos();
            }
            catch
            {

            }
        }

        public void llenatablaPrestamos()
        {
            try
            {
                    limpiar();//primero limpiamos todo para que empiece desde cero todo
                    cajas(2);
                    botenes(2);
                    dts.setIdCliente(idcliente);
                    frm.tblPrestamos.DataSource = mtd.mtdllenarPrestamos(dts);
                    frm.tblPrestamos.Columns[0].Visible = false;
                    frm.tblPrestamos.Columns[1].Visible = false;
                    if (!(frm.tblPrestamos.Rows.Count >= 1))//preguntamos si hay registros en la tabla
                    {
                        MessageBox.Show("No hay registros para este Cliente :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cajas(3);
                        opc = 1;//si no hay registros
                        existe = 0;
                        //op = 1;
                        //frm.btnContinuar.Enabled = false;
                    }
                    else
                    {
                        idprestamo = Convert.ToInt32(frm.tblPrestamos.Rows[0].Cells[0].Value.ToString());
                        cajas(1);
                        opc = 2;//si hay registros
                        existe = Convert.ToInt32(frm.tblPrestamos.Rows[0].Cells[2].Value.ToString());
                        //frm.btnContinuar.Enabled = true;
                    }
                    botenes(3);
            }
            catch
            {

            }

        }

        public void enviar()
        {
            d = frm.dtFecha.Value.Day;
            m = frm.dtFecha.Value.Month;
            a = frm.dtFecha.Value.Year;
            fecha = a + "-" + m + "-" + d;
            dts.setFecha(fecha);
        }

        public void validarRegistro()/*este metodo primero verificar q accion se realizar y la ejecuta*/
        {
            try
            {
                if(opc==1)//si no hay registros en la tabla pretamos para el cleinte seleccionado
                {
                    if (frm.txtPrestar.Text == "" || frm.txtRegresar.Text == "")
                    {
                        MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Convert.ToInt32(frm.txtPrestar.Text) <= 0)
                        {
                            MessageBox.Show("Ingrese una cantidad mayor a 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (validar.mtd_mensaje() == 1)
                            {
                                //guardar
                                enviar();//fecha
                                dts.setIdVendedor(Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString()));
                                dts.setIdCliente(idcliente);
                                dts.setPresta(Convert.ToInt32(frm.txtPrestar.Text));
                                mtd.mtdInsertar(dts);
                                MessageBox.Show("Resgistro exitoso :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                llenatablaPrestamos();
                            }

                        }
                    }
                }//si ya hay registros
                else if (opc == 2)
                {
                    if (frm.txtPrestar.Text == "" || frm.txtRegresar.Text == "")
                    {
                        MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Convert.ToInt32(frm.txtPrestar.Text) <= 0 && Convert.ToInt32(frm.txtRegresar.Text) <= 0)
                        {
                            MessageBox.Show("Almenos una cantidad tiene que ser mayor a 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (existe < Convert.ToInt32(frm.txtRegresar.Text))
                            {
                                MessageBox.Show("No puede regresar mas de lo que tiene prestado :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if(validar.mtd_mensaje()==1)
                                {
                                    //modificar existente
                                    nuevo = (existe + Convert.ToInt32(frm.txtPrestar.Text)) - Convert.ToInt32(frm.txtRegresar.Text);
                                    enviar();
                                    dts.setQuitar(Convert.ToInt32(frm.txtPrestar.Text));
                                    dts.setRegresa(Convert.ToInt32(frm.txtRegresar.Text));
                                    dts.setPendiente(nuevo);
                                    dts.setIdPrestamo(idprestamo);
                                    mtd.mtdActualizar(dts);
                                    MessageBox.Show("Resgistro exitoso :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    llenatablaPrestamos();
                                }
                            }
                        }
                    }
                }

            }catch{
                MessageBox.Show("Se produjo un error inseperado :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void botenes(int op)
        {
            switch (op)
            {
                case 1://cuando selecciono un cliente
                    frm.btnContinuar.Enabled = true;
                    frm.btnRegistrar.Enabled = false;
                    break;
                case 2://cuando no hay clientes
                    frm.btnContinuar.Enabled = false;
                    break;
                case 3://si hay registros enla tabla prestamos
                    frm.btnRegistrar.Enabled = true;
                    break;
                case 4:
                    frm.btnRegistrar.Enabled = false;
                    frm.btnContinuar.Enabled = false;
                    break;
                    
            }
        }

        void btnRegistrar_Click(object sender, EventArgs e)
        {
            validarRegistro();
        }

        void btnContinuar_Click(object sender, EventArgs e)
        {
            llenatablaPrestamos();
        }

        void btnAceptar_Click(object sender, EventArgs e)
        {
            cargaClientes();
        }

        void txtRegresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void txtPrestar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        public void cargaClientes()
        {
            try
            {
                if(!(op==0))
                {
                    dts.setIdVendedor(Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString()));
                    frm.tblClientes.DataSource = mtd.mtdllenarClientes(dts);
                    frm.tblClientes.Columns[0].Visible = false;
                    if (!(frm.tblClientes.Rows.Count >= 1))
                    {
                        MessageBox.Show("Este vendedor no tiene clientes :)", "Aviso...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm.tblClientes.DataSource = null;
                        frm.tblPrestamos.DataSource = null;
                        cajas(2);
                        botenes(2);
                        limpiar();
                        
                    }
                }
                op = 1;
                
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(", "Alerta...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public void cajas(int op)
        {
            switch(op)
            {
                case 1:
                    frm.txtPrestar.Enabled = true;
                    frm.txtRegresar.Enabled = true;
                    break;
                case 2:
                    frm.txtRegresar.Enabled = false;
                    frm.txtPrestar.Enabled = false;
                    break;
                case 3://si no hay registros en la tabla prestamos
                    frm.txtPrestar.Enabled = true;
                    frm.txtRegresar.Enabled = false;
                    break;
            }
        }

        public void limpiar()
        {
            frm.txtRegresar.Text = "0";
            frm.txtPrestar.Text = "0";
        }
       
    }
}
