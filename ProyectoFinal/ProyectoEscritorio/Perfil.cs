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
    public partial class Perfil : Form
    {

        UsuarioWS.usuario usuario;
        UsuarioWS.UsuarioWSClient usuariows = new UsuarioWS.UsuarioWSClient();
        ActividadUsuarioWS.ActividadUsuarioWSClient actividadusuariows = new ActividadUsuarioWS.ActividadUsuarioWSClient();
        ModificacionWS.ModificacionWSClient modificacionws = new ModificacionWS.ModificacionWSClient();
        EquipoUsuarioWS.EquipoUsuarioWSClient equipousuariows = new EquipoUsuarioWS.EquipoUsuarioWSClient();
        TableroWS.TableroWSClient tablerows = new TableroWS.TableroWSClient();
        tableroUsuarioWS.tableroUsuarioWSClient tablerousuariows = new tableroUsuarioWS.tableroUsuarioWSClient();
        ActividadWS.ActividadWSClient actividadws = new ActividadWS.ActividadWSClient();
        ModuloWS.ModuloWSClient modulows = new ModuloWS.ModuloWSClient();

        public Perfil()
        {
            InitializeComponent();
        }

        public Perfil(int idUsuario, string comienzo)
        {
            InitializeComponent();
            this.usuario = usuariows.SeleccionarUsuario(idUsuario);
            if (comienzo.Equals("C"))
            {
                lbConfig.BackColor = Color.FromArgb(224, 224, 224);
                lbActividades.BackColor = Color.FromArgb(200, 200, 200);
                lbPerfil.BackColor = Color.FromArgb(200, 200, 200);
                panelConfiguracion.Visible = true;
                panelActividades.Visible = false;
                panelPerfil.Visible = false;
            }else if (comienzo.Equals("P"))
            {
                lbPerfil.BackColor = Color.FromArgb(244, 244, 244);
                lbActividades.BackColor = Color.FromArgb(200, 200, 200);
                lbConfig.BackColor = Color.FromArgb(200, 200, 200);
                panelPerfil.Visible = true;
                panelActividades.Visible = false;
                panelConfiguracion.Visible = false;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ActividadUsuarioWS.actividad[] actividades = actividadusuariows.ObtenerActividadesDeUsuario(usuario.id);
            ModificacionWS.modificacion[] modificaciones = modificacionws.ObtenerModificacionesDeUsuario(usuario.id);
            EquipoUsuarioWS.equipo[] equipos = equipousuariows.ObtenerEquiposDeUsuario(usuario.id);
            tableroUsuarioWS.tablero[] tableros = tablerousuariows.ObtenerTablerosDeUsuario(usuario.id);
            lblUsuario.Text = usuariows.SeleccionarUsuario(usuario.id).nombre;
            try
            {
                for (int i = 0; i < actividades.Length; i++)
                {
                    ModuloWS.modulo modulo = modulows.SeleccionarModulo(actividadws.SeleccionarActividad(actividades[i].id).idModulo);
                    TableroWS.tablero tablero = tablerows.SeleccionarTablero(modulows.SeleccionarModulo(actividadws.SeleccionarActividad(actividades[i].id).idModulo).idTablero);
                    if (actividades[i].activo != 0 && modulo.activo != 0 && tablero.activo !=0) {
                    Label actividad = new Label();
                    actividad.Text = actividades[i].titulo;
                    actividad.Name = actividades[i].id.ToString();
                    actividad.BackColor = System.Drawing.Color.LightGray;
                    actividad.Cursor = System.Windows.Forms.Cursors.Hand;
                    actividad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    actividad.Location = new System.Drawing.Point(6, 6);
                    actividad.Margin = new System.Windows.Forms.Padding(6);
                    actividad.MaximumSize = new System.Drawing.Size(141, 88);
                    actividad.MinimumSize = new System.Drawing.Size(141, 88);
                    actividad.Size = new System.Drawing.Size(141, 88);
                    actividad.TabIndex = 7;
                    actividad.Click += new System.EventHandler((sender1, e1) => MostrarActividad(sender1, e1, actividad.Name));
                    pnActividades.Controls.Add(actividad);
                    }
                }
            }catch(Exception ex)
            {
                Console.Write(ex + "No se encontraron actividades pertenecientes a el usuario" + usuario.nombre);
            }

            try
            {
                for (int i = 0; i < modificaciones.Length; i++)
                {
                    Label modificacion = new Label();
                    modificacion.BackColor = System.Drawing.Color.Gainsboro;
                    modificacion.Cursor = System.Windows.Forms.Cursors.Hand;
                    modificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    modificacion.Location = new System.Drawing.Point(6, 6);
                    modificacion.Margin = new System.Windows.Forms.Padding(3);
                    modificacion.Text = modificaciones[i].descripcion;
                    modificacion.Name = modificaciones[i].id.ToString();
                    modificacion.Size = new System.Drawing.Size(440, 25);
                    modificacion.TabIndex = 2;
                    modificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    modificacion.Click += new System.EventHandler((sender1, e1) => VerModificacion(sender1, e1, modificacion.Name));
                    listaModificaciones.Controls.Add(modificacion);
                }
            }catch(Exception ex)
            {
                Console.Write(ex + "No se encontraron modificaciones pertenecientes a el usuario" + usuario.nombre);
            }

            try
            {
                for (int i = 0; i < equipos.Length; i++)
                {
                    Label equipo = new Label();
                    equipo.BackColor = System.Drawing.Color.Gainsboro;
                    equipo.Cursor = System.Windows.Forms.Cursors.Hand;
                    equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    equipo.Location = new System.Drawing.Point(6, 6);
                    equipo.Margin = new System.Windows.Forms.Padding(3);
                    equipo.Text = equipos[i].nombre;
                    equipo.Name = equipos[i].id.ToString();
                    equipo.Size = new System.Drawing.Size(440, 25);
                    equipo.TabIndex = 2;
                    equipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    equipo.Click += new System.EventHandler((sender1, e1) => MostrarEquipo(sender1, e1, equipo.Name));
                    listaTableros.Controls.Add(equipo);
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex + "No se encontraron equipos a los que pertenzca el usuario" + usuario.nombre);
            }

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
        
        private void lbConfig_Click(object sender, EventArgs e)
        {
            lbConfig.BackColor = Color.FromArgb(224,224,224);
            lbActividades.BackColor = Color.FromArgb(200, 200, 200);
            lbPerfil.BackColor = Color.FromArgb(200, 200, 200);
            panelConfiguracion.Visible = true;
            panelActividades.Visible = false;
            panelPerfil.Visible = false;
        }

        private void VerModificacion(object sender, EventArgs e, string id)
        {
            MostrarModificacion mostrarModificacion = new MostrarModificacion(Convert.ToInt32(id));
            mostrarModificacion.ShowDialog();
        }

        private void MostrarEquipo(object sender, EventArgs e, string id)
        {
            
            Equipo equipo = new Equipo(Convert.ToInt32(id),usuario.id);
            equipo.Show();
            this.Visible = false;
         }

        private void lbActividades_Click(object sender, EventArgs e)
        {
            lbActividades.BackColor = Color.FromArgb(224, 224, 224);
            lbConfig.BackColor = Color.FromArgb(200, 200, 200);
            lbPerfil.BackColor = Color.FromArgb(200, 200, 200);
            panelActividades.Visible = true;
            panelConfiguracion.Visible = false;
            panelPerfil.Visible = false;
        }

        private void lbPerfil_Click(object sender, EventArgs e)
        {
            lbPerfil.BackColor = Color.FromArgb(244, 244, 244);
            lbActividades.BackColor = Color.FromArgb(200, 200, 200);
            lbConfig.BackColor = Color.FromArgb(200, 200, 200);
            panelPerfil.Visible = true;
            panelActividades.Visible = false;
            panelConfiguracion.Visible = false;
        }

        private void lblCambiarNombre_Click(object sender, EventArgs e)
        {
            EditarNombre en = new EditarNombre(usuario.id,this);
            en.ShowDialog();
        }

        private void lblCambiarContra_Click(object sender, EventArgs e)
        {
            EditarContrasena en = new EditarContrasena(usuario.id);
            en.ShowDialog();
        }

        private void lblCambiarCorreo_Click(object sender, EventArgs e)
        {
            EditarCorreo en = new EditarCorreo(usuario.id);
            en.ShowDialog();
        }

        public void MostrarActividad(object sender, EventArgs e, string id)
        {
            ModalMostrarActividad f2 = new ModalMostrarActividad();
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
            ModuloWS.modulo modulo = modulows.SeleccionarModulo(actividadws.SeleccionarActividad(Convert.ToInt32(id)).idModulo);
            TableroWS.tablero tablero = tablerows.SeleccionarTablero(modulows.SeleccionarModulo(actividadws.SeleccionarActividad(Convert.ToInt32(id)).idModulo).idTablero);
            Tablero t = new Tablero(usuario.id, tablero.id);
            t.Show();
            Actividad a = new Actividad(Convert.ToInt32(id),usuario.id,t);
            a.Show();
                this.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Index i = new Index(usuario.id);
            i.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ventanaTableros.Visible == true)
            {
                ventanaTableros.Visible = false;
            }
            else
            {
                ventanaTableros.Visible = true;
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (ventanaUsuario.Visible == true)
            {
                ventanaUsuario.Visible = false;
            }
            else
            {
                ventanaUsuario.Visible = true;
            }
        }

        private void btnCrearTablero_Click(object sender, EventArgs e)
        {
            ModalAgregarTablero f2 = new ModalAgregarTablero();
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
                int id = tablerows.AgregarTablero(f2.TextBox1.Text);
                tablerousuariows.CrearTableroUsuario(id, usuario.id,"ADMIN");
                Button b = new Button();
                b.Width = 210;
                b.Height = 30;
                b.Text = tablerows.SeleccionarTablero(id).titulo;
                b.Name = tablerows.SeleccionarTablero(id).id.ToString();
                tablerousuariows.CrearTableroUsuario(id, usuario.id, "ADMIN");
                b.Click += new System.EventHandler((sender1, e1) => AbrirTablero(sender1, e1, b));
                pnTableros.Controls.Add(b);
                modificacionws.CrearModificacion("Creacion de tablero " + " " + tablerows.SeleccionarTablero(id).titulo,
                                                 DateTime.Now.ToString(),
                                                 id,
                                                 usuario.id);
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            lbPerfil.BackColor = Color.FromArgb(244, 244, 244);
            lbActividades.BackColor = Color.FromArgb(200, 200, 200);
            lbConfig.BackColor = Color.FromArgb(200, 200, 200);
            panelPerfil.Visible = true;
            panelActividades.Visible = false;
            panelConfiguracion.Visible = false;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            lbConfig.BackColor = Color.FromArgb(224, 224, 224);
            lbActividades.BackColor = Color.FromArgb(200, 200, 200);
            lbPerfil.BackColor = Color.FromArgb(200, 200, 200);
            panelConfiguracion.Visible = true;
            panelActividades.Visible = false;
            panelPerfil.Visible = false;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Visible = false;
        }

        private void AbrirTablero(object sender, EventArgs e, Button b)
        {
            Tablero f = new Tablero(usuario.id, Convert.ToInt32(b.Name));
            f.Show();
            this.Visible = false;
        }
    }
}
