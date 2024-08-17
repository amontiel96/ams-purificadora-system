using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_GastosRutaVO
    {
        private int vendedor,idgasto;
        private float gasolina, refaccionaria, mantenimiento;
        private string fecha;

        public int getIdGasto()
        {
            return idgasto;
        }
        public void setIdgasto(int _id)
        {
            this.idgasto = _id;
        }

        public int getIdVendedor()
        {
            return vendedor;
        }
        public void setIdVendedor(int _id)
        {
            this.vendedor = _id;
        }
        public float getGasolina()
        {
            return gasolina;
        }
        public void setGasolina(float _gas)
        {
            this.gasolina = _gas;
        }
        public float getRefaccionaria()
        {
            return refaccionaria;
        }
        public void setRefaccionaria(float _refaccionaria)
        {
            this.refaccionaria = _refaccionaria;
        }
        public float getMante()
        {
            return mantenimiento;
        }
        public void setMante(float _mante)
        {
            this.mantenimiento = _mante;
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
