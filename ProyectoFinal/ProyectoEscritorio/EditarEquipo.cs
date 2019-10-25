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
    public partial class EditarEquipo : Form
    {

        int id;
        UsuarioWS.usuario usuario = new UsuarioWS.usuario();
        EquipoWS.EquipoWSClient equipows = new EquipoWS.EquipoWSClient();
        EquipoUsuarioWS.EquipoUsuarioWSClient equipousuariows = new EquipoUsuarioWS.EquipoUsuarioWSClient();
        ProyectoEscritorio.Equipo form = new ProyectoEscritorio.Equipo();

        public EditarEquipo()
        {
            InitializeComponent();
        }

        public bool administradorEquipo() {

            EquipoUsuarioWS.equipoUsuario[] equipoUsuarios = equipousuariows.SeleccionarTodosEquipoUsuario(id);

            bool admin = false;

            for (int i = 0; i < equipoUsuarios.Length; i++)
            {
                if (equipoUsuarios[i].rol.Equals("ADMIN"))
                {
                    if (equipoUsuarios[i].idUsuario == usuario.id)
                    {
                        admin = true;
                    }
                }
            }
            return admin;
        }

        public EditarEquipo(int id, UsuarioWS.usuario usuario, ProyectoEscritorio.Equipo form)
        {
            this.id = id;
            this.usuario = usuario;
            InitializeComponent();
            EquipoWS.equipo equipo = equipows.SeleccionarEquipo(id);
            txtNombre.Text = equipo.nombre;
            txtDescripcion.Text = equipo.descripcion;
            this.form = form;
            if (administradorEquipo())
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            equipows.EditarEquipo(id, txtNombre.Text, txtDescripcion.Text);
            this.Visible = false;
            this.form.Visible = false;
            Equipo form1 = new Equipo(id,usuario.id);
            form1.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EquipoUsuarioWS.equipoUsuario[] lsita = equipousuariows.SeleccionarTodosEquipoUsuario(id);
            int tamano = lsita.Length;
            for(int i=0; i < tamano; i++)
            {
                equipousuariows.EliminarEquipoUsuario(lsita[i].id);   
            }
            this.Visible = false;
            form.Visible = false;
            Index index = new Index(usuario.id);
            index.Show();
        }
    }
}
