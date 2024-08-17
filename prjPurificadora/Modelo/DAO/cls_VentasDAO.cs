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
    class cls_VentasDAO
    {
    
        /*selecciona los clientes de un vendedor esspecifico*/
        public DataTable mtdllenar(cls_VentasVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelClientes("+ dts.getIdVendedor()+");");
        }
        /*selecciona los vendedores activos*/
        public DataTable mtdllenarVendedor()
        {
            return cls_conexion.Instancia().consultas("select * from vsRutas");
        }
        /*consulta los precios del botellon*/
        public DataTable mtdllenarPrecios()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM tblPrecios");
        }
        /*hace una consulta al almacen para verificar la exitencias de los productos*/
        public DataTable mtdllenarExistencia()
        {
            return cls_conexion.Instancia().consultas("SELECT intExistencia FROM tblbotellones");
        }
        /*hace una consulta a la tabla deudas para verificar que vendedor tiene deudas*/
        public DataTable mtdllenarDeudas(cls_VentasVO dts)
        {
            return cls_conexion.Instancia().consultas("SELECT fltDeuda FROM tbldeudas WHERE intIdClienteFK ="+dts.getIdCliente());
        }
        /*hace una consulta a la tabla deudas para verificar que vendedor tiene deudas especiales*/
        public DataTable mtdllenarDeudasEspeciales(cls_VentasVO dts)
        {
            return cls_conexion.Instancia().consultas("SELECT fltDeuda FROM tbldeudasespeciales WHERE intIdClienteFK =" + dts.getIdCliente());
        }

        /*hace la inserccion a la tabla ventas*/
        public void mtdInsertarVentas(cls_VentasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsVentas(" + dts.getTotal() + ",'" + dts.getFecha() + "'" + ");");
        }
        /*hace una las inserciones a la tabla venta detalle*/
        public void mtdInsertarDetalle(cls_VentasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsVenDet(" + dts.getIdCliente() + "," + dts.getIdBote() + "," + dts.getNormal() + "," + dts.getP1()+","+ dts.getMayo1() + "," + dts.getP2()+","+ dts.getMayo2() + "," + dts.getP3()+","+ dts.getSubtotal() + ",'" + dts.getFecha() + "',"+dts.getCantidad()+","+dts.getIdVendedor()+","+dts.getBonificados()+","+dts.getUnidades()+");");
        }
        /*inserta a la tabla deudas*/
        public void mtdInsertarDeudas(cls_VentasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsDeuda(" + dts.getIdVendedor() + "," + dts.getIdCliente() + "," + dts.getDebes() + ",'" + dts.getFecha() + "');");
        }
        /*realiza una actualizacion a la tabla deudas*/
        public void mtdActualizarDeudas(cls_VentasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpDeudasVentas(" + dts.getIdCliente() + "," + dts.getNuevaDeuda() + ",'" + dts.getFecha() + "');");
        }

        /*inserta a la tabla deudas especiales*/
        public void mtdInsertarDeudasEspeciales(cls_VentasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsDeudaEspecial(" + dts.getIdVendedor() + "," + dts.getIdCliente() + "," + dts.getDebes() + ",'" + dts.getFecha() + "');");
        }
        /*realiza una actualizacion a la tabla deudas especiales*/
        public void mtdActualizarDeudasEspeciales(cls_VentasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpDeudasVentasEspeciales(" + dts.getIdCliente() + "," + dts.getNuevaDeuda() + ",'" + dts.getFecha() + "');");
        }

    }
}
