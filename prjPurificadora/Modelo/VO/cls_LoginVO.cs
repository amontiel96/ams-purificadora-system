using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.VO
{
    class cls_LoginVO
    {
        private string user, pwd;
        private int id;

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
        public int getId()
        {
            return id;
        }
        public void setId(int _id)
        {
            this.id = _id;
        }
    }
}
