using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J_fiess
{
    public partial class InicioSeción : Form
    {
        public InicioSeción()
        {
            InitializeComponent();
        }

        private void InicioSeción_Load(object sender, EventArgs e)
        {

        }

        private void btnInicioSe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio FR = new Inicio();
            FR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clases.PersonalDal.ValidarCuenta (tbxUsuario.Text, tbxContraseña.Text) > 0)
            {
                this.Hide();
                Menu FR = new Menu();
                FR.Show();
            
        }

        else MessageBox.Show("Error en nombre de usuario y/o Contraseña");
        } 
        private void TbxUsuario_TextChanged( object sender, EventArgs e)
        {
        }

        }
    }
