using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Vista;
using System.Windows.Forms;

namespace prjPurificadora.Controlador
{
    class cls_CRutas
    {

        frmRutas frm = new frmRutas();
        cls_RutasDAO mtd = new cls_RutasDAO();
        cls_RutasVO dts = new cls_RutasVO();
        Cls_Validaciones validar = new Cls_Validaciones();

        int idRuta;

        public void frm_load()
        {
            frm.btnAgregar.Click += btnAgregar_Click;
            frm.btnEliminar.Click += btnEliminar_Click;
            frm.tblRutas.CellClick += tblRutas_CellClick;
            frm.btnCancelar.Click += btnCancelar_Click;
            frm.txtNombreRuta.TextChanged += txtNombreRuta_TextChanged;
            frm.txtNombreRuta.KeyPress += txtNombreRuta_KeyPress;
            llenaRutas();
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }

        void txtNombreRuta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras_numeros(e);
        }

        void txtNombreRuta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frm.txtNombreRuta.Text == "")
                {
                    frm.btnCancelar.Enabled = false;
                }
                else
                {
                    frm.btnCancelar.Enabled = true;
                }

            }
            catch
            {

            }
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            frm.btnEliminar.Enabled = false;
            frm.txtNombreRuta.Clear();
            frm.btnAgregar.Enabled = true;
        }

        void tblRutas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idRuta = Convert.ToInt32(frm.tblRutas.Rows[frm.tblRutas.CurrentRow.Index].Cells[0].Value.ToString());
                frm.txtNombreRuta.Text = frm.tblRutas.Rows[frm.tblRutas.CurrentRow.Index].Cells[1].Value.ToString();
                frm.btnAgregar.Enabled = false;
                frm.btnEliminar.Enabled = true;
            }
            catch
            {

            }
        }

        void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dts.setId(idRuta);
                if(validar.mtd_mensaje()==1)
                {
                    mtd.mtdEliminar(dts);
                    MessageBox.Show("Accion exitosa :)","Aviso...!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    limpiar();
                    llenaRutas();
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error insperado :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (frm.txtNombreRuta.Text == "")
                {
                    MessageBox.Show("No dejar campo vacio :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Esta seguro de agregar una nueva ruta?", "Responda la pregunta...!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dts.setNombre(frm.txtNombreRuta.Text);
                        mtd.mtdInsertar(dts);
                        MessageBox.Show("Acción exitosa :)", "Aviso...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        llenaRutas();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error inesperado :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void llenaRutas()
        {
            try
            {
                frm.tblRutas.DataSource = mtd.mtdllenar();
                frm.tblRutas.Columns[0].Visible = false;
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta...!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public void limpiar()
        {
            frm.txtNombreRuta.Clear();
            frm.btnAgregar.Enabled = true;
            frm.btnEliminar.Enabled = false;
            frm.btnCancelar.Enabled = false;
        }
    }
}
