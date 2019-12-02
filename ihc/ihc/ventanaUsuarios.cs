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
    public partial class ventanaUsuarios : Form
    {
        public ventanaUsuarios()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaMenuPrincipal form3 = new ventanaMenuPrincipal();
            form3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            ventanaConsultaUsuario form25 = new ventanaConsultaUsuario();
            form25.Show();
        }
    }
}
