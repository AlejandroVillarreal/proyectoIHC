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
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet24.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter2.Fill(this.bdDataSet24.Clientes);
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
            switch (MessageBox.Show("Desea Eliminar el Registro?", "Confirmacion", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes: MessageBox.Show("Registro Eliminado"); break;
                case DialogResult.No:; break;
                case DialogResult.Cancel:; break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
