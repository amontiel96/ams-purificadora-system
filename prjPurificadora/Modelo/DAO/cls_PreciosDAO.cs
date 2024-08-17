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
    class cls_PreciosDAO
    {
        /*consulta los precios del botellon*/
        public DataTable mtdllenarPrecios()
        {
            return cls_conexion.Instancia().consultas("SELECT intIdPrecioPK,intIdBoteFK,fltPrecio AS 'Precio',fltComision AS 'Comision' FROM tblprecios");
        }
        /*actualiza los precios*/
        public void mtdEditar(cls_PreciosVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpPrecios(" + dts.getId() + "," + dts.getPrecio() + "," + dts.getComision() + ");");
        }
    }
}
