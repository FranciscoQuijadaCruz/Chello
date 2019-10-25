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
    public partial class crearEquipo : Form
    {
        EquipoWS.EquipoWSClient equipows = new EquipoWS.EquipoWSClient();
        UsuarioWS.UsuarioWSClient usuariows = new UsuarioWS.UsuarioWSClient();
        EquipoUsuarioWS.EquipoUsuarioWSClient equipoUsuariows = new EquipoUsuarioWS.EquipoUsuarioWSClient();
        tableroUsuarioWS.tableroUsuarioWSClient tuws = new tableroUsuarioWS.tableroUsuarioWSClient();
        ModificacionWS.modificacion modificacion = new ModificacionWS.modificacion();
        ModificacionWS.ModificacionWSClient modificacionws = new ModificacionWS.ModificacionWSClient();

        EquipoWS.equipo equipo = new EquipoWS.equipo();
        UsuarioWS.usuario usuario = new UsuarioWS.usuario();
        EquipoUsuarioWS.equipoUsuario equipo_usuario = new EquipoUsuarioWS.equipoUsuario();

        ProyectoEscritorio.Index form;

        public crearEquipo(int idUsuario,ProyectoEscritorio.Index form)
        {
            InitializeComponent();
            this.usuario = usuariows.SeleccionarUsuario(idUsuario);
            this.form = form;
        }

        private void btnCancelarEquipo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptarEquipo_Click(object sender, EventArgs e)
        {
            //PREPARA MENSAJE
            string aviso = "Aviso";
            string mensaje = "";

            //VALIDAR TXTNOMBREEQUIPO
            if (string.IsNullOrEmpty(txtNombreEquipo.Text))
            {

                //VACIO
                mensaje = "Por favor ingresa un nombre";
                MessageBox.Show(mensaje, aviso,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(txtDescripcionEquipo.Text))
                {
                    mensaje = "Por favor ingresa una descripción";
                    MessageBox.Show(mensaje, aviso,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        //ASIGNAR VALORES AL EQUIPO
                        equipo.nombre = txtNombreEquipo.Text;
                        equipo.descripcion = txtDescripcionEquipo.Text;
                        //AGREGAR AL WEB SERVICES
                        equipo.id = equipows.AgregarEquipo(equipo.nombre, equipo.descripcion);
                        if (equipo.id != 0)
                        {
                            mensaje = "Se agregó el equipo";
                            MessageBox.Show(mensaje, aviso,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //MODIFICACION VALORES
                            String descripcion = "Se creó el Equipo ";
                            Console.Write(descripcion);
                            DateTime fecha_s = new DateTime();
                            String fecha = Convert.ToString(fecha_s);

                            equipoUsuariows.AgregarEquipoUsuario(equipo.id, usuario.id, "ADMIN");
                            form.Visible = false;
                            //this.relacionEquipoUsuario(equipo.id,usuario.id);//METODO ENTIDAD REL EQUIPO_USUARIO
                            Index i = new Index(usuario.id);
                            i.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            mensaje = "ERROR. No se agrego el equipo ";
                            MessageBox.Show(mensaje, aviso,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    catch (Exception)
                    {
                        mensaje = "ERROR. No se agrego el equipo";
                        MessageBox.Show(mensaje, aviso,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        //LIMPIAR
                        txtNombreEquipo.Text = "";
                        txtDescripcionEquipo.Text = "";
                    }

                }
            }
        }

        private void crearEquipo_Load(object sender, EventArgs e)
        {

        }

        public void relacionEquipoUsuario(int idEquipo, int idUsuario)
        {//METODO CREAR RELACION EQUIPO/USUARIO

            try
            {

                equipoUsuariows.AgregarEquipoUsuario(idEquipo, idUsuario, "ADMIN");
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
            finally
            {

            }
        }//CIERRE METODO RELACION EQUIPO USUARIO

        public void buscarTablero()
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}