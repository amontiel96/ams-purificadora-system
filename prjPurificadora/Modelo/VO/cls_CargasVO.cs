using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_CargasVO
    {
        private int vendedor,idcarga;
        private string fecha;
        private float carga, descarga;

        public int getIdCraga()
        {
            return idcarga;
        }
        public void setIdCarga(int _id)
        {
            this.idcarga = _id;
        }

        public string getFecha()
        {
            return fecha;
        }
        public void setFecha(string _fecha)
        {
            this.fecha = _fecha;
        }

        public float getCarga()
        {
            return carga;
        }
        public void setCarga(float _carga)
        {
            this.carga = _carga;
        }
        public float getDescarga()
        {
            return descarga;
        }
        public void setDescarga(float _descarga)
        {
            this.descarga = _descarga;
        }
        public int getVendedor()
        {
            return vendedor;
        }
        public void setVendedor(int _vendedor)
        {
            this.vendedor = _vendedor;
        }
    }
}
