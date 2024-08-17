using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using prjPurificadora.Modelo.Conexion;
using prjPurificadora.Modelo.VO;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.DAO
{
    class cls_ExtrasDAO
    {
        /*inserta en la tabla de gastos extras*/
        public void mtdInsertar(cls_ExtrasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsExtras(" + dts.getIdadmin() + ",'" + dts.getAsunto() + "'," + dts.getTotal() + ",'" + dts.getFecha() + "');");
        }
        /*edita un gasto extra*/
        public void mtdEditar(cls_ExtrasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpGastosExtras('" + dts.getAsunto() + "'," + dts.getTotal() + "," + dts.getIdGasto() + ","+dts.getIdadmin()+");");
        }
        /*consulta a la tabla de gastos extras*/
        public DataTable mtdllenar()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM vsGastosExtras");
        }

    }
}
