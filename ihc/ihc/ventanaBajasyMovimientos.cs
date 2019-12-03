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
    public partial class ventanaBajasyMovimientos : Form
    {
        public ventanaBajasyMovimientos()
        {
            InitializeComponent();
        }

        private void VentanaBajasyMovimientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet10.Bajas_y_Movimientos' Puede moverla o quitarla según sea necesario.
           // this.bajas_y_MovimientosTableAdapter.Fill(this.bdDataSet10.Bajas_y_Movimientos);

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            ventanaNuevoBajasyMovimientos ventanaNuevoBajasyMovimientos = new ventanaNuevoBajasyMovimientos();
            ventanaNuevoBajasyMovimientos.Show();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            ventanaEditarBajasyMovimientos ventanaEditarBajasyMovimientos = new ventanaEditarBajasyMovimientos();
            ventanaEditarBajasyMovimientos.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
