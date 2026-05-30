using MySql.Data.MySqlClient;

namespace Mini_Proyecto_Cine
{
    public partial class Funciones : Form
    {
        private int idSeleccionado = 0;

        public Funciones()
        {
            InitializeComponent();

            // AGREGAR ESTAS DOS LÍNEAS ANTES DE TODO
            dtpFecha.MinDate = DateTime.Parse("01/01/2000");
            dtpFecha.MaxDate = DateTime.Parse("31/12/2099");
            CargarPeliculasCombo();
            CargarSalasCombo();
            CargarFunciones();
            EstadoBotones(false);
        }

        private void CargarPeliculasCombo()
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                string sql = "SELECT id_pelicula, nombre FROM peliculas WHERE estado='En Cartelera'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                cmbPelicula.DisplayMember = "nombre";
                cmbPelicula.ValueMember = "id_pelicula";
                cmbPelicula.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }
        }

        private void CargarSalasCombo()
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                string sql = "SELECT id_sala, nombre FROM salas WHERE estado='activa'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                cmbSala.DisplayMember = "nombre";
                cmbSala.ValueMember = "id_sala";
                cmbSala.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }
        }

        private void CargarFunciones()
        {
            dgvFunciones.Rows.Clear();
            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                string sql = @"SELECT f.id_funcion, p.nombre, s.nombre, f.fecha, f.hora, f.precio
                               FROM funciones f
                               INNER JOIN peliculas p ON f.id_pelicula = p.id_pelicula
                               INNER JOIN salas s ON f.id_sala = s.id_sala
                               ORDER BY f.fecha DESC, f.hora";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    dgvFunciones.Rows.Add(
                        dr[0],
                        dr[1],
                        dr[2],
                        Convert.ToDateTime(dr[3]).ToShortDateString(),
                        dr[4],
                        dr[5]);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }
        }

        private void LimpiarCampos()
        {
            txtHora.Clear();
            txtPrecio.Clear();
            dtpFecha.Value = DateTime.Today;

            if (cmbPelicula.Items.Count > 0) cmbPelicula.SelectedIndex = 0;
            if (cmbSala.Items.Count > 0) cmbSala.SelectedIndex = 0;

            idSeleccionado = 0;
        }

        private void EstadoBotones(bool editando)
        {
            btnGuardar.Enabled = editando;
            btnEditar.Enabled = !editando && idSeleccionado > 0;
            btnEliminar.Enabled = !editando && idSeleccionado > 0;
            btnNuevo.Enabled = !editando;
        }

        private void Nuevo()
        {
            LimpiarCampos();
            EstadoBotones(true);
            txtHora.Focus();
        }

        private void Guardar()
        {
            if (cmbPelicula.SelectedValue == null || cmbSala.SelectedValue == null
                || string.IsNullOrWhiteSpace(txtHora.Text)
                || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Completa todos los campos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                string sql = idSeleccionado == 0
                    ? "INSERT INTO funciones (id_pelicula, id_sala, fecha, hora, precio) VALUES (@p, @s, @f, @h, @pr)"
                    : "UPDATE funciones SET id_pelicula=@p, id_sala=@s, fecha=@f, hora=@h, precio=@pr WHERE id_funcion=@id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p", cmbPelicula.SelectedValue);
                cmd.Parameters.AddWithValue("@s", cmbSala.SelectedValue);
                cmd.Parameters.AddWithValue("@f", dtpFecha.Value.Date);
                cmd.Parameters.AddWithValue("@h", txtHora.Text.Trim());
                cmd.Parameters.AddWithValue("@pr", decimal.Parse(txtPrecio.Text));
                if (idSeleccionado > 0)
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);

                cmd.ExecuteNonQuery();

                // Crear asientos automáticamente si es función nueva
                if (idSeleccionado == 0)
                {
                    int idFuncion = (int)cmd.LastInsertedId;
                    int idSala = Convert.ToInt32(cmbSala.SelectedValue);
                    CrearAsientos(idFuncion, idSala, con);
                }

                MessageBox.Show("Guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarFunciones();
                EstadoBotones(false);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }
        }

        private void CrearAsientos(int idFuncion, int idSala, MySqlConnection con)
        {
            MySqlCommand cmdCap = new MySqlCommand(
                "SELECT capacidad FROM salas WHERE id_sala=@id", con);
            cmdCap.Parameters.AddWithValue("@id", idSala);
            int capacidad = Convert.ToInt32(cmdCap.ExecuteScalar());

            for (int i = 1; i <= capacidad; i++)
            {
                MySqlCommand cmdA = new MySqlCommand(
                    "INSERT INTO asientos (id_sala, id_funcion, numero, estado) VALUES (@s, @f, @n, 'disponible')", con);
                cmdA.Parameters.AddWithValue("@s", idSala);
                cmdA.Parameters.AddWithValue("@f", idFuncion);
                cmdA.Parameters.AddWithValue("@n", "A" + i);
                cmdA.ExecuteNonQuery();
            }
        }

        private void Editar()
        {
            EstadoBotones(true);
        }

        private void Eliminar()
        {
            if (idSeleccionado == 0) return;
            if (MessageBox.Show("¿Eliminar esta función?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                MySqlCommand cmd1 = new MySqlCommand(
                    "DELETE FROM asientos WHERE id_funcion=@id", con);
                cmd1.Parameters.AddWithValue("@id", idSeleccionado);
                cmd1.ExecuteNonQuery();

                MySqlCommand cmd2 = new MySqlCommand(
                    "DELETE FROM funciones WHERE id_funcion=@id", con);
                cmd2.Parameters.AddWithValue("@id", idSeleccionado);
                cmd2.ExecuteNonQuery();

                LimpiarCampos();
                CargarFunciones();
                EstadoBotones(false);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }
        }

        private void Cancelar()
        {
            LimpiarCampos();
            EstadoBotones(false);
        }

        private void SeleccionarFila(int rowIndex)
        {
            if (rowIndex < 0) return;
            DataGridViewRow row = dgvFunciones.Rows[rowIndex];
            idSeleccionado = Convert.ToInt32(row.Cells[0].Value);
            txtHora.Text = row.Cells[4].Value?.ToString();
            txtPrecio.Text = row.Cells[5].Value?.ToString();

            // Seleccionar la fecha desde el grid
            if (DateTime.TryParse(row.Cells[3].Value?.ToString(), out DateTime fecha))
                dtpFecha.Value = fecha;

            EstadoBotones(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarFila(e.RowIndex);
        }

        private void dgvFunciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
