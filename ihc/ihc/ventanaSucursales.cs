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
    public partial class ventanaSucursales : Form
    {
        public ventanaSucursales()
        {
            InitializeComponent();
        }

        private void ventanaSucursales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet22.Sucursales' Puede moverla o quitarla según sea necesario.
            this.sucursalesTableAdapter.Fill(this.bdDataSet22.Sucursales);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(TabPage2);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Desea Suspender la Sucursal?", "Importante", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes: MessageBox.Show("Sucursal Suspendida"); break;
                case DialogResult.No:; break;
                case DialogResult.Cancel:; break;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TabControl1.SelectTab(TabPage2);
        }
    }
}
