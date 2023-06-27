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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio FR = new Inicio();
            FR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.CConexiones ObjetoConexion = new Clases.CConexiones();
            ObjetoConexion.EstablecerConexion();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (TbxCon.Text == TbxConfirContra.Text)
            {
                if (Clases.PersonalDal.CrearPersona(TbxUsuario.Text, TbxNumero.Text, TbxNom.Text, TbxCon.Text, TbxCorreo.Text, TbxEdad.Text) > 0)
                {
                    MessageBox.Show("Usuario creado con éxito");
                }
                else
                    MessageBox.Show("Error en el registro");
            }
            else
                MessageBox.Show("Las contraseñas no coinciden");
        }

    }
}
