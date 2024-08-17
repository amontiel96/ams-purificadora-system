/*en esta clase se realizan las compras de todos los productos requeroidos en produccion ejem. sal, detergente etc...*/
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
    class cls_CCompras
    {

        frmCompras frm = new frmCompras();
        cls_ComprasDAO mtd = new cls_ComprasDAO();
        cls_ComprasVO dts = new cls_ComprasVO();
        Cls_Validaciones validar = new Cls_Validaciones();


        int d, m, a;
        string fecha;
        int idproducto,idproveedor,idadmin;
        int cantidad;
        float subtotal = 0;
        /*
         d-m-a son para obtener la fecha actual
         * idproducto es el id del producto seleccionado
         * idproveedor es el id del proveedor seleccionado del combo
         * idadmin es el id del administraor q realiza la compra
         * cantidad es la cantidad de producto a comprar
         * subtotal es la cantiad de dinero a pagar por cada compra
         */


        public void frm_load(string id)
        {
            //inicializamos los eventos que se desean de cada control del formulario
            idadmin = Convert.ToInt32(id);
            llenarproveedor();
            llenarTabla();
            frm.txtCantidad.TextChanged += txtCantidad_TextChanged;
            frm.tblProductos.CellClick += tblProductos_CellClick;
            frm.btnAgregar.Click += btnAgregar_Click;
            frm.btnComfirmar.Click += btnComfirmar_Click;
            frm.txtCantidad.KeyPress += txtCantidad_KeyPress;
            frm.tblAgrega.Columns[0].Visible = false;
            frm.tblAgrega.Columns[1].Visible = false;
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }
        //todas las cajas que tengan el evento keypres es para validar lo que se va ingresando ala caja de texto
        void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }
        //obtenemos la fecha actual del sistema
        public void obtenerFecha()/*obtiene la fecha actual*/
        {
            d = frm.dtFecha.Value.Day;
            m = frm.dtFecha.Value.Month;
            a = frm.dtFecha.Value.Year;
            fecha = a + "-" + m + "-" + d;
        }


        void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {   
                //cuando va cambiandoel valor de esta caja de texto se va multiplicando por lo que teiene la otra caja
                //y se va mostranto en la etiqueta
                frm.lblSubtotal.Text = (float.Parse(frm.txtPreCompra.Text) * float.Parse(frm.txtCantidad.Text)).ToString();
            }
            catch {
                frm.lblSubtotal.Text = "0";
                frm.txtCantidad.Text = "";
            }
        }


        void tblProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                //pasamos los datos de la fila seleccionada de la tabla
                idproducto = Convert.ToInt32(frm.tblProductos.Rows[frm.tblProductos.CurrentRow.Index].Cells[0].Value.ToString());
                frm.txtNombre.Text = frm.tblProductos.Rows[frm.tblProductos.CurrentRow.Index].Cells[1].Value.ToString();
                frm.txtPreCompra.Text = frm.tblProductos.Rows[frm.tblProductos.CurrentRow.Index].Cells[2].Value.ToString();
                frm.txtCantidad.Enabled = true;
                frm.btnAgregar.Enabled = true;
                frm.txtCantidad.Focus();
            }
            catch
            {

            }
            
        }

        void btnComfirmar_Click(object sender, EventArgs e)
        {
            insertarCompras();
        }

        void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }
        public void agregar()
        {
            try
            {
                if (frm.txtCantidad.Text == "")
                {
                    MessageBox.Show("No dejar campos vacios :(", "error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cantidad = int.Parse(frm.txtCantidad.Text);
                    if(cantidad==0)//verificamos que el valor no sea 0
                    {
                        MessageBox.Show("La cantidad a comprar tiene que ser mayor que 0  :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else
                    {
                        //una ves verificado que todo va bien
                        //pasamos los datos ala tabla detalle
                        obtenerFecha();
                        idproveedor = Convert.ToInt32(frm.cmbProveedor.SelectedValue.ToString());
                        frm.tblAgrega.Rows.Add(idproducto, idproveedor, frm.txtCantidad.Text, frm.txtPreCompra.Text, frm.lblSubtotal.Text, fecha);
                        calSubtotal();//cuando se van ingresando los datos ala tabla detalle atomaticamente se va calculando el subtotal
                        frm.txtCantidad.Enabled = false;
                        frm.btnAgregar.Enabled = false;
                        limpiar();
                        if (frm.tblAgrega.Rows.Count >= 2)//si ya haydatos en la tabla detalle, se habilitara el boton para poder registrar la compra
                        {
                            frm.btnComfirmar.Enabled = true;
                        }
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error al agregar :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
        //este metodo se utiliza para llenar la tabla
        public void llenarTabla()
        {
            try
            {
                frm.tblProductos.DataSource = mtd.mtdllenarProductos();
                if (frm.tblProductos.Rows.Count >= 1)//si hay datos
                {
                    //ocultamos estas dos columnas que no son necsarias para el administrador, pero si se necesitan para realizar otras funciones
                    frm.tblProductos.Columns[0].Visible = false;
                    frm.tblProductos.Columns[3].Visible = false;
                    idproducto = Convert.ToInt32(frm.tblProductos.Rows[0].Cells[0].Value.ToString());
                    frm.txtNombre.Text = frm.tblProductos.Rows[0].Cells[1].Value.ToString();
                    frm.txtPreCompra.Text = frm.tblProductos.Rows[0].Cells[2].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Aú no hay registros :)","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
        //este metodo sirve para ir recorriendo la tabla detalle
        //e ir sumando los subtotales que van hasta el momento
        public void calSubtotal()
        {
            subtotal = 0;
            for (int x = 0; x < frm.tblAgrega.Rows.Count - 1;x++)
            {
                subtotal = subtotal + float.Parse(frm.tblAgrega.Rows[x].Cells[4].Value.ToString());
            }
            frm.lblTotal.Text = subtotal.ToString();
        }
        public void insertarCompras()
        {
            try
            {
                if(validar.mtd_mensaje()==1)
                {
                    //encapsulamos los campos
                    dts.setIdAdmin(idadmin);
                    dts.setTotal(float.Parse(frm.lblTotal.Text));
                    dts.setFecha(fecha);
                    //ejecutamos el metodo para insertar pasandole los datos
                    mtd.mtdInsertarComprasProductos(dts);
                    //este metodo sirve para ir recorriendo la tabla detalle e ir agregando fifla por fila ala base de datos
                    for (int x = 0; x < frm.tblAgrega.Rows.Count - 1; x++)
                    {
                        dts.setIdProducto(Convert.ToInt32(frm.tblAgrega.Rows[x].Cells[0].Value.ToString()));
                        dts.setCantidad(Convert.ToInt32(frm.tblAgrega.Rows[x].Cells[2].Value.ToString()));
                        dts.setIdProveedor(Convert.ToInt32(frm.tblAgrega.Rows[x].Cells[1].Value.ToString()));
                        dts.setPrecio(float.Parse(frm.tblAgrega.Rows[x].Cells[3].Value.ToString()));
                        dts.setSubtotal(float.Parse(frm.tblAgrega.Rows[x].Cells[4].Value.ToString()));
                        dts.setFecha(frm.tblAgrega.Rows[x].Cells[5].Value.ToString());
                        mtd.mtdInsertarComprasDetalle(dts);

                    }
                    MessageBox.Show("Compra realizada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.tblAgrega.Rows.Clear();
                    frm.lblTotal.Text = "0";
                    frm.btnComfirmar.Enabled = false;
                }
                
                
            }
            catch
            {
                MessageBox.Show("Verifique su conexion :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
        public void limpiar()
        {
            frm.txtCantidad.Clear();
            frm.txtNombre.Clear();
            frm.txtPreCompra.Clear();
            frm.lblSubtotal.Text = "0";
        }
    }
}
