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
    public partial class ventanaReportesContratos : Form
    {
        public ventanaReportesContratos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            ventanaReportesContratosBuscador ventanaReportesContratosBuscador = new ventanaReportesContratosBuscador();
            ventanaReportesContratosBuscador.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            
            ventanaReportesContratosBuscador ventanaReportesContratosBuscador = new ventanaReportesContratosBuscador();
            ventanaReportesContratosBuscador.Show();

        }
    }
}
