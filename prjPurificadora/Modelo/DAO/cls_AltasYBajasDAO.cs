using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Modelo.Conexion;

namespace prjPurificadora.Modelo.DAO
{
    class cls_AltasYBajasDAO
    {
        //llenar botellones
        public DataTable mtdllenarBotellones()
        {
            return cls_conexion.Instancia().consultas("SELECT * FROM vsBotellones");
        }
        /*actualiza las unidades del producto*/
        public void mtdEditaBotellones(cls_AltasYBajasVO dts)
        {
            cls_conexion.Instancia().accion("CALL spUdpAltas_y_Bajas_Bote(" + dts.getId() + "," + dts.getUnidades() + ");");
        }

    }
}
