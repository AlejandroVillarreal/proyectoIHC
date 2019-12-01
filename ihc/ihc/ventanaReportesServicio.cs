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
    public partial class ventanaReportesServicio : Form
    {
        public ventanaReportesServicio()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            ventanaReportesServicioBusqueda ventanaReportesServicioBusqueda = new ventanaReportesServicioBusqueda();
            ventanaReportesServicioBusqueda.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ventanaReportesServicioBusqueda ventanaReportesServicioBusqueda = new ventanaReportesServicioBusqueda();
            ventanaReportesServicioBusqueda.Show();
        }
    }
}
