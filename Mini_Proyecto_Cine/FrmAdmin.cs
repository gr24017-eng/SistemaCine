namespace Mini_Proyecto_Cine
{
    public partial class FrmAdmin : Form
    {
        private string _rol;

        public FrmAdmin(string rol)
        {
            InitializeComponent();
            _rol = rol;
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

            label3.Text = "Bienvenido — Rol: " + _rol.ToUpper();
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
            new frm_Ventas().Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            new Confiteria().Show();
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

        private void btnPeliculas_Click_1(object sender, EventArgs e)
        {
            new Peliculas().Show();
        }

        private void btnFunciones_Click_1(object sender, EventArgs e)
        {
            new Funciones().Show();
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {


            new frm_Ventas().Show();
        }

        private void btnInventario_Click_1(object sender, EventArgs e)
        {

            new Confiteria().Show();
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            new Usuarios().Show();
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            new Reportes_Estadisticas().Show();
        }

        private void btnSalas_Click_1(object sender, EventArgs e)
        {
            new Gestion_salas().Show();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            CargarFunciones();
        }
    }
}
