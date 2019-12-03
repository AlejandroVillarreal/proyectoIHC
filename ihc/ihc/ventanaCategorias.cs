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
    public partial class ventanaCategorias : Form
    {
        public ventanaCategorias()
        {
            InitializeComponent();
        }

        private void ventanaCategorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet11.Lineas' Puede moverla o quitarla según sea necesario.
            this.lineasTableAdapter.Fill(this.bdDataSet11.Lineas);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ventanaNuevaCategoria ventanaNuevaCategoria = new ventanaNuevaCategoria();
            ventanaNuevaCategoria.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaEditarCategoria ventanaEditarCategoria = new ventanaEditarCategoria();
            ventanaEditarCategoria.Show();
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
