using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjPurificadora.Modelo.Conexion;
using prjPurificadora.Modelo.VO;
using System.Data;
namespace prjPurificadora.Modelo.DAO
{
    class cls_RutasDAO
    {
        /*consulta la tabla rutas*/
        public DataTable mtdllenar()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM vstRutas;");
        }
        /*consulta el ultimo id registrado*/
        public DataTable mtdObtenerId()
        {
            return cls_conexion.Instancia().consultas("SELECT MAX(intIdRutaPK) FROM tblrutas WHERE intStatus=1;");
        }
        /*elimina rutas*/
        public void mtdEliminar(cls_RutasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spDelRutas("+ dts.getId()+");");
        }
        /*registra ruta*/
        public DataTable mtdInsertar(cls_RutasVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spInsRuta('"+dts.getNombre()+"');");
        }
    }
}
