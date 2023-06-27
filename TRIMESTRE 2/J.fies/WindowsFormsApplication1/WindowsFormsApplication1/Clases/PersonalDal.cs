using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace J_fiess.Clases
{
    class PersonalDal
    {
        public static int CrearPersona(string pUsuario, string pNumero, string pNombre, string pContraseña, string pCorreo, string pEdad)
        {
            int resultado = 0;
            Clases.CConexiones ObjetoConexion = new Clases.CConexiones();
            ObjetoConexion.EstablecerConexion();
            MySqlConnection Conex = ObjetoConexion.EstablecerConexion();
            {
                MySqlCommand comando = new MySqlCommand(string.Format("insert into usuario (Nombre_Usuario,numero_tel,nombre,contraseña,Correo,edad)values('{0}','{1}','{2}','{3}','{4}','{5}')", pUsuario, pNumero, pNombre, pContraseña, pCorreo, pEdad), Conex);
                resultado = comando.ExecuteNonQuery();

            } return resultado;
        }

        public static int ValidarCuenta(string PUsuario, string pContraseña)
        {
            int resultado = -5;

            Clases.CConexiones ObjetoConexion = new Clases.CConexiones();
            ObjetoConexion.EstablecerConexion();
            MySqlConnection Conex = ObjetoConexion.EstablecerConexion();
            {
                MySqlCommand comando = new MySqlCommand(string.Format("insert into usuario (Nombre_Usuario,contraseña)values('{0}','{1}')", PUsuario, pContraseña), Conex);
                resultado = 50;
            }
            return resultado;
        }
    }

}