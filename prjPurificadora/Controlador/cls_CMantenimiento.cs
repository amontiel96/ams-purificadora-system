/*en esta clase se registran, actualizan los gastos de mantenimiento*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjPurificadora.Vista;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Modelo.DAO;
using System.Threading.Tasks;

namespace prjPurificadora.Controlador
{
    class cls_CMantenimiento
    {
        frmMantenimiento frm = new frmMantenimiento();
        cls_MantenimientoDAO mtd = new cls_MantenimientoDAO();
        cls_MantenimientoVO dts = new cls_MantenimientoVO();
        Cls_Validaciones validar = new Cls_Validaciones();

        int d, m, a,idmante,idadmin;
        string fecha,id,asunto;
        float planta, luz, papeleria, uniformes, otros,total;

        /*
         d-m-a son para obtener la fecha
         * idmante es el id de regsitro en caso de modificacion
         * idadmin es el id del administrador seleccionado de la tabl q realizo algun registro anterior
         * id es el id del administrador logueado
         * planta es la cantidad q se gasto en planta
         * luz es la cantidad q se gasto en luz
         * papeleria es la cantidad q se gasto en papeleeria
         * uniformes es la cantidad q se gasto en uniformes
         * otros es la cantidad q se gasto en cualquier otra cosa
         * total es la suma de todos los gastos anteriores
         */

        public void frm_load(string idadmin)
        {
            id = idadmin;
            frm.btnRegistrar.Click += btnRegistrar_Click;
            frm.btnNuevo.Click += btnNuevo_Click;
            frm.btnModificar.Click += btnModificar_Click;
            frm.btnSalir.Click += btnSalir_Click;
            frm.btnCancelar.Click += btnCancelar_Click;
            frm.txtUniformes.KeyPress += txtUniformes_KeyPress;
            frm.txtLuz.KeyPress += txtLuz_KeyPress;
            frm.txtOtros.KeyPress += txtOtros_KeyPress;
            frm.txtOtros.TextChanged += txtOtros_TextChanged;
            frm.txtPapeleria.KeyPress += txtPapeleria_KeyPress;
            frm.txtPlanta.KeyPress += txtPlanta_KeyPress;
            frm.txtAsunto.KeyPress += txtAsunto_KeyPress;
            frm.tblMantenimiento.CellClick += tblMantenimiento_CellClick;
            Application.EnableVisualStyles();
            llanartabla();
            frm.ShowDialog();
        }


        void txtAsunto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras(e);
        }

        void txtOtros_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frm.txtOtros.Text == "" || frm.txtOtros.Text == "0")
                {
                    frm.txtAsunto.Enabled = false;
                    frm.txtAsunto.Text = "Sin Asunto";
                }
                else
                {
                    frm.txtAsunto.Enabled = true;
                    frm.txtAsunto.Clear();
                }
            }
            catch
            {

            }
        }

        void txtPlanta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtPlanta.Text,e);
        }

        void txtPapeleria_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtPapeleria.Text,e);
        }

        void txtOtros_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtOtros.Text,e);
        }

        void txtLuz_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtLuz.Text,e);
        }

        void txtUniformes_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtUniformes.Text, e);
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            if(validar.mtd_mensajeCancelar()==1)
            {
                cajas(2);
                botones(2);
                limpiar();
            }
            
        }

        void tblMantenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idmante = Convert.ToInt32(frm.tblMantenimiento.Rows[frm.tblMantenimiento.CurrentRow.Index].Cells[0].Value.ToString());
                idadmin = Convert.ToInt32(frm.tblMantenimiento.Rows[frm.tblMantenimiento.CurrentRow.Index].Cells[1].Value.ToString());
                frm.txtPlanta.Text = frm.tblMantenimiento.Rows[frm.tblMantenimiento.CurrentRow.Index].Cells[2].Value.ToString();
                frm.txtLuz.Text = frm.tblMantenimiento.Rows[frm.tblMantenimiento.CurrentRow.Index].Cells[3].Value.ToString();
                frm.txtPapeleria.Text = frm.tblMantenimiento.Rows[frm.tblMantenimiento.CurrentRow.Index].Cells[4].Value.ToString();
                frm.txtUniformes.Text = frm.tblMantenimiento.Rows[frm.tblMantenimiento.CurrentRow.Index].Cells[5].Value.ToString();
                frm.txtOtros.Text = frm.tblMantenimiento.Rows[frm.tblMantenimiento.CurrentRow.Index].Cells[6].Value.ToString();
                frm.txtAsunto.Text = frm.tblMantenimiento.Rows[frm.tblMantenimiento.CurrentRow.Index].Cells[7].Value.ToString();
                if (frm.txtAsunto.Text != "Sin Asunto")
                {
                    frm.txtAsunto.Enabled = true;
                }
                else
                {
                    frm.txtAsunto.Enabled = false;
                }
                cajas(1);
                botones(3);
            }
            catch
            {

            }
            
            //frm = frm.tblMantenimiento.Rows[frm.tblMantenimiento.CurrentRow.Index].Cells[7].Value.ToString();
        }

        void btnSalir_Click(object sender, EventArgs e)
        {
            frm.Close();
        }

        void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                /*se verifica q todo este bien antes de enviar los datos a la base de datos y no tener conflictos*/
                if (frm.txtLuz.Text == "" || frm.txtOtros.Text == "" || frm.txtPapeleria.Text == "" || frm.txtPlanta.Text == "" || frm.txtUniformes.Text == ""||frm.txtAsunto.Text=="")
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    planta = float.Parse(frm.txtPlanta.Text);
                    luz = float.Parse(frm.txtLuz.Text);
                    papeleria = float.Parse(frm.txtPapeleria.Text);
                    uniformes = float.Parse(frm.txtUniformes.Text);
                    otros = float.Parse(frm.txtOtros.Text);

                    if (luz<=0 && otros <= 0 && papeleria <=0 && planta <=0 && uniformes <=0)
                    {
                        MessageBox.Show("Por lo menos tiene que haber un valor mayor a 0 para registrar :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                       if(validar.mtd_mensaje()==1)
                       {
                           enviar();
                           dts.setIdAdmin(idadmin);
                           dts.setIdMante(idmante);
                           mtd.mtdEditar(dts);
                           MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           llanartabla();
                           cajas(2);
                           botones(2);
                           limpiar();
                       }
                            
                    }

                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error al guardar :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        void btnNuevo_Click(object sender, EventArgs e)
        {
            cajas(1);
            botones(1);
        }

        public void enviar()
        {
            d = frm.dtFecha.Value.Day;
            m = frm.dtFecha.Value.Month;
            a = frm.dtFecha.Value.Year;
            fecha = a + "-" + m + "-" + d;

            dts.setFecha(fecha);
            dts.setLuz(luz);
            dts.setOtros(otros);
            dts.setAsunto(frm.txtAsunto.Text);
            dts.setPapeleria(papeleria);
            dts.setPlanta(planta);
            dts.setUniformes(uniformes);
            total = luz + otros + papeleria + planta + uniformes;
            dts.setTotal(total);
        }

        void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                /*se verifica q todo este bien antes de enviar los datos a la base de datos para no tener conflictos*/
                if (frm.txtLuz.Text == "" || frm.txtOtros.Text == "" || frm.txtPapeleria.Text == "" || frm.txtPlanta.Text == "" || frm.txtUniformes.Text == ""||frm.txtAsunto.Text=="")
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    planta = float.Parse(frm.txtPlanta.Text);
                    luz = float.Parse(frm.txtLuz.Text);
                    papeleria = float.Parse(frm.txtPapeleria.Text);
                    uniformes = float.Parse(frm.txtUniformes.Text);
                    otros = float.Parse(frm.txtOtros.Text);

                    if (luz <= 0 && otros <= 0 && papeleria <= 0 && planta <= 0 && uniformes <= 0)
                    {
                        MessageBox.Show("Por lo menos tiene que haber un valor mayor a 0 para registrar :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (planta < 0 || luz < 0 || papeleria < 0 || uniformes < 0 || otros < 0)
                        {
                            MessageBox.Show("No puede haber cantidades negativas :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if(validar.mtd_mensaje()==1)
                            {
                                enviar();
                                dts.setIdAdmin(Convert.ToInt32(id));
                                mtd.mtdInsertar(dts);
                                MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                llanartabla();
                                cajas(2);
                                botones(2);
                                limpiar();
                            }
                            
                        }
                        
                    }
                   
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error al guardar :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
                

        }



        public void llanartabla()
        {
            try
            {
                frm.tblMantenimiento.DataSource = mtd.mtdllenar();
                frm.tblMantenimiento.Columns[0].Visible = false;
                frm.tblMantenimiento.Columns[1].Visible = false;
                if(!(frm.tblMantenimiento.Rows.Count>=1))
                {
                    MessageBox.Show("Aún noy hay registros :)","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        public void botones(int op)
        {
            switch (op)
            {
                case 1:
                    frm.btnNuevo.Enabled = false;
                    frm.btnRegistrar.Enabled = true;
                    frm.btnModificar.Enabled = false;
                    frm.btnCancelar.Enabled = true;
                    break;
                case 2:
                    frm.btnNuevo.Enabled = true;
                    frm.btnRegistrar.Enabled = false;
                    frm.btnModificar.Enabled = false;
                    frm.btnCancelar.Enabled = false;
                    break;
                case 3:
                    frm.btnNuevo.Enabled = false;
                    frm.btnRegistrar.Enabled = false;
                    frm.btnModificar.Enabled = true;
                    frm.btnCancelar.Enabled = true;
                    break;
            }
        }
        public void cajas(int op)
        {
            switch (op)
            {
                case 1:
                    frm.txtLuz.Enabled = true;
                    frm.txtOtros.Enabled = true;
                    frm.txtPapeleria.Enabled = true;
                    frm.txtPlanta.Enabled = true;
                    frm.txtUniformes.Enabled = true;
                   
                    break;
                case 2:
                    frm.txtLuz.Enabled = false;
                    frm.txtOtros.Enabled = false;
                    frm.txtPapeleria.Enabled = false;
                    frm.txtPlanta.Enabled = false;
                    frm.txtUniformes.Enabled = false;
                    break;
            }
        }

        public void limpiar()
        {
            frm.txtLuz.Text = "0";
            frm.txtOtros.Text = "0";
            frm.txtPapeleria.Text = "0";
            frm.txtPlanta.Text = "0";
            frm.txtUniformes.Text = "0";
            luz = 0;
            otros = 0;
            papeleria = 0;
            planta = 0;
            uniformes = 0;
        }

    }
}
