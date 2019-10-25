using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEscritorio
{
    public partial class EditarCorreo : Form
    {
        string codigo = "";
        UsuarioWS.usuario usuario;
        UsuarioWS.UsuarioWSClient usuariows = new UsuarioWS.UsuarioWSClient();

        public EditarCorreo(int idUsuario)
        {
            this.usuario = usuariows.SeleccionarUsuario(idUsuario);
            InitializeComponent();
            lblEmail.Text = usuario.email;
        }

        public EditarCorreo()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmacion.Text.Equals(codigo))
            {
                usuariows.EditarUsuario(usuario.id, usuario.nombre, txtEmail.Text, usuario.contrasena);
                MessageBox.Show("Cambio realizado correctamente.", "",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Visible = false;
            }
        }

        public static bool ValidarEmail(string email)
        {
            return email != null && Regex.IsMatch(email, "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$");
        }

        public string GenerarCodigo()
        {
            int longitud = 4;
            const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder token = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indice = rnd.Next(alfabeto.Length);
                token.Append(alfabeto[indice]);
            }

            return token.ToString();
        }

        public void EnviarCodigo (string email){

            //La cadena "servidor" es el servidor de correo que enviará tu mensaje
            string servidor = "smtp.gmail.com";
            // Crea el mensaje estableciendo quién lo manda y quién lo recibe
            MailMessage mensaje = new MailMessage(
               "chellosoporte@gmail.com",
               email,
               "Código de confirmación",
               codigo);

            //Envía el mensaje.
            SmtpClient cliente = new SmtpClient(servidor);
            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new System.Net.NetworkCredential("chellosoporte@gmail.com", "C7GCKpix");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            //Añade credenciales si el servidor lo requiere.

            cliente.Send(mensaje);

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarEmail(txtEmail.Text))
            {
                materialLabel1.Visible = false;
                txtEmail.Visible = false;
                mensajeError.Visible = false;
                btnGuardar.Visible = false;
                lblConfirmacion.Visible = true;
                txtConfirmacion.Visible = true;
                codigo = GenerarCodigo();
                EnviarCodigo(usuario.email);
            }
            else
            {
                mensajeError.Text = "Formato de email incorrecto.";
            }
        }
    }
}
