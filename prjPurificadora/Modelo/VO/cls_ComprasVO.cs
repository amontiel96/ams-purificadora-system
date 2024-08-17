using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_ComprasVO
    {
        private int idadmin, idproveedor, idproducto, cantidad;
        private float subtotal, total,precio;
        private string fecha;

        public float getPrecio()
        {
            return precio;
        }
        public void setPrecio(float _precio)
        {
            this.precio = _precio;
        }

        public int getIdAdmin()
        {
            return idadmin;
        }
        public void setIdAdmin(int _id)
        {
            this.idadmin = _id;
        }
        public int getIdProveedor()
        {
            return idproveedor;
        }
        public void setIdProveedor(int _id)
        {
            this.idproveedor = _id;
        }
        public int getIdProducto()
        {
            return idproducto;
        }
        public void setIdProducto(int _id)
        {
            this.idproducto = _id;
        }
        public int getCantidad()
        {
            return cantidad;
        }
        public void setCantidad(int _cantidad)
        {
            this.cantidad = _cantidad;
        }
        public string getFecha()
        {
            return fecha;
        }
        public void setFecha(string _fecha)
        {
            this.fecha = _fecha;
        }
        public float getTotal()
        {
            return total;
        }
        public void setTotal(float _total)
        {
            this.total = _total;
        }
        public float getSubtotal()
        {
            return subtotal;
        }
        public void setSubtotal(float _subtotal)
        {
            this.subtotal = _subtotal;
        }
    }
}
