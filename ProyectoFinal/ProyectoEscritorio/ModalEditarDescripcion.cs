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
    public partial class ModalEditarDescripcion : Form
    {
        public ModalEditarDescripcion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
