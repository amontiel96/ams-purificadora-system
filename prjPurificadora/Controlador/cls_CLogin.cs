/*en esta clase se hace la verificacion de acceso al sistema*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Vista;
using System.Windows.Forms;
using prjPurificadora.Controlador;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Modelo.DAO;
using System.Threading.Tasks;

namespace prjPurificadora.Controlador
{
   
    class cls_CLogin
    {
        frmLogin frm = new frmLogin();
        cls_LoginDAO mtd = new cls_LoginDAO();
        cls_LoginVO dts = new cls_LoginVO();
        Cls_Validaciones validar = new Cls_Validaciones();

        public void frm_load()
        {
            frm.btnIniciar.Click += btnIniciar_Click;
            frm.btnSalir.Click += btnSalir_Click;
            frm.btnConfig.Click += btnConfig_Click;
            frm.txtPwd.KeyPress += txtPwd_KeyPress;
            frm.txtUser.KeyPress += txtUser_KeyPress;
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }

        void btnConfig_Click(object sender, EventArgs e)
        {
            cls_CDtsConexion f = new cls_CDtsConexion();
            f.frm_load();
        }

        void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras_numeros(e);
        }

        void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras_numeros(e);
        }

        void btnSalir_Click(object sender, EventArgs e)
        {
            frm.Dispose();
        }

        void btnIniciar_Click(object sender, EventArgs e)/*se verifica la existencia del usaurio y contraseña para poder ingresar al sistema y tambien se obtiene su id para posteriormente utilizarlo en otros mudulos*/
        {
            try
            {
                if (frm.txtPwd.Text == "" || frm.txtUser.Text == "")
                {
                    MessageBox.Show("Ingrese datos :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dts.setUser(frm.txtUser.Text);
                    dts.setPwd(frm.txtPwd.Text);

                    if (mtd.verifica(dts) == 1)
                    {
                        frm.tblUser.DataSource = mtd.obtener(dts);
                        MessageBox.Show("Acceso concedido...", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Controlador.cls_CPrincipal menu = new Controlador.cls_CPrincipal();
                        frm.Hide();
                        menu.frm_load(frm.tblUser.Rows[0].Cells[2].Value.ToString(), frm.tblUser.Rows[0].Cells[3].Value.ToString(),frm.tblUser.Rows[0].Cells[0].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Error de user o contraseña Ó verifica tu conexion :(...", "Verifica tus datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                
            }
            catch
            {
                MessageBox.Show("Verifica tu conexionnnn :(", "Alerta...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                    
        }

    }
}
