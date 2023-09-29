using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAutos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tsl_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsl_Regresar_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            this.Close();
            inicio.Show();
        }
    }
}
