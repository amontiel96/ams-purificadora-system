using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Vista;

namespace prjPurificadora.Controlador
{
    class cls_CInventarioInicial
    {
        frmInventarioInicial frm = new frmInventarioInicial();
        cls_ProductosDAO mtd = new cls_ProductosDAO();
        cls_ProductosVO dts = new cls_ProductosVO();
        Cls_Validaciones validar = new Cls_Validaciones();

        public void frm_load()
        {
            frm.btnComfirmar.Click += btnComfirmar_Click;
            frm.btnCancelar.Click += btnCancelar_Click;
            frm.txtBote.KeyPress += txtBote_KeyPress;
            frm.txtSello.KeyPress += txtSello_KeyPress;
            frm.txtTapon.KeyPress += txtTapon_KeyPress;
            MessageBox.Show("Para poder utilizar el sistema primero tiene que configuar el inventario inicial...","Aviso...!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            frm.ShowDialog();
        }

        void txtTapon_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void txtSello_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void txtBote_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_numeros(e);
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de salir e intentarlo en otro momento???","Responda la pregunta...!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        void btnComfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (frm.txtBote.Text == "" || frm.txtSello.Text == "" || frm.txtTapon.Text == "")
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (frm.txtBote.Text == "0" || frm.txtSello.Text == "0" || frm.txtTapon.Text == "0")
                    {
                        MessageBox.Show("El inventario inicial tiene que ser mayor a 0 :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(validar.mtd_mensaje()==1)
                        {
                            dts.setBoteI(Convert.ToInt32(frm.txtBote.Text));
                            dts.setSelloI(Convert.ToInt32(frm.txtSello.Text));
                            dts.setTaponI(Convert.ToInt32(frm.txtTapon.Text));
                            mtd.mtdActualizaInventarioInicial(dts);
                            MessageBox.Show("Acción exitosa, El sistema se reiniciara para guardar los cambios :)", "Aviso...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Restart();
                            //frm.Close();
                        }
                        
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Se produjo un error inesperado al intentar guardar :(","Alerta...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
