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
    class cls_DevolucionesVentasDAO
    {
        /*selecciona a los vendedores activos*/
        public DataTable mtdllenarVendedor()
        {
            return cls_conexion.Instancia().consultas("select * from vsRutas");
        }
        /*selecciona las ventas de la venta a detalle de un vendedor especifico*/
        public DataTable mtdllenartabla(cls_DevolucionesVentasVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelVenDetDevoluciones("+dts.getVendedor()+ ",'"+ dts.getFechai() + "','" + dts.getFechaf() + "');");
        }
        /*actualiza la venta a detalle*/
        public void mtdActualizarVentaDet(cls_DevolucionesVentasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpVenDetDevoluciones(" + dts.getIdventa() + "," + dts.getNormal() + "," + dts.getM1() + ","+dts.getM2()+","+dts.getBonificados()+","+dts.getUnidades()+","+dts.getSubtotal()+","+dts.getSumar()+");");
        }
    }
}
