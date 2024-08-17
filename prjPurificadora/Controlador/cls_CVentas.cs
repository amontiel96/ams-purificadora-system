/*en esta clase se registran las ventas realizadas*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Vista;
using System.Windows.Forms;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Modelo.Conexion;
using System.Threading.Tasks;

namespace prjPurificadora.Controlador
{
    class cls_CVentas
    {
        frmVentas frm = new frmVentas();
        cls_VentasDAO mtd = new cls_VentasDAO();
        cls_VentasVO dts = new cls_VentasVO();
        Cls_Validaciones validar = new Cls_Validaciones();

        

         int idvendedor,idcliente=0,n,m1,m2;

         float acutotal = 0, p1, p2, p3,t1,t2,t3,acudebes=0,debe,deposito,actual=0,nuevaDeuda,debes;
         bool existe=false;
         int d, m, a;
         string fecha,tipoCliente;
         int b, b1, b2,boni,existeBote,existeSello,existeTapon,aux=0,cantiVender;
         bool si;

        /*
         * idvendedor es el id del vendedor seleccionado del combo
         * idcliente es el id del cliente seleccionado
         * n es la cantidad de unidades al precion normal
         * m1 es la cantidad de unidades al precio mayoreo1
         * m2 es la cantidad de unidades al precio mayoreo2
         * acutotal es el total a depositar de la venta
         * p1 es el precio normal
         * p2 es el precio mayoreo1
         * p2 es el precio mayoreo2
         * t1 es el total vendido al precio norma
         * t2 es el total vendido al precio mayoreo1
         * t3 es el total vendido al precio mayoreo2
         * acudebes es la canidad q se debe de la venta
         * debe representa cuando va a quedar a deber un cliente
         * deposito es lo q va a depositar de la venta
         * actual es lo q se debe ne general de las ventas registradas
         * nuevaDeuda es la suma de actual + debes
         * existe es para verificar si exite alguna deuda
         * d-m-a son para obtener la fecha
         * b son unidades precio normal ya registradas
         * b1 son unidades precio maoreo1 ya registradas
         * b2 son unidades precio mayoreo2 ya registradas
         * boni son unidades bonificadas ya registradas
         * existencia son las unidades q existen en el almacen para q no se puedan vender mas de lo q hay en existencia
         * cantiVender es la suma total de las unidades a vender
         * si es para verificar si la venta es a un cliente o no
         */

        public void frm_load()
        {
            frm.rbtSi.Click += rbtSi_Click;
            frm.rbtNo.Click += rbtNo_Click;
            frm.tblClientes.Visible = false;
            frm.btnAceptar.Click +=btnAceptar_Click;
            frm.btnAgregar.Click += btnAgregar_Click;
            frm.btnRegistrar.Click += btnRegistrar_Click;
            frm.tblClientes.CellClick += tblClientes_CellClick;
            frm.txtNormal.TextChanged += txtNormal_TextChanged;
            frm.txtMayoreo2.TextChanged += txtMayoreo2_TextChanged;
            frm.txtMayoreo1.TextChanged += txtMayoreo1_TextChanged;
            frm.txtDeposito.TextChanged += txtDeposito_TextChanged;
            frm.txtBonificados.TextChanged += txtBonificados_TextChanged;
            frm.txtPreNormal.TextChanged += txtPreNormal_TextChanged;
            frm.txtPreM1.TextChanged += txtPreM1_TextChanged;
            frm.txtPreM2.TextChanged += txtPreM2_TextChanged;
            frm.txtBonificados.KeyPress += txtBonificados_KeyPress;
            frm.txtMayoreo1.KeyPress += txtMayoreo1_KeyPress;
            frm.txtMayoreo2.KeyPress += txtMayoreo2_KeyPress;
            frm.txtDeposito.KeyPress += txtDeposito_KeyPress;
            frm.txtNormal.KeyPress += txtNormal_KeyPress;
            frm.txtPreM1.KeyPress += txtPreM1_KeyPress;
            frm.txtPreM2.KeyPress += txtPreM2_KeyPress;
            frm.txtPreNormal.KeyPress += txtPreNormal_KeyPress;
            frm.tblAgregar.Columns[0].Visible = false;
            frm.tblAgregar.Columns[1].Visible = false;
            frm.tblAgregar.Columns[3].Visible = false;
            frm.tblAgregar.Columns[5].Visible = false;
            frm.tblAgregar.Columns[7].Visible = false;
            frm.tblAgregar.Columns[10].Visible = false;
            frm.tblAgregar.Columns[13].Visible = false;
            frm.cmbVendedor.TextChanged += cmbVendedor_TextChanged;
            llenarExistencia();
            llenarprecios();
            nombreCeldas();
            Application.EnableVisualStyles();
            llenarVendedor();
            frm.ShowDialog();
        }

        void cmbVendedor_TextChanged(object sender, EventArgs e)
        {
            limpiar();
            frm.txtBonificados.Enabled = false;
            frm.txtDeposito.Enabled = false;
            frm.txtMayoreo1.Enabled = false;
            frm.txtMayoreo2.Enabled = false;
            frm.txtNormal.Enabled = false;
            frm.txtPreM1.Enabled = false;
            frm.txtPreM2.Enabled = false;
            frm.txtPreNormal.Enabled = false;
            frm.tblClientes.DataSource = null;
            frm.tblClientes.Visible = false;
            frm.tblClientes.Enabled = false;
            idcliente = 0;
            si = false;
            frm.rbtNo.Checked = true;
            frm.rbtNo.Enabled = false;
            frm.rbtSi.Enabled = false;
        }

        void txtPreNormal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtPreNormal.Text,e);
        }

        void txtPreM2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtPreM2.Text,e);
        }

        void txtPreM1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtPreM1.Text,e);
        }

        void txtPreM2_TextChanged(object sender, EventArgs e)/*por si se modifica el precio mayoreo2 se tiene q ir calculando nuevamente el subtotal*/
        {
            try
            {
                p3 = float.Parse(frm.txtPreM2.Text);
            }
            catch
            {
                p3 = 0;
            }
            calSubtotal();
        }

        void txtPreM1_TextChanged(object sender, EventArgs e)/*por si se modifica el precio mayoreo1 se tiene q ir calculando nuevamente el subtotal*/
        {
            try
            {
                p2 = float.Parse(frm.txtPreM1.Text);
            }
            catch
            {
                p2 = 0;
            }
            calSubtotal();
        }

        void txtPreNormal_TextChanged(object sender, EventArgs e)/*por si se modifica el precio normal se tiene q ir calculando nuevamente el subtotal*/
        {
            try
            {
                p1 = float.Parse(frm.txtPreNormal.Text);
            }
            catch
            {
                p1 = 0;
            }
            calSubtotal();
        }

        void txtDeposito_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtDeposito.Text,e);
        }

        void txtBonificados_TextChanged(object sender, EventArgs e)/*es para q se vaya calculando cada ves q se modifiq la cantidad de bonificados*/
        {
            try
            {
                boni = int.Parse(frm.txtBonificados.Text);
            }catch{
                
                }
            calSubtotal();

        }

        void txtNormal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void txtMayoreo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void txtMayoreo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void txtBonificados_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void txtDeposito_TextChanged(object sender, EventArgs e)/*es para determinar cuanto deposito el vendedor de las ventas realizadas*/
        {
            try
            {
                deposito = float.Parse(frm.txtDeposito.Text);
                if(deposito<0)
                {
                    deposito = 0;
                    frm.txtDeposito.Text = "";
                }else if(deposito>float.Parse(frm.txtSubtotal.Text))
                {
                    MessageBox.Show("No puedes depositar mas de lo que se debe :)","Aviso...!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frm.lblDeuda.Text = "0";
                    frm.txtDeposito.Focus();
                }
            }
            catch
            {
                deposito = 0;
                frm.txtDeposito.Text = "";
            }
            calDeuda();
        }

        void txtMayoreo1_TextChanged(object sender, EventArgs e)/*es para indicar la cantidad de unidades de precio mayoreo1*/
        {
            try
            {
                m1 = int.Parse(frm.txtMayoreo1.Text);
            }
            catch
            {
                m1 = 0;
                
            }
            calSubtotal();
        }

        void txtMayoreo2_TextChanged(object sender, EventArgs e)/*es para indicar la cantidad de unidades de precio mayoreo2*/
        {
            try
            {
                m2 = int.Parse(frm.txtMayoreo2.Text);
            }
            catch
            {
                m2 = 0;
                
            }
            calSubtotal();
        }
        void txtNormal_TextChanged(object sender, EventArgs e)/*es para indicar la cantidad de unidades de precio normal*/
        {
            try
            {
                n = int.Parse(frm.txtNormal.Text);
            }catch
            {
                n = 0;
             
            }
            calSubtotal();
        }
        void tblClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idcliente = Convert.ToInt32(frm.tblClientes.Rows[frm.tblClientes.CurrentRow.Index].Cells[0].Value);
                tipoCliente = frm.tblClientes.Rows[frm.tblClientes.CurrentRow.Index].Cells[2].Value.ToString();
                
            }
            catch
            {

            }
            
        }
        void btnRegistrar_Click(object sender, EventArgs e)
        {
            comfirmarVenta();
        }
        public void verificado()/*este metodo se ejecuta cuando ya todo esta verifiado q ya esta bien antes de agregar a la tabla detalles*/
        {
            obtenerFecha();
            tempo = float.Parse(frm.txtDeposito.Text) - float.Parse(frm.txtSubtotal.Text);
            if(frm.rbtNo.Checked==true)
            {
                tipoCliente = "No cliente";
            }
            frm.tblAgregar.Rows.Add(frm.cmbVendedor.SelectedValue.ToString(), idcliente, frm.txtNormal.Text, p1, frm.txtMayoreo1.Text, p2, frm.txtMayoreo2.Text, p3, frm.txtSubtotal.Text, frm.lblDebes.Text, fecha, frm.txtBonificados.Text, int.Parse(frm.txtNormal.Text) + int.Parse(frm.txtMayoreo1.Text) + int.Parse(frm.txtMayoreo2.Text) + int.Parse(frm.txtBonificados.Text),tipoCliente);
            calcular();
            cajas(2);
            limpiar();
            frm.btnRegistrar.Enabled = true;
            frm.tblClientes.DataSource = null;
            frm.tblClientes.Visible = false;
            idcliente = 0;
        }
        float tempo;
        DialogResult respuesta;
        void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                /*primero se va verificando q todo esta bien antes de enviar los datos a la base de datos*/
                if (deposito > float.Parse(frm.txtSubtotal.Text))
                {
                    MessageBox.Show("nose puede depositar mas de lo que debe","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if (frm.txtBonificados.Text == "" || frm.txtMayoreo1.Text == "" || frm.txtMayoreo2.Text == "" || frm.txtNormal.Text == "")
                    {
                        MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (frm.txtBonificados.Text == "0" && frm.txtMayoreo1.Text == "0" && frm.txtMayoreo2.Text == "0" && frm.txtNormal.Text == "0")
                    {
                        MessageBox.Show("Por lo menos un valor tiene que ser mayor a 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (frm.txtDeposito.Text == "")
                        {
                            MessageBox.Show("Tiene que ingresar cuanto deposito de esa venta :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (si == true)
                            {

                                if (idcliente == 0)
                                {
                                    MessageBox.Show("Selecciona un cliente ó desmarca la opción si no es cliente :)", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    if (frm.txtDeposito.Text == "")
                                    {
                                        MessageBox.Show("Tiene que ingresar cuanto se deposito de esa venta :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        if (!(frm.lblDebes.Text == "0"))
                                        {
                                            debe = float.Parse(frm.lblDebes.Text);
                                            respuesta = MessageBox.Show("Se agregara a deudas", "Responda la pregunta......?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            if (respuesta == DialogResult.Yes)
                                            {
                                                verificado();
                                            }
                                        }
                                        else
                                        {
                                            verificado();
                                        }
                                    }

                                }
                            }
                            else
                            {
                                if (float.Parse(frm.txtDeposito.Text) < float.Parse(frm.txtSubtotal.Text))
                                {
                                    MessageBox.Show("No puede quedar a deber almenos que sea cliente", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    verificado();
                                }

                            }
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error al registar agregar a la venta :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cls_conexion.Instancia().desconectar();
            }
            
        }
        public void calSubtotal()/*este metodo va calculando el subtotal de las ventas ingresadas*/
        {
            try
            {
                t1 = p1 * n;
                t2 = p2 * m1;
                t3 = p3 * m2;
                cantiVender = n + m1 + m2 + boni;
                frm.txtSubtotal.Text = (t1 + t2 + t3).ToString();
                frm.lblDebes.Text = (t1 + t2 + t3).ToString();
                if (cantiVender > existeBote)
                {
                    MessageBox.Show("Nose puede vender mas de lo que tiene en el almacen :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inhabilitar();
                    limpiar();
                }
                else
                {
                    if (frm.txtSubtotal.Text == "0")
                    {
                        inhabilitar();
                        if ((frm.txtBonificados.Text == "" || frm.txtBonificados.Text == "0"))
                        {
                            inhabilitar();
                        }
                        else
                        {
                            habilitar();
                        }
                    }
                    else
                    {
                        habilitar();
                    }
                }
                
            }catch{}
            
           
        }
        public void habilitar()
        {
            frm.txtDeposito.Enabled = true;
            frm.btnAgregar.Enabled = true;
        }
        public void inhabilitar()
        {
            frm.txtDeposito.Text = "0";
            frm.lblDebes.Text = "0";
            frm.txtDeposito.Enabled = false;
            frm.btnAgregar.Enabled = false;
        }
        public void calDeuda()/*indica cuando es la deuda en general de las deudas*/
        {
            
                try
                {
                    frm.lblDebes.Text = (float.Parse(frm.txtSubtotal.Text)-deposito).ToString();
                    acutotal = acutotal + float.Parse(frm.txtDeposito.Text);
                }catch{}
           
        }
        void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                idvendedor = Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString());
                cajas(1);
                llenartabla();
                llenarprecios();
                if (frm.rbtSi.Checked == true)
                {
                    frm.tblClientes.Visible = true;
                    frm.tblClientes.Enabled = true;
                    si = true;
                    llenartabla();
                }
                else if(frm.rbtNo.Checked ==true)
                {
                    frm.tblClientes.Visible = false;
                    frm.tblClientes.Enabled = false;
                    idcliente = 0;
                    si = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        void rbtNo_Click(object sender, EventArgs e)/*si no es cliente*/
        {
            frm.tblClientes.Visible = false;
            frm.tblClientes.Enabled = false;
            idcliente = 0;
            si = false;
        }
        void rbtSi_Click(object sender, EventArgs e)/*si si es cliente*/
        {
            idvendedor = Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString());
            frm.tblClientes.Visible = true;
            frm.tblClientes.Enabled = true;
            si = true;
        }
        public bool llenarDeudasEspeciales()
        {
            actual = 0;
            existe = false;
            dts.setIdCliente(idcliente);
            frm.tblDeudas.DataSource = mtd.mtdllenarDeudasEspeciales(dts);
            if (frm.tblDeudas.Rows.Count >= 1)
            {
                //existe
                existe = true;
                for (int x = 0; x < frm.tblDeudas.Rows.Count; x++)
                {
                    actual = actual + float.Parse(frm.tblDeudas.Rows[x].Cells[0].Value.ToString());
                }
            }
            else
            {
                //insertar
                existe = false;
                actual = 0;
            }

            return existe;
        }
        public bool llenarDeudas()/*para verifcar si existen deudas*/
        {
            actual = 0;
            existe = false;
            dts.setIdCliente(idcliente);
            frm.tblDeudas.DataSource = mtd.mtdllenarDeudas(dts);
            if (frm.tblDeudas.Rows.Count >= 1)
            {
                //existe
                existe = true;
                for (int x = 0; x < frm.tblDeudas.Rows.Count;x++)
                {
                    actual = actual + float.Parse(frm.tblDeudas.Rows[x].Cells[0].Value.ToString());
                }
            }
            else
            {
                //insertar
                existe = false;
                actual = 0;
            }

            return existe;
        }
        public void llenartabla()
        {
            try
            {
                dts.setIdVendedor(idvendedor);
                frm.tblClientes.DataSource = mtd.mtdllenar(dts);
                frm.tblClientes.Columns[0].Visible = false;
            }
            catch
            {
                MessageBox.Show("Se ha producido un error al cargar los datos :(","Alerta...!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
            }
            
            //frm.tblClientes.Columns[2].Visible = false;
            //frm.tblClientes.Columns[3].Visible = false;
        }
        public void llenarVendedor()
        {
            try
            {
                frm.cmbVendedor.DataSource = mtd.mtdllenarVendedor();
                frm.cmbVendedor.DisplayMember = "vchNombre";
                frm.cmbVendedor.ValueMember = "intIdVendedorPK";
            }catch{}
   
        }
        public void calcular()/*calcula el total depositado de todas las ventas*/
        {
            acutotal = 0;
            acudebes = 0;
           
            for (int x = 0; x < frm.tblAgregar.Rows.Count-1;x++)
            {
                acutotal = acutotal + float.Parse(frm.tblAgregar.Rows[x].Cells[8].Value.ToString());
                acudebes = acudebes + float.Parse(frm.tblAgregar.Rows[x].Cells[9].Value.ToString());
            }
            frm.lblTotal.Text = acutotal.ToString();
            frm.lblDeuda.Text = acudebes.ToString();
            
        }
        public void llenarExistencia()/*indica cuantas unidades tienes en el almacen*/
        {
            try
            {
                frm.tblExistencia.DataSource = mtd.mtdllenarExistencia();
                existeBote=int.Parse(frm.tblExistencia.Rows[0].Cells[0].Value.ToString());
                existeSello=int.Parse(frm.tblExistencia.Rows[1].Cells[0].Value.ToString());
                existeTapon=int.Parse(frm.tblExistencia.Rows[2].Cells[0].Value.ToString());
                if (existeBote <= 100)
                {
                    MessageBox.Show("Te quedán esta entre 0 y 100 Botellones, Porfavor realiza las compras necesarias", "Alerta...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    frm.btnAceptar.Enabled = false;
                    frm.cmbVendedor.Enabled = false;
                    aux = 1;
                }
                if(existeSello <= 100)
                {
                    MessageBox.Show("Te quedán esta entre 0 y 100 Sellos, Porfavor realiza las compras necesarias", "Alerta...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    frm.btnAceptar.Enabled = false;
                    frm.cmbVendedor.Enabled = false;
                    aux = 1;
                }
                if(existeTapon<=100)
                {
                    MessageBox.Show("Te quedán esta entre 0 y 100 Tapones, Porfavor realiza las compras necesarias", "Alerta...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    frm.btnAceptar.Enabled = false;
                    frm.cmbVendedor.Enabled = false;
                    aux = 1;
                }
                if(aux!=1)
                {
                    frm.btnAceptar.Enabled = true;
                    frm.cmbVendedor.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("No ha registrados botellones en el inventario :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        public void llenarprecios()/*se cargan los precios del botellon*/
        {
            try
            {
                frm.tblPrecios.DataSource = mtd.mtdllenarPrecios();
                frm.txtPreNormal.Text = frm.tblPrecios.Rows[0].Cells[2].Value.ToString();
                frm.txtPreM1.Text = frm.tblPrecios.Rows[1].Cells[2].Value.ToString();
                frm.txtPreM2.Text = frm.tblPrecios.Rows[2].Cells[2].Value.ToString();
                p1 = float.Parse(frm.tblPrecios.Rows[0].Cells[2].Value.ToString());
                p2 = float.Parse(frm.tblPrecios.Rows[1].Cells[2].Value.ToString());
                p3 = float.Parse(frm.tblPrecios.Rows[2].Cells[2].Value.ToString());

                
            }
            catch
            {
                MessageBox.Show("Aún no ha configuado los precios del botellon :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }
        public void agregarVenta()/*este metodo verifica q todo este bien antes de agregar a la tabla detalle*/
        {
            try
            {
                dts.setTotal(float.Parse(frm.lblTotal.Text));
                dts.setFecha(fecha);
                dts.setIdBote(1);
                mtd.mtdInsertarVentas(dts);
                //insertar en tabla venta
                for (int x = 0; x < frm.tblAgregar.Rows.Count - 1; x++)
                {
                    //idven   idcliente  noral p1  m1 p2 m2 p3 subtotal  debe   fecha
                    dts.setIdVendedor(Convert.ToInt32(frm.tblAgregar.Rows[x].Cells[0].Value.ToString()));
                    dts.setFecha(frm.tblAgregar.Rows[x].Cells[10].Value.ToString());
                    idcliente = Convert.ToInt32(frm.tblAgregar.Rows[x].Cells[1].Value.ToString());
                    dts.setIdCliente(idcliente);
                    dts.setNormal(float.Parse(frm.tblAgregar.Rows[x].Cells[2].Value.ToString()));
                    dts.setP1(float.Parse(frm.tblAgregar.Rows[x].Cells[3].Value.ToString()));
                    dts.setMayo1(float.Parse(frm.tblAgregar.Rows[x].Cells[4].Value.ToString()));
                    dts.setP2(float.Parse(frm.tblAgregar.Rows[x].Cells[5].Value.ToString()));
                    dts.setMayo2(float.Parse(frm.tblAgregar.Rows[x].Cells[6].Value.ToString()));
                    dts.setP3(float.Parse(frm.tblAgregar.Rows[x].Cells[7].Value.ToString()));
                    dts.setSubtotal(float.Parse(frm.tblAgregar.Rows[x].Cells[8].Value.ToString()));
                    b = int.Parse(frm.tblAgregar.Rows[x].Cells[2].Value.ToString());
                    dts.setBonificados(float.Parse(frm.tblAgregar.Rows[x].Cells[11].Value.ToString()));
                    b1 = int.Parse(frm.tblAgregar.Rows[x].Cells[4].Value.ToString());
                    b2 = int.Parse(frm.tblAgregar.Rows[x].Cells[6].Value.ToString());
                    boni = int.Parse(frm.tblAgregar.Rows[x].Cells[11].Value.ToString());
                    dts.setUnidades(int.Parse(frm.tblAgregar.Rows[x].Cells[12].Value.ToString()));
                    dts.setCantidad(b + b1 + b2 + boni);
                    //insertar en venta a detalle    
                    mtd.mtdInsertarDetalle(dts);
                }
                MessageBox.Show("Venta Guardada...","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //frm.tblAgregar.Rows.Clear();
                frm.btnRegistrar.Enabled = false;
                idcliente = 0;
            }
            catch
            {
                MessageBox.Show("Verifique su conexion :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
            
        }
        public void agregarDeuda()/*este metodo ve verificando q clientes han quedado a deber y los va reistrando en la base*/
        {
            for (int x = 0; x < frm.tblAgregar.Rows.Count - 1; x++)
            {
                
                if (Convert.ToInt32(frm.tblAgregar.Rows[x].Cells[9].Value.ToString()) > 0)
                {
                    idvendedor = Convert.ToInt32(frm.tblAgregar.Rows[x].Cells[0].Value.ToString());
                    idcliente = Convert.ToInt32(frm.tblAgregar.Rows[x].Cells[1].Value.ToString());
                    debes = float.Parse(frm.tblAgregar.Rows[x].Cells[9].Value.ToString());
                    dts.setIdCliente(idcliente);
                    dts.setDebes(debes);
                    dts.setFecha(fecha);
                    if (frm.tblAgregar.Rows[x].Cells[13].Value.ToString() == "Si")
                    {
                        if (llenarDeudasEspeciales() == true)
                        {
                            //actualizar
                            nuevaDeuda = actual + debes;
                            dts.setNuevaDeuda(nuevaDeuda);
                            mtd.mtdActualizarDeudasEspeciales(dts);
                        }
                        else
                        {
                            //insertar en deudas
                            mtd.mtdInsertarDeudasEspeciales(dts);
                        }
                    }
                    else if (frm.tblAgregar.Rows[x].Cells[13].Value.ToString() == "No")
                    {
                        if (llenarDeudas() == true)
                        {
                            //actualizar
                            nuevaDeuda = actual + debes;
                            dts.setNuevaDeuda(nuevaDeuda);
                            mtd.mtdActualizarDeudas(dts);
                        }
                        else
                        {
                            //insertar en deudas
                            mtd.mtdInsertarDeudas(dts);
                        }
                    }
                    
                                       
                }
                
            }
        }
        public void comfirmarVenta()/*una vez q ya todo este bien se ejecuta este metodo*/
        {
            if(validar.mtd_mensaje()==1)
            {
                obtenerFecha();
                agregarVenta();
                agregarDeuda();
                frm.tblAgregar.Rows.Clear();
                frm.tblClientes.DataSource = null;
                frm.rbtNo.Checked = true;
                llenarExistencia();
            }
            
        }
        public void obtenerFecha()/*obtiene fecha actual*/
        {
            d = frm.dtFecha.Value.Day;
            m = frm.dtFecha.Value.Month;
            a = frm.dtFecha.Value.Year;
            fecha = a + "-" + m + "-" + d;
        }
        public void cajas(int op)
        {
            switch (op)
            {
                case 1:
                    frm.txtBonificados.Enabled = true;
                    frm.txtMayoreo1.Enabled = true;
                    frm.txtMayoreo2.Enabled = true;
                    frm.txtNormal.Enabled = true;
                    frm.grpClientes.Enabled = true;
                    frm.rbtNo.Enabled = true;
                    frm.rbtSi.Enabled = true;
                    frm.txtPreNormal.Enabled = true;
                    frm.txtPreM2.Enabled = true;
                    frm.txtPreM1.Enabled = true;
                    //frm.rbtNo.Checked = true;
                    //frm.rbtSi.Checked = false;
                    //frm.btnAgregar.Enabled = true;
                    //frm.txtDeposito.Enabled = true;
                    break;
                case 2:
                    frm.txtNormal.Enabled = false;
                    frm.txtMayoreo2.Enabled = false;
                    frm.txtMayoreo1.Enabled = false;
                    frm.txtBonificados.Enabled = false;
                    frm.grpClientes.Enabled = false;
                    //frm.rbtNo.Enabled = false;
                    //frm.rbtSi.Enabled = false;
                    //frm.rbtNo.Checked = false;
                    //frm.rbtSi.Checked = false;
                    frm.txtPreNormal.Enabled = false;
                    frm.txtPreM2.Enabled = false;
                    frm.txtPreM1.Enabled = false;
                    frm.btnAgregar.Enabled = false;
                    frm.txtDeposito.Enabled = false;
                    break;
            }
        }
        public void limpiar()
        {
            
            frm.txtBonificados.Text = "0";
            frm.txtDeposito.Clear();
            frm.txtMayoreo1.Text = "0";
            frm.txtMayoreo2.Text = "0";
            frm.txtNormal.Text = "0";
            frm.txtSubtotal.Text = "0";
            frm.lblDebes.Text = "0";
           
        }
        public void nombreCeldas()/*asignamos estos nombres a la tabla detalle ya q son dinamicos*/
        {
            frm.tblAgregar.Columns[4].HeaderText = "Mayoreo " + frm.txtPreM1.Text;
            frm.tblAgregar.Columns[6].HeaderText = "Mayoreo " + frm.txtPreM2.Text;
        }
      
    }
}
