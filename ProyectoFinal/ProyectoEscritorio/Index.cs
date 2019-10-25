using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEscritorio
{
    public partial class Index : Form
    {

        UsuarioWS.UsuarioWSClient usuariows = new UsuarioWS.UsuarioWSClient();
        tableroUsuarioWS.tableroUsuarioWSClient tablerousuariows = new tableroUsuarioWS.tableroUsuarioWSClient();
        TableroWS.TableroWSClient tablerows = new TableroWS.TableroWSClient();
        EquipoUsuarioWS.EquipoUsuarioWSClient equipousuariows = new EquipoUsuarioWS.EquipoUsuarioWSClient();
        UsuarioWS.usuario usuario;

        public Index()
        {
            InitializeComponent();
            mostrarTableros();
            ocultarUsuario();
            pnInicio.Visible = false;

        }

        public Index(int idUsuario)
        {
            this.usuario = usuariows.SeleccionarUsuario(idUsuario);
            InitializeComponent();
            pnInicio.Visible = false;
            pnUsuario.Visible = false;
            lblUsuario.Text = usuario.nombre;
            mostrarTableros();
            mostrarEquiposUsuario();
        }

        //MOSTRAR TABLEROS EN INICIO
        public void mostrarTableros()
        {

            try
            {
                tableroUsuarioWS.tablero[] listaTableros = tablerousuariows.ObtenerTablerosDeUsuario(usuario.id);
                //GENERA LOS BOTONES
                for (int i = 0; i < listaTableros.Length; i++) //listaTableros.Length
                {

                    if (listaTableros[i].activo != 0) {
                        Button b = new Button();

                        b.Text = listaTableros[i].titulo;
                        b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        b.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        b.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                        b.Width = 310;
                        b.Height = 150;
                        b.Name = listaTableros[i].id.ToString();
                        b.BackColor = Color.MediumSeaGreen;
                        b.FlatStyle = FlatStyle.Flat;
                        b.BackgroundImageLayout = ImageLayout.None;
                        b.Cursor = System.Windows.Forms.Cursors.Hand;
                        b.Click += new System.EventHandler((sender1, e1) => MostrarTablero(sender1, e1, b));

                        pnIndex.Controls.Add(b);
                    }

                }//FIN DEL FOR CREAR BOTONES
            }
            catch (Exception ex)
            {

                Console.Write(ex);

            }
            //BOTON CREAR
            Button c = new Button();

            c.Text = "CREE UN TABLERO ... ";
            c.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            c.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c.ForeColor = System.Drawing.SystemColors.WindowFrame;
            c.Width = 310;
            c.Height = 150;
            c.BackColor = System.Drawing.SystemColors.InactiveCaption;
            c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            c.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            c.FlatAppearance.BorderSize = 0;
            c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            c.Cursor = System.Windows.Forms.Cursors.Hand;
            c.Click += new EventHandler(crearTablero_Click);

            pnIndex.Controls.Add(c);
        }//FIN MOSTRAR TABLEROS

        //OCULTAR USUARIO
        public void ocultarUsuario()
        {
            pnUsuario.Visible = false;

        }
        //MUESTRA EL USUARIO
        public void mostrarUsuario()
        {
            pnUsuario.Visible = true;

        }
        //BOTON MOSTRAR USUARIO
        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            if (pnUsuario.Visible == true)
            {
                ocultarUsuario();
            }
            else
            {
                mostrarUsuario();
            }
        }

        private void btnCreeEquipo_Click(object sender, EventArgs e)
        {
            ocultarPanel();
            crearEquipo cr = new crearEquipo(usuario.id,this);
            cr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        void crearTablero_Click(object sender, System.EventArgs e)
        {
            ocultarPanel();
            crearTablero ct = new crearTablero(usuario.id, this);
            ct.ShowDialog();
        }

        public void ocultarPanel()
        {
            pnInicio.Visible = false;
            pnUsuario.Visible = false;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Dispose();
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

        private void MostrarTablero(object sender, EventArgs e, Button b)
        {
            Tablero tf = new Tablero(usuario.id, Convert.ToInt32(b.Name));
            tf.Show();
            this.Visible = false;
        }

        //..............

        //LISTA DE EQUIPO_USUARIO
        public void mostrarEquiposUsuario()
        {
            try
            {
                EquipoUsuarioWS.equipo[] listaEquipos = equipousuariows.ObtenerEquiposDeUsuario(usuario.id);

                //GENERA LOS BOTONES
                for (int i = 0; i < listaEquipos.Length; i++) //listaTableros.Length
                {
                    Button be = new Button();

                    //VALORES BOTON
                    be.Text = listaEquipos[i].nombre;
                    be.Name = listaEquipos[i].id.ToString();
                    be.BackColor = Color.MediumSeaGreen;
                    be.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                    be.Size = new System.Drawing.Size(230, 73);
                    be.BackgroundImageLayout = ImageLayout.None;
                    be.FlatStyle = FlatStyle.Flat;
                    be.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    be.Cursor = System.Windows.Forms.Cursors.Hand;
                    be.Click += new System.EventHandler((sender1, e1) => mostrarEquipo(sender1, e1, be));
                    
                    pnEquipos.Controls.Add(be);

                    //pnIndex.Controls.Add(be);
                }//FIN DEL FOR CREAR BOTONES
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        //LLAMAR FORM EQUIPO
        private void mostrarEquipo(object sender, EventArgs e, Button be)
        {
            Equipo eq = new Equipo(Convert.ToInt32(be.Name), usuario.id);
            eq.Show();
            this.Visible = false;
        }

        private void btnCreeTablero_Click(object sender, EventArgs e)
        {
            crearTablero_Click( sender,  e);
        }
    }
}