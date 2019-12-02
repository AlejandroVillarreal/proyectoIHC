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
    public partial class ventanaConsultaUsuario : Form
    {
        public ventanaConsultaUsuario()
        {
            InitializeComponent();
        }

        private void Form25_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet19.Usuarios_del_Sistema' Puede moverla o quitarla según sea necesario.
            this.usuarios_del_SistemaTableAdapter2.Fill(this.bdDataSet19.Usuarios_del_Sistema);
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet18.Usuarios_del_Sistema' Puede moverla o quitarla según sea necesario.
            this.usuarios_del_SistemaTableAdapter1.Fill(this.bdDataSet18.Usuarios_del_Sistema);
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet17.Usuarios_del_Sistema' Puede moverla o quitarla según sea necesario.
            this.usuarios_del_SistemaTableAdapter.Fill(this.bdDataSet17.Usuarios_del_Sistema);
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet16.Usuarios' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet4.Usuarios' Puede moverla o quitarla según sea necesario.
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaUsuarios form7 = new ventanaUsuarios();
            form7.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaMenuPrincipal form3 = new ventanaMenuPrincipal();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaNuevoUsuario ventanaNuevoUsuario = new ventanaNuevoUsuario();
            ventanaNuevoUsuario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaEditarUsuario ventanaEditarUsuario = new ventanaEditarUsuario();
            ventanaEditarUsuario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Desea Eliminar el Registro?", "Confirmacion", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes: MessageBox.Show("Registro Eliminado"); break;
                case DialogResult.No:; break;
                case DialogResult.Cancel:; break;
            }
        }
    }
}
