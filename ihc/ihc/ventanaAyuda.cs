using System;
using System.Diagnostics;
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
    public partial class ventanaAyuda : Form
    {
        public ventanaAyuda()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Reporte Enviado", "Importante", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes: ; break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
