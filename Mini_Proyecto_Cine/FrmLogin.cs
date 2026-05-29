using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Mini_Proyecto_Cine
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private string HashearClave(string clave)
        {
            using SHA256 sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(clave));
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes) sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = HashearClave(txtContra.Text.Trim());

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(txtContra.Text))
            {
                MessageBox.Show("Ingresa usuario y contraseña.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();

                // Traer id, nombre y rol en una sola consulta
                string sql = @"SELECT id_usuario, nombre, rol 
                               FROM usuarios 
                               WHERE usuario=@u AND clave=@c AND estado='activo'";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@c", clave);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (!dr.Read())
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Guardar sesión
                Sesion.IdUsuario = dr.GetInt32("id_usuario");
                Sesion.Nombre = dr.GetString("nombre");
                Sesion.Rol = dr.GetString("rol");

                dr.Close();

                this.Hide();
                FrmAdmin admin = new FrmAdmin(Sesion.Rol);
                admin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}