using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_VentasVO
    {
        private int idvendedor, idcliente,idbote,cantidad,unidades;
        private float normal, mayo1, mayo2, subtotal, debes, total, p1, p2, p3,bonificados,nuevaDeuda;
        private string fecha;


        public int getUnidades()
        {
            return unidades;
        }
        public void setUnidades(int _uni)
        {
            this.unidades = _uni;
        }

        public float getNuevaDeuda()
        {
            return nuevaDeuda;
        }
        public void setNuevaDeuda(float _deuda)
        {
            this.nuevaDeuda = _deuda;
        }

        public float getBonificados()
        {
            return this.bonificados;
        }
        public void setBonificados(float _bonificados)
        {
            this.bonificados = _bonificados;
        }

        public float getP1()
        {
            return p1;
        }
        public void setP1(float _p1)
        {
            this.p1 = _p1;
        }
        public float getP2()
        {
            return p2;
        }
        public void setP2(float _p2)
        {
            this.p2 = _p2;
        }
        public float getP3()
        {
            return p3;
        }
        public void setP3(float _p3)
        {
            this.p3 = _p3;
        }

        public int getCantidad()
        {
            return cantidad;
        }
        public void setCantidad(int _cantidad)
        {
            this.cantidad = _cantidad;
        }


        public int getIdBote()
        {
            return idbote;
        }
        public void setIdBote(int _idbote)
        {
            this.idbote = _idbote;
        }

        public float getTotal()
        {
            return total;
        }
        public void setTotal(float _total)
        {
            this.total = _total;
        }

        public string getFecha()
        {
            return fecha;
        }
        public void setFecha(string _fecha)
        {
            this.fecha = _fecha;
        }

        public int getIdVendedor()
        {
            return idvendedor;
        }
        public void setIdVendedor(int _id)
        {
            this.idvendedor = _id;
        }
        public int getIdCliente()
        {
            return idcliente;
        }
        public void setIdCliente(int _idcliente)
        {
            this.idcliente = _idcliente;
        }
        public float getNormal()
        {
            return normal;
        }
        public void setNormal(float _normal)
        {
            this.normal = _normal;
        }
        public float getMayo1()
        {
            return mayo1;
        }
        public void setMayo1(float _m1)
        {
            this.mayo1 = _m1;
        }
        public float getMayo2()
        {
            return mayo2;
        }
        public void setMayo2(float _m2)
        {
            this.mayo2 = _m2;
        }
        public float getSubtotal()
        {
            return subtotal;
        }
        public void setSubtotal(float _subtotal)
        {
            this.subtotal = _subtotal;
        }
        public float getDebes()
        {
            return debes;
        }
        public void setDebes(float _debes)
        {
            this.debes = _debes;
        }

    }
}
