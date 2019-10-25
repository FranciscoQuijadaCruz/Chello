using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEscritorio
{
    public partial class Login : Form
    {
        UsuarioWS.UsuarioWSClient usuarios = new UsuarioWS.UsuarioWSClient();
        public Login()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point(
                 this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                    this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            txtUser.Text = "p ej: fran@gmail.com";
            txtUser.ForeColor = Color.Gray;
            txtPassword.Text = "**********";
            txtPassword.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                //MessageBox.Show("No dejar campos vacios.", "Aviso",
                //MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblMsg.Text = "No dejar campos vacíos";
            }
            else if (txtUser.Text.Equals("p ej: fran@gmail.com") ||
                     txtPassword.Text.Equals("**********"))
            {
                lblMsg.Text = "Favor de no dejar campos vacíos";
            }
            else if (MsgEmail.Text == "Dirección de correo electrónico no valida") {
                MsgEmail.Text = "Dirección de correo electrónico no valida";
            }
            else
            {
                if (usuarios.Login(txtUser.Text, txtPassword.Text).id > 0)
                {
                    Index f = new Index(usuarios.Login(txtUser.Text, txtPassword.Text).id);
                    f.Show();
                    this.Visible = false;
                }
                else
                {
                    //MessageBox.Show("Cuenta o contraseña incorrecta.", "Aviso",
                    //MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblMsg.Text = "Cuenta o cotraseña incorrecta";
                }



            }
        }
        

       /* string desencriptar(string cadena)
        {
            string resultado = string.Empty;
            Byte[] desencriptar = Convert.FromBase64String(cadena);
            resultado = System.Text.Encoding.Unicode.GetString(desencriptar); 

            return resultado;
        }*/
        private void button2_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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



        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "p ej: fran@gmail.com";

                txtUser.ForeColor = Color.Gray;
            }

            if (validarEmail(txtUser.Text))
             {
                MsgEmail.Text = "";

            }
            else {
                /* MessageBox.Show("Dirección de correo electrónico no valida", "Aviso",
                     MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);*/

                MsgEmail.Text = "Dirección de correo electrónico no valida";
                 //txtUser.SelectAll();
                 //txtUser.Focus();
             }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "p ej: fran@gmail.com")
            {
                txtUser.Text = "";

                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "**********";

                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "**********")
            {
                txtPassword.Text = "";

                txtPassword.ForeColor = Color.Black;
            }
        }
    }
}
