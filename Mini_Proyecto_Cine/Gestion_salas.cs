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
    public partial class Gestion_salas : Form
    {
        int idSalaSeleccionada = 0;

        public Gestion_salas()
        {
            InitializeComponent();
            
        }

        // ── LOAD ─────────────────────────────────────────────────────────
        private void Gestion_salas_Load(object sender, EventArgs e)
        {
            // Cargar combo estado
            cmbEstado_salas.Items.Clear();
            cmbEstado_salas.Items.Add("activa");
            cmbEstado_salas.Items.Add("inactiva");
            cmbEstado_salas.SelectedIndex = 0;

            // Capacidad no se puede editar (el inge dijo que es inamovible)
            txtCapacidad_salas.ReadOnly = true;
            txtCapacidad_salas.BackColor = System.Drawing.Color.WhiteSmoke;

            // Las salas son fijas, no se pueden agregar ni eliminar
            btnNuevo_salas.Enabled = false;
            btnEliminar_salas.Enabled = false;

            // Modo solo lectura al inicio
            ModoLectura();
            CargarSalas();
        }

        // ── CARGAR GRID ───────────────────────────────────────────────────
        private void CargarSalas()
        {
            try
            {
                dgvSalas.Rows.Clear();
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = "SELECT id_sala, nombre, capacidad, estado FROM salas ORDER BY id_sala";
                    using (var cmd = new MySqlCommand(sql, con))
                    using (var dr = cmd.ExecuteReader())
                        while (dr.Read())
                            dgvSalas.Rows.Add(
                                dr["id_sala"],
                                dr["nombre"],
                                dr["capacidad"],
                                "",           // descripcion no está en BD, se deja vacío
                                dr["estado"]
                            );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar salas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── CLICK EN FILA DEL GRID ────────────────────────────────────────
        private void dgvSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvSalas.Rows[e.RowIndex];
            idSalaSeleccionada = Convert.ToInt32(fila.Cells["ID"].Value);
            txtNum_sala_salas.Text = fila.Cells["Numero_sala"].Value?.ToString();
            txtCapacidad_salas.Text = fila.Cells["Capacidad"].Value?.ToString();
            txtDescripcion_salas.Text = fila.Cells["Descripcion"].Value?.ToString();
            cmbEstado_salas.Text = fila.Cells["Estado"].Value?.ToString();
        }

        // ── BOTONES ───────────────────────────────────────────────────────
        private void btnNuevo_salas_Click(object sender, EventArgs e)
        {
            // Las salas son fijas — no se pueden agregar
            MessageBox.Show("Las salas del cine son fijas y no se pueden agregar.",
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_salas_Click(object sender, EventArgs e)
        {
            if (idSalaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una sala de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ModoEdicion();
        }

        private void btnGuardar_salas_Click(object sender, EventArgs e)
        {
            if (idSalaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una sala de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNum_sala_salas.Text))
            {
                MessageBox.Show("El nombre de la sala no puede estar vacío.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    // Solo se puede editar nombre y estado, NO la capacidad
                    string sql = @"UPDATE salas 
                                   SET nombre=@n, estado=@e 
                                   WHERE id_sala=@id";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@n", txtNum_sala_salas.Text.Trim());
                        cmd.Parameters.AddWithValue("@e", cmbEstado_salas.Text);
                        cmd.Parameters.AddWithValue("@id", idSalaSeleccionada);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Sala actualizada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ModoLectura();
                CargarSalas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_salas_Click(object sender, EventArgs e)
        {
            // Las salas son fijas — no se pueden eliminar
            MessageBox.Show("Las salas del cine son fijas y no se pueden eliminar.",
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_salas_Click(object sender, EventArgs e)
        {
            Limpiar();
            ModoLectura();
        }

        // ── HELPERS ───────────────────────────────────────────────────────
        private void Limpiar()
        {
            txtNum_sala_salas.Clear();
            txtCapacidad_salas.Clear();
            txtDescripcion_salas.Clear();
            cmbEstado_salas.SelectedIndex = 0;
            idSalaSeleccionada = 0;
        }

        private void ModoLectura()
        {
            txtNum_sala_salas.ReadOnly = true;
            txtDescripcion_salas.ReadOnly = true;
            cmbEstado_salas.Enabled = false;
            btnGuardar_salas.Enabled = false;
            btnEditar_salas.Enabled = true;
        }

        private void ModoEdicion()
        {
            txtNum_sala_salas.ReadOnly = false;
            txtDescripcion_salas.ReadOnly = false;
            cmbEstado_salas.Enabled = true;
            btnGuardar_salas.Enabled = true;
            btnEditar_salas.Enabled = false;
        }
    }
}
