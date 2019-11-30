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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            
            ventanaMantenimiento form16 = new ventanaMantenimiento();
            form16.Show();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaMenuPrincipal form3 = new ventanaMenuPrincipal();
            form3.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaConsultaEquipos form2 = new ventanaConsultaEquipos();
            form2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            ventanaReservaciones form17 = new ventanaReservaciones();
            form17.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ventanaBajasyMovimientos ventanaBajasyMovimientos = new ventanaBajasyMovimientos();
            ventanaBajasyMovimientos.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaEquiposExternos form19 = new ventanaEquiposExternos();
            form19.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            ventanaSeleccionNuevoEquipo ventanaSeleccionNuevoEquipo = new ventanaSeleccionNuevoEquipo();
            ventanaSeleccionNuevoEquipo.Show();
        }
    }
}
