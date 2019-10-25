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
    public partial class ModalEditarModulo : Form
    {
        public ModalEditarModulo()
        {
            InitializeComponent();
        }

        private void ModalEditarModulo_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Equals(string.Empty))
            {
                label4.Visible = true;
            }
            else
            {
                this.Visible = false;
            }
        }
    }
}
