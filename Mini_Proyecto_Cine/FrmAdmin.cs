namespace Mini_Proyecto_Cine
{
    public partial class FrmAdmin : Form
    {
        private string _rol;
        private string _usuario;

        public FrmAdmin(string rol, string nombre)
        {
            InitializeComponent();
            _rol = rol;
            _usuario = nombre;
            ConfigurarPorRol();
            CargarFunciones();
        }

        private void ConfigurarPorRol()
        {
            bool esAdmin = _rol == "superadmin" || _rol == "administrador";
            bool tieneVentas = _rol == "superadmin" || _rol == "ventas";
            btnUsuarios.Visible = esAdmin;
            btnReportes.Visible = esAdmin;
            btnSalas.Visible = esAdmin;
            btnInventario.Visible = esAdmin || tieneVentas;
            btnVentas.Visible = tieneVentas;
            label3.Text = "Bienvenido, " + _usuario;
        }

        private void CargarFunciones()
        {
            dataGridView1.Rows.Clear();
            MySql.Data.MySqlClient.MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                string sql = @"SELECT p.nombre, s.nombre, f.fecha, f.hora, f.precio
                               FROM funciones f
                               INNER JOIN peliculas p ON f.id_pelicula = p.id_pelicula
                               INNER JOIN salas s ON f.id_sala = s.id_sala
                               ORDER BY f.fecha, f.hora";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, con);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                    dataGridView1.Rows.Add(dr[0], dr[1],
                        Convert.ToDateTime(dr[2]).ToShortDateString(), dr[3], dr[4]);
            }
            catch { }
            finally { con.Close(); }
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            new Peliculas().Show();
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            new Funciones().Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            new FrmCartelera().Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            new Control_inventario().Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new Usuarios().Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            new Reportes_Estadisticas().Show();
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            new Gestion_salas().Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CargarFunciones();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
