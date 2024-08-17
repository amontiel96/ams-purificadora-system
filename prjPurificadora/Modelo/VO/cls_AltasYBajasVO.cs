using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_AltasYBajasVO
    {
        private int id, unidades;

        public int getId()
        {
            return id;
        }
        public void setId(int _id)
        {
            this.id = _id;
        }

        public int getUnidades()
        {
            return unidades;
        }
        public void setUnidades(int _uni)
        {
            this.unidades = _uni;
        }
    }
}
