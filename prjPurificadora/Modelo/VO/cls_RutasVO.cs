using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_RutasVO
    {
        private string nombre;
        private int id;

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string _nombre)
        {
            this.nombre = _nombre;
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
