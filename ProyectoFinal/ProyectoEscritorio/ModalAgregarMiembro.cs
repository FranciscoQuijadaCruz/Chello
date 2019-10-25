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
    public partial class ModalAgregarMiembro : Form
    {
        tableroUsuarioWS.tableroUsuarioWSClient tablerousuariows = new tableroUsuarioWS.tableroUsuarioWSClient();
        int idTablero;
        ActividadUsuarioWS.ActividadUsuarioWSClient actividadusuariows = new ActividadUsuarioWS.ActividadUsuarioWSClient();
        int idActividad;

        public ModalAgregarMiembro()
        {
            InitializeComponent();
        }

        public ModalAgregarMiembro(int idTablero, int idActividad)
        {
            this.idTablero = idTablero;
            this.idActividad = idActividad;
            InitializeComponent();
        }

        private void ModalAgregarMiembro_Load(object sender, EventArgs e)
        {
            tableroUsuarioWS.usuario[] usuarios = tablerousuariows.ObtenerUsuariosDeTablero(idTablero);
            ActividadUsuarioWS.usuario[] pertenecientes = actividadusuariows.ObtenerUsuariosDeActividad(idActividad);

            try
            {
            for(int i = 0; i < usuarios.Length; i++)
            {
                    bool perteneciente = false;

                    try { 
                        for (int j = 0; j < pertenecientes.Length; j++) {

                            if(usuarios[i].id == pertenecientes[j].id)
                            {
                                perteneciente = true;
                            }
                        }
                    }catch(Exception ex)
                    {
                        Console.Write(ex);

                    }

                    if (!perteneciente)
                    {
                        Label label3 = new Label();
                        label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        label3.Cursor = System.Windows.Forms.Cursors.Hand;
                        label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label3.ForeColor = System.Drawing.SystemColors.Control;
                        label3.Image = global::ProyectoEscritorio.Properties.Resources.bbn;
                        label3.Location = new System.Drawing.Point(3, 3);
                        label3.Margin = new System.Windows.Forms.Padding(3);
                        label3.Name = usuarios[i].id.ToString();
                        label3.Size = new System.Drawing.Size(214, 23);
                        label3.TabIndex = 8;
                        label3.Text = usuarios[i].email;
                        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        label3.Click += new System.EventHandler((sender1, e1) => deshabilitarBoton(sender1, e1, Convert.ToInt32(label3.Name)));
                        pnMiembros.Controls.Add(label3);
                    }


                }
            }catch(Exception ex)
            {
                Console.Write(ex);

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void deshabilitarBoton(object sender, EventArgs e, int idUser)
        {
            btnEliminar.Enabled = true;
            label1.Text = idUser.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
