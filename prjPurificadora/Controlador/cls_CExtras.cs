/*en esta clase se registra los gastos extras de la empresa*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Modelo.VO;
using prjPurificadora.Modelo.DAO;
using prjPurificadora.Vista;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPurificadora.Controlador
{
    class cls_CExtras
    {
        frmGastosExtras frm = new frmGastosExtras();
        cls_ExtrasDAO mtd = new cls_ExtrasDAO();
        cls_ExtrasVO dts = new cls_ExtrasVO();
        Cls_Validaciones validar = new Cls_Validaciones();



        int d, m, a,idgasto,idadmin;
        string fecha, id;
        float total;
        /*
         d-m-a son para obtener la fecha
         * idgasto es para obener el registro de gastos en caso de modificar el registro
         * idadmin es el id del administrador q registro un gasto anteriormente
         * id es para recibir el id del administrador a registra el gasto
         * total es la suma total del gasto
         */

        public void frm_load(string _id)
        {
            id = _id;
            frm.btnRegistrar.Click += btnRegistrar_Click;
            frm.btnCancelar.Click += btnCancelar_Click;
            frm.btnNuevo.Click += btnNuevo_Click;
            frm.btnSalir.Click += btnSalir_Click;
            frm.txtTotal.KeyPress += txtTotal_KeyPress;
            frm.txtAsunto.KeyPress += txtAsunto_KeyPress;
            frm.tblGastosExtras.CellClick += tblGastosExtras_CellClick;
            frm.btnModifcar.Click += btnModifcar_Click;
            Application.EnableVisualStyles();
            llenatabla();
            frm.ShowDialog();
        }

        void txtAsunto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras(e);
        }

        void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_numero_con_decimal(frm.txtTotal.Text,e);
        }

        void btnModifcar_Click(object sender, EventArgs e)
        {
            try
            {
                /*aqui primero se va verificando q todo este bien antes de enviar los ddatos a la base de datos*/
                if (frm.txtAsunto.Text == "" || frm.txtTotal.Text == "")
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    total = float.Parse(frm.txtTotal.Text);
                    if (total <= 0)
                    {
                        MessageBox.Show("El total no puede ser menor ó igual a 0  :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(validar.mtd_mensaje()==1)
                        {
                            enviar();
                            dts.setIdGasto(idgasto);
                            dts.setIdadmin(idadmin);
                            mtd.mtdEditar(dts);
                            MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            llenatabla();
                            botones(2);
                            cajas(2);
                            limpiar();
                        }
                        
                    }

                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error al intentar guardar :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void tblGastosExtras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idgasto = Convert.ToInt32(frm.tblGastosExtras.Rows[frm.tblGastosExtras.CurrentRow.Index].Cells[0].Value.ToString());
                idadmin = Convert.ToInt32(frm.tblGastosExtras.Rows[frm.tblGastosExtras.CurrentRow.Index].Cells[1].Value.ToString());
                frm.txtAsunto.Text = frm.tblGastosExtras.Rows[frm.tblGastosExtras.CurrentRow.Index].Cells[2].Value.ToString();
                frm.txtTotal.Text = frm.tblGastosExtras.Rows[frm.tblGastosExtras.CurrentRow.Index].Cells[3].Value.ToString();
                cajas(1);
                botones(3);
            }
            catch
            {

            }

            
            
        }


        void btnSalir_Click(object sender, EventArgs e)
        {
            frm.Close();
            frm.Dispose();
        }

        void btnNuevo_Click(object sender, EventArgs e)
        {
            botones(1);
            cajas(1);
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            if(validar.mtd_mensajeCancelar()==1)
            {
                botones(2);
                cajas(2);
                limpiar();
            }
            
        }
        public void enviar()
        {
            d = frm.dtFecha.Value.Day;
            m = frm.dtFecha.Value.Month;
            a = frm.dtFecha.Value.Year;
            fecha = a + "-" + m + "-" + d;
            dts.setAsunto(frm.txtAsunto.Text);
            dts.setFecha(fecha);
            dts.setTotal(total);
        }

        void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                /*primero se va verificando q todo este bien entes de enviar los datos a la base de datos para no tener conflictos*/
                if (frm.txtAsunto.Text == "" || frm.txtTotal.Text == "")
                {
                    MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                        total = float.Parse(frm.txtTotal.Text);
                        if (total <= 0)
                        {
                            MessageBox.Show("El total no puede ser menor ó igual a 0  :(","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else
                        {
                            if(validar.mtd_mensaje()==1)
                            {
                                enviar();
                                dts.setIdadmin(Convert.ToInt32(id));
                                mtd.mtdInsertar(dts);
                                MessageBox.Show("Acción exitosa :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                llenatabla();
                                botones(2);
                                cajas(2);
                                limpiar();
                            }
                            
                        }
                                            
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error al intentar guardar :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

           
        }
        public void llenatabla()
        {
            try
            {
                frm.tblGastosExtras.DataSource = mtd.mtdllenar();
                frm.tblGastosExtras.Columns[0].Visible = false;
                frm.tblGastosExtras.Columns[1].Visible = false;
            }
            catch
            {
                MessageBox.Show("Nose pudieron cargar los datos :(","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }

        public void botones(int op)
        {
            switch(op)
            {
                case 1:
                    frm.btnNuevo.Enabled = false;
                    frm.btnRegistrar.Enabled = true;
                    frm.btnCancelar.Enabled = true;
                    frm.btnModifcar.Enabled = false;
                    break;
                case 2:
                    frm.btnNuevo.Enabled = true;
                    frm.btnRegistrar.Enabled = false;
                    frm.btnCancelar.Enabled = false;
                    frm.btnModifcar.Enabled = false;
                    break;

                case 3:
                    frm.btnNuevo.Enabled = false;
                    frm.btnRegistrar.Enabled = false;
                    frm.btnCancelar.Enabled = true;
                    frm.btnModifcar.Enabled = true;
                    break;
            }

        }
        public void cajas(int op)
        {
            switch(op)
            {
                case 1:
                    frm.txtAsunto.Enabled = true;
                    frm.txtTotal.Enabled = true;
                    frm.txtAsunto.Focus();
                    break;
                case 2:
                    frm.txtAsunto.Enabled = false;
                    frm.txtTotal.Enabled = false;
                    break;
            }

        }
        public void limpiar()
        {
            frm.txtAsunto.Text = "0";
            frm.txtTotal.Text = "0";
        }
    }
}
