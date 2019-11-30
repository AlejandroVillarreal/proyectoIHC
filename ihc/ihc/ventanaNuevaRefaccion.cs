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
    public partial class ventanaNuevaRefaccion : Form
    {
        public ventanaNuevaRefaccion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Guardados  Satisfactoriamente", "Modificacion",
 MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
