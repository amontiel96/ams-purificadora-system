using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class Cls_ProveedorVO
    {
       
        private string strnombre;
        private string strdomicilio;
        private string inttelefono;
        private int id;

        public int getId()
        {
            return id;
        }
        public void setId(int _id)
        {
            this.id = _id;
        }

        public string getNombre()
        {
            return strnombre;
        }

        public void setNombre(string nombre)
        {
            this.strnombre = nombre;
        }

        public string getDomicilio()
        {
            return strdomicilio;
        }
        public void setDomicilio(string domicilio)
        {
            this.strdomicilio = domicilio;
        }

        public string getTelefono()
        {
            return inttelefono;
        }
        public void setTelefono(string telefono)
        {
            this.inttelefono = telefono;
        }


    }
}
