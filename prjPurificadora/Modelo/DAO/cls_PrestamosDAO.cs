using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using prjPurificadora.Modelo.Conexion;
using prjPurificadora.Modelo.VO;

namespace prjPurificadora.Modelo.DAO
{
    class cls_PrestamosDAO
    {
        /*consulta a los clientes activos*/
        public DataTable mtdllenarClientes(cls_PrestamosVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelClientes(" + dts.getIdVendedor() + ");");
        }
        /*consulta a la tabla prestamos*/
        public DataTable mtdllenarPrestamos(cls_PrestamosVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelPrestamo(" + dts.getIdCliente() + ");");
        }
        /*selecciona a los vendedores activos*/
        public DataTable mtdllenarVendedor()
        {
            return cls_conexion.Instancia().consultas("select * from vsRutas");
        }
        /*registra un nuevo prestamo*/
        public void mtdInsertar(cls_PrestamosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsPrestamo(" + dts.getIdVendedor() + "," + dts.getPresta() + ",'" + dts.getFecha() + "',"+dts.getIdCliente()+");");
        }
        /*actualiza un prestamo*/
        public void mtdActualizar(cls_PrestamosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpPrestamo(" + dts.getIdPrestamo() + "," + dts.getPendiente() + ",'" + dts.getFecha() + "',"+dts.getQuitar()+","+dts.getRegresa()+");");
        }

    }
}
