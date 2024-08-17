using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Modelo.Conexion;
using prjPurificadora.Modelo.VO;
using System.Threading.Tasks;
using System.Data;

namespace prjPurificadora.Modelo.DAO
{
    class cls_MantenimientoDAO
    {
        /*registra un nuevo gasto de mantenimiento*/
        public void mtdInsertar(cls_MantenimientoVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsMantenimiento(" + dts.getIdAdmin() + "," + dts.getPlanta() + "," + dts.getLuz() + ","+dts.getPapeleria()+","+dts.getUniformes()+","+dts.getOtros()+",'"+dts.getAsunto()+"','"+dts.getFecha()+"',"+dts.getTotal()+");");
        }
        /*edita un gasto de mantenimiento*/
        public void mtdEditar(cls_MantenimientoVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpMantenimiento(" + dts.getPlanta() + "," + dts.getLuz() + "," + dts.getPapeleria() + "," + dts.getUniformes() + "," + dts.getOtros() + "," + dts.getTotal() + "," + dts.getIdMente() + "," + dts.getIdAdmin() + ",'"+dts.getAsunto()+"');");
        }
        /*consulta a los gastos de mantenimiento*/
        public DataTable mtdllenar()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM vsMantenimiento");
        }
    }
}
