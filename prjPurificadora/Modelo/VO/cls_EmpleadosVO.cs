using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_EmpleadosVO
    {
        private string nombre, ap, am, domicilio, curp,user,pwd;
        private int idtipo,idruta,iddato;
        private float salario;

        public int getIdDato()
        {
            return iddato;
        }
        public void setIdDato(int _id)
        {
            this.iddato = _id;
        }

        public int getIdRuta()
        {
            return idruta;
        }
        public void setIdRuta(int _idruta)
        {
            this.idruta = _idruta;
        }

        public string getUser()
        {
            return user;
        }
        public void setUser(string _user)
        {
            this.user = _user;
        }
        public string getPwd()
        {
            return pwd;
        }
        public void setPwd(string _pwd)
        {
            this.pwd = _pwd;
        }


        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getAp()
        {
            return ap;
        }
        public void setAp(string _ap)
        {
            this.ap = _ap;
        }
        public string getAm()
        {
            return am;
        }
        public void setAm(string _am)
        {
            this.am = _am;
        }
        public string getDomicilio()
        {
            return domicilio;
        }
        public void setDomicilio(string _domicilio)
        {
            this.domicilio = _domicilio;
        }
        public string getCurp()
        {
            return curp;
        }
        public void setCurp(string _curp)
        {
            this.curp = _curp;
        }
        public int getIdTipo()
        {
            return idtipo;
        }
        public void setIdTipo(int _id)
        {
            this.idtipo = _id;
        }
        public float getSalario()
        {
            return salario;
        }
        public void setSalario(float _salario)
        {
            this.salario = _salario;
        }

    }
}
