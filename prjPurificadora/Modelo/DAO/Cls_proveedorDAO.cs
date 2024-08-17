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
    class Cls_proveedorDAO
    {
        /*registra un nuevo proveedor*/
        public void MTD_InsertarProveedor(Cls_ProveedorVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsProveedor('" + dts.getNombre() + "','" + dts.getDomicilio() + "','" + dts.getTelefono() + "');");
        }
        /*edita un proveedor*/
        public void MTD_EditarProveedor(Cls_ProveedorVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUpdProveedor(" + dts.getId() + ",'" + dts.getNombre() + "','" + dts.getDomicilio() + "','" + dts.getTelefono() + "');");
        }
        /*elimina un proveedor*/
        public void MTD_EliminarProveedor(Cls_ProveedorVO dts)
        {
            cls_conexion.Instancia().accion("CALL spDelProveedor(" + dts.getId() + ");");     
        }
        /*consulta a los proveedores*/
        public DataTable MTD_LlenarData()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM vsProvedoores");
        }
        /*cosnulta una busqueda de un proveedor*/
        public DataTable MTD_buscar(Cls_ProveedorVO dts)
        {
            return cls_conexion.Instancia().consultas("SELECT intIdProveedorPK AS 'No.Registro', vchNombre AS 'Nombre',vchDomicilio AS 'Domicilio',vchTelefono AS 'Telefono',intStatus AS 'Status' FROM tblproveedor WHERE intIdProveedorPK LIKE '%" + dts.getId() + "%' OR vchNombre LIKE '%" + dts.getNombre() + "%' AND intStatus=1");
        }
        
    }
}
