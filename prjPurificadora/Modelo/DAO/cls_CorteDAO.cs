using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Modelo.Conexion;
using System.Threading.Tasks;

namespace prjPurificadora.Modelo.DAO
{
    class cls_CorteDAO
    {
        /*---------------------procedimientos para los puros vendedores-------------*/
        
        /*selecciona los vendedores activos*/
        public DataTable mtdllenarVendedor()
        {
            return cls_conexion.Instancia().consultas("select * from vsRutas");
        }
        /*selecciona las ventas realizadas de un vendedor*/
        public DataTable mtdllenartabla(cls_CorteVO dts)
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM tblven_det WHERE intIdVendedorFK ="+dts.getIdVendedor()+" AND dtFecha >= '"+dts.getFechai()+"' AND dtFecha <= '"+dts.getFechaf()+"'");
        }
        /*selecciona las deudas que tenga algun vendedor*/
        public DataTable mtdObtenerDeuda(cls_CorteVO dts)
        {
            return cls_conexion.Instancia().consultas("SELECT fltDeuda FROM tbldeudas WHERE intIdVendedorFK =" + dts.getIdVendedor());
        }
        /*consulta los precios del botellon*/
        public DataTable mtdllenarPrecios()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM tblPrecios");
        }
        /*registra sueldo de los vendedores*/
        public void mtdInsertarSueldo(cls_CorteVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsSueldo(" + dts.getComision() + "," + dts.getDeuda() + "," + dts.getBono() +","+dts.getDespensa()+","+dts.getSueldo()+",'"+dts.getFecha()+ "',"+dts.getIdVendedor()+");");
        }


        public DataTable mtdVerificaSueldo(cls_CorteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelExisteSueldo(" + dts.getIdVendedor()+",'"+dts.getFecha()+"');");
        }
        public void mtdUpdateVendedor(cls_CorteVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpSueldoVendedor(" + dts.getComision() + "," + dts.getDeuda() + "," + dts.getBono() + "," + dts.getDespensa() + "," + dts.getSueldo() + "," + dts.getIdSueldo() + ");");
        }

        /*----------------------------procedimiento para el corte de caja de los puros empleados-------------------*/


        /*cnsulta a los empleados*/
        public DataTable mtdllenarTablaEmpleados()
        {
            return cls_conexion.Instancia().consultas("select * from vstEmpleados");
        }

        //insertar sueldo empleados
        public void mtdInsertarSueldoEmpleados(cls_CorteVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsSueldoEmpleados(" + dts.getSalario() + "," + 0 + "," + dts.getDeuda() + "," + dts.getBono() + "," + dts.getDespensa() + "," + dts.getSueldo() + ",'" + dts.getFecha() + "'," + dts.getIdVendedor() + ");");
        }

        public void mtdUpdateEmpleado(cls_CorteVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpSueldoEmpleado(" + dts.getSalario() + "," + dts.getDeuda() + "," + dts.getBono() + "," + dts.getDespensa() + "," + dts.getSueldo() + "," + dts.getIdSueldo() + ");");
        }
        public DataTable mtdVerificaSueldoEmpleado(cls_CorteVO dts)
        {
            return cls_conexion.Instancia().consultas("CALL spSelExisteSueldoEmpleado(" + dts.getIdVendedor() + ",'" + dts.getFecha() + "');");
        }
    }
}
