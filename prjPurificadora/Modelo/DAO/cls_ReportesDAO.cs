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
    class cls_ReportesDAO
    {
        //llenar combo vendedor
        public DataTable mtdllenarVendedor()
        {
            return cls_conexion.Instancia().consultas("select * from vsRutas");
        }
        //llenar reporte de gastos de produccion
        public DataTable mtdllenartabla(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelProduccion('" + dts.getFechai() + "','" + dts.getFechaf() + "');");
        }
        //llenar gastos de admon
        public DataTable mtdllenartablaAdmin(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelReMantenimiento('" + dts.getFechai() + "','" + dts.getFechaf() + "');");
        }

        //llenar gastos extras
        public DataTable mtdllenartablaExtras(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelExtras('" + dts.getFechai() + "','" + dts.getFechaf() + "');");
        }

        //llenar gastos de ruta
        public DataTable mtdllenartablaRuta(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelReRuta('" + dts.getFechai() + "','" + dts.getFechaf() + "');");
        }

        //llenar gastos por ruta especifico
        public DataTable mtdllenartablaRutaEspecifico(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelReRutaEspecifico('" + dts.getFechai() + "','" + dts.getFechaf() + "'," + dts.getIdVendedor()+");");
        }

        //llenar ventas
        public DataTable mtdllenartablaVentas(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelRVentas('" + dts.getFechai() + "','" + dts.getFechaf() + "');");
        }

        //llenar ventas especifico
        public DataTable mtdllenartablaVentasEspecifico(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelRVentasEspecifico('" + dts.getFechai() + "','" + dts.getFechaf() + "'," + dts.getIdVendedor()+");");
        }

        //llenar gastos de ventas
        public DataTable mtdllenarGastosDeVentas(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("SELECT fltGasto FROM tblgastosventas WHERE dtFecha >= '" + dts.getFechai() + "' AND dtFecha <= '" + dts.getFechaf()+"'");
        }

        //llenar nominas empleados falta hacer este con todo y formulario
        public DataTable mtdNominas(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelNominas('"  + dts.getFechai() + "','" + dts.getFechaf() + "');");
        }

        //llenar nominas vendedores
        public DataTable mtdllenartablaNominasVendedores(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelNominaVendedor('" + dts.getFechai() + "','" + dts.getFechaf() + "');");
        }
        
        //llenar compras de botellones
        public DataTable mtdllenartablaBotellonesProd(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM tblCompraBoteDet WHERE dtFecha >= '" + dts.getFechai() + "' AND dtFecha <= '" + dts.getFechaf() + "' AND intIdBoteFK = 1");
        }

        //llenar compras de botellones
        public DataTable mtdllenartablaBotellones(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelRCompras('" + dts.getFechai() + "','" + dts.getFechaf() + "');");
        }
        //llenar sueldo
        public DataTable mtdllenarSueldo(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelSueldoVendedor(" + dts.getIdVendedor() + ",'" + dts.getFecha() + "');");
        }

        //insertar analisis
        public DataTable mtdInsertarAnalisis(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("INSERT INTO tblGastosVentas(intIdVendedorFK,fltGasto,dtFecha)VALUES(" + dts.getIdVendedor() + "," + dts.getGasto() + ",'" + dts.getFecha() + "');");
        }
        //verifica si ya existe el analisis
        public DataTable mtdVerificaAnalisis(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelExiGastosVenta('" + dts.getFecha() + "'," + dts.getIdVendedor() +");");
        }
        //insertar analisis
        public DataTable mtdUpdateAnalisis(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spUpdateGastosVenta(" + dts.getGasto() + "," + dts.getIdGasto() + ");");
        }

        //insertar analisis
        public DataTable selInicialBote(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("SELECT MIN(intInicial) FROM tblControlInventario WHERE intIdBoteFK =" + dts.getIdBote() +"");
        }


        public DataTable insControlInventario(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spInsControlInventario("+dts.getIdBote()+","+dts.getInicial()+");");
        }

        public DataTable selFinalBote(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("SELECT intExistencia FROM tblbotellones WHERE intIdBotePK=" + dts.getIdBote() +"");
        }

        //llenar unidades producidas al año
        public DataTable mtdllenarUnidades(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelUnidades('" + dts.getFechai() + "','" + dts.getFechaf() + "');");
        }

        //obtener precios de sellos y tapones
        public DataTable mtdllenarPreciosSyT()
        {
            return cls_conexion.Instancia().consultas("SELECT fltPrecioCompra FROM tblbotellones WHERE intIdBotePK !=1");
        }

        //obtener precios del botellon
        public DataTable mtdllenarPreciosBotellon()
        {
            return cls_conexion.Instancia().consultas("SELECT fltPrecio FROM tblprecios");
        }


        public DataTable mtdllenarClientes(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelClientes(" + dts.getIdVendedor() + ");");
        }
        /*selecciona los vendedores activos*/
        public DataTable mtdllenarUnidadesClientes(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelVenClientes("+dts.getIdCliente()+",'"+dts.getFechai()+"','"+dts.getFechaf()+"');");
        }



        ////////////////////////reportes de clientes

        public DataTable mtdllenarClientes1(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelClientes(" + dts.getIdVendedor() + ");");
        }
        /*selecciona los vendedores activos*/
        public DataTable mtdllenarUnidadesClientes1(cls_ReporteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelVenClientes(" + dts.getIdCliente() + ",'" + dts.getFechai() + "','" + dts.getFechaf() + "');");
        }

    }
}
