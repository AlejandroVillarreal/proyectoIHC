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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void Form24_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet3.Contratos' Puede moverla o quitarla según sea necesario.
            //this.contratosTableAdapter.Fill(this.bdDataSet3.Contratos);

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Create and initialize an HScrollBar.
            HScrollBar hScrollBar1 = new HScrollBar();

            // Dock the scroll bar to the bottom of the form.
            hScrollBar1.Dock = DockStyle.Bottom;

            // Add the scroll bar to the form.
            Controls.Add(hScrollBar1);
        }
    }
}
