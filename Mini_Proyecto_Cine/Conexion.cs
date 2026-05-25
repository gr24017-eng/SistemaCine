using MySql.Data.MySqlClient;

namespace Mini_Proyecto_Cine
{
    public class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            string cadena = "Server=localhost;Database=cine_db;Uid=root;Pwd=;";
            return new MySqlConnection(cadena);
        }
    }
}