using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEscritorio
{
    public partial class EditarContrasena : Form
    {
        UsuarioWS.usuario usuario;
        UsuarioWS.UsuarioWSClient usuariows = new UsuarioWS.UsuarioWSClient();
        
        public EditarContrasena()
        {
            InitializeComponent();
        }

        public EditarContrasena(int idUsuario)
        {
            this.usuario = usuariows.SeleccionarUsuario(idUsuario);
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContra.Text.Equals("") ||
               txtNContra.Text.Equals("") ||
               txtNContra2.Text.Equals(""))
            {
                mensajeError.Text = "No debe dejar campos vacios.";
            }
            else
            {
                if (txtNContra.Text.Equals(txtNContra2.Text))
                {
                    if (txtNContra.Text.Length >= 8)
                    {
                        if (usuario.contrasena.Equals(txtContra.Text))
                        {
                            usuariows.EditarUsuario(usuario.id, usuario.nombre, usuario.email, txtNContra.Text);
                            MessageBox.Show("Cambio realizado correctamente.", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            usuario = usuariows.SeleccionarUsuario(usuario.id);
                            this.Visible = false;
                        }
                        else
                        {
                            mensajeError.Text = "Contrasena incorrecta.";
                        }
                    }
                    else
                    {
                        mensajeError.Text = "La contrasena debe ser mayor a 7 caracteres.";
                    }
                }
                else
                {
                    mensajeError.Text = "La contrasenas no coinciden.";
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
