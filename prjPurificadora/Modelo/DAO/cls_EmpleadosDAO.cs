using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Modelo.Conexion;
using System.Threading.Tasks;
using System.Data;

namespace prjPurificadora.Modelo.DAO
{
    class cls_EmpleadosDAO
    {
        /*registra un nuevo empleado*/
        public void mtdInsertar(cls_EmpleadosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsEmpleado('" + dts.getNombre() + "','" + dts.getAp() + "','" + dts.getAm() + "','" + dts.getDomicilio() + "','" + dts.getCurp() + "','" + dts.getIdTipo() + "','" + dts.getSalario() + "');");
        }
        /*actualiza un empleado*/
        public void mtdEditarEmpleado(cls_EmpleadosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpEmpleados('" + dts.getNombre() + "','" + dts.getAp() + "','" + dts.getAm() + "','" + dts.getDomicilio() + "','" + dts.getCurp() + "'," + dts.getSalario() + ","+dts.getIdDato()+");");
        }
        /*elimina un empeado*/
        public void mtdEliminarEmpleado(cls_EmpleadosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spDelEmpleados("+ dts.getIdDato() + ");");
        }
        /*registra a un aadministrador*/
        public void mtdInsertarAdmin(cls_EmpleadosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsAdmin('" + dts.getNombre() + "','" + dts.getAp() + "','" + dts.getAm() + "','" + dts.getDomicilio() + "','" + dts.getCurp() + "','" + dts.getIdTipo() +"','"+dts.getUser()+"','"+dts.getPwd()+ "');");
        }
        /*actualiza los datos de un administrador*/
        public void mtdEditarAdmin(cls_EmpleadosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpAdministrador('" + dts.getNombre() + "','" + dts.getAp() + "','" + dts.getAm() + "','" + dts.getDomicilio() + "','" + dts.getCurp() + "','" + dts.getUser() + "','" + dts.getPwd() + "',"+dts.getIdDato()+");");
        }
        /*registra un nuevo vendedor*/
        public void mtdInsertarVendedor(cls_EmpleadosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsVendedor('" + dts.getNombre() + "','" + dts.getAp() + "','" + dts.getAm() + "','" + dts.getDomicilio() + "','" + dts.getCurp() + "'," + dts.getIdTipo() + ","+dts.getIdRuta()+");");
        }
        /*actualiza los datos de un vendedor*/
        public void mtdEditarVendedor(cls_EmpleadosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpVendedor('" + dts.getNombre() + "','" + dts.getAp() + "','" + dts.getAm() + "','" + dts.getDomicilio() + "','" + dts.getCurp() + "'," + dts.getIdDato() + ","+dts.getIdRuta()+");");
        }
        /**/
        public DataTable mtdllenaRuta()
        {
            return cls_conexion.Instancia().consultas("SELECT intIdRutaPK,vchNombre FROM tblRutas WHERE intStatus =1");
        }
        /*selecciona los tipos de usuario*/
        public DataTable mtdLLenarCombo()
        {
            return cls_conexion.Instancia().consultas("select * from tbltipouser");
        }
        /*selecciona a los empleados activos*/
        public DataTable mtdLLenaTablaEmpleado()
        {
            return cls_conexion.Instancia().consultas("select * from vstEmpleados");
        }
        /*selecciona a los administradores activos*/
        public DataTable mtdLLenaTablaAdmin()
        {
            return cls_conexion.Instancia().consultas("select * from vstAdmin");
        }
        //carga admin tienda
        public DataTable mtdLLenaTablaAdminSucursal()
        {
            return cls_conexion.Instancia().consultas("select * from vstEmplAdmin");
        }
        /*selecciona a los vendedores activos*/
        public DataTable mtdLLenaTablaVendedor()
        {
            return cls_conexion.Instancia().consultas("select * from vstVendedores");
        }
        /*seleciona a los supervisores*/
        public DataTable mtdLLenaTablaSupervisor()
        {
            return cls_conexion.Instancia().consultas("select * from vstSupervisor");
        }
        /*selecciona a los empleados de produccion*/
        public DataTable mtdLLenaTablaProduccion()
        {
            return cls_conexion.Instancia().consultas("select * from vstEplProduccion");
        }
        /*selecciona a los ayudantes*/
        public DataTable mtdLLenaTablaAyudante()
        {
            return cls_conexion.Instancia().consultas("select * from vstAyudante");
        }
        /*selecciona a los veladores*/
        public DataTable mtdLLenaTablaVelador()
        {
            return cls_conexion.Instancia().consultas("select * from vstVelador");
        }
    
    }
    
}
