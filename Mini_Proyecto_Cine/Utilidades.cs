using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Mini_Proyecto_Cine
{
    public class Utilidades
    {
        public static string HashSHA256(string texto)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }

    public static class Sesion
    {
        public static int IdUsuario { get; set; }
        public static string Rol { get; set; }
        public static string Nombre { get; set; }
    }

    // Clase auxiliar para los ComboBox con ID
    public class ComboItem
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public override string ToString() => Texto;
    }
}
