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
    public partial class Actividad : Form
    {
        ActividadWS.actividad actividad;
        ActividadWS.ActividadWSClient actividadws = new ActividadWS.ActividadWSClient();
        ModuloWS.ModuloWSClient modulows = new ModuloWS.ModuloWSClient();
        TableroWS.TableroWSClient tablerows = new TableroWS.TableroWSClient();
        ModificacionWS.ModificacionWSClient modificacionws = new ModificacionWS.ModificacionWSClient();
        ComentarioWS.ComentarioWSClient comentariows = new ComentarioWS.ComentarioWSClient();
        UsuarioWS.UsuarioWSClient usuariows = new UsuarioWS.UsuarioWSClient();
        int idActividad;
        int idUser;
        ProyectoEscritorio.Tablero form;

        public Actividad()
        {
            InitializeComponent();
        }

        public Actividad(int idActividad, int idUser, ProyectoEscritorio.Tablero form)
        {
            this.idActividad = idActividad;
            this.form = form;
            this.idUser = idUser;
            actividad = actividadws.SeleccionarActividad(idActividad);
            InitializeComponent();
        }

        private void Actividad_Load(object sender, EventArgs e)
        {
            tituloActividad.Text = actividad.titulo;
            descripcionActividad.Text = actividad.descripcion;
            label6.Text = actividad.vencimiento;
            checkEstado.Checked = Convert.ToBoolean(actividad.estado);

            try
            {

               ComentarioWS.comentario[] comentarios = comentariows.ObtenerComentariosDeActividad(idActividad);

                for (int i = 0; i < comentarios.Length; i++)
                {
                    Label label2 = new Label();
                    label2.BackColor = System.Drawing.SystemColors.Info;
                    label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    label2.Location = new System.Drawing.Point(3, 3);
                    label2.Margin = new System.Windows.Forms.Padding(3);
                    label2.Name = comentarios[i].id.ToString();
                    label2.Text = comentarios[i].descripcion + "\n" + "-" +
                                  usuariows.SeleccionarUsuario(comentarios[i].idUsuario).nombre + "  -" +
                                  comentarios[i].fecha;
                    label2.Size = new System.Drawing.Size(288, 42);
                    label2.TabIndex = 2;
                    tlpComentarios.Controls.Add(label2);
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex);

            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModalEliminarActividad f2 = new ModalEliminarActividad();
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
                ModuloWS.modulo modulo = modulows.SeleccionarModulo(actividadws.SeleccionarActividad(actividad.id).idModulo);
                TableroWS.tablero tablero = tablerows.SeleccionarTablero(modulows.SeleccionarModulo(actividadws.SeleccionarActividad(actividad.id).idModulo).idTablero);
                actividadws.EliminarActividadVirtual(actividad.id);
                modificacionws.CrearModificacion("Eliminacion de actividad " + actividad.estado +
                                                 " de modulo " + modulo.nombre +
                                                 " en tablero " + tablero.titulo,
                                                 DateTime.Now.ToString(), tablero.id, idUser);
                
                this.Visible = false;
                form.Visible = false;
                Tablero t = new Tablero(idUser,tablero.id);
                t.Show();
            }
        }

        private void lblMiembros_Click(object sender, EventArgs e)
        {
            ModuloWS.modulo modulo = modulows.SeleccionarModulo(actividadws.SeleccionarActividad(actividad.id).idModulo);
            TableroWS.tablero tablero = tablerows.SeleccionarTablero(modulows.SeleccionarModulo(actividadws.SeleccionarActividad(actividad.id).idModulo).idTablero);
            ModalMiembrosActividad mma = new ModalMiembrosActividad(idActividad, idUser, tablero.id);
            mma.Show();
        }

        private void lblEditarDescripcion_Click(object sender, EventArgs e)
        {
            actividad = actividadws.SeleccionarActividad(idActividad);

            ModalEditarDescripcion f2 = new ModalEditarDescripcion();
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
                actividadws.EditarActividad(actividad.id, actividad.titulo, f2.descripcionActividad.Text, actividad.vencimiento, actividad.estado);
                descripcionActividad.Text = f2.descripcionActividad.Text;
            }

        }

        private void checkEstado_CheckedChanged(object sender, EventArgs e)
        {
            actividad = actividadws.SeleccionarActividad(idActividad);
            if (checkEstado.Checked == true)
            {
                actividadws.EditarActividad(actividad.id, actividad.titulo, actividad.descripcion, actividad.vencimiento, "true");
            }
            else
            {
                actividadws.EditarActividad(actividad.id, actividad.titulo, actividad.descripcion, actividad.vencimiento, "false");
            }
        }

        private void lblEditarVencimiento_Click(object sender, EventArgs e)
        {

        }

        private void vencimientoSelect_ValueChanged(object sender, EventArgs e)
        {
            actividad = actividadws.SeleccionarActividad(idActividad);
            string fecha = vencimientoSelect.Text.Replace('-','d');
            fecha = fecha.Replace('.', 'e');
            label6.Text = fecha; 
            actividadws.EditarActividad(actividad.id, actividad.titulo, actividad.descripcion, fecha, actividad.estado);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            ModalAgregarComentario f2 = new ModalAgregarComentario();
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK && !f2.textBox1.Text.Equals(string.Empty))
            {
                int id = comentariows.CrearComentario(f2.textBox1.Text,DateTime.Now.ToString(), idActividad,idUser);
                Label label2 = new Label();
                label2.BackColor = System.Drawing.SystemColors.Info;
                label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                label2.Location = new System.Drawing.Point(3, 3);
                label2.Margin = new System.Windows.Forms.Padding(3);
                label2.Name = id.ToString();
                label2.Text = comentariows.SeleccionarComentario(id).descripcion + "\n" + "-" +
                              usuariows.SeleccionarUsuario(idUser).nombre + "  -" +
                             comentariows.SeleccionarComentario(id).fecha;
                label2.Size = new System.Drawing.Size(288, 42);
                label2.TabIndex = 2;
                tlpComentarios.Controls.Add(label2);
            }
        }

    }
}
