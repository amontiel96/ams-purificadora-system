/*en esta clase se realizan las devoluciones de las compras de botellones, sellos y tapones indicando primero en q fecha se realizo la compra*/
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
    class cls_CDevolucionesCompras
    {
        frmDevolucionesCompras frm = new frmDevolucionesCompras();
        cls_DevolucionesComprasDAO mtd = new cls_DevolucionesComprasDAO();
        cls_DevolucionesComprasVO dts = new cls_DevolucionesComprasVO();
        Cls_Validaciones validar = new Cls_Validaciones();

        int d, m, a, idcompra,idbote;
        string fechaI, fechaF;
        float precompra = 0, temSubtotal = 0, subInicial = 0, total = 0, gastoCompra = 0, cantidad = 0, devolver = 0, temCanti = 0;
        DialogResult respuesta;

        /*
         * fechaI el el día inicial
         * fechaF es el día final
         d-m-a son para obtener la fecha inicial y fecha final
         * idcompra es el id de la compra detalle para poder identidficar en q compra se va a realizar la devolucion
         * idbote es el id del producto a devolver
         * precompra es el precio de compra po el cual se compro ese producto
         * temSubtotal esta variable es solo un auxiliar para poder obtener el total
         * subInicail es la cantidad de dinero q se pago por esa compra
         * total es lo q se va a actualizar nuevamente en lo q era el subtotal de compra
         * gastoCompra es para obtener si exitia un gasto de compra adicional en esa compra
         * cantidad es la cantidad de producto q se compro en esa compra
         * devolver es la cantidad de producto a devolver de esa compra
         *temCanti es solo un auxiliar para obtener con cuanto producto se quedo despues de la devolucion
         *respuesta es para realizar un mensaje con respuesta
         */

        public void frm_load()
        {
            frm.btnAceptar.Click += btnAceptar_Click;
            frm.tblCompras.CellClick += tblCompras_CellClick;
            frm.txtCantidaDev.TextChanged += txtCantidaDev_TextChanged;
            frm.txtCantidaDev.KeyPress += txtCantidaDev_KeyPress;
            frm.btnComfirmarDev.Click += btnComfirmarDev_Click;
            frm.ShowDialog();
        }

        void btnComfirmarDev_Click(object sender, EventArgs e)
        {
            comfirmarDevolucion();
        }

        void txtCantidaDev_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void txtCantidaDev_TextChanged(object sender, EventArgs e)/*aqui se obtiene la cantidad de unidades a devolver para enviarlo al metodo que resta a la cantidad q tenia esa compra*/
        {
            try
            {
                devolver = int.Parse(frm.txtCantidaDev.Text);
            }
            catch
            {
                devolver = 0;
            }
            calDevolucion();
        }

        public void calDevolucion()/*este metodo resta la cantidad de unidades a devolver de la cantidad de unidades q tenia registrado esa compra asi como tambien va calculando el subtotal de compra nuevamente*/
        {
            temCanti = cantidad - devolver;
            frm.txtQuedan.Text = temCanti.ToString();
            temSubtotal = temCanti * precompra;
            total = temSubtotal + gastoCompra;
            frm.txtSubtotal.Text = total.ToString();
        }

        void tblCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idcompra = Convert.ToInt32(frm.tblCompras.Rows[frm.tblCompras.CurrentRow.Index].Cells[0].Value.ToString());
                frm.txtNombre.Text = frm.tblCompras.Rows[frm.tblCompras.CurrentRow.Index].Cells[2].Value.ToString();
                frm.txtCantidad.Text = frm.tblCompras.Rows[frm.tblCompras.CurrentRow.Index].Cells[3].Value.ToString();
                frm.txtPreCompra.Text = frm.tblCompras.Rows[frm.tblCompras.CurrentRow.Index].Cells[4].Value.ToString();
                frm.txtSubtotal.Text = frm.tblCompras.Rows[frm.tblCompras.CurrentRow.Index].Cells[5].Value.ToString();
                idbote = Convert.ToInt32(frm.tblCompras.Rows[frm.tblCompras.CurrentRow.Index].Cells[7].Value.ToString());
                cantidad = float.Parse(frm.txtCantidad.Text);
                precompra = float.Parse(frm.txtPreCompra.Text);
                subInicial = float.Parse(frm.tblCompras.Rows[frm.tblCompras.CurrentRow.Index].Cells[5].Value.ToString());
                frm.txtQuedan.Text = cantidad.ToString();
                float resta = cantidad * precompra;
                gastoCompra = subInicial-resta;
                frm.txtCantidaDev.Enabled = true;
                frm.btnComfirmarDev.Enabled = true;
            }
            catch
            {

            }
            
        }

        void btnAceptar_Click(object sender, EventArgs e)
        {
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

        public void comfirmarDevolucion()/*aqui se va verficando q todo este bien antes de enviar los datos a la base de datos y no causar conflictos*/
        {
            try
            {
                
                if (frm.txtCantidaDev.Text == "")
                {
                    MessageBox.Show("No debe dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (devolver <= 0)
                    {
                        MessageBox.Show("Indique cantidad a devolver :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (devolver > cantidad)
                        {
                            MessageBox.Show("No puede devolver mas de lo que ha comprado :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            respuesta = MessageBox.Show("¿Esta seguro de continuar?","Responda la pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                            if (respuesta == DialogResult.Yes)
                            {
                                dts.setId(idcompra);
                                dts.setCantidad(Convert.ToInt32(temCanti));
                                dts.setSubtotal(total);
                                dts.setQuitar(Convert.ToInt32(devolver));
                                dts.setBote(idbote);
                                mtd.mtdActualizarCompra(dts);
                                MessageBox.Show("Accion exitosa :)", "Aviso...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                llenarTabla();
                            }
                            else
                            {
                                MessageBox.Show("Accion cancelada :)","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                            limpiar();
                            
                        }
                        
                    }
                }
               
            }
            catch
            {
                MessageBox.Show("Se producjo un error al intentelo de nuevo :(","Error inesperado...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
           
        }

        public void llenarTabla()
        {
            try
            {
                fechaInicial();
                fechaFinal();
                dts.setFechai(fechaI);
                dts.setFechaf(fechaF);
                frm.tblCompras.DataSource = mtd.mtdllenartabla(dts);
                frm.tblCompras.Columns[0].Visible = false;
                frm.tblCompras.Columns[7].Visible = false;
                if(!(frm.tblCompras.Rows.Count >=1))
                {
                   
                    MessageBox.Show("No hay registros :)","Verifique las fechas...!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    limpiar();
                }
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta...!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        public void limpiar()
        {
            idcompra = 0;
            frm.txtCantidad.Clear();
            frm.txtCantidaDev.Clear();
            frm.txtNombre.Clear();
            frm.txtPreCompra.Clear();
            frm.txtQuedan.Clear();
            frm.txtSubtotal.Clear();
            frm.btnComfirmarDev.Enabled = false;
            frm.txtCantidaDev.Enabled = false;
        }

    }
}
