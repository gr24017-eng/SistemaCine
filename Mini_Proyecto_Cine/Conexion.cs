using MySql.Data.MySqlClient;

namespace Mini_Proyecto_Cine
{
    public class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            string cadena = "server=mysql-proyectosu.alwaysdata.net;port=3306;database=proyectosu_cine;uid=proyectosu_engel;password=3ng3lb3r7;";
            return new MySqlConnection(cadena);
        }
    }
}