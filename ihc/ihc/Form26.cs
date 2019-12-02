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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet5.Mantenimientos' Puede moverla o quitarla según sea necesario.
            this.mantenimientosTableAdapter.Fill(this.bdDataSet5.Mantenimientos);

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
    }
    }

