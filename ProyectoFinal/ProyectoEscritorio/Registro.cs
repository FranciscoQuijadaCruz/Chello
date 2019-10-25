using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEscritorio
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistarse_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") ||
                txtEmail.Text.Equals("") ||
                txtPassword.Text.Equals("") ||
                txtPassword2.Text.Equals(""))
            {
                //MessageBox.Show("Favor de no dejar campos vacios.", "Aviso",
                //MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MsgVacios.Text = "Favor de no dejar campos vacíos";
            }
            else if (txtNombre.Text.Equals("p ej: Francisco Quijada Cruz") ||
                    txtEmail.Text.Equals("p ej: fran@gmail.com") ||
                    txtPassword.Text.Equals("p ej: **********") ||
                    txtPassword2.Text.Equals("p ej: **********"))
            {
                
                MsgVacios.Text = "Favor de no dejar campos vacíos";
            }
            else if (MsgContrasena.Text == "Las contraseñas no coinciden" ||
                MsgNombre.Text == "Su nombre no esta bien escrito" ||
                MsgCorreo.Text == "Su email no esta bien escrito")
            {
               
                MsgVacios.Text = "Favor de corregir errores";
            }
            else
            {
                MsgVacios.Text = "";

                if (MessageBox.Show("¿Desea concluir el registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString().Equals("Yes"))
                {
                    UsuarioWS.UsuarioWSClient usuarios = new UsuarioWS.UsuarioWSClient();
                    usuarios.AgregarUsuario(txtNombre.Text, txtEmail.Text, txtPassword.Text.ToString());
                    MessageBox.Show("Usuario registrado", "Chello",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCasillas();
                }
                
                Login l = new Login();
                l.Show();
                this.Hide();
                
            }
            

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            txtNombre.Text = "p ej: Francisco Quijada Cruz";
            txtNombre.ForeColor = Color.Gray;
            txtEmail.Text = "p ej: fran@gmail.com";
            txtEmail.ForeColor = Color.Gray;
            txtPassword.Text = "p ej: **********";
            txtPassword.ForeColor = Color.Gray;
            txtPassword2.Text = "p ej: **********";
            txtPassword2.ForeColor = Color.Gray;
        }
        /*string encriptar(string cadena)
        {
            string resultado = string.Empty;
            Byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(cadena);
            resultado = Convert.ToBase64String(encriptar);

            return resultado;
        }*/
        public void limpiarCasillas()
        {

            txtNombre.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Location = new Point(
                this.ClientSize.Width / 2 - panel2.Size.Width / 2,
                   this.ClientSize.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private Boolean validarNombre(String nombre)
        {
            String expresion;
            expresion = "^[A-Z a-z]*$";
            //@"^[a-zA-Z]+$";
            //"^[A-Z0-9 a-z]*$"
            if (Regex.IsMatch(nombre, expresion))
            {
                if (Regex.Replace(nombre, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private Boolean validarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtPassword2_Leave(object sender, EventArgs e)
        {
            if (txtPassword2.Text == "")
            {
                txtPassword2.Text = "p ej: **********";

                txtPassword2.ForeColor = Color.Gray;
            }

            if (txtPassword.Text != txtPassword2.Text)
            {
                //MessageBox.Show("Las contraseñas no coinciden.", "Aviso",
                //MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MsgContrasena.Text = "Las contraseñas no coinciden";
                //txtPassword2.Focus();

            }
            else
            {
                MsgContrasena.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {

            if (txtNombre.Text == "")
            {
                txtNombre.Text = "p ej: Francisco Quijada Cruz";

                txtNombre.ForeColor = Color.Gray;
            }

            if (validarNombre(txtNombre.Text))
            {
                MsgNombre.Text = "";
            }
            else
            {
                /*MessageBox.Show("Su nombre no esta bien escrito", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.SelectAll();*/ 
                MsgNombre.Text = "Su nombre no esta bien escrito";
                //txtNombre.Focus();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "p ej: fran@gmail.com";

                txtPassword.ForeColor = Color.Gray;
            }

            if (validarEmail(txtEmail.Text))
            {
                MsgCorreo.Text = "";
            }
            else
            {
                //MessageBox.Show("Su correo no esta bien escrito", "Aviso",
                // MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //txtEmail.SelectAll();
                MsgCorreo.Text = "Su email no esta bien escrito";
                //txtEmail.Focus();
            }
        }

        private void Registro_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "p ej: **********";

                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "p ej: Francisco Quijada Cruz")
            {
                txtNombre.Text = "";

                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "p ej: fran@gmail.com")
            {
                txtEmail.Text = "";

                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "p ej: **********")
            {
                txtPassword.Text = "";

                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword2_Enter(object sender, EventArgs e)
        {
            if (txtPassword2.Text == "p ej: **********")
            {
                txtPassword2.Text = "";

                txtPassword2.ForeColor = Color.Black;
            }
        }
    }
}
