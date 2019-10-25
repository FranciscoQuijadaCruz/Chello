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
    public partial class EditarNombre : Form
    {
        UsuarioWS.usuario usuario;
        UsuarioWS.UsuarioWSClient usuariows = new UsuarioWS.UsuarioWSClient();
        ProyectoEscritorio.Perfil p;

        public EditarNombre(int idUsuario, ProyectoEscritorio.Perfil p)
        {
            this.usuario = usuariows.SeleccionarUsuario(idUsuario);
            this.p = p;
            InitializeComponent();
            txtNombre.Text = usuario.nombre;
        }

        public EditarNombre()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if (!txtNombre.Text.Equals(usuario.nombre))
                {
                    try
                    {
                        usuariows.EditarUsuario(usuario.id, txtNombre.Text, usuario.email, usuario.contrasena);
                        MessageBox.Show("Cambio realizado correctamente.", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Visible = false;
                        p.Visible = false;
                        Perfil np = new Perfil(usuario.id, "C");
                        np.Show();
                    }
                    catch
                    {
                        mensajeError.Text = "El cambio no se concreto.";
                    }
                }
            }
            else
            {
                mensajeError.Text = "No puedes dejar el campo vacio.";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
