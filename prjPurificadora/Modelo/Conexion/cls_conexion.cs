using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
//
using MySql.Data.MySqlClient;
using MySql.Data;
using System.IO;

namespace prjPurificadora.Modelo.Conexion
{
    class cls_conexion
    {
       

        string[] datos;
        string servidor, bd, user,pwd,cadena;

        MySqlConnection CONEXION;
        MySqlDataAdapter traer_datos;
        public bool exito=false;

        string data;
        //metodo para instanciar una nueva conexion a la base de datos
        public void conectar()
        {
            
            datos = new string[4];

            using (StreamReader sr = new StreamReader(@"C:/Purificadora/config.ini", false))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cadena = line;
                    }
                    datos = DesEncriptar(cadena).Split('-');
                    servidor = datos[0];
                    bd = datos[1];
                    user = datos[2];
                    pwd = datos[3];
                }
                
                data = "Data Source=" + servidor + "; Initial Catalog=" + bd + "; User Id=" + user + "; Pwd="+pwd+";";
                
                CONEXION = new MySqlConnection(data);//hacemos la peticion para abrir una conexion con los datos que recibe
                CONEXION.Open();//abre una nueva conexion
        }

        

        #region "Patron Singleton" 
        private static cls_conexion instance = null; /*instancia de la clase*/

        private cls_conexion() { } /*constructor privado*/

        public static cls_conexion Instancia() /*metodo para instanciar la clase*/
        {
            if (instance == null)
                instance = new cls_conexion();

            return instance; /*retorna la clase*/
        }
        #endregion

        //metodo para destruir la conexion 
        public void desconectar()
        {
            CONEXION.Close();//cierra la conexion
            CONEXION.Dispose();//una vez cerrada la conexion tambien es necesario liberar memoria del sistema y se hace con esta instruccion
        }

        //este metodo sirve para insertar, modificar, eliminar y ejecutar procedimientos almacenados
        public void accion(string sql)//recibe el query o prcedimiento almacenado que queremos ejecutar
        {
           
                conectar();//abre una nueva conexion
                MySqlCommand insertar = new MySqlCommand(sql, CONEXION);//ejecutamos las instrucciones con los datos de la conexion
                insertar.ExecuteNonQuery();//se ejecuta las instrucciones en la base de datos
                desconectar();
                //System.Diagnostics.Process.Start(@"C:\RESPALDOS\scripAccion.bat");
        }

        public DataTable control_acceso(string sql)
        {
            DataTable tabla = new DataTable();
            MySqlDataAdapter busca = new MySqlDataAdapter(sql, CONEXION);
            busca.Fill(tabla);
            return tabla;

        }


        public DataTable consultas(string sql)//recibe la consulta que deseamos
        {
            DataTable dato = new DataTable();//creamos un datatable para recibir la consulta
            try
            {
                conectar();//instancia una nueva conexion
                MySqlDataAdapter busca = new MySqlDataAdapter(sql, CONEXION);//ejecutamos las instrucciones con los datos de la conexion
                busca.Fill(dato);//

            }
            catch (MySqlException e)
            {
            }
            desconectar();
            return dato;//retornamos el data table que lleva la consulta
        }

        public int existe(string sql)//recibe la consulta que deseamos
        {
            DataTable dato = new DataTable();//creamos un datatable para recibir la consulta
            exito = false;
            try
            {
                conectar();//instancia una nueva conexion
                MySqlDataAdapter busca = new MySqlDataAdapter(sql, CONEXION);//ejecutamos las instrucciones con los datos de la conexion
                busca.Fill(dato);// 
             }
            catch (MySqlException e)
            {
            }
            desconectar();
            return dato.Rows.Count;//retornamos el numero de filas que tiene la consulta
        }

     
        public DataTable mostrar(string sql)
        {
            traer_datos = new MySqlDataAdapter(sql, data);
            DataTable most = new DataTable();
            try
            {
                traer_datos.Fill(most);
            }
            catch (Exception e)
            {
                MessageBox.Show("error al mostrar los resultado vuelva a intentarlo mas tarde" + e);
            }
            return most;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            try
            {
                byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
                //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
                result = System.Text.Encoding.Unicode.GetString(decryted);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("El desencriptado fallo...","Error...!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return result;
        }

    }
}
