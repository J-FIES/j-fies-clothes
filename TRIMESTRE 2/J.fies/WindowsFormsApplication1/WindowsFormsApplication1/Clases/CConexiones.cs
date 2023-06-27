using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J_fiess.Clases
{
    class CConexiones
    {
        MySqlConnection Conex = new MySqlConnection();

        static string Servidor = "localhost";
        static string bd = "j_fies";
        static string usuario = "root";
        static string password = "";
        static string Puerto = "3306";

        string CadenaConexion = "server=" + Servidor + ";" + "port=" + Puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection EstablecerConexion()
        {
            try
            {
                Conex.ConnectionString = CadenaConexion;
                Conex.Open();
                MessageBox.Show("Conexion establecida");
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se puede conectar a la base de datos, error" + e.ToString());
            }
            return Conex;
        }

    }
}
