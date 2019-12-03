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
    public partial class ventanaReportesEquipo1 : Form
    {
        public ventanaReportesEquipo1()
        {
            InitializeComponent();
        }

        private void ventanaReportesEquipo1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaReporteBuscado1 ventanaReporteBuscado1 = new ventanaReporteBuscado1();
            ventanaReporteBuscado1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
