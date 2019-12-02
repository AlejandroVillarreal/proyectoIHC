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
    public partial class ventanaReportes : Form
    {
        public ventanaReportes()
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
            ventanaReportesEquipo ventanaReportesEquipo = new ventanaReportesEquipo();
            ventanaReportesEquipo.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            ventanaReportesContratos ventanaReportesContratos = new ventanaReportesContratos();
            ventanaReportesContratos.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            ventanaReportesClientes ventanaReportesClientes = new ventanaReportesClientes();
            ventanaReportesClientes.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ventanaReportesServicio ventanaReportesServicio = new ventanaReportesServicio();
            ventanaReportesServicio.Show();
        }
    }
}
