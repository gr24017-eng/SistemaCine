using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Proyecto_Cine
{
    public partial class Control_inventario : Form
    {
        int idProductoSeleccionado = 0;
        bool modoEdicion = false;
        public Control_inventario()
        {
            InitializeComponent();
        }

        private void Control_inventario_Load(object sender, EventArgs e)
        {
            // Llenar combos
            cmbCategoria_inve.Items.Clear();
            cmbCategoria_inve.Items.AddRange(new string[]
                { "Bebidas", "Palomitas", "Nachos", "Dulces", "Otros" });
            cmbCategoria_inve.SelectedIndex = 0;

            cmbEstado_inve.Items.Clear();
            cmbEstado_inve.Items.Add("activo");
            cmbEstado_inve.Items.Add("inactivo");
            cmbEstado_inve.SelectedIndex = 0;

            ModoLectura();
            CargarInventario();
        }

        // ── CARGAR GRID ───────────────────────────────────────────────────
        private void CargarInventario(string filtro = "")
        {
            try
            {
                dgvInventario.Rows.Clear();
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = @"SELECT id_producto, nombre, precio, stock, estado 
                                   FROM inventario 
                                   WHERE nombre LIKE @filtro
                                   ORDER BY nombre";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                        using (var dr = cmd.ExecuteReader())
                            while (dr.Read())
                                dgvInventario.Rows.Add(
                                    dr["id_producto"],
                                    dr["nombre"],
                                    "",                      // categoría no está en BD
                                    "$" + dr["precio"],
                                    dr["stock"],
                                    dr["estado"]
                                );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];
            idProductoSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
            txtNombre_inve.Text = fila.Cells["Producto"].Value?.ToString();
            txtPrecio_inve.Text = fila.Cells["Precio"].Value?.ToString().Replace("$", "");
            txtStock_inve.Text = fila.Cells["Stock"].Value?.ToString();
            cmbEstado_inve.Text = fila.Cells["Estado"].Value?.ToString();
        }

        private void txtBuscar_inve_TextChanged(object sender, EventArgs e)
        {
            CargarInventario(txtBuscar_inve.Text.Trim());
        }

        private void btnNuevo_inve_Click(object sender, EventArgs e)
        {
            idProductoSeleccionado = 0;
            modoEdicion = false;
            Limpiar();
            ModoEdicion();
            txtNombre_inve.Focus();
        }

        private void btnGuardar_inve_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre_inve.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrecio_inve.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("Ingrese un precio válido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtStock_inve.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un stock válido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();

                    if (!modoEdicion)
                    {
                        // INSERT
                        string sql = @"INSERT INTO inventario (nombre, precio, stock, estado)
                                       VALUES (@n, @p, @s, @e)";
                        using (var cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@n", txtNombre_inve.Text.Trim());
                            cmd.Parameters.AddWithValue("@p", precio);
                            cmd.Parameters.AddWithValue("@s", stock);
                            cmd.Parameters.AddWithValue("@e", cmbEstado_inve.Text);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Producto agregado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // UPDATE
                        string sql = @"UPDATE inventario 
                                       SET nombre=@n, precio=@p, stock=@s, estado=@e
                                       WHERE id_producto=@id";
                        using (var cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@n", txtNombre_inve.Text.Trim());
                            cmd.Parameters.AddWithValue("@p", precio);
                            cmd.Parameters.AddWithValue("@s", stock);
                            cmd.Parameters.AddWithValue("@e", cmbEstado_inve.Text);
                            cmd.Parameters.AddWithValue("@id", idProductoSeleccionado);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Producto actualizado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                ModoLectura();
                CargarInventario();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_inve_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            modoEdicion = true;
            ModoEdicion();
        }

        private void btnEliminar_inve_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar este producto?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = "DELETE FROM inventario WHERE id_producto=@id";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", idProductoSeleccionado);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Producto eliminado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ModoLectura();
                CargarInventario();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_inve_Click(object sender, EventArgs e)
        {
            Limpiar();
            ModoLectura();
            idProductoSeleccionado = 0;
            modoEdicion = false;
        }

        // ── HELPERS ───────────────────────────────────────────────────────
        private void Limpiar()
        {
            txtNombre_inve.Clear();
            txtPrecio_inve.Clear();
            txtStock_inve.Clear();
            cmbCategoria_inve.SelectedIndex = 0;
            cmbEstado_inve.SelectedIndex = 0;
        }

        private void ModoLectura()
        {
            txtNombre_inve.ReadOnly = true;
            txtPrecio_inve.ReadOnly = true;
            txtStock_inve.ReadOnly = true;
            cmbCategoria_inve.Enabled = false;
            cmbEstado_inve.Enabled = false;
            btnGuardar_inve.Enabled = false;
            btnNuevo_inve.Enabled = true;
            btnEditar_inve.Enabled = true;
            btnEliminar_inve.Enabled = true;
        }

        private void ModoEdicion()
        {
            txtNombre_inve.ReadOnly = false;
            txtPrecio_inve.ReadOnly = false;
            txtStock_inve.ReadOnly = false;
            cmbCategoria_inve.Enabled = true;
            cmbEstado_inve.Enabled = true;
            btnGuardar_inve.Enabled = true;
            btnNuevo_inve.Enabled = false;
            btnEditar_inve.Enabled = false;
            btnEliminar_inve.Enabled = false;
        }
    }
}
