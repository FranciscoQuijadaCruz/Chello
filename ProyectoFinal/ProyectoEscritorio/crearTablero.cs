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
    public partial class crearTablero : Form
    {
        TableroWS.TableroWSClient tablerows = new TableroWS.TableroWSClient();
        UsuarioWS.UsuarioWSClient usuariows = new UsuarioWS.UsuarioWSClient();
        tableroUsuarioWS.tableroUsuarioWSClient tableroUsuariows = new tableroUsuarioWS.tableroUsuarioWSClient();
        ModificacionWS.ModificacionWSClient modificacionws = new ModificacionWS.ModificacionWSClient();
        ProyectoEscritorio.Index index;
        TableroWS.tablero tablero = new TableroWS.tablero();
        UsuarioWS.usuario usuario = new UsuarioWS.usuario();
        tableroUsuarioWS.tableroUsuario tableroUsuario = new tableroUsuarioWS.tableroUsuario();
        ModificacionWS.modificacion modificacion = new ModificacionWS.modificacion();

        public crearTablero(int idUsuario, ProyectoEscritorio.Index index)
        {
            InitializeComponent();
            this.index = index;
            this.usuario = usuariows.SeleccionarUsuario(idUsuario);
        }

        private void btnCancelarTablero_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptarTablero_Click(object sender, EventArgs e)
        {
            //PREPARA MENSAJE
            string aviso = "Aviso";
            string mensaje = "";

            //VALIDAR TXTNOMBRETABLERO
            if (string.IsNullOrEmpty(txtNombreTablero.Text))
            {

                //VACIO
                mensaje = "Por favor ingresa un nombre";
                MessageBox.Show(mensaje, aviso,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                try
                {
                    //ASIGNAR TIULO AL TABLERO
                    tablero.titulo = txtNombreTablero.Text;
                    //AGREGAR AL WEB SERVICES
                    tablero.id = tablerows.AgregarTablero(tablero.titulo);
                    if (tablero.id != 0)
                    {
                        mensaje = "Se agregó el tablero";
                        MessageBox.Show(mensaje, aviso,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //MODIFICACION VALORES
                        String descripcion = "Se creó en tablero ";
                        DateTime fecha_s = new DateTime();
                        String fecha = Convert.ToString(fecha_s);

                        tableroUsuariows.CrearTableroUsuario(tablero.id, usuario.id, "ADMIN");
                        modificacionws.CrearModificacion(descripcion, fecha, tablero.id, usuario.id);

                        //this.relacionTableroUsuario(tablero.id, usuario.id);//METODO ENTIDAD REL TABLERO_USUARIO
                        //this.modificacionUsuario();//METODO PARA CREAR MODIFICACION
                        Tablero t = new Tablero(usuario.id, tablerows.AgregarTablero(tablero.titulo));
                        t.Show();
                        this.Visible = false;
                        index.Visible = false;
                    }
                    else
                    {
                        mensaje = "ERROR. No se agrego el tablero ";
                        MessageBox.Show(mensaje, aviso,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception)
                {
                    mensaje = "ERROR. No se agrego el tablero";
                    MessageBox.Show(mensaje, aviso,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    //LIMPIAR 
                    txtNombreTablero.Text = "";
                }
            }
        }

        private void btnAceptarTablero_Click_1(object sender, EventArgs e)
        {
            //PREPARA MENSAJE
            string aviso = "Aviso";
            string mensaje = "";

            //VALIDAR TXTNOMBRETABLERO
            if (string.IsNullOrEmpty(txtNombreTablero.Text))
            {

                //VACIO
                mensaje = "Por favor ingresa un nombre";
                MessageBox.Show(mensaje, aviso,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                try
                {
                    //ASIGNAR TIULO AL TABLERO
                    
                    //AGREGAR AL WEB SERVICES
                    tablero.id = tablerows.AgregarTablero(txtNombreTablero.Text);

                    if (tablero.id != 0)
                    {
                        mensaje = "Se agregó el tablero";
                        MessageBox.Show(mensaje, aviso,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //MODIFICACION VALORES
                        String descripcion = "Se creó el tablero ";
                        DateTime fecha_s = new DateTime();
                        String fecha = Convert.ToString(fecha_s);

                        tableroUsuariows.CrearTableroUsuario(tablero.id, usuario.id, "ADMIN");
                        modificacionws.CrearModificacion(descripcion+" "+txtNombreTablero.Text, fecha, tablero.id, usuario.id);

                        //this.relacionTableroUsuario(tablero.id, usuario.id);//METODO ENTIDAD REL TABLERO_USUARIO
                        //this.modificacionUsuario();//METODO PARA CREAR MODIFICACION
                        Tablero t = new Tablero(usuario.id, tablerows.AgregarTablero(tablero.titulo));
                        t.Show();
                        this.Visible = false;
                        index.Visible = false;
                    }
                    else
                    {
                        mensaje = "ERROR. No se agrego el tablero ";
                        MessageBox.Show(mensaje, aviso,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    mensaje = "ERROR. No se agrego el tablero";
                    MessageBox.Show(mensaje, aviso,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    //LIMPIAR 
                    txtNombreTablero.Text = "";
                }
            }
        }

        private void crearTablero_Load(object sender, EventArgs e)
        {

        }

        public void relacionTableroUsuario(int idTablero, int idUsuario)
        {//METODO CREAR RELACION TABLERA/USUARIO

            try
            {

                tableroUsuariows.CrearTableroUsuario(idTablero, idUsuario, "ADMIN");
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
            finally
            {

            }
        }//CIERRE METODO

        public void modificacionUsuario()
        {//METODO CREAR MODIFICACION

            String descripcion = "Se creó en tablero ";
            DateTime fecha_s = new DateTime();
            String fecha = Convert.ToString(fecha_s);

            try
            {
                modificacionws.CrearModificacion(descripcion, fecha, tablero.id, usuario.id);
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
            finally
            {

            }
        }//CIERRE METODO
    }
}