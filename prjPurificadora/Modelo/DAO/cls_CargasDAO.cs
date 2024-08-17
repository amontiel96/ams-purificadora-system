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
    class cls_CargasDAO
    {
        /*registra una nueva carga*/
        public void mtdInsertar(cls_CargasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsCargas(" + dts.getVendedor() + "," + dts.getCarga() + ",'" + dts.getFecha() + "');");
        }
        /*actualiza un registro a la tabla cargas*/
        public void mtdActualizar(cls_CargasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpCargas(" + dts.getIdCraga() + "," + dts.getCarga() + "," + dts.getDescarga() + ",'"+dts.getFecha()+"');");
        }
        /*consulta a la tabla cargas*/
        public DataTable mtdllenar(cls_CargasVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelCargas(" + dts.getVendedor()+");");
        }
        /*selecciona los vendedores activos*/
        public DataTable mtdllenarVendedor()
        {
            return cls_conexion.Instancia().consultas("select * from vsRutas");
        }
    }
}
