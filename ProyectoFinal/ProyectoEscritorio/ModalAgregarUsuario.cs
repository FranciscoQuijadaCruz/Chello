using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEscritorio
{

    public partial class ModalAgregarUsuario : Form
    {

        UsuarioWS.UsuarioWSClient usuariows = new UsuarioWS.UsuarioWSClient();
        tableroUsuarioWS.tableroUsuarioWSClient tablerousuariows = new tableroUsuarioWS.tableroUsuarioWSClient();
        ProyectoEscritorio.Tablero form;
        int idUsuario;
        int idTablero;

        public ModalAgregarUsuario()
        {
            InitializeComponent();
        }

        public ModalAgregarUsuario(int idUsuario, int idTablero, ProyectoEscritorio.Tablero form)
        {
            this.idUsuario = idUsuario;
            this.idTablero = idTablero;
            this.form = form;
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Equals(string.Empty))
            {
                if (ValidarEmail(txtEmail.Text)) {

                    if (usuariows.comprobarExistenciaEmail(txtEmail.Text))
                    {
                        int id = tablerousuariows.SeleccionarIdPorTableroYUsuario(idTablero, usuariows.SeleccionUsuarioPorEmail(txtEmail.Text));

                        if (id <= 0)
                        {
                            tablerousuariows.CrearTableroUsuario(idTablero, usuariows.SeleccionUsuarioPorEmail(txtEmail.Text), "USER");
                            this.Visible = false;
                            form.Visible = false;
                            Tablero t = new Tablero(idUsuario, idTablero);
                            t.Show();
                        }
                        else
                        {
                            label4.Text = "Esta usuario ya forma parte del tablero.";
                            label4.Visible = true;
                        }
                    }
                    else
                    {
                        label4.Text = "Esta direccion de email no coincide con ningún usuario."; 
                        label4.Visible = true;
                    }

                } else {
                    label4.Text = "Direccion de correo no válida.";
                    label4.Visible = true;
                }
            }
            else
            {
                label4.Text = "Favor de no dejar campos vacíos.";
                label4.Visible = true;
            }
        }

        public static bool ValidarEmail(string email)
        {
            return email != null && Regex.IsMatch(email, "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
