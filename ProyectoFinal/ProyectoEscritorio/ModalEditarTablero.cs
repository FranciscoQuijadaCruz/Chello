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
    public partial class ModalEditarTablero : Form
    {

        UsuarioWS.usuario usuario;
        TableroWS.tablero tablero;
        TableroWS.TableroWSClient tablerows = new TableroWS.TableroWSClient();
        ProyectoEscritorio.Tablero form;

        public ModalEditarTablero()
        {
            InitializeComponent();
        }

        public ModalEditarTablero(UsuarioWS.usuario usuario, TableroWS.tablero tablero, ProyectoEscritorio.Tablero form)
        {
            this.usuario = usuario;
            this.tablero = tablero;
            this.form = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Equals(string.Empty))
            {
                label4.Visible = true;
            }
            else
            {
                tablerows.EditarTablero(tablero.id, TextBox1.Text);
                form.Visible = false;
                this.Visible = false;
                Tablero t = new Tablero(usuario.id, tablero.id);
                t.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
