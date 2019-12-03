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
    public partial class ventanaModeloMaquinas : Form
    {
        public ventanaModeloMaquinas()
        {
            InitializeComponent();
        }

        private void ventanaModeloMaquinas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet12.ModelosMaquinas' Puede moverla o quitarla según sea necesario.
            this.modelosMaquinasTableAdapter.Fill(this.bdDataSet12.ModelosMaquinas);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ventanaNuevoModeloMaquina ventanaNuevoModeloMaquina = new ventanaNuevoModeloMaquina();
            ventanaNuevoModeloMaquina.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaEditarModeloMaquina ventanaEditarModeloMaquina = new ventanaEditarModeloMaquina();
            ventanaEditarModeloMaquina.Show();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
