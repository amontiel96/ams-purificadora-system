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
    class cls_GastosRutaDAO
    {
        /*registra un nuevo gasto de ruta*/
        public void mtdInsertar(cls_GastosRutaVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsGastosRuta(" + dts.getIdVendedor() + "," + dts.getGasolina() + "," + dts.getRefaccionaria() + "," + dts.getMante() + ",'"+dts.getFecha()+"');");
        }
        /*edita un gasto de ruta*/
        public void mtdEditar(cls_GastosRutaVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpGastosRuta("+dts.getGasolina() + "," + dts.getRefaccionaria() + "," + dts.getMante() + "," + dts.getIdGasto() + ","+dts.getIdVendedor()+");");
        }
        /*llena una busqueda de gastos de ruta de un vendedor especifico*/
        public DataTable mtdllenarBusqueda(cls_GastosRutaVO dts)
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM tblgastosruta WHERE intIdVendedorFK="+dts.getIdVendedor());
        }
        /*selecciona a los vendedores activos*/
        public DataTable mtdllenarVendedor()
        {
            return cls_conexion.Instancia().consultas("select * from vsRutas");
        }
        /*consulta a la tabla de gastos de ruta*/
        public DataTable mtdllenartabla()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM vsGastosRuta");
        }
    }
}
