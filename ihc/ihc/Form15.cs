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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Guardado Satisfactoriamente", "Guardar",
            MessageBoxButtons.OK, MessageBoxIcon.Information
            );

           

            this.Hide();
            Form form12 = new Form12();
            form12.Show();
        }
    }
}
