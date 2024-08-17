using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Modelo.Conexion;
using prjPurificadora.Modelo.VO;
using System.Data;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.DAO
{
    class cls_LoginDAO
    {
        /*verifica que exista el usuario*/
        public int verifica(cls_LoginVO dts)
        {
            return cls_conexion.Instancia().existe("SELECT * FROM tbladministrador WHERE vchUsuario = '" + dts.getUser() + "' AND vchPwd = '" + dts.getPwd() + "'");
        }
        /*obtiene el nombre y contraseña del usuario*/
        public DataTable obtener(cls_LoginVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelLogin('" + dts.getUser() + "','" + dts.getPwd() + "');");
        }

    }
}
