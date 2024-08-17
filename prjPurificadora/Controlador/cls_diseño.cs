using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Vista;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPurificadora.Controlador
{
    class cls_diseño
    {
        frmDiseño objDiseño = new frmDiseño();
        public void frm_load()
        {
            Application.EnableVisualStyles();
            objDiseño.ShowDialog();
        }
    }
}
