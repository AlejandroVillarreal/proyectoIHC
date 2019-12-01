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
    public partial class ventanaReportesClientesBusqueda : Form
    {
        public ventanaReportesClientesBusqueda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            ventanaReportesContratos ventanaReportesContratos = new ventanaReportesContratos();
            ventanaReportesContratos.Show();
        }
    }
}
