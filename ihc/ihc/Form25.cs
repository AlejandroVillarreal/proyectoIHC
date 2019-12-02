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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void Form25_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet4.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bdDataSet4.Usuarios);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaMenuPrincipal form3 = new ventanaMenuPrincipal();
            form3.Show();
        }
    }
}
