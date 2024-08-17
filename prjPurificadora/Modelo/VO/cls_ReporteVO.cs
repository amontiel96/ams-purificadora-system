using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_ReporteVO
    {
        private string fechai, fechaf,fecha;
        private int idvendedor,idbote,inicial,idcliente,idgasto;
        private float gastosventa;


        public int getIdGasto()
        {
            return idgasto;
        }
        public void setIdGasto(int _id)
        {
            this.idgasto = _id;
        }

        public int getIdCliente()
        {
            return idcliente;
        }
        public void setIdCliente(int _id)
        {
            this.idcliente = _id;
        }

        public int getInicial()
        {
            return inicial;
        }
        public void setInicial(int _inicial)
        {
            this.inicial = _inicial;
        }

        public int getIdBote()
        {
            return this.idbote;
        }
        public void setIdBote(int _idbote)
        {
            this.idbote = _idbote;
        }

        public string getFecha()
        {
            return fecha;
        }
        public void setFecha(string _fecha)
        {
            this.fecha = _fecha;
        }

        public float getGasto()
        {
            return gastosventa;
        }
        public void setGasto(float _gasto)
        {
            this.gastosventa = _gasto;
        }

        public string getFechai()
        {
            return fechai;
        }
        public void setFechai(string _fi)
        {
            this.fechai = _fi;
        }
        public string getFechaf()
        {
            return fechaf;
        }
        public void setFechaf(string _ff)
        {
            this.fechaf = _ff;
        }
        public int getIdVendedor()
        {
            return idvendedor;
        }
        public void setIdVendedor(int _id)
        {
            this.idvendedor = _id;
        }
    }
}
