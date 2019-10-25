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
    public partial class MostrarModificacion : Form
    {

        ModificacionWS.ModificacionWSClient modificacionws = new ModificacionWS.ModificacionWSClient();

        public MostrarModificacion()
        {
            InitializeComponent();
        }

        public MostrarModificacion(int id)
        {
            ModificacionWS.modificacion modificacion = modificacionws.SeleccionarModificacion(id);
            InitializeComponent();
            lblDescripcion.Text = modificacion.descripcion;
            lblFecha.Text = modificacion.fecha;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
