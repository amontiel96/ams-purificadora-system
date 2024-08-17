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
    class cls_ComprasDAO
    {
        //llenar proveedores a un combo
        public DataTable mtdllenarProveedor()
        {
            return cls_conexion.Instancia().consultas("SELECT intIdProveedorPK,vchNombre FROM tblproveedor WHERE intStatus=1");
        }
        //llenarProductos
        public DataTable mtdllenarProductos()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM vsproductos");
        }
        //llenar botellones
        public DataTable mtdllenarBotellones()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM vsbotellones");
        }
        //insertar en compras de botellones
        public void mtdInsertarComprasBote(cls_ComprasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsCompraBote(" + dts.getIdAdmin() + "," + dts.getTotal() + ",'" + dts.getFecha() + "');");
        }
        //compra a detalle de botellones
        public void mtdInsertarComprasBoteDet(cls_ComprasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsCompraBoteDetalle(" + dts.getIdProducto() + "," + dts.getIdProveedor() + "," + dts.getCantidad() + ","+dts.getPrecio()+"," + dts.getSubtotal() + ",'" + dts.getFecha() + "');");
        }
        //insertar en compras productos
        public void mtdInsertarComprasProductos(cls_ComprasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsCompra("+dts.getIdAdmin()+"," + dts.getTotal() + ",'" + dts.getFecha() + "'" + ");");
        }
        //insertar en compras a detalle de los produtos
        public void mtdInsertarComprasDetalle(cls_ComprasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsCompra_det("+ dts.getIdProducto() + "," + dts.getCantidad() + "," + dts.getIdProveedor() + "," + dts.getSubtotal() + ",'" + dts.getFecha() + "',"+dts.getPrecio()+");");
        }
    }
}
