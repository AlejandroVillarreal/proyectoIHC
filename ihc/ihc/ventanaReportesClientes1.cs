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
    public partial class ventanaReportesClientes1 : Form
    {
        public ventanaReportesClientes1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ventanaReportesClientesBuscador1 ventanaReportesClientesBuscador1 = new ventanaReportesClientesBuscador1();
            ventanaReportesClientesBuscador1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ventanaReportesClientesBuscador1 ventanaReportesClientesBuscador1 = new ventanaReportesClientesBuscador1();
            ventanaReportesClientesBuscador1.Show();
        }
    }
}
