/*esta clase es para inicializar el splas de presentacion del sistema*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Vista;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace prjPurificadora.Controlador
{
    class cls_CSplash
    {
        frmSplash splas = new frmSplash();
        int contador = 0;
        /*
         contador es para definir hasta cuando se va a detener el splash
         */
        public void frm_load()
        {

            splas.timer1.Tick += timer1_Tick;
            splas.timer1.Start();
            Application.EnableVisualStyles();
            splas.ShowDialog();
            
           
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (splas.progressBar1.Value < 100)
            {
                contador = contador + 25;
                splas.progressBar1.Value = contador;
            }
            else
            {
                splas.Hide();
                splas.timer1.Enabled = false;
                Controlador.cls_CLogin login = new Controlador.cls_CLogin();
                login.frm_load();
                
            }
        }

    }
}
