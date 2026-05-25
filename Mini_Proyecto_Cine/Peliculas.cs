using MySql.Data.MySqlClient;

namespace Mini_Proyecto_Cine
{
    public partial class Peliculas : Form
    {
        private int idSeleccionado = 0;
        private byte[] imagenBytes = null;

        public Peliculas()
        {
            InitializeComponent();
            CargarPeliculas();
            EstadoBotones(false);
        }

        private void CargarPeliculas(string filtro = "")
        {
            dataGridView1.Rows.Clear();
            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                string sql = "SELECT id_pelicula, nombre, categoria, clasificacion, duracion, estado FROM peliculas WHERE nombre LIKE @f";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@f", "%" + filtro + "%");
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDuracion.Clear();
            txtDescripcion.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbClasificacion.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            pictureBox1.Image = null;
            imagenBytes = null;
            idSeleccionado = 0;
        }

        private void EstadoBotones(bool editando)
        {
            btnGuardar.Enabled = editando;
            btnEditar.Enabled = !editando && idSeleccionado > 0;
            btnEliminar.Enabled = !editando && idSeleccionado > 0;
            btnNuevo.Enabled = !editando;
            btnCargar.Enabled = editando;
            btnQuitar.Enabled = editando;
        }








        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(row.Cells[0].Value);
            txtNombre.Text = row.Cells[1].Value?.ToString();
            cmbCategoria.SelectedItem = row.Cells[2].Value?.ToString();
            cmbClasificacion.SelectedItem = row.Cells[3].Value?.ToString();
            txtDuracion.Text = row.Cells[4].Value?.ToString();
            cmbEstado.SelectedItem = row.Cells[5].Value?.ToString();

            // Cargar descripción e imagen desde BD
            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT descripcion, imagen FROM peliculas WHERE id_pelicula=@id", con);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtDescripcion.Text = dr["descripcion"]?.ToString();
                    if (dr["imagen"] != DBNull.Value)
                    {
                        imagenBytes = (byte[])dr["imagen"];
                        using MemoryStream ms = new MemoryStream(imagenBytes);
                        pictureBox1.Image = Image.FromStream(ms);
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        pictureBox1.Image = null;
                        imagenBytes = null;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }

            EstadoBotones(false);
        }







        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            EstadoBotones(true);

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;
            if (MessageBox.Show("¿Eliminar esta película?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM peliculas WHERE id_pelicula=@id", con);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);
                cmd.ExecuteNonQuery();
                LimpiarCampos();
                CargarPeliculas();
                EstadoBotones(false);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            EstadoBotones(false);
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            CargarPeliculas(txtBuscar.Text);
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            EstadoBotones(true);
            txtNombre.Focus();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagenBytes = File.ReadAllBytes(ofd.FileName);
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            imagenBytes = null;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               cmbCategoria.SelectedIndex < 0 ||
               cmbClasificacion.SelectedIndex < 0 ||
               cmbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Completa los campos obligatorios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                string sql;
                if (idSeleccionado == 0)
                    sql = @"INSERT INTO peliculas 
                            (nombre, categoria, clasificacion, duracion, descripcion, estado, imagen) 
                            VALUES (@n, @cat, @cl, @d, @desc, @e, @img)";
                else
                    sql = @"UPDATE peliculas SET 
                            nombre=@n, categoria=@cat, clasificacion=@cl, 
                            duracion=@d, descripcion=@desc, estado=@e, imagen=@img 
                            WHERE id_pelicula=@id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@cat", cmbCategoria.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@cl", cmbClasificacion.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@d", string.IsNullOrWhiteSpace(txtDuracion.Text) ? 0 : int.Parse(txtDuracion.Text));
                cmd.Parameters.AddWithValue("@desc", txtDescripcion.Text.Trim());
                cmd.Parameters.AddWithValue("@e", cmbEstado.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@img", (object)imagenBytes ?? DBNull.Value);

                if (idSeleccionado > 0)
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarPeliculas();
                EstadoBotones(false);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }
        }
    }
}