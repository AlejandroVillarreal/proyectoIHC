﻿using System;
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
    public partial class ventanaMenuPrincipal : Form
    {
        public ventanaMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void AdministracionEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaConsultaEquipos form2 = new ventanaConsultaEquipos();
            form2.Show();

        }

        private void RealizarRentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AdministrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
           
            Form21 form21 = new Form21();
            form21.Show();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            
            ventanaConsultaUsuario ventanaConsultaUsuario = new ventanaConsultaUsuario();
            ventanaConsultaUsuario.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
            ventanaProcesos form11 = new ventanaProcesos();
            form11.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaLogin form1 = new ventanaLogin();
            form1.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaLogin form1 = new ventanaLogin();
            form1.Show();
        }
    }
}
