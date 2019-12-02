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
    public partial class ventanaContratosCotizacion : Form
    {
        public ventanaContratosCotizacion()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);

            MessageBox.Show("Infomacion Actualizada.",
    "Importante",
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TextBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label35_Click(object sender, EventArgs e)
        {

        }

        private void TextBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label33_Click(object sender, EventArgs e)
        {

        }
    }
}
