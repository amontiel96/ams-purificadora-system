/*en esta clase se ejecuta el meni principal para definir a que modulo se va a ingresar*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjPurificadora.Vista;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using prjPurificadora.Modelo.DAO;
using MySql.Data;

namespace prjPurificadora.Controlador
{
    class cls_CPrincipal
    {
        frmPrincipal frm = new frmPrincipal();
        Cls_Validaciones validar = new Cls_Validaciones();
        cls_ProductosDAO mtd = new cls_ProductosDAO();
        string fecha;
        DateTime hora = DateTime.Now;
        String dia = DateTime.Now.Day.ToString();
        String mes = DateTime.Now.Month.ToString();
        String ano = DateTime.Now.Year.ToString();
        int opc;
        string[] datos;
        
        string servidor, bd, user, pwd, cadena;

        /*
         servidor es el nombre del servidor q se desencripta del archivo config
         * bd es el nombre de la base de datos q se desencripta del archivo config
         * user es el nombre de usuario q se desencripta del archivo config
         * pwd es la contraseña q se desencripta del archivo config
         * cadena es la cadena de conexion 
         */

        public void frm_load(string user,string id,string sesion)
        {
            opc = Convert.ToInt32(sesion);
            DateTime hora = DateTime.Now;
            String dia = DateTime.Now.Day.ToString();
            String mes = DateTime.Now.Month.ToString();
            String ano = DateTime.Now.Year.ToString();

            frm.lblUser.Text = user;
            frm.lblIdUser.Text = id;
            frm.meRProduccion.Click += meRProduccion_Click;
            frm.meBotellones.Click += meBotellones_Click;
            frm.meGastoRuta.Click += meGastoRuta_Click;
            frm.meSalir.Click += meSalir_Click;
            frm.meAbonos.Click += meAbonos_Click;
            frm.meCarga.Click += meCarga_Click;
            frm.meClientes.Click += meClientes_Click;
            frm.meCompras.Click += meCompras_Click;
            frm.meGarrafones.Click += meGarrafones_Click;
            frm.meProductos.Click += meProductos_Click;
            //frm.meCorteCaja.Click += meCorteCaja_Click;
            frm.meEmpleados.Click += meEmpleados_Click;
            frm.meInventario.Click += meInventario_Click;
            //frm.meMantenimiento.Click += meMantenimiento_Click;
            frm.meProveedores.Click += meProveedores_Click;
            frm.meVentas.Click += meVentas_Click;
            frm.meExtras.Click += meExtras_Click;
            frm.meOtrosProductos.Click += meOtrosProductos_Click;
            frm.MeRAdministrador.Click += MeRAdministrador_Click;
            frm.meRExtras.Click += meRExtras_Click;
            frm.meRRuta.Click += meRRuta_Click;
            frm.meRVentas.Click += meRVentas_Click;
            frm.meRCompra.Click += meRCompra_Click;
            frm.meRAnalisis.Click += meRAnalisis_Click;
            frm.meREstadoResultados.Click += meREstadoResultados_Click;
            frm.meRNomina.Click += meRNomina_Click;
            frm.meBackup.Click += meBackup_Click;
            frm.meCrearRespaldo.Click += meCrearRespaldo_Click;
            frm.meImportarRespaldo.Click += meImportarRespaldo_Click;
            frm.meRUnidades.Click += meRUnidades_Click;
            frm.meVendedores.Click += meVendedores_Click;
            frm.meCEmpleados.Click += meCEmpleados_Click;
            frm.meGastosMantenimiento.Click += meGastosMantenimiento_Click;
            frm.meDevCompras.Click += meDevCompras_Click;
            frm.meDevVentas.Click += meDevVentas_Click;
            frm.meAltas.Click += meAltas_Click;
            frm.meBajas.Click += meBajas_Click;
            frm.mePrestamos.Click += mePrestamos_Click;
            frm.mePrecios.Click += mePrecios_Click;
            frm.meRutas.Click += meRutas_Click;
            frm.meClientesNormales.Click += meClientesNormales_Click;
            frm.meClientesEspeciales.Click += meClientesEspeciales_Click;
            frm.meRClientes.Click += meRClientes_Click;
            verificaSesion(Convert.ToInt32(sesion));
            leerDatos();
            verificaInventario();
            Application.EnableVisualStyles();
            frm.ShowDialog();
        }

        void meRClientes_Click(object sender, EventArgs e)
        {
            cls_CClientesVentas f = new cls_CClientesVentas();
            f.frm_load();
        }

        void meClientesEspeciales_Click(object sender, EventArgs e)
        {
            cls_CAbonosClientesEspeciales f = new cls_CAbonosClientesEspeciales();
            f.frm_load();
        }

        void meClientesNormales_Click(object sender, EventArgs e)
        {
            cls_CAbonos llamar = new cls_CAbonos();
            llamar.frm_load();
        }

        void meRutas_Click(object sender, EventArgs e)
        {
            cls_CRutas f = new cls_CRutas();
            f.frm_load();
        }

        void mePrecios_Click(object sender, EventArgs e)
        {
            cls_CPrecios f = new cls_CPrecios();
            f.frm_load();
        }

        void mePrestamos_Click(object sender, EventArgs e)
        {
            cls_CPrestamosBote f = new cls_CPrestamosBote();
            f.frm_load();
        }

        void meBajas_Click(object sender, EventArgs e)
        {
            cls_CBjas f = new cls_CBjas();
            f.frm_load();
        }

        void meAltas_Click(object sender, EventArgs e)
        {
            cls_CAltas f = new cls_CAltas();
            f.frm_load();
        }

        public void leerDatos()/*este metodo solo lee los datos de conexion a la base de datos*/
        {
            datos = new string[4];

            using (StreamReader sr = new StreamReader(@"C:\Purificadora\DATOS DE CONEXION\config.ini", false))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    cadena = line;
                }
                datos = validar.DesEncriptar(cadena).Split('-');
                servidor = datos[0];
                bd = datos[1];
                user = datos[2];
                pwd = datos[3];
            }
        }

        void meDevVentas_Click(object sender, EventArgs e)
        {
            cls_CDevolucionesVentas f = new cls_CDevolucionesVentas();
            f.frm_load();
        }

        void meDevCompras_Click(object sender, EventArgs e)
        {
            cls_CDevolucionesCompras f = new cls_CDevolucionesCompras();
            f.frm_load();
        }

        void meGastosMantenimiento_Click(object sender, EventArgs e)
        {
            cls_CMantenimiento llamar = new cls_CMantenimiento();
            llamar.frm_load(frm.lblIdUser.Text);
        }

        void meCEmpleados_Click(object sender, EventArgs e)
        {
            cls_CorteEmpleados f = new cls_CorteEmpleados();
            f.frm_load();
        }

        void meVendedores_Click(object sender, EventArgs e)
        {
            cls_CCorteCaja f = new cls_CCorteCaja();
            f.frm_load();
            
        }
        public void verificaSesion(int op)/*este metodo solo verifica el tipo de sesion iniciada*/
        {
            if (op!=1)
            {
                frm.meRProduccion.Enabled = false;
                frm.meBotellones.Enabled = false;
                frm.meGastoRuta.Enabled = false;
                frm.meAbonos.Enabled = false;
                frm.meCarga.Enabled = false;
                frm.meClientes.Enabled = false;
                frm.meCompras.Enabled = false;
                frm.meGarrafones.Enabled = false;
                frm.meProductos.Enabled = false;
                frm.meCorteCaja.Enabled = false;
                frm.meEmpleados.Enabled = false;
                frm.meInventario.Enabled = false;
                frm.meMantenimiento.Enabled = false;
                frm.meConfig.Enabled = false;
                frm.meProveedores.Enabled = false;
                frm.meGastos.Enabled = false;
                frm.meReportes.Enabled = false;
                frm.meExtras.Enabled = false;
                frm.meOtrosProductos.Enabled = false;
                frm.MeRAdministrador.Enabled = false;
                frm.meRExtras.Enabled = false;
                frm.meRRuta.Enabled = false;
                frm.meRVentas.Enabled = false;
                frm.meRCompra.Enabled = false;
                frm.meRAnalisis.Enabled = false;
                frm.meREstadoResultados.Enabled = false;
                frm.meRNomina.Enabled = false;
                frm.meBackup.Enabled = false;
                frm.meCrearRespaldo.Enabled = false;
                frm.meImportarRespaldo.Enabled = false;
                frm.meRUnidades.Enabled = false;
            }
        }
        void meRUnidades_Click(object sender, EventArgs e)
        {
            cls_RUnidadesProducidas f = new cls_RUnidadesProducidas();
            f.frm_load();
        }

        void meImportarRespaldo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog archivo = new OpenFileDialog();
                archivo.Title = "Elija que fecha quiere restaurar";
                archivo.ShowDialog();

                if (archivo.FileName == "")
                {
                    MessageBox.Show("Accion cancelada :)","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    nomBackup = archivo.FileName;
                    StreamWriter sw = new StreamWriter(@"C:\Purificadora\RECURSOS\scripCreaBK.bat");

                    sw.WriteLine("cd /");
                    sw.WriteLine("cd xampp");
                    sw.WriteLine("cd mysql");
                    sw.WriteLine("cd bin");
                    sw.WriteLine("cls");
                    sw.WriteLine("mysql -u "+user+" -p"+pwd+" "+bd+" < " + nomBackup);
                    sw.Close();

                    System.Diagnostics.Process.Start(@"C:\Purificadora\RECURSOS\scripCreaBK.bat");
                }

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            
        }

        void meCrearRespaldo_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Guardar Backups en";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName == "")
                {
                    MessageBox.Show("acción cancelada :)","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    fecha = "Fecha_" + DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString() + "-Hora-" + DateTime.Now.Hour.ToString() + "Hrs_" + DateTime.Now.Minute.ToString() + "Min_" + DateTime.Now.Second.ToString() + "Seg_" + ".sql";
                    nomBackup = saveFileDialog1.FileName + "-" + fecha;
                    StreamWriter sw = new StreamWriter(@"C:\Purificadora\RECURSOS\scripCreaBK.bat");

                    sw.WriteLine("cd /");
                    sw.WriteLine("cd xampp");
                    sw.WriteLine("cd mysql");
                    sw.WriteLine("cd bin");
                    sw.WriteLine("cls");
                    sw.WriteLine("mysqldump -u " + user + " -p" + pwd + " " + bd + " > " + nomBackup);
                    sw.WriteLine("");
                    sw.Close();

                    System.Diagnostics.Process.Start(@"C:\Purificadora\RECURSOS\scripCreaBK.bat");
                }
                

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            
        }
        string nomBackup;
        void meBackup_Click(object sender, EventArgs e)
        {
            

        }

        void meRNomina_Click(object sender, EventArgs e)
        {
            cls_RNominas f = new cls_RNominas();
            f.frm_load();
        }

        void meREstadoResultados_Click(object sender, EventArgs e)
        {
            cls_REstadoDeReusltados f = new cls_REstadoDeReusltados();
            f.frm_load();
        }

        void meRAnalisis_Click(object sender, EventArgs e)
        {
            cls_RAnalisis f = new cls_RAnalisis();
            f.frm_load();
        }

        void meRCompra_Click(object sender, EventArgs e)
        {
            cls_RCompras f = new cls_RCompras();
            f.frm_load();
        }

        void meRVentas_Click(object sender, EventArgs e)
        {
            cls_RVentas f=new cls_RVentas();
            f.frm_load();
        }

        void meRRuta_Click(object sender, EventArgs e)
        {
            cls_RGastosRuta f = new cls_RGastosRuta();
            f.frm_load();
        }

        void meRExtras_Click(object sender, EventArgs e)
        {
            cls_RGastosExtras f = new cls_RGastosExtras();
            f.frm_load();
        }

        void MeRAdministrador_Click(object sender, EventArgs e)
        {
            cls_RAdministrador r = new cls_RAdministrador();
            r.frm_load();
        }

        void meRProduccion_Click(object sender, EventArgs e)
        {
            cls_CGastosProduccion r = new cls_CGastosProduccion();
            r.frm_load();
        }

        void meOtrosProductos_Click(object sender, EventArgs e)
        {
            cls_CCompras llamar = new cls_CCompras();
            llamar.frm_load(frm.lblIdUser.Text);   
        }

        void meBotellones_Click(object sender, EventArgs e)
        {
            cls_CCompraBotellones llamar = new cls_CCompraBotellones();
            llamar.frm_load(frm.lblIdUser.Text);
        }

        void meExtras_Click(object sender, EventArgs e)
        {
            cls_CExtras llamar = new cls_CExtras();
            llamar.frm_load(frm.lblIdUser.Text);
        }

        void meGastoRuta_Click(object sender, EventArgs e)
        {
            cls_CGastoRuta llamar = new cls_CGastoRuta();
            llamar.frm_load();
        }

        void meProductos_Click(object sender, EventArgs e)
        {
            cls_CInventario llamar = new cls_CInventario();
            llamar.frm_load();
        }

        void meGarrafones_Click(object sender, EventArgs e)
        {
            cls_CBotellones llamar = new cls_CBotellones();
            llamar.frm_load();
        }

        void meProveedores_Click(object sender, EventArgs e)
        {
            cls_CProveedores llamar = new cls_CProveedores();
            llamar.frm_load();
        }

        void meInventario_Click(object sender, EventArgs e)
        {
            //cls_CInventario llamar = new cls_CInventario();
            //llamar.frm_load();
        }

        void meEmpleados_Click(object sender, EventArgs e)
        {
            cls_CEmpleados llamar = new cls_CEmpleados();
            llamar.frm_load();
        }

        void meCompras_Click(object sender, EventArgs e)
        {
           
        }

        void meClientes_Click(object sender, EventArgs e)
        {
            cls_CClientes llamar = new cls_CClientes();
            llamar.frm_load();
        }

        void meCarga_Click(object sender, EventArgs e)
        {
            cls_CCargas llamar = new cls_CCargas();
            llamar.frm_load();
        }

        void meAbonos_Click(object sender, EventArgs e)
        {
           
        }

        void meVentas_Click(object sender, EventArgs e)
        {
            cls_CVentas ventas = new cls_CVentas();
            ventas.frm_load();
        }
        DialogResult respuesta;
        void meSalir_Click(object sender, EventArgs e)
        {
            respuesta = MessageBox.Show("Desea cerrar sesión???","Responda la pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(respuesta==DialogResult.Yes)
            {
                if (opc == 1)
                {
                    StreamWriter sw = new StreamWriter(@"C:\Purificadora\RECURSOS\scripAccion.bat");

                    sw.WriteLine("cd /");
                    sw.WriteLine("cd xampp");
                    sw.WriteLine("cd mysql");
                    sw.WriteLine("cd bin");
                    sw.WriteLine("cls");
                    sw.WriteLine("mysqldump -u " + user + " -p" + pwd + " " + bd + " > "+@"C:\Purificadora\RESPALDOS\seguridad.sql");
                    sw.WriteLine("copy "+@"C:\Purificadora\RESPALDOS\seguridad.sql D:\RESPALDOS\seguridad.sql");
                    sw.Close();
                    System.Diagnostics.Process.Start(@"C:\Purificadora\RECURSOS\scripAccion.bat");
                    MessageBox.Show("Se ha guardado una copia de seguridad a la base de datos :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Application.Exit();
            }
            
        }
        int boteExiste, selloExiste, taponExiste;
        public void verificaInventario()
        {
            try
            {
                frm.tblProductos.DataSource = mtd.mtdVerificaInventarioInicial();
                boteExiste = Convert.ToInt32(frm.tblProductos.Rows[0].Cells[1].Value.ToString());
                selloExiste = Convert.ToInt32(frm.tblProductos.Rows[1].Cells[1].Value.ToString());
                taponExiste = Convert.ToInt32(frm.tblProductos.Rows[2].Cells[1].Value.ToString());

                if(boteExiste==0&&selloExiste==0&&taponExiste==0)
                {
                    cls_CInventarioInicial f = new cls_CInventarioInicial();
                    f.frm_load();
                }
            }
            catch
            {

            }
        }
        
    }
}
