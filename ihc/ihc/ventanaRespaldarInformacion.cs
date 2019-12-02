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
    public partial class ventanaRespaldarInformacion : Form
    {
        public ventanaRespaldarInformacion()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("¿Esta correcta la ruta?", "Exportar Informacion", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes: MessageBox.Show("Exportado"); break;
                case DialogResult.No:; break;
                case DialogResult.Cancel:; break;
            }
        }
    }
}
