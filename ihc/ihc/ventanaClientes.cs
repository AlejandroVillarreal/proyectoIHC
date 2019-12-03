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
    public partial class ventanaClientes : Form
    {
        public ventanaClientes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            ventanaClientesConsulta form22 = new ventanaClientesConsulta();
            form22.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            ventanaAnadirCliente ventanaAnadirClientes = new ventanaAnadirCliente();
            ventanaAnadirClientes.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            ventanaModificarCliente ventanaModificarCliente = new ventanaModificarCliente();
            ventanaModificarCliente.Show();
        }
    }
}
