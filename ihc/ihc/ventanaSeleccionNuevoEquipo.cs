using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ihc
{
    public partial class ventanaSeleccionNuevoEquipo : Form
    {
        public ventanaSeleccionNuevoEquipo()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ventanaNuevoEquipo ventanaNuevoEquipo = new ventanaNuevoEquipo();
            ventanaNuevoEquipo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ventanaCategorias ventanaCategorias = new ventanaCategorias();
            ventanaCategorias.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ventanaModeloMaquinas ventanaModeloMaquionas = new ventanaModeloMaquinas();
            ventanaModeloMaquionas.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ventanaAditamentos ventanaAditamentos = new ventanaAditamentos();
            ventanaAditamentos.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ventanaModeloMotor ventanaModeloMotor = new ventanaModeloMotor();
            ventanaModeloMotor.Show();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ventanaProveedor ventanaProveedor = new ventanaProveedor();
            ventanaProveedor.Show();
        }
    }
}
