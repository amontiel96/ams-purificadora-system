/*en esta clase se relizan las devolucione de las ventas realizadas indicando en q fecha se realizo las ventas*/
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
    class cls_CDevolucionesVentas
    {
        frmDevolucionesVentas frm = new frmDevolucionesVentas();
        cls_DevolucionesVentasDAO mtd = new cls_DevolucionesVentasDAO();
        cls_DevolucionesVentasVO dts = new cls_DevolucionesVentasVO();
        Cls_Validaciones validar = new Cls_Validaciones();


        int d, m, a,idvendedor,idventa,can1,can2,can3,canBoni,dev1,dev2,dev3,devBoni,ct1,ct2,ct3,ctb;
        string fechaI, fechaF;
        float p1 = 0, p2 = 0, p3 = 0, subInicial;

        /*
         * fechaI día inicial
         * fechaF día final
         d-m-a son para obtener las fecha inicial y fecha final
         * idvendedor para indicar q vendedor va a realizar la devolucion y descontarle esas ventas
         * idventa es el id de la venta a detalle para identificar a cual registro de venta se va actualizar
         * can1 son las ventas realizadas al preccio normal
         * can2 son la ventas realizadas al precion de mayoreo 1
         * can3 son las ventas realizadas al precio de mayoreo 2
         * canBoni son los botellones bonificados
         * dev1 son la cantidad de unidades vendidas al prcio normal a devolver
         * dev2 son la cantidad de unidades vendidas al precio mayoreo1 a devolver
         * devBoni son la cantidad de unidades bonificadas a devolver
         * ct1 es la cantidad de unidades al precio normal restantes
         * ct2 es la cantidad de inidades al mayoreo1 restantes
         * ctb es la cantidad de unidades al mayoreo2 restantes
         * p1 es el precio normal registrado en esa venta
         * p2 es el precio mayoreo1 registrado en esa venta
         * p3 es el precio mayoreo2 registrado en esa venta
         * subInicial es paraobtener lo q se gano en esa venta regsitrada
         */


        public void frm_load()
        {
            frm.btnAceptar.Click += btnAceptar_Click;
            frm.tblVenDet.CellClick += tblVenDet_CellClick;
            frm.txtDev1.TextChanged += txtDev1_TextChanged;
            frm.txtDev2.TextChanged += txtDev2_TextChanged;
            frm.txtDev3.TextChanged += txtDev3_TextChanged;
            frm.txtDevBoni.TextChanged += txtDevBoni_TextChanged;
            frm.txtDev1.KeyPress += txtDev1_KeyPress;
            frm.txtDev2.KeyPress += txtDev2_KeyPress;
            frm.txtDev3.KeyPress += txtDev3_KeyPress;
            frm.txtDevBoni.KeyPress += txtDevBoni_KeyPress;
            frm.btnComfirmarDevoluciones.Click += btnComfirmarDevoluciones_Click;
            llenacombo();
            frm.ShowDialog();
        }

        void btnComfirmarDevoluciones_Click(object sender, EventArgs e)/*aqui primero se va verificndo q todo este bien antes de enviar los datos a la base de datos y no causar conflictos*/
        {
            
                if (!(dev1 == 0 & dev2 == 0 & dev3 == 0 & devBoni == 0))
                {
                    if (frm.txtDev1.Text == "" || frm.txtDev2.Text == "" || frm.txtDev3.Text == "" || frm.txtDevBoni.Text == "")
                    {
                        MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (dev1 > can1 || dev2 > can2 || dev3 > can3 || devBoni > canBoni)
                        {
                            MessageBox.Show("No puedes devolver mas delo que fue la venta :(", "Verifica tus datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (validar.mtd_mensaje() == 1)
                            {
                                comfirmar();
                                llenarTabla();
                            }
                            else
                            {
                                limpiar();
                            }
                        }
                       
                    }
                }
                else
                {
                    MessageBox.Show("Sino hay devoluciones, nose puede registrar :)","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }            
            
        }

        void txtDevBoni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void txtDev3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void txtDev2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void txtDev1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void txtDevBoni_TextChanged(object sender, EventArgs e)/*indico la cantidad de bonificados a devolver*/
        {
            try
            {
                devBoni = int.Parse(frm.txtDevBoni.Text);
            }
            catch
            {
                devBoni = 0;
            }
            calSubtotal();
        }

        void txtDev3_TextChanged(object sender, EventArgs e)/*indico la cantidad de unidades al precio mayoreo2 a devolver*/
        {
            try
            {
                dev3 = int.Parse(frm.txtDev3.Text);
            }
            catch
            {
                dev3 = 0;
            }
            calSubtotal();
        }

        void txtDev2_TextChanged(object sender, EventArgs e)/*indico la cantidad de unidades al precio mayoreo1 a devolver*/
        {
            try
            {
                dev2 = int.Parse(frm.txtDev2.Text);
            }
            catch
            {
                dev2 = 0;
            }
            calSubtotal();
        }

        void txtDev1_TextChanged(object sender, EventArgs e)/*indico la cantidad de unidades al precio normal a devolver*/
        {
            try
            {
                dev1 = int.Parse(frm.txtDev1.Text);
            }
            catch
            {
                dev1 = 0;
            }
            calSubtotal();
        }

        public void calSubtotal()/*este metodo va calculando las unidades restantes de esa venta asi como tambien va calculando nuevamente el subtotal de esas ventas para actualizar los datos en la base de datos*/
        {
            ct1 = can1 - dev1;
            ct2 = can2 - dev2;
            ct3 = can3 - dev3;
            ctb = canBoni - devBoni;

            frm.txtQuea1.Text = ct1.ToString();
            frm.txtQueda2.Text = ct2.ToString();
            frm.txtQueda3.Text = ct3.ToString();
            frm.txtQuedaBoni.Text = ctb.ToString();


            frm.txtSubtotal.Text = ((ct1 * p1) + (ct2 * p2) + (ct3 * p3)).ToString();

            frm.txtUnidades.Text = ((int.Parse(frm.txtQuea1.Text)) + (int.Parse(frm.txtQueda2.Text)) + (int.Parse(frm.txtQueda3.Text)) + (int.Parse(frm.txtQuedaBoni.Text))).ToString();

        }

        void tblVenDet_CellClick(object sender, DataGridViewCellEventArgs e)/*al dar clic en el registro deseado, se van obteniendo los valores de esas ventas realizadas*/
        {
            try
            {
                limpiar();
                frm.txtDev1.Enabled = false;
                frm.txtDev3.Enabled = false;
                frm.txtDev2.Enabled = false;
                frm.txtDevBoni.Enabled = false;
                idventa = Convert.ToInt32(frm.tblVenDet.Rows[frm.tblVenDet.CurrentRow.Index].Cells[0].Value.ToString());
                frm.txtPreNormal.Text = frm.tblVenDet.Rows[frm.tblVenDet.CurrentRow.Index].Cells[4].Value.ToString();
                frm.txtPreM1.Text = frm.tblVenDet.Rows[frm.tblVenDet.CurrentRow.Index].Cells[6].Value.ToString();
                frm.txtPreM2.Text = frm.tblVenDet.Rows[frm.tblVenDet.CurrentRow.Index].Cells[8].Value.ToString();

                frm.txtNormal.Text = frm.tblVenDet.Rows[frm.tblVenDet.CurrentRow.Index].Cells[3].Value.ToString();
                frm.txtMayoreo1.Text = frm.tblVenDet.Rows[frm.tblVenDet.CurrentRow.Index].Cells[5].Value.ToString();
                frm.txtMayoreo2.Text = frm.tblVenDet.Rows[frm.tblVenDet.CurrentRow.Index].Cells[7].Value.ToString();
                frm.txtBonificados.Text = frm.tblVenDet.Rows[frm.tblVenDet.CurrentRow.Index].Cells[9].Value.ToString();
                frm.txtSubtotal.Text = frm.tblVenDet.Rows[frm.tblVenDet.CurrentRow.Index].Cells[10].Value.ToString();
                frm.txtUnidades.Text = frm.tblVenDet.Rows[frm.tblVenDet.CurrentRow.Index].Cells[11].Value.ToString();

                frm.txtQuea1.Text = frm.txtNormal.Text;
                frm.txtQueda2.Text = frm.txtMayoreo1.Text;
                frm.txtQueda3.Text = frm.txtMayoreo2.Text;
                frm.txtQuedaBoni.Text = frm.txtBonificados.Text;


                p1 = float.Parse(frm.txtPreNormal.Text);
                p2 = float.Parse(frm.txtPreM1.Text);
                p3 = float.Parse(frm.txtPreM2.Text);

                can1 = int.Parse(frm.txtNormal.Text);
                can2 = int.Parse(frm.txtMayoreo1.Text);
                can3 = int.Parse(frm.txtMayoreo2.Text);
                canBoni = int.Parse(frm.txtBonificados.Text);

                subInicial = float.Parse(frm.txtSubtotal.Text);


                frm.txtVendedor.Text = frm.cmbVendedor.Text;
                frm.txtCliente.Text = frm.tblVenDet.Rows[frm.tblVenDet.CurrentRow.Index].Cells[2].Value.ToString();

                if (!(frm.txtNormal.Text == "0"))
                {
                    frm.txtDev1.Enabled = true;
                }
                if (!(frm.txtMayoreo1.Text == "0"))
                {
                    frm.txtDev2.Enabled = true;
                }
                if (!(frm.txtMayoreo2.Text == "0"))
                {
                    frm.txtDev3.Enabled = true;
                }
                if (!(frm.txtBonificados.Text == "0"))
                {
                    frm.txtDevBoni.Enabled = true;
                }

                frm.btnComfirmarDevoluciones.Enabled = true;
            }
            catch
            {

            }    
        }

        public void comfirmar()/*este metodo se ejecuta cuando ya todo esta bien y se actualiza la base de datso*/
        {
            dts.setBonificados(int.Parse(frm.txtQuedaBoni.Text));
            dts.setIdVenta(idventa);
            dts.setM1(int.Parse(frm.txtQueda2.Text));
            dts.setM2(int.Parse(frm.txtQueda3.Text));
            dts.setNormal(int.Parse(frm.txtQuea1.Text));
            dts.setSubtotal(float.Parse(frm.txtSubtotal.Text));
            dts.setUnidades(int.Parse(frm.txtUnidades.Text));
            dts.setSumar(dev1+dev2+dev3+devBoni);
            mtd.mtdActualizarVentaDet(dts);
            MessageBox.Show("Accion exitosa :)","Aviso...!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            limpiar();
        }

        void btnAceptar_Click(object sender, EventArgs e)
        {
            limpiar();
            llenarTabla();
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

        public void llenarTabla()
        {
            try
            {
                fechaInicial();
                fechaFinal();
                dts.setFechai(fechaI);
                dts.setFechaf(fechaF);
                dts.setVendedor(Convert.ToInt32(frm.cmbVendedor.SelectedValue.ToString()));
                frm.tblVenDet.DataSource = mtd.mtdllenartabla(dts);
                frm.tblVenDet.Columns[0].Visible = false;
                frm.tblVenDet.Columns[1].Visible = false;
                if (!(frm.tblVenDet.Rows.Count >= 1))
                {
                    MessageBox.Show("No hay registros :)", "Verifique las fechas...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //limpiar();
                }
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(", "Alerta...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //llenamos el combo de los vendedores
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

        public void limpiar()
        {
            frm.txtBonificados.Text="0";
            frm.txtCliente.Clear();
            frm.txtDev1.Text = "0";
            frm.txtDev2.Text = "0";
            frm.txtDev3.Text = "0";
            frm.txtDevBoni.Text = "0";
            frm.txtMayoreo1.Text = "0";
            frm.txtMayoreo2.Text = "0";
            frm.txtNormal.Text = "0";
            frm.txtPreM1.Text = "0";
            frm.txtPreM2.Text = "0";
            frm.txtPreNormal.Text = "0";
            frm.txtQuea1.Text = "0";
            frm.txtQueda2.Text = "0";
            frm.txtQueda3.Text = "0";
            frm.txtQuedaBoni.Text = "0";
            frm.txtVendedor.Clear();
            frm.txtUnidades.Text = "0";
            frm.txtSubtotal.Text = "0";

            frm.txtDev1.Enabled = false;
            frm.txtDev2.Enabled = false;
            frm.txtDev3.Enabled = false;
            frm.txtDevBoni.Enabled = false;
            frm.btnComfirmarDevoluciones.Enabled = false;
        }
    }
}
