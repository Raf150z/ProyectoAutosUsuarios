using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaUsuarios;

namespace ProyectoAutos
{
    public partial class Form1 : Form
    {
        UsuariosLogica Logear;
        public Form1()
        {
            InitializeComponent();
            Logear = new UsuariosLogica();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            bool Iniciar = Logear.Verificacion(txt_Usuarios.Text, txt_Contraseña.Text);
            if (Iniciar == true)
            {
                FrmPrincipal Entrar = new FrmPrincipal();
                this.Hide();
                Entrar.Show();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
