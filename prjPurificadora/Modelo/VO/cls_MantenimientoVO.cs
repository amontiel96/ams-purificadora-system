using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_MantenimientoVO
    {
        private float planta, luz, papeleria, uniformes, otros,total;
        private int idadmin,idmante;
        private string asunto;

        public string getAsunto()
        {
            return asunto;
        }
        public void setAsunto(string _asunto)
        {
            this.asunto = _asunto;
        }

        public int getIdMente()
        {
            return idmante;
        }
        public void setIdMante(int _id)
        {
            this.idmante = _id;
        }

        public float getTotal()
        {
            return total;
        }
        public void setTotal(float _total)
        {
            this.total = _total;
        }


        public int getIdAdmin()
        {
            return idadmin;
        }
        public void setIdAdmin(int _id)
        {
            this.idadmin = _id;
        }

        private string fecha;

        public float getPlanta()
        {
            return planta;
        }
        public void setPlanta(float _planta)
        {
            this.planta = _planta;
        }

        public float getLuz()
        {
            return luz;
        }
        public void setLuz(float _luz)
        {
            this.luz = _luz;
        }
        public float getPapeleria()
        {
            return papeleria;
        }
        public void setPapeleria(float _papeleria)
        {
            this.papeleria = _papeleria;
        }
        public float getUniformes()
        {
            return uniformes;
        }
        public void setUniformes(float _uniformes)
        {
            this.uniformes = _uniformes;
        }
        public float getOtros()
        {
            return otros;
        }
        public void setOtros(float _otros)
        {
            this.otros = _otros;
        }
        public string getFecha()
        {
            return fecha;
        }
        public void setFecha(string _fecha)
        {
            this.fecha = _fecha;
        }
    }
}
