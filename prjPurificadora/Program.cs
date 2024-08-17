using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPurificadora
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Controlador.cls_CSplash obj = new Controlador.cls_CSplash();
            obj.frm_load();
        }
    }
}
