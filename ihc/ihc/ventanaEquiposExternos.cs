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
    public partial class ventanaEquiposExternos : Form
    {
        public ventanaEquiposExternos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void ventanaEquiposExternos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet21.Mantenimientos' Puede moverla o quitarla según sea necesario.
            this.mantenimientosTableAdapter.Fill(this.bdDataSet21.Mantenimientos);
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet20.Equipos_Externos' Puede moverla o quitarla según sea necesario.
            this.equipos_ExternosTableAdapter.Fill(this.bdDataSet20.Equipos_Externos);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ventanaNuevoEquipoExterno ventanaNuevoEquipoExterno = new ventanaNuevoEquipoExterno();
            ventanaNuevoEquipoExterno.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ventanaEditarEquipoExterno ventanaEditarEquipoExterno = new ventanaEditarEquipoExterno();
            ventanaEditarEquipoExterno.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            ventanaNota ventanaNota = new ventanaNota();
            ventanaNota.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Desea Eliminar el Registro?", "Confirmacion", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes: MessageBox.Show("Registro Eliminado"); break;
                case DialogResult.No:; break;
                case DialogResult.Cancel:; break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ventanaNuevoMantenimiento ventanaNuevoMantenimiento = new ventanaNuevoMantenimiento();
            ventanaNuevoMantenimiento.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ventanaEditarMantenimiento ventanaEditarMantenimiento = new ventanaEditarMantenimiento();
            ventanaEditarMantenimiento.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
