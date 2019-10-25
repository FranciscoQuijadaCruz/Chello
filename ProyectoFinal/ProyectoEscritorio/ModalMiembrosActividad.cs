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
    public partial class ModalMiembrosActividad : Form
    {
        TableroWS.TableroWSClient tablerows = new TableroWS.TableroWSClient();
        ActividadWS.ActividadWSClient actividadws = new ActividadWS.ActividadWSClient();
        ModuloWS.ModuloWSClient modulows = new ModuloWS.ModuloWSClient();
        UsuarioWS.UsuarioWSClient usuariows = new UsuarioWS.UsuarioWSClient();
        ActividadUsuarioWS.ActividadUsuarioWSClient actividadusuariows = new ActividadUsuarioWS.ActividadUsuarioWSClient();
        tableroUsuarioWS.tableroUsuarioWSClient tablerousuariows = new tableroUsuarioWS.tableroUsuarioWSClient();
        ModificacionWS.ModificacionWSClient modificacionws = new ModificacionWS.ModificacionWSClient();
        int idActividad;
        int idUsuario;
        int idTablero;

        public ModalMiembrosActividad()
        {
            InitializeComponent();
        }

        public ModalMiembrosActividad(int idActividad, int idUsuario, int idTablero)
        {
            this.idTablero = idTablero;
            this.idActividad = idActividad;
            this.idUsuario = idUsuario;
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ModalAgregarMiembro f2 = new ModalAgregarMiembro(idTablero, idActividad);
            DialogResult res = f2.ShowDialog();

            if (res == DialogResult.OK)
            {
               UsuarioWS.usuario u =  usuariows.SeleccionarUsuario(Convert.ToInt32(f2.label1.Text));
                actividadusuariows.AgregarActividadUsuario(idActividad, u.id);
                Label label3 = new Label();
                label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                label3.Cursor = System.Windows.Forms.Cursors.Hand;
                label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label3.ForeColor = System.Drawing.SystemColors.Control;
                label3.Image = global::ProyectoEscritorio.Properties.Resources.bbn;
                label3.Location = new System.Drawing.Point(3, 3);
                label3.Margin = new System.Windows.Forms.Padding(3);
                label3.Name = u.id.ToString();
                label3.Size = new System.Drawing.Size(214, 23);
                label3.TabIndex = 8;
                label3.Text = u.email;
                label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                pnMiembros.Controls.Add(label3);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ModalMiembrosActividad_Load(object sender, EventArgs e)
        {
            try
            {
              ActividadUsuarioWS.usuario[] usuario = actividadusuariows.ObtenerUsuariosDeActividad(idActividad);

                for(int i = 0; i < usuario.Length; i++)
                {
                    Label label3 = new Label();
                    label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    label3.Cursor = System.Windows.Forms.Cursors.Hand;
                    label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label3.ForeColor = System.Drawing.SystemColors.Control;
                    label3.Image = global::ProyectoEscritorio.Properties.Resources.bbn;
                    label3.Location = new System.Drawing.Point(3, 3);
                    label3.Margin = new System.Windows.Forms.Padding(3);
                    label3.Name = usuario[i].id.ToString();
                    label3.Size = new System.Drawing.Size(214, 23);
                    label3.TabIndex = 8;
                    label3.Text = usuario[i].email;
                    label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    pnMiembros.Controls.Add(label3);
                }

            } catch(Exception ex)
            {
                Console.Write(ex);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
