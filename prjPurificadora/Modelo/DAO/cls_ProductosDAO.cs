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
    class cls_ProductosDAO
    {
        //llenarProductos
        public DataTable mtdllenarProductos()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM vsProductos");
        }
        //llenar botellones
        public DataTable mtdllenarBotellones()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM vsBotellones");
        }
        /*edita botellones*/
        public void mtdEditaBotellones(cls_ProductosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpBotellones('" + dts.getNombre() + "'," + dts.getPrecio() + ","+dts.getId()+");");
        }



        //insertar en productos
        public void mtdInsertarProductos(cls_ProductosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsProductos('" + dts.getNombre() + "'," + dts.getPrecio() +  ");");
        }
        /*edita productos*/
        public void mtdEditaProductos(cls_ProductosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpProductos('" + dts.getNombre() + "'," + dts.getPrecio() + "," + dts.getId() + ");");
        }
        /*elimina productos*/
        public void mtdEliminaProductos(cls_ProductosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spDelProductos("+ dts.getId()+");");
        }

        //insertar en compras productos
        public void mtdInsertarBotellones(cls_ProductosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsBotellon('" + dts.getNombre() + "'," + dts.getExistencia() + "," + dts.getPrecio()  + ");");
        }



        /*inventario inicial*/
        /*actualiza el inventario inicial*/
        public void mtdActualizaInventarioInicial(cls_ProductosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpInventarioInicial(" + dts.getBoteI() + "," + dts.getSelloI() + "," + dts.getTaponI() + ");");
        }

        //verifica el inventario inicial
        public DataTable mtdVerificaInventarioInicial()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM vstVerificaInventarioInicial");
        }
    }
}
