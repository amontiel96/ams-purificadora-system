using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_ProductosVO
    {
        private string nombre;
        private float precio;
        private int id,existencia,boteInicial,selloInicial,taponInicial;

        public int getBoteI()
        {
            return boteInicial;
        }
        public void setBoteI(int _bi)
        {
            this.boteInicial = _bi;
        }
        public int getSelloI()
        {
            return selloInicial;
        }
        public void setSelloI(int _si)
        {
            this.selloInicial = _si;
        }
        public int getTaponI()
        {
            return taponInicial;
        }
        public void setTaponI(int _ti)
        {
            this.taponInicial = _ti;
        }

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string _nombre)
        {
            this.nombre = _nombre;
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
        public int getExistencia()
        {
            return existencia;
        }
        public void setExistencia(int _existencia)
        {
            this.existencia = _existencia;
        }
    }
}
