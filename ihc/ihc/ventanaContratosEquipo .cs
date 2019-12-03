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
    public partial class ventanaContratosEquipo : Form
    {
        public ventanaContratosEquipo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
            a.Clear();
            b.Clear();
            c.Clear();
            d.Clear();
            ee.Clear();
            f.Clear();
            g.Clear();
            h.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Reporte se ha eliminado.",
   "Importante",
   MessageBoxButtons.OK,
   MessageBoxIcon.Exclamation,
   MessageBoxDefaultButton.Button1);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios Guardados con Exito.",
  "Importante",
  MessageBoxButtons.OK,
  MessageBoxIcon.Exclamation,
  MessageBoxDefaultButton.Button1);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
