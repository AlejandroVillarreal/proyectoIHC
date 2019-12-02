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
    public partial class ventanaAditamentos : Form
    {
        public ventanaAditamentos()
        {
            InitializeComponent();
        }

        private void ventanaAditamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet13.Aditamentos' Puede moverla o quitarla según sea necesario.
            this.aditamentosTableAdapter.Fill(this.bdDataSet13.Aditamentos);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ventanaNuevoAditamento ventanaNuevoAditamento = new ventanaNuevoAditamento();
            ventanaNuevoAditamento.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaEditarAditamento ventanaEditarAditamento = new ventanaEditarAditamento();
            ventanaEditarAditamento.Show();
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
