using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_DevolucionesComprasVO
    {
        private int idcompra,cantidad,bote,quitar;
        private string fi, ff;
        private float subtotal;

        public int getBote()
        {
            return bote;
        }
        public void setBote(int _bote)
        {
            this.bote = _bote;
        }
        public int getQuitar()
        {
            return quitar;
        }
        public void setQuitar(int _quitar)
        {
            this.quitar = _quitar;
        }

        public int getId()
        {
            return idcompra;
        }
        public void setId(int _id)
        {
            this.idcompra = _id;
        }

        public int getCantidad()
        {
            return cantidad;
        }
        public void setCantidad(int _canti)
        {
            this.cantidad = _canti;
        }

        public string getFechai()
        {
            return fi;
        }
        public void setFechai(string _fi)
        {
            this.fi = _fi;
        }
        public string getFechaf()
        {
            return ff;
        }
        public void setFechaf(string _ff)
        {
            this.ff = _ff;
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
