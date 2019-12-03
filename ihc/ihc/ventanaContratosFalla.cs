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
    public partial class ventanaContratosFalla : Form
    {
        public ventanaContratosFalla()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
            TextBox5.Clear();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string message = "Se ha Editado";
            string title = "Editar";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
            TextBox5.Clear();
            MessageBox.Show("Se ha eliminado el reporte.",
    "Importante",
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
