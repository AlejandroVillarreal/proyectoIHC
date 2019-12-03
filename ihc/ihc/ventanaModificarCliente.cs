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
    public partial class ventanaModificarCliente : Form
    {
        public ventanaModificarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Realmente desea Hacer los cambios?", "Cambios", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Modificacion  Satisfactoria", "Modificacion",
  MessageBoxButtons.OK, MessageBoxIcon.Information
  );
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("No se Hizo ningun cambio", "Guardar",
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Realmente desea Hacer los cambios?", "Cambios", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Modificacion  Satisfactoria", "Modificacion",
  MessageBoxButtons.OK, MessageBoxIcon.Information
  );
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("No se Hizo ningun cambio", "Guardar",
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
}
