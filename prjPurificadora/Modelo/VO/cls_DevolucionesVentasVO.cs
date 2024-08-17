using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_DevolucionesVentasVO
    {
        private int vendedor, normal, m1, m2,bonificados,unidades,idventa,sumar;
        private float subtotal;
        private string fechai,fechaf;

        public int getSumar()
        {
            return sumar;
        }
        public void setSumar(int _sumar)
        {
            this.sumar = _sumar;
        }

        public int getVendedor()
        {
            return vendedor;
        }
        public void setVendedor(int _vendedor)
        {
            this.vendedor = _vendedor;
        }

        public int getNormal()
        {
            return normal;
        }
        public void setNormal(int _normal)
        {
            this.normal = _normal;
        }

        public int getM1()
        {
            return m1;
        }
        public void setM1(int _m1)
        {
            this.m1 = _m1;
        }

        public int getM2()
        {
            return m2;
        }
        public void setM2(int _m2)
        {
            this.m2 = _m2;
        }

        public int getBonificados()
        {
            return bonificados;
        }
        public void setBonificados(int _boni)
        {
            this.bonificados = _boni;
        }

        public int getUnidades()
        {
            return unidades;
        }
        public void setUnidades(int _uni)
        {
            this.unidades = _uni;
        }

        public int getIdventa()
        {
            return idventa;
        }
        public void setIdVenta(int _idventa)
        {
            this.idventa = _idventa;
        }

        //public float getPn()
        //{
        //    return pn;
        //}
        //public void setPn(float _pn)
        //{
        //    this.pn = _pn;
        //}

        //public float getPm1()
        //{
        //    return pm1;
        //}
        //public void setPm1(float _pm1)
        //{
        //    this.pm1 = _pm1;
        //}

        //public float getPm2()
        //{
        //    return pm2;
        //}
        //public void setPm2(float _pm2)
        //{
        //    this.pm2 = _pm2;
        //}

        public float getSubtotal()
        {
            return subtotal;
        }
        public void setSubtotal(float _subtotal)
        {
            this.subtotal = _subtotal;
        }

        public string getFechai()
        {
            return fechai;
        }
        public void setFechai(string _fecha)
        {
            this.fechai = _fecha;
        }

        public string getFechaf()
        {
            return fechaf;
        }
        public void setFechaf(string _fecha)
        {
            this.fechaf = _fecha;
        }

        
    }
}
