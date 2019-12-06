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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet23.Servicios' Puede moverla o quitarla según sea necesario.
            this.serviciosTableAdapter1.Fill(this.bdDataSet23.Servicios);
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet2.Servicios' Puede moverla o quitarla según sea necesario.
            //this.serviciosTableAdapter.Fill(this.bdDataSet2.Servicios);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaMenuPrincipal form3 = new ventanaMenuPrincipal();
            form3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void serviciosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            ventanaNuevoServicio ventanaNuevoServicio = new ventanaNuevoServicio();
            ventanaNuevoServicio.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ventanaNuevoServicio ventanaNuevoServicio = new ventanaNuevoServicio();
            ventanaNuevoServicio.Show();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
