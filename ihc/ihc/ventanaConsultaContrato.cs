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
    public partial class ventanaConsultaContrato : Form
    {
        public ventanaConsultaContrato()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 3;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 4;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
