using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Modelo.Conexion;

namespace prjPurificadora.Modelo.DAO
{
    class cls_DevolucionesComprasDAO
    {
        /*selecciona las compras de la venta a detalle*/
        public DataTable mtdllenartabla(cls_DevolucionesComprasVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelDevCompras('" + dts.getFechai() + "','" + dts.getFechaf() + "');");
        }
        /*actualiza la compra a detalle*/
        public void mtdActualizarCompra(cls_DevolucionesComprasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpComBoteDet(" + dts.getId() + "," + dts.getCantidad() + "," + dts.getSubtotal() + ","+dts.getQuitar()+","+dts.getBote()+");");
        }
    }
}
