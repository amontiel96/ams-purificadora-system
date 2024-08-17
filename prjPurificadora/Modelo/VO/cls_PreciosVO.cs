using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_PreciosVO
    {
        private float p1, p2, p3,precio,comision;
        private int id;


        public float getComision()
        {
            return comision;
        }
        public void setComision(float _comision)
        {
            this.comision = _comision;
        }

        public float getPrecio()
        {
            return precio;
        }
        public void setPrecio(float _precio)
        {
            this.precio = _precio;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int _id)
        {
            this.id = _id;
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
    }
}
