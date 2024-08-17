using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPurificadora.Controlador
{
    class Cls_Validaciones
    {
        DialogResult respuesta;
        int opc = 0;

        //metodo que solo permite insertar numeros 
        public void mtd_solo_numeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
            { }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        //inserta solo letras
        public void mtd_solo_letras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //solo letras insertas letras o numeros, no inserta simbolos
        public void mtd_solo_letras_numeros(KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            { e.KeyChar = (char)Keys.None; }
            else
            {

            }
        }
        //inserta solo nimeros con un solo punto decimal este puede servir para las cantidades
        public void mtd_numero_con_decimal(string texto, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back || e.KeyChar == '.')
            {
                if (texto.Contains(".") && e.KeyChar == '.')
                {
                    e.KeyChar = (char)Keys.None;
                }
            }
            else
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        //mensaje
        public int mtd_mensaje()
        {
            opc = 0;
            respuesta = MessageBox.Show("¿Desea continuar?","Responda la pregunta...!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                opc = 1;
                //MessageBox.Show("Accion exitosa :)","Aviso...!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            return opc;

        }

        //mensaje
        public int mtd_mensajeCancelar()
        {
            opc = 0;
            respuesta = MessageBox.Show("¿Desea cancelar esta acción?", "Responda la pregunta...!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                opc = 1;
                MessageBox.Show("Accion cancelada :)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return opc;

        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public string DesEncriptar(string _cadenaAdesencriptar)
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
                System.Windows.Forms.MessageBox.Show("El desencriptado fallo...", "Error...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public void email_bien_escrito(String email)
        {
            Regex emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?
                                ^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+
                                [a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

            if (emailRegex.IsMatch(email))
            {
                MessageBox.Show(email + "matches the expected format.", "Attention");
            }
        }
    }
}
