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
    class cls_AbonosDAO
    {
        /*consulta la tabla abonos*/
        public DataTable mtdllenar(cls_AbonosVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelAbonos(" + dts.getIdVendedor()+");");
        }
        /*actualiza una deuda*/
        public void mtdActualizar(cls_AbonosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpDeudas(" + dts.getIdDeuda() +"," + dts.getDeuda() + ",'" + dts.getFecha() + "');");
        }
        /*selecciona a los vendedores activos*/
        public DataTable mtdllenarVendedor()
        {
            return cls_conexion.Instancia().consultas("select * from vsRutas");
        }

        /*consulta la tabla abonos*/
        public DataTable mtdllenarEspeciales()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM vstAbonosEspeciales");
        }
        /*consulta la tabla abonos*/
        public DataTable mtdllenarEspeciales(cls_AbonosVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelAbonos(" + dts.getIdVendedor() + ");");
        }
        /*actualiza una deuda*/
        public void mtdActualizarEspeciales(cls_AbonosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpAbonosDeudas(" + dts.getIdDeuda() + "," + dts.getDeuda() + ",'" + dts.getFecha() + "');");
        }
    }
}
