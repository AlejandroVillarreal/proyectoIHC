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
    public partial class ventanaContratos : Form
    {
        public ventanaContratos()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form24 form24 = new Form24();
            form24.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            ventanaConsultaContrato ventanaConsultaContrato = new ventanaConsultaContrato();
            ventanaConsultaContrato.Show();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            ventanaContratosEquipo ventanaContratosEquipo = new ventanaContratosEquipo();
            ventanaContratosEquipo.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ventanaContratosFalla ventanaContratosFalla = new ventanaContratosFalla();
            ventanaContratosFalla.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ventanaContratosCotizacion ventanaContratosCotizacion = new ventanaContratosCotizacion();
            ventanaContratosCotizacion.Show();
        }
    }
    }

