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
    public partial class ventanaReportes1 : Form
    {
        public ventanaReportes1()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ventanaReportesEquipo1 ventanaReportesEquipo1 = new ventanaReportesEquipo1();
            ventanaReportesEquipo1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            ventanaReportesContratos1 ventanaReportesContratos1 = new ventanaReportesContratos1();
            ventanaReportesContratos1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ventanaReportesClientes1 ventanaReportesClientes1 = new ventanaReportesClientes1();
            ventanaReportesClientes1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ventanaReportesServicio1 ventanaReportesServicio1 = new ventanaReportesServicio1();
            ventanaReportesServicio1.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            ventanaReportesEquipo1 ventanaReportesEquipo1 = new ventanaReportesEquipo1();
            ventanaReportesEquipo1.Show();
        }
    }
}
