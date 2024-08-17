using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_AbonosVO
    {
        private int idvendedor,idcliente,iddeuda;
        private float deuda;
        private string fecha;


        public int getIdDeuda()
        {
            return iddeuda;
        }
        public void setIdDeuda(int _id)
        {
            this.iddeuda = _id;
        }

        public int getIdCliente()
        {
            return idcliente;
        }
        public void setIdCliente(int _idc)
        {
            this.idcliente = _idc;
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
        public float getDeuda()
        {
            return deuda;
        }
        public void setDeuda(float _deuda)
        {
            this.deuda = _deuda;
        }
    }
}
