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
    public partial class ventanaClientesConsulta : Form
    {
        public ventanaClientesConsulta()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.bdDataSet1.Clientes);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ventanaAnadirCliente ventanaAnadirCliente = new ventanaAnadirCliente();
            ventanaAnadirCliente.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ventanaAnadirCliente ventanaAnadirCliente = new ventanaAnadirCliente();
            ventanaAnadirCliente.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
