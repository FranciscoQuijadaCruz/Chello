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

    public partial class Tablero : Form
    {
        /*
            Pistas creadas al momento de que se pasa por encima de un componente.
        */
        ToolTip toolTip1 = new ToolTip();


        /*
         Instancias de entidades provinientes del web service.
        */
        UsuarioWS.UsuarioWSClient usuariows = new UsuarioWS.UsuarioWSClient();
        UsuarioWS.usuario usuario;
        TableroWS.tablero tablero;
        TableroWS.TableroWSClient tablerows = new TableroWS.TableroWSClient();
        tableroUsuarioWS.tableroUsuarioWSClient tablerousuariows = new tableroUsuarioWS.tableroUsuarioWSClient();
        ModuloWS.ModuloWSClient modulows = new ModuloWS.ModuloWSClient();
        ActividadUsuarioWS.ActividadUsuarioWSClient actividadusuariows = new ActividadUsuarioWS.ActividadUsuarioWSClient();
        ActividadWS.ActividadWSClient actividadws = new ActividadWS.ActividadWSClient();
        ModificacionWS.ModificacionWSClient modificacionws = new ModificacionWS.ModificacionWSClient();

        public Tablero()
        {
            InitializeComponent();
        }

        public Tablero(int idUsuario, int idTablero)
        {
            this.usuario = usuariows.SeleccionarUsuario(idUsuario);
            this.tablero = tablerows.SeleccionarTablero(idTablero);
            InitializeComponent();
        }

        private void btnCrearTablero_Click(object sender, EventArgs e)
        {
            ModalAgregarTablero f2 = new ModalAgregarTablero(); 
            DialogResult res = f2.ShowDialog(); 

            if (res == DialogResult.OK)
            {
                int id = tablerows.AgregarTablero(f2.TextBox1.Text);
                tablerousuariows.CrearTableroUsuario(id,usuario.id,"ADMIN");
                Button b = new Button();
                b.Width = 210;
                b.Height = 30;
                b.Text = tablerows.SeleccionarTablero(id).titulo;
                b.Name = tablerows.SeleccionarTablero(id).id.ToString();
                b.Click += new System.EventHandler((sender1, e1) => AbrirTablero(sender1, e1, b));
                tablerousuariows.CrearTableroUsuario(id, usuario.id, "ADMIN");
                pnTableros.Controls.Add(b);
                modificacionws.CrearModificacion("Creacion de tablero " + tablerows.SeleccionarTablero(id).titulo,
                                                 DateTime.Now.ToString(),
                                                 id,
                                                 usuario.id);
            }
        }

        private void btnVerTableros_Click(object sender, EventArgs e)
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

        private void BtnCrearModulo(object sender, EventArgs e)
        {

            ModalAgregarModulo f2 = new ModalAgregarModulo();
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
                int id = modulows.AgregarModulo(f2.TextBox1.Text, tablero.id);
                modificacionws.CrearModificacion("Creacion de modulo "+ " " + f2.TextBox1.Text + " en tablero " + tablero.titulo,
                                                 DateTime.Now.ToString(),
                                                 tablero.id,
                                                 usuario.id);

                TableLayoutPanel tlp = new TableLayoutPanel();
                tlp.Name = id.ToString();
                tlp.Size = new System.Drawing.Size(139, 288);

                Button nombreM = new Button();
                nombreM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                nombreM.Cursor = System.Windows.Forms.Cursors.Hand;
                nombreM.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                nombreM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                nombreM.Name = id.ToString();
                nombreM.Size = new System.Drawing.Size(133, 25);
                nombreM.Margin = new System.Windows.Forms.Padding(0);
                nombreM.Text = modulows.SeleccionarModulo(id).nombre;
                nombreM.UseVisualStyleBackColor = false;
                nombreM.Click += new System.EventHandler((sender1, e1) => EditarModulo(sender1, e1, nombreM));
                TableLayoutPanel pnActividades = new TableLayoutPanel();
                pnActividades.AllowDrop = true;
                pnActividades.AutoScroll = true;
                pnActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                pnActividades.Cursor = System.Windows.Forms.Cursors.Default;
                pnActividades.ImeMode = System.Windows.Forms.ImeMode.On;
                pnActividades.Margin = new System.Windows.Forms.Padding(0);
                pnActividades.Size = new System.Drawing.Size(133, 209);
                pnActividades.Name = id.ToString();
                Button nuevaTarjeta = new Button();
                nuevaTarjeta.BackColor = System.Drawing.SystemColors.InactiveCaption;
                nuevaTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
                nuevaTarjeta.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                nuevaTarjeta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                nuevaTarjeta.Name = id.ToString();
                nuevaTarjeta.Size = new System.Drawing.Size(133, 26);
                nuevaTarjeta.Text = "+Crear nueva tarjeta";
                nuevaTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                nuevaTarjeta.Margin = new System.Windows.Forms.Padding(0);
                nuevaTarjeta.Click += new System.EventHandler((sender1, e1) => AgregarActividad(sender1, e1, pnActividades));
                Button eliminar = new Button();
                eliminar.BackColor = System.Drawing.SystemColors.InactiveCaption;
                eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
                eliminar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                eliminar.Name = id.ToString();
                eliminar.Size = new System.Drawing.Size(133, 26);
                eliminar.Text = "Eliminar modulo";
                eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                eliminar.Margin = new System.Windows.Forms.Padding(0);
                eliminar.Click += new System.EventHandler((sender1, e1) => eliminarModulo(sender1, e1, tlp));

                tlp.Controls.Add(nombreM);
                tlp.Controls.Add(pnActividades);
                tlp.Controls.Add(nuevaTarjeta);
                tlp.Controls.Add(eliminar);
                Padding m = tlp.Margin;
                tlp.Margin = new Padding(0, 0, 0, 0);
                pnModulos.Controls.Add(tlp);
                pnModulos.SetColumn(tlp, 0);
                pnModulos.SetColumn(btnCrearModulo, pnModulos.Controls.Count);

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
            Perfil p = new Perfil(usuario.id,"P");
            p.Show();
            this.Visible = false;
        }

        public void eliminarModulo(object sender, EventArgs e, TableLayoutPanel tlp)
        {
            pnModulos.Controls.Remove(tlp);
            modulows.EliminarModuloVirtual(Convert.ToInt32(tlp.Name));
            modificacionws.CrearModificacion("Eliminacion de modulo " + " " + 
                                              modulows.SeleccionarModulo(Convert.ToInt32(tlp.Name)).nombre,
                                                             DateTime.Now.ToString(),
                                                             tablero.id,
                                                             usuario.id);
        }

        public void AgregarActividad(object sender, EventArgs e, TableLayoutPanel tlp)
        {
            ModalAgregarActividad f2 = new ModalAgregarActividad(); 
            DialogResult res = f2.ShowDialog(); 

            if (res == DialogResult.OK)
            {
                int id = actividadws.AgregarActividad(f2.nombreModulo.Text, "", "", "false", Convert.ToInt32(tlp.Name));

                Label l = new Label();
                TableLayoutPanel actividad = new TableLayoutPanel();
                actividad.Size = new System.Drawing.Size(127, 50);
                actividad.BackColor = System.Drawing.SystemColors.InactiveCaption;
                actividad.Name = id.ToString();
                l.Text = actividadws.SeleccionarActividad(id).titulo;
                l.Height = 50;
                l.Name = id.ToString();
                l.Cursor = System.Windows.Forms.Cursors.Hand;
                l.Click += new System.EventHandler((sender1, e1) => MostrarActividad(sender1, e1, actividad.Name));
                actividad.Controls.Add(l);
                tlp.Controls.Add(actividad);
                modificacionws.CrearModificacion("Creacion de actividad " +
                                                  actividadws.SeleccionarActividad(id).titulo + " en modulo " + 
                                                  modulows.SeleccionarModulo(Convert.ToInt32(tlp.Name)) + " de tablero" + 
                                                  tablerows.SeleccionarTablero(tablero.id).titulo,
                                                                            DateTime.Now.ToString(),
                                                                            tablero.id,
                                                                            usuario.id);
            }

        }

        public void EditarModulo(object sender, EventArgs e, Button b)
        {
            ModalEditarModulo f2 = new ModalEditarModulo();
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
                if (!f2.TextBox1.Text.Equals(string.Empty))
                {
                    modulows.EditarModulo(f2.TextBox1.Text, Convert.ToInt32(b.Name));
                    b.Text = f2.TextBox1.Text;
                    modificacionws.CrearModificacion("Edicion de nombre en modulo " +
                                                  modulows.SeleccionarModulo(Convert.ToInt32(b.Name)) + " de tablero" +
                                                  tablerows.SeleccionarTablero(tablero.id).titulo,
                                                                            DateTime.Now.ToString(),
                                                                            tablero.id,
                                                                            usuario.id);
                }
            }

        }

        public void MostrarActividad(object sender, EventArgs e, string id) {
            Actividad a = new Actividad(Convert.ToInt32(id),usuario.id,this);
            a.ShowDialog();
                }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Perfil p = new Perfil(usuario.id,"C");
            p.Show();
            this.Visible = false;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Visible = false;
        }

        private void agregarActividadesAModulo(ModuloWS.modulo modulo, TableLayoutPanel tlp) {

            try { 

            ActividadWS.actividad[] actividades = actividadws.ObtenerActividadesDeModulo(modulo.id);

            for (int i = 0; i < actividades.Length; i++) {
                    if (actividades[i].activo != 0)
                    {
                        Label l = new Label();
                        TableLayoutPanel actividad = new TableLayoutPanel();
                        actividad.Size = new System.Drawing.Size(127, 50);
                        actividad.BackColor = System.Drawing.SystemColors.InactiveCaption;
                        actividad.Name = actividades[i].id.ToString();
                        l.Text = actividades[i].titulo;
                        l.Height = 50;
                        l.Width = 127;
                        l.Name = actividades[i].id.ToString();
                        l.Cursor = System.Windows.Forms.Cursors.Hand;
                        l.Click += new System.EventHandler((sender1, e1) => MostrarActividad(sender1, e1, actividad.Name));
                        actividad.Controls.Add(l);
                        tlp.Controls.Add(actividad);
                    }
            }

            }catch(Exception ex)
            {
                Console.Write(ex + "No se encontraron actividades en el modulo" + tlp.Name);
            }


        }

        private void AbrirTablero(object sender, EventArgs e, Button b)
        {
            Tablero f = new Tablero(usuario.id, Convert.ToInt32(b.Name));
            f.Show();
            this.Visible = false;
        }

        private void Tablero_Load(object sender, EventArgs e)
        {
            lblNombreTablero.Text = tablerows.SeleccionarTablero(tablero.id).titulo;
            lblUsuario.Text = usuariows.SeleccionarUsuario(usuario.id).nombre;
            tableroUsuarioWS.tablero[] tableros = tablerousuariows.ObtenerTablerosDeUsuario(usuario.id);
            ModuloWS.modulo[] modulos = modulows.ObtenerModulosDeTablero(tablero.id);
            tableroUsuarioWS.usuario[] usuarios = tablerousuariows.ObtenerUsuariosDeTablero(tablero.id);

            try
            {
                for(int ux = 0; ux < usuarios.Length; ux++)
                {
                    if(!(usuarios[ux].id == usuario.id)) { 
                    Button b = new Button();
                    b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                    b.BackColor = System.Drawing.SystemColors.Highlight;
                    b.Cursor = System.Windows.Forms.Cursors.Hand;
                    b.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    b.ForeColor = System.Drawing.Color.White;
                    b.Location = new System.Drawing.Point(3, 3);
                    b.Name = usuarios[ux].id.ToString();
                    b.Size = new System.Drawing.Size(182, 30);
                    b.TabIndex = 31;
                    b.Text = usuarios[ux].nombre;
                    b.UseVisualStyleBackColor = false;
                    if (tablerousuariows.SeleccionarTableroUsuario(tablerousuariows.SeleccionarIdPorTableroYUsuario(tablero.id,usuario.id)).rol.Equals("ADMIN"))
                    {
                        b.Click += new System.EventHandler((sender1, e1) => EliminarMiembro(sender1, e1, b));
                    }
                    pnMiembros.Controls.Add(b);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex);
            }

            try{

            for (int i = 0; i < tableros.Length; i++)
            {
                if(tableros[i].activo != 0) {
                   Button b = new Button();
                   b.Width = 210;
                   b.Height = 30;
                   b.Text = tableros[i].titulo;
                   b.Name = tableros[i].id.ToString();
                   b.Click += new System.EventHandler((sender1, e1) => AbrirTablero(sender1, e1, b));
                   pnTableros.Controls.Add(b);
                }
            }

            }catch(Exception ex)
            {
                Console.Write(ex + "No hay tableros para mostrar en el aside Tableros.");
            }

            try
            {

                for (int i = 0; i < modulos.Length; i++)
                {
                    if (modulos[i].activo != 0) {
                        TableLayoutPanel tlp = new TableLayoutPanel();
                        tlp.Name = modulos[i].id.ToString();
                        tlp.Size = new System.Drawing.Size(139, 288);

                        Button nombreM = new Button();
                        nombreM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                        nombreM.Cursor = System.Windows.Forms.Cursors.Hand;
                        nombreM.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        nombreM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                        nombreM.Name = modulos[i].id.ToString();
                        nombreM.Size = new System.Drawing.Size(133, 25);
                        nombreM.Margin = new System.Windows.Forms.Padding(0);
                        nombreM.TabIndex = 11;
                        nombreM.Text = modulos[i].nombre;
                        nombreM.UseVisualStyleBackColor = false;
                        nombreM.Click += new System.EventHandler((sender1, e1) => EditarModulo(sender1, e1, nombreM));
                        TableLayoutPanel pnActividades = new TableLayoutPanel();
                        pnActividades.AllowDrop = true;
                        pnActividades.AutoScroll = true;
                        pnActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                        pnActividades.Name = modulos[i].id.ToString();
                        pnActividades.Cursor = System.Windows.Forms.Cursors.Default;
                        pnActividades.ImeMode = System.Windows.Forms.ImeMode.On;
                        pnActividades.Margin = new System.Windows.Forms.Padding(0);
                        pnActividades.Size = new System.Drawing.Size(133, 209);
                        Button nuevaTarjeta = new Button();
                        nuevaTarjeta.BackColor = System.Drawing.SystemColors.InactiveCaption;
                        nuevaTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
                        nuevaTarjeta.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        nuevaTarjeta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                        nuevaTarjeta.Size = new System.Drawing.Size(133, 26);
                        nuevaTarjeta.TabIndex = 12;
                        nuevaTarjeta.Name = modulos[i].id.ToString();
                        nuevaTarjeta.Text = "+Crear nueva tarjeta";
                        nuevaTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        nuevaTarjeta.Margin = new System.Windows.Forms.Padding(0);
                        nuevaTarjeta.Click += new System.EventHandler((sender1, e1) => AgregarActividad(sender1, e1, pnActividades));
                        Button eliminar = new Button();
                        eliminar.BackColor = System.Drawing.SystemColors.InactiveCaption;
                        eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
                        eliminar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                        eliminar.Size = new System.Drawing.Size(133, 26);
                        eliminar.Text = "Eliminar modulo";
                        eliminar.Name = modulos[i].id.ToString();
                        eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        eliminar.Margin = new System.Windows.Forms.Padding(0);
                        eliminar.Click += new System.EventHandler((sender1, e1) => eliminarModulo(sender1, e1, tlp));

                        tlp.Controls.Add(nombreM);
                        tlp.Controls.Add(pnActividades);
                        tlp.Controls.Add(nuevaTarjeta);
                        tlp.Controls.Add(eliminar);
                        Padding m = tlp.Margin;
                        tlp.Margin = new Padding(0, 0, 0, 0);
                        pnModulos.Controls.Add(tlp);
                        pnModulos.SetColumn(tlp, 0);
                        pnModulos.SetColumn(btnCrearModulo, pnModulos.Controls.Count);
                        agregarActividadesAModulo(modulos[i], pnActividades);
                    }
                }
            }catch(Exception ex)
            {
                Console.Write(ex + "No hay modulos para mostrar en el tablero actual.");
            }
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            Index i = new Index(usuario.id);
            i.Show();
            this.Visible = false;
        }

        private void btnAgregarMiembro_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Agregar miembro";
            toolTip1.Show("Dar click para agregar un nuevo miembro al tablero.", btnAgregarMiembro);
        }

        public void EliminarMiembro(object sender, EventArgs e, Button b)
        {
            ModalEliminarMiembro f2 = new ModalEliminarMiembro();
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
                tablerousuariows.EliminarTableroUsuario(tablerousuariows.SeleccionarIdPorTableroYUsuario(tablero.id, Convert.ToInt32(b.Name)));
                this.Visible = false;
                Tablero t = new Tablero(usuario.id, tablero.id);
                t.Show();
            }
        }

        private void btnAgregarMiembro_Click(object sender, EventArgs e)
        {
            ModalAgregarUsuario mau = new ModalAgregarUsuario(usuario.id,tablero.id,this);
            mau.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (pnConfiguracion.Visible == true)
            {
                pnConfiguracion.Visible = false;
            }
            else
            {
                pnConfiguracion.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModalEditarTablero f2 = new ModalEditarTablero(usuario,tablero,this);
            f2.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ModalEliminarTablero f2 = new ModalEliminarTablero();
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
                tablerows.EliminarTablero(tablero.id);
                Index i = new Index(usuario.id);
                i.Show();
                this.Visible = false;
            }
        }
    }
}
