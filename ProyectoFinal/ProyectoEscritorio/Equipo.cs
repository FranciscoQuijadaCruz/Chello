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
    public partial class Equipo : Form
    {
        int idEquipo;
        UsuarioWS.usuario usuario = new UsuarioWS.usuario();
        EquipoWS.EquipoWSClient equipows = new EquipoWS.EquipoWSClient();
        TableroWS.TableroWSClient tablerows = new TableroWS.TableroWSClient();
        UsuarioWS.UsuarioWSClient usuariows = new UsuarioWS.UsuarioWSClient();
        tableroUsuarioWS.tableroUsuarioWSClient tablerousuariows = new tableroUsuarioWS.tableroUsuarioWSClient();
        EquipoUsuarioWS.EquipoUsuarioWSClient equipousuariows = new EquipoUsuarioWS.EquipoUsuarioWSClient();
        tableroEquipoWS.tableroEquipoWSClient tableroequipows = new tableroEquipoWS.tableroEquipoWSClient();

        public Equipo()
        {
            InitializeComponent();
        }


        public Equipo(int idEquipo, int idUsuario)
        {
            this.idEquipo = idEquipo;
            this.usuario = usuariows.SeleccionarUsuario(idUsuario);
            InitializeComponent();

        }


        private void lbPerfil_Click(object sender, EventArgs e)
        {
            PMiembro.Visible = false;
            PTableros.Visible = true;
            lbTableros.BackColor = Color.FromArgb(224, 224, 224);
            lbMiembros.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void lbActividades_Click(object sender, EventArgs e)
        {
            PMiembro.Visible = true;
            PTableros.Visible = false;
            lbTableros.BackColor = Color.FromArgb(200, 200, 200);
            lbMiembros.BackColor = Color.FromArgb(224, 224, 224);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            EditarEquipo ee = new EditarEquipo(idEquipo, usuario, this);
            ee.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            EquipoWS.equipo equipo = equipows.SeleccionarEquipo(idEquipo);
            lbNombre.Text = equipo.nombre;
            lbDescripcion.Text = equipo.descripcion;
            lblUsuario.Text = usuario.nombre;
            llenarListaMiembros(idEquipo);
            llenarListaTableros(idEquipo);
            tableroUsuarioWS.tablero[] tableros = tablerousuariows.ObtenerTablerosDeUsuario(usuario.id);

            try
            {
                for (int i = 0; i < tableros.Length; i++)
                {
                    if (tableros[i].activo != 0)
                    {
                        Button b = new Button();
                        b.Width = 210;
                        b.Height = 30;
                        b.Text = tableros[i].titulo;
                        b.Name = tableros[i].id.ToString();
                        b.Click += new System.EventHandler((sender1, e1) => AbrirTablero(sender1, e1, b));
                        pnTableros.Controls.Add(b);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex + "No hay tableros para mostrar en el aside Tableros.");
            }


        }

        private void btnAgregarTablero_Click(object sender, EventArgs e)
        {

            if (txtTablero.Text.Equals(""))
            {
                lbMensajeError.Visible = true;
            }
            else
            {
                int idTablero = tablerows.AgregarTablero(txtTablero.Text);

                lbMensajeError2.Visible = false;
                Button b = new Button();
                b.Name = idTablero.ToString(); ;
                int id = tablerousuariows.CrearTableroUsuario(idTablero, usuario.id,"ADMIN");
                tableroequipows.CrearTableroEquipo(id, idEquipo);
                b.Text = txtTablero.Text;
                b.Size = new System.Drawing.Size(776, 23);
                b.TabIndex = 0;
                b.UseVisualStyleBackColor = true;
                b.Click += new System.EventHandler((sender1, e1) => AbrirTablero(sender1, e1, b));
                listaTableros.Controls.Add(b);
            }
        }

        private void btnInvitarMiembro_Click(object sender, EventArgs e)
        {
            if (txtMiembro.Text.Equals(""))
            {
                lbMensajeError2.Text = "Favor de no dejar el campo vacio.";
                lbMensajeError2.Visible = true;
            }
            else
            {
                if (usuariows.comprobarExistenciaEmail(txtMiembro.Text)) {

                    int id = equipousuariows.SeleccionarIdPorEquipoYUsuario(idEquipo, usuariows.SeleccionUsuarioPorEmail(txtMiembro.Text));

                    if (id <= 0)
                    {
                        lbMensajeError2.Visible = false;
                        Button b = new Button();
                        b.Name = equipousuariows.AgregarEquipoUsuario(idEquipo, usuariows.SeleccionUsuarioPorEmail(txtMiembro.Text), "USER").ToString();
                        b.Text = usuariows.SeleccionarUsuario(usuariows.SeleccionUsuarioPorEmail(txtMiembro.Text)).nombre + " - " + txtMiembro.Text;
                        b.Size = new System.Drawing.Size(776, 23);
                        b.TabIndex = 0;
                        b.UseVisualStyleBackColor = true;
                        listaMiembros.Controls.Add(b);
                        Equipo p = new Equipo(idEquipo, usuario.id);
                        p.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        lbMensajeError2.Text = "Esta usuario ya forma parte del tablero.";
                        lbMensajeError2.Visible = true;
                    }


                } else {

                    lbMensajeError2.Text = "Este email no coincide con ningun usuario.";
                    lbMensajeError2.Visible = true;

                }
            }
        }

        public void llenarListaMiembros(int idEquipo) {

            EquipoUsuarioWS.usuario[] usuarios = equipousuariows.ObtenerUsuariosDeEquipo(idEquipo);
            EquipoUsuarioWS.equipoUsuario[] equipoUsuarios = equipousuariows.SeleccionarTodosEquipoUsuario(idEquipo);

            bool admin = false;

            for(int i = 0; i < equipoUsuarios.Length; i++)
            {
                if (equipoUsuarios[i].rol.Equals("ADMIN"))
                {
                    if(equipoUsuarios[i].idUsuario == usuario.id)
                    {
                        admin = true;
                    }
                }
            }

            try
            {
                for (int i = 0; i < usuarios.Length; i++)
                {
                    if (!(usuario.id == usuarios[i].id))
                    {
                        Button b = new Button();
                        b.Name = usuarios[i].id.ToString();
                        b.Text = usuarios[i].nombre + " - " + usuarios[i].email;
                        b.Size = new System.Drawing.Size(776, 23);
                        b.TabIndex = 0;
                        if (admin)
                        {
                            b.Click += new System.EventHandler((sender1, e1) => EditarMiembro(sender1, e1, b));
                        }
                        b.UseVisualStyleBackColor = true;
                        listaMiembros.Controls.Add(b);
                    }
                }
            } catch (Exception ex)
            {
                Console.Write(ex);

            }
        }

        public void EditarMiembro(object sender, EventArgs e, Button b)
        {
            ModalEliminarActividad f2 = new ModalEliminarActividad();
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
                equipousuariows.EliminarEquipoUsuario(equipousuariows.SeleccionarIdPorEquipoYUsuario(idEquipo,Convert.ToInt32(b.Name)));
                Equipo p = new Equipo(idEquipo, usuario.id);
                p.Show();
                this.Visible = false;
            }
        }

            public void llenarListaTableros(int idEquipo) {

            tableroEquipoWS.tablero[] tableros = tableroequipows.ObtenerTablerosDeEquipo(idEquipo);
            try
            {
                for (int i = 0; i < tableros.Length; i++)
                {
                    Button b = new Button();
                    b.Name = tableros[i].id.ToString();
                    b.Text = tableros[i].titulo;
                    b.Size = new System.Drawing.Size(776, 23);
                    b.TabIndex = 0;
                    b.Click += new System.EventHandler((sender1, e1) => AbrirTablero(sender1, e1, b));
                    b.UseVisualStyleBackColor = true;
                    listaTableros.Controls.Add(b);
                }
            }catch (Exception ex)
            {
                Console.Write(ex);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (pnUsuario.Visible == true)
            {
                pnUsuario.Visible = false;
            }
            else
            {
                pnUsuario.Visible = true;
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Perfil p = new Perfil(usuario.id, "P");
            p.Show();
            this.Visible = false;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Perfil p = new Perfil(usuario.id, "C");
            p.Show();
            this.Visible = false;
        }

        private void AbrirTablero(object sender, EventArgs e, Button b)
        {
            Tablero f = new Tablero(usuario.id, Convert.ToInt32(b.Name));
            f.Show();
            this.Visible = false;
        }

        private void btnCrearTablero_Click(object sender, EventArgs e)
        {
            ModalAgregarTablero f2 = new ModalAgregarTablero();
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
                int t = tablerows.AgregarTablero(f2.TextBox1.Text);
                tablerousuariows.CrearTableroUsuario(t, usuario.id,"ADMIN");
                Button b = new Button();
                b.Click += new System.EventHandler((sender1, e1) => AbrirTablero(sender1, e1, b));
                b.Width = 210;
                b.Height = 30;
                b.Name = t.ToString();
                b.Text = f2.TextBox1.Text;
                tablerousuariows.CrearTableroUsuario(t, usuario.id, "ADMIN");
                pnTableros.Controls.Add(b);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Index i = new Index(usuario.id);
            i.Show();
            this.Visible = false;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login l = new Login();
            l.Visible = true;
        }
    }
}
