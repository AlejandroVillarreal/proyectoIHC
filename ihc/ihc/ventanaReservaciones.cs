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
    public partial class ventanaReservaciones : Form
    {
        public ventanaReservaciones()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaMenuPrincipal form3 = new ventanaMenuPrincipal();
            form3.Show();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet7.ReservarEquipos' Puede moverla o quitarla según sea necesario.
            this.reservarEquiposTableAdapter.Fill(this.bdDataSet7.ReservarEquipos);

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            ventanaNuevaReservacion ventanaNuevaReservacion = new ventanaNuevaReservacion();
            ventanaNuevaReservacion.Show();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            ventanaEditarReservacion ventanaEditarReservacion = new ventanaEditarReservacion();
            ventanaEditarReservacion.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Desea Cancelar Esta Reservacion", "Confirmacion", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes: MessageBox.Show("Cancelado"); break;
                case DialogResult.No:; break;
                case DialogResult.Cancel:; break;
            }
        }
    }
}
