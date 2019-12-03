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
    public partial class ventanaAnadirCliente : Form
    {
        public ventanaAnadirCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ventanaAnadirCliente_Load(object sender, EventArgs e)
        {

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guardado Satisfactoriamente", "Guardar",
            MessageBoxButtons.OK, MessageBoxIcon.Information
    );

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();

        }
    }
    
}
