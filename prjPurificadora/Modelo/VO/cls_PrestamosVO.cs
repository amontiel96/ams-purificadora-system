using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_PrestamosVO
    {
        private int idvendedor, idprestamo,idcliente,presta,regresa,pendiente,quitar;
        private string fecha;

        public int getQuitar()
        {
            return quitar;
        }
        public void setQuitar(int _quitar)
        {
            this.quitar = _quitar;
        }

        public int getIdCliente()
        {
            return idcliente;
        }
        public void setIdCliente(int _id)
        {
            this.idcliente = _id;
        }

        public int getPendiente()
        {
            return pendiente;
        }
        public void setPendiente(int _pendiente)
        {
            this.pendiente = _pendiente;
        }

        public int getIdVendedor()
        {
            return idvendedor;
        }
        public void setIdVendedor(int _id)
        {
            this.idvendedor = _id;
        }

        public int getIdPrestamo()
        {
            return idprestamo;
        }
        public void setIdPrestamo(int _id)
        {
            this.idprestamo = _id;
        }

        public int getPresta()
        {
            return presta;
        }
        public void setPresta(int _presta)
        {
            this.presta = _presta;
        }

        public int getRegresa()
        {
            return regresa;
        }
        public void setRegresa(int _resgresa)
        {
            this.regresa = _resgresa;
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
