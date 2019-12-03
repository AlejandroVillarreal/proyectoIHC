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
    public partial class ventanaMantenimiento : Form
    {
        public ventanaMantenimiento()
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

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet9.Servicios' Puede moverla o quitarla según sea necesario.
            this.serviciosTableAdapter.Fill(this.bdDataSet9.Servicios);
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet8.Refacciones' Puede moverla o quitarla según sea necesario.
            this.refaccionesTableAdapter.Fill(this.bdDataSet8.Refacciones);
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet6.Mantenimientos' Puede moverla o quitarla según sea necesario.
            this.mantenimientosTableAdapter.Fill(this.bdDataSet6.Mantenimientos);

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ventanaEditarMantenimiento ventanaEditarMantenimiento = new ventanaEditarMantenimiento();
            ventanaEditarMantenimiento.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ventanaNuevoMantenimiento ventanaNuevoMantenimiento = new ventanaNuevoMantenimiento();
            ventanaNuevoMantenimiento.Show();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            ventanaNuevaRefaccion ventanaNuevaRefaccion = new ventanaNuevaRefaccion();
            ventanaNuevaRefaccion.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            ventanaEditarRefaccion ventanaEditarRefaccion = new ventanaEditarRefaccion();
            ventanaEditarRefaccion.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ventanaNuevoServicio ventanaNuevoServicio = new ventanaNuevoServicio();
            ventanaNuevoServicio.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ventanaEditarServicio ventanaEditarServicio = new ventanaEditarServicio();
            ventanaEditarServicio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
