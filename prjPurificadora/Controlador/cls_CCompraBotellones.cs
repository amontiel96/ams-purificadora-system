/*en esta clase se realizan las compras de botellones, sellos y tapones unicamente*/
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
    class cls_CCompraBotellones
    {
        //instanciamos objetos de las clases necesarias
        frmCompraBote frm = new frmCompraBote();
        cls_ComprasDAO mtd = new cls_ComprasDAO();
        cls_ComprasVO dts = new cls_ComprasVO();
        Cls_Validaciones validar = new Cls_Validaciones();

        //declaramos las variables a utilizar
        int d, m, a;
        string fecha;
        float subtotal = 0,gastoCompra=0,preCompra=0,canti=0;
        int idbote,idadmin,idproveedor,cantidad,exis;
        /*
         d-m-a son para obtener la fecha
         * subtotal es lo q se va gastando en la compra de cada producto
         * gastoCompra es por si hay un gasto adicional en la compra y se suma al subtotal
         * idbote es el id del producto seleccionado a comprar
         * idadmin es el id del adminitrador quien realizo la compra
         * idproveedor es el id del proveedor seleccionado del combo
         * canidad es la cantidad de producto q se va a comprar
         * exis a esta variable se le va a sumar la cantidad ingresada y asi solo hacer una actualizacion a la base de datos
         */
        
        public void frm_load(string id)//creamos el metodo load para inicializar los eventos del los controles necesarios
        {
            idadmin = Convert.ToInt32(id);
            llenarproveedor();
            llenarTabla();//desde que inicie el formulario llenamos la tabla
            //ocultamos estas tres columnas yaque no son requeridas para la vista del administrador, pero si son necesarias para realizar algunas acciones
            frm.tblAgrega.Columns[0].Visible = false;
            frm.tblAgrega.Columns[1].Visible = false;
            frm.tblAgrega.Columns[5].Visible = false;
            frm.btnComfirmarCompras.Click += btnComfirmarCompras_Click;
            frm.tblBotellones.CellClick += tblBotellones_CellClick;
            frm.txtCantidad.TextChanged += txtCantidad_TextChanged;
            frm.btnComfirmar.Click += btnComfirmar_Click;
            frm.txtCantidad.KeyPress += txtCantidad_KeyPress;
            frm.txtGastoCompra.KeyPress += txtGastoCompra_KeyPress;
            frm.txtPreCompra.KeyPress += txtPreCompra_KeyPress;
            frm.txtGastoCompra.TextChanged += txtGastoCompra_TextChanged;
            frm.txtPreCompra.TextChanged += txtPreCompra_TextChanged;
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }

        void txtPreCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtPreCompra.Text,e);
        }

        void txtPreCompra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                /*obtenemos el precio de compra por si hay un descuento y hacer los caculos necesarios*/
                preCompra = float.Parse(frm.txtPreCompra.Text);
            }
            catch
            {
                preCompra = 0;
            }
            calSubtotal1();
        }

        void txtGastoCompra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                /*obtenemos el gasto de compra si esq lo hay y procedemos a sumarselo al subtotal
                 de la compra
                 */
                gastoCompra = float.Parse(frm.txtGastoCompra.Text);
            }
            catch
            {
                gastoCompra = 0;
            }
            calSubtotal1();

        }

        void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                /*obtenemoos la cantidad de poducto a comprar y lo vamos multiplicando por 
                 el precio de compra
                 */
                canti = float.Parse(frm.txtCantidad.Text);  
            }
            catch
            {
                canti = 0;
            }
            calSubtotal1();
        }

        public void calSubtotal1()
        {
            //aqui lo que se hace es que va multimplicando auntomaticamente cuando se va ingresando un valor por el precio de compra
            frm.lblSubtotal.Text = ((canti * preCompra) + gastoCompra).ToString();
        }

        void txtGastoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtGastoCompra.Text,e);
        }

        //las cajas que centan on elevento keypres es para validar lo que se va ingresando en la caja
        void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void btnComfirmarCompras_Click(object sender, EventArgs e)
        {
            try
            {
                if(validar.mtd_mensaje()==1)
                {
                    insertarCompras();//cuando le demos clic en el boton comfirmar llamamos a nuestro metodo insertar compras
                    MessageBox.Show("Compra exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarTabla();//si la compra fue exitosa volvemos a llenar la tabla para ver los datos nuevo
                    frm.tblAgrega.Rows.Clear();//y limpiamos la tabla detalle
                    frm.btnComfirmarCompras.Enabled = false;//asi como tambien deshabiltamos el boton de comfirmar para que no pueden dar clic hasta que ahiga nuevamente datos en la tabla detalle
                    frm.lblTotal.Text = "0";
                }
                
            }
            catch
            {
                MessageBox.Show("Se produjo un error al intentar guardar :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        //este metodo es para obtener la fecha actual del sistema
        public void obtenerFecha()
        {
            d = frm.dtFecha.Value.Day;
            m = frm.dtFecha.Value.Month;
            a = frm.dtFecha.Value.Year;
            fecha = a + "-" + m + "-" + d;
        }

        //al seleccionar el producto desado pasamos los datos de la fila seleccionada alas cajas de texto
        void tblBotellones_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            try
            {
                idbote = Convert.ToInt32(frm.tblBotellones.Rows[frm.tblBotellones.CurrentRow.Index].Cells[0].Value.ToString());
                frm.txtNombre.Text = frm.tblBotellones.Rows[frm.tblBotellones.CurrentRow.Index].Cells[1].Value.ToString();
                frm.txtExistencia.Text = frm.tblBotellones.Rows[frm.tblBotellones.CurrentRow.Index].Cells[2].Value.ToString();
                frm.txtPreCompra.Text = frm.tblBotellones.Rows[frm.tblBotellones.CurrentRow.Index].Cells[3].Value.ToString();
                frm.txtCantidad.Enabled = true;
                frm.btnComfirmar.Enabled = true;
                frm.txtPreCompra.Enabled = true;
                frm.txtGastoCompra.Enabled = true;
            }
            catch
            {

            }
            
        }

        void btnComfirmar_Click(object sender, EventArgs e)
        {
            //cuando le demos clic en el boton agregar, llamamos a  nuestro metodo done agregamos nuevo registro ala tabla detalle
            agregar();
        }
        public void agregar()
        {
            try
            {
                if (frm.txtCantidad.Text == "")//antes de guardar primero verificamos que la caja no este vacia
                {
                    MessageBox.Show("No dejar campo vacio :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cantidad = int.Parse(frm.txtCantidad.Text);
                    if (cantidad == 0)//la cantidad no puede ser cero
                    {
                        MessageBox.Show("La cantidad a comprar tiene que ser mayor que 0  :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //una ves que ya se verificaron las validaciones correspondientes 
                        //se procede a realizar las sigueientes acciones
                        obtenerFecha();//ejecutamos este metodo para obtener la fecha actual del sistema
                        idproveedor = Convert.ToInt32(frm.cmbProveedor.SelectedValue.ToString());//obtenemos el id del proveedr seleccionado
                        frm.tblAgrega.Rows.Add(idbote, idproveedor, cantidad, frm.txtPreCompra.Text, frm.lblSubtotal.Text, fecha);//agregamos los valores ala tabla detalle
                        calSubtotal();//enseguida despues de agregar ala tabla detalle, llamamos al metodo calSubtotal para que automaticamente vaya calculando cuanto es de la compra
                        //una ves calculado este proceso 
                        //deshabilitamos la caja cantidad y el boton de comfirmar para que se vuelvan activar hasta que agreguen un nuevo registro ala tabla detalle
                        frm.txtCantidad.Enabled = false;
                        frm.btnComfirmar.Enabled = false;
                        limpiar();
                        if(frm.tblAgrega.Rows.Count>=2)//verifica si ya hay datos en la tabl detalle para que se active el boton de regsitrar la compra
                        {
                            frm.btnComfirmarCompras.Enabled = true;
                        }
                    }
                    
                }
                
            }
            catch
            {
                MessageBox.Show("Se produjo un error al agregar :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        
        public void calSubtotal()/*este metodo se utiliza cuando ya se agrega una compra a la tabla detalle para ir calculando el total de la compra*/
        {
            subtotal = 0;//iniciamos nuestro acumulador en 0
            for (int x = 0; x < frm.tblAgrega.Rows.Count - 1; x++)//vamos a recorres todas las filas de la tabla detalle
            {
                subtotal = subtotal + float.Parse(frm.tblAgrega.Rows[x].Cells[4].Value.ToString());//va ir acumulando los subtotales de la compra para poder obtener el total general de compra
            }
            frm.lblTotal.Text = subtotal.ToString();//una ves obtenido el subtotal de esa compra la igualamos ala etiqueta para ser visible al administrador
        }

        public void insertarCompras()/*una vez que ya se verifico todo, se ejecuta este metodo donde recorremos con un ciclo la tabla detalle para registrar todoas las compras solicitadas*/
        {
            
                //encapsulamos los datos de las cajas de texto
                dts.setIdAdmin(idadmin);
                dts.setTotal(float.Parse(frm.lblTotal.Text));
                dts.setFecha(fecha);
                //ejecutamos nuestro metodo de insertar compras
                mtd.mtdInsertarComprasBote(dts);

                for (int x = 0; x < frm.tblAgrega.Rows.Count - 1; x++)//recorremos todas las filas que agregamos ala tabla detalle
                {
                    //donde vamos obteniendo los datos decada registro y encapsularlos
                    dts.setIdProducto(Convert.ToInt32(frm.tblAgrega.Rows[x].Cells[0].Value.ToString()));
                    dts.setCantidad(Convert.ToInt32(frm.tblAgrega.Rows[x].Cells[2].Value.ToString()));
                    dts.setIdProveedor(Convert.ToInt32(frm.tblAgrega.Rows[x].Cells[1].Value.ToString()));
                    dts.setPrecio(float.Parse(frm.tblAgrega.Rows[x].Cells[3].Value.ToString()));
                    dts.setSubtotal(float.Parse(frm.tblAgrega.Rows[x].Cells[4].Value.ToString()));
                    dts.setFecha(frm.tblAgrega.Rows[x].Cells[5].Value.ToString());
                    //cada que se va encapsulando datos 
                    mtd.mtdInsertarComprasBoteDet(dts);//se procede a isertar en la compra detalle
                    //para asi ir recorriendo cada registro de la tabla 
                }

        }

        public void llenarproveedor()
        {
            try
            {
                frm.cmbProveedor.DataSource = mtd.mtdllenarProveedor();
                frm.cmbProveedor.DisplayMember = "vchNombre";
                frm.cmbProveedor.ValueMember = "intIdProveedorPK";
            }
            catch
            {

            }
            
        }
        public void llenarTabla()
        {

            try
            {
                //llenamos la tabla de botellones
                frm.tblBotellones.DataSource = mtd.mtdllenarBotellones();
                if (frm.tblBotellones.Rows.Count >= 1)//verificamos que la tabla tenga mas de un registro
                {
                    //si hay registros, ocultamos estas dos columnas yaque no son requeridas para la vista del administrador
                    //pero si son necesarias para realizar algunas acciones
                    frm.tblBotellones.Columns[0].Visible = false;
                    frm.tblBotellones.Columns[4].Visible = false;
                    //siempre que se llena la tabla, automaticamente pasamos los valores dle primer registro alas cajas de texto para poder realizar las acciones
                    idbote = Convert.ToInt32(frm.tblBotellones.Rows[0].Cells[0].Value.ToString());
                    frm.txtNombre.Text = frm.tblBotellones.Rows[0].Cells[1].Value.ToString();
                    frm.txtExistencia.Text = frm.tblBotellones.Rows[0].Cells[2].Value.ToString();
                    frm.txtPreCompra.Text = frm.tblBotellones.Rows[0].Cells[3].Value.ToString();
                    preCompra = float.Parse(frm.tblBotellones.Rows[0].Cells[3].Value.ToString());
                }
                else
                {
                    //si no hay registros solo se muestra un mensaje de aviso
                    MessageBox.Show("Aún no hay registros :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
            
        }
        public void limpiar()
        {
            frm.txtCantidad.Clear();
            frm.txtExistencia.Clear();
            frm.txtNombre.Clear();
            frm.txtPreCompra.Clear();
            frm.lblSubtotal.Text = "0";
            frm.txtGastoCompra.Text = "0";
            frm.txtGastoCompra.Enabled = false;
            frm.txtPreCompra.Clear();
            frm.txtPreCompra.Enabled = false;
        }

    }
}
