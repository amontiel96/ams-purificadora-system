using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_ExtrasVO
    {
        private string asunto, fecha;
        private float total;
        private int idadmin,idgasto;


        public int getIdGasto()
        {
            return idgasto;
        }
        public void setIdGasto(int _id)
        {
            this.idgasto = _id;
        }

        public int getIdadmin()
        {
            return idadmin;
        }

        public void setIdadmin(int _id)
        {
            this.idadmin = _id;
        }
        public string getAsunto()
        {
            return asunto;
        }
        public void setAsunto(string _asunto)
        {
            this.asunto = _asunto;
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


    }
}
