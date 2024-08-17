/*en esta clase se crea el arcivo config donde estan registrados los datos de la conexion a la base de datos*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjPurificadora.Vista;
using prjPurificadora.Modelo.Conexion;
using System.Threading.Tasks;
using System.IO;


namespace prjPurificadora.Controlador
{
    class cls_CDtsConexion
    {
        frmDtsConexion frm = new frmDtsConexion();
        Cls_Validaciones validar = new Cls_Validaciones();

        string[] datos;
        string servidor, bd, user, pwd, cadena;

        public void frm_load()//cargamos los eventos de los controles
        {
            frm.btnConexion.Click += btnConexion_Click;
            frm.btnCancelar.Click += btnCancelar_Click;
            frm.txtBd.KeyPress += txtBd_KeyPress;
            frm.txtPwd.KeyPress += txtPwd_KeyPress;
            frm.txtUser.KeyPress += txtUser_KeyPress;
            Application.EnableVisualStyles();
            verficaArchivo();
            frm.ShowDialog();
        }

        void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras_numeros(e);
        }

        void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.mtd_solo_letras_numeros(e);
        }

        void txtBd_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        void btnCancelar_Click(object sender, EventArgs e)
        {
            frm.Close();
        }

        void btnConexion_Click(object sender, EventArgs e)
        {
            if (frm.txtServidor.Text == "" || frm.txtBd.Text == "" || frm.txtUser.Text == "")
            {
                MessageBox.Show("No dejar campos vacios :(", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(validar.mtd_mensaje()==1)//si es iguala 1 quere decir q la respuesta es si y provedera a crear nuevamente el archivo config y probar la conexion
                {
                    crearConfig();
                    conectar();
                }
                
            }
            
        }

        public void crearConfig()/*en este metodo se crea el archivo config con los datos enviados*/
        {
            try
            {
                    StreamWriter sw = new StreamWriter(@"C:\Purificadora\DATOS DE CONEXION\config.ini");
                    //enviamos los valores de las cajas de texto a el metodo para encriptar
                    sw.WriteLine(Encriptar(frm.txtServidor.Text+"-"+frm.txtBd.Text+"-"+frm.txtUser.Text+"-"+frm.txtPwd.Text));
                    sw.Close();
                                 
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void conectar()
        {
            //este metodo funcioa para una ves de que se creo el archivo config, probamos la conexion con los datos guardados
            try
            {
                cls_conexion.Instancia().conectar();
                MessageBox.Show("La conexion ha sido exitosa :)","Reinicie el sistema para guardar cambios",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frm.Close();
            }
            catch {
                MessageBox.Show("No es posible conectar con el servidor :(","Alerta... Verifique sus datos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }

        /// Encripta una cadena
        public static string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public void verficaArchivo()/*pasar datos a las cajas de texto*/
        {
            if (File.Exists(@"C:\Purificadora\DATOS DE CONEXION\config.ini"))
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
                frm.txtBd.Text = bd;
                frm.txtPwd.Text = pwd;
                frm.txtServidor.Text = servidor;
                frm.txtUser.Text = user;
            }
            else
            {
                MessageBox.Show("Aún no se ha configurado los datos de conexion :(","Alerta...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
       
    }
}
