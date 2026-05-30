using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Mini_Proyecto_Cine
{
    public partial class Usuarios : Form
    {
        private int idSeleccionado = 0;

        public Usuarios()
        {
            InitializeComponent();
            cmbRol.Items.AddRange(new[] { "superadmin", "administrador", "ventas", "cliente" });
            cmbEstado.Items.AddRange(new[] { "activo", "inactivo" });
            ModoLectura();
            CargarUsuarios();
        }

        private void ModoLectura()
        {
            txtNombre.ReadOnly = true;
            txtUsuario.ReadOnly = true;
            txtContraseña.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            cmbRol.Enabled = false;
            cmbEstado.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = idSeleccionado > 0;
            btnEliminar.Enabled = idSeleccionado > 0;
            btnLimpiar.Enabled = true;
        }

        private void ModoEdicion()
        {
            txtNombre.ReadOnly = false;
            txtUsuario.ReadOnly = false;
            txtContraseña.ReadOnly = false;
            txtCorreo.ReadOnly = false;
            cmbRol.Enabled = true;
            cmbEstado.Enabled = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLimpiar.Enabled = true;
        }

        private string Hashear(string clave)
        {
            return Utilidades.HashSHA256(clave);
        }

        private void CargarUsuarios(string filtro = "")
        {
            dgvUsuarios.Rows.Clear();
            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                string sql = @"SELECT id_usuario, nombre, usuario, rol, estado 
                               FROM usuarios 
                               WHERE nombre LIKE @f OR usuario LIKE @f";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@f", "%" + filtro + "%");
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    dgvUsuarios.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }
        }

        private void CargarCorreoUsuario(int id)
        {
            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = "SELECT correo FROM usuarios WHERE id_usuario=@id";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        var dato = cmd.ExecuteScalar();
                        txtCorreo.Text = dato?.ToString() ?? "";
                    }
                }
            }
            catch { txtCorreo.Clear(); }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtCorreo.Clear();
            cmbRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            idSeleccionado = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ModoEdicion();
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ModoEdicion();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                cmbRol.SelectedIndex < 0 ||
                cmbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Completa todos los campos obligatorios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                MySqlCommand cmd;

                if (idSeleccionado == 0)
                {
                    if (string.IsNullOrWhiteSpace(txtContraseña.Text))
                    {
                        MessageBox.Show("Escribe una contraseña para el nuevo usuario.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cmd = new MySqlCommand(
                        "INSERT INTO usuarios (nombre,usuario,clave,rol,estado,correo) VALUES (@n,@u,@c,@r,@e,@correo)", con);
                    cmd.Parameters.AddWithValue("@c", Hashear(txtContraseña.Text));
                }
                else
                {
                    string sql = string.IsNullOrWhiteSpace(txtContraseña.Text)
                        ? "UPDATE usuarios SET nombre=@n,usuario=@u,rol=@r,estado=@e,correo=@correo WHERE id_usuario=@id"
                        : "UPDATE usuarios SET nombre=@n,usuario=@u,clave=@c,rol=@r,estado=@e,correo=@correo WHERE id_usuario=@id";
                    cmd = new MySqlCommand(sql, con);
                    if (!string.IsNullOrWhiteSpace(txtContraseña.Text))
                        cmd.Parameters.AddWithValue("@c", Hashear(txtContraseña.Text));
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);
                }

                cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@u", txtUsuario.Text.Trim());
                cmd.Parameters.AddWithValue("@r", cmbRol.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@e", cmbEstado.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuario guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarUsuarios();
                ModoLectura();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;
            if (MessageBox.Show("¿Eliminar este usuario?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM usuarios WHERE id_usuario=@id", con);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarUsuarios();
                ModoLectura();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ModoLectura();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvUsuarios.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(row.Cells[0].Value);
            txtNombre.Text = row.Cells[1].Value?.ToString();
            txtUsuario.Text = row.Cells[2].Value?.ToString();
            cmbRol.SelectedItem = row.Cells[3].Value?.ToString();
            cmbEstado.SelectedItem = row.Cells[4].Value?.ToString();
            txtContraseña.Clear();
            CargarCorreoUsuario(idSeleccionado);
            ModoLectura();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarUsuarios(txtBuscar.Text);
        }
    }
}