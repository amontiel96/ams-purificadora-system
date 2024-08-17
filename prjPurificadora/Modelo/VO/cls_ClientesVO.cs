using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_ClientesVO
    {
        private string nombre,especial;
        private int ruta,id;

        public string getEspecial()
        {
            return especial;
        }
        public void setEspecial(string _especial)
        {
            this.especial = _especial;
        }

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string _nombre)
        {
            this.nombre = _nombre;
        }
        public int getRuta()
        {
            return ruta;
        }
        public void setRuta(int _ruta)
        {
            this.ruta = _ruta;
        }
        public int getId()
        {
            return id;
        }
        public void setId(int _id)
        {
            this.id = _id;
        }
    }
}
