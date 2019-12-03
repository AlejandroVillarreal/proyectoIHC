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
    public partial class ventanaProveedor : Form
    {
        public ventanaProveedor()
        {
            InitializeComponent();
        }

        private void ventanaProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet15.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.bdDataSet15.Proveedores);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ventanaNuevoProveedor ventanaNuevoProveedor = new ventanaNuevoProveedor();
            ventanaNuevoProveedor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaEditarProveedor ventanaEditarProveedor = new ventanaEditarProveedor();
            ventanaEditarProveedor.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Desea Eliminar el Registro?", "Confirmacion", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes: MessageBox.Show("Registro Eliminado"); break;
                case DialogResult.No:; break;
                case DialogResult.Cancel:; break;
            }
        }
    }
}
