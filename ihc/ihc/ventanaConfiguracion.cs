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
    public partial class ventanaConfiguracion : Form
    {
        public ventanaConfiguracion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ventanaSucursales ventanaSucursales = new ventanaSucursales();
            ventanaSucursales.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ventanaEmpresa ventanaEmpresa = new ventanaEmpresa();
            ventanaEmpresa.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ventanaImpresora ventanaImpresora = new ventanaImpresora();
            ventanaImpresora.Show();
        }
    }
}
