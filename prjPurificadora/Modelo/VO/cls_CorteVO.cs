using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_CorteVO
    {
        private int idvendedor,idsueldo;
        private string fechai, fechaf,fecha;
        private float comision, m1, m2, deuda, bono, despensa, sueldo,salrio;

        public int getIdSueldo()
        {
            return idsueldo;
        }
        public void setiIdSueldo(int _id)
        {
            this.idsueldo = _id;
        }


        public float getSalario() { return salrio; }
        public void setSalario(float _salario) { this.salrio = _salario; }

        public int getIdVendedor(){ return idvendedor; }
        public void setIdVendedor(int _id){ this.idvendedor = _id; }

        public string getFechai() { return fechai; }
        public void setFechai(string _fecha) { this.fechai = _fecha; }

        public string getFechaf() { return fechaf; }
        public void setFechaf(string _fechaf) { this.fechaf = _fechaf; }

        public string getFecha() { return fecha; }
        public void setFecha(string _fecha) { this.fecha = _fecha; }

        public float getComision() { return comision; }
        public void setComision(float _n) { this.comision = _n; }

        public float getM1() { return m1; }
        public void setM1(float _m1) { this.m1 = _m1; }

        public float getM2() { return m2; }
        public void setM2(float _m2) { this.m2 = _m2; }

        public float getDeuda() { return deuda; }
        public void setDeuda(float _deuda) { this.deuda = _deuda; }

        public float getBono() { return bono; }
        public void setBono(float _bono) { this.bono = _bono; }

        public float getDespensa() { return despensa; }
        public void setDespensa(float _despensa) { this.despensa = _despensa; }

        public float getSueldo() { return sueldo; }
        public void setSueldo(float _sueldo) { this.sueldo = _sueldo; }
    }
}
