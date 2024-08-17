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
    class cls_ClientesDAO
    {
        /*inserta un nuevo cliente*/
        public void mtdInsertar(cls_ClientesVO dts)
        {
            cls_conexion.Instancia().accion("CALL spInsCliente('" + dts.getNombre() + "'," + dts.getRuta() + ",'"+dts.getEspecial()+"');");
        }
        /*edita a un cliente*/
        public void mtdEditar(cls_ClientesVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpClientes(" + dts.getId() + ",'" + dts.getNombre() + "',"+dts.getRuta()+",'"+dts.getEspecial()+"');");
        }
        /*elimina a los clientes*/
        public void mtdEliminar(cls_ClientesVO dts)
        {
            cls_conexion.Instancia().accion("CALL spDelClientes(" + dts.getId() + ");");
        }
        /*consulta a los clientes activos*/
        public DataTable mtdllenaTabla()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM vsClientes");
        }
        /*Selecciona las rutas*/
        public DataTable mtdllenaRuta()
        {
            return cls_conexion.Instancia().consultas("SELECT intIdRutaPK,vchNombre FROM tblRutas WHERE intStatus =1");
        }
        /*busca un cliente*/
        public DataTable MTD_buscar(cls_ClientesVO dts)
        {
            return cls_conexion.Instancia().consultas("SELECT intIdClientePK,vchNombre AS 'Nombre', intIdRutaFK AS 'Ruta',intStatus FROM tblclientes WHERE intIdClientePK LIKE '%" + dts.getId() + "%' OR vchNombre LIKE '%" + dts.getNombre() + "%' AND intStatus=1");
        }

    }
}
