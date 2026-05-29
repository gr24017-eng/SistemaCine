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
    public partial class Confiteria : Form
    {
        // Recibe el subtotal de boletos desde Ventas
        private decimal subtotalBoletos = 0;

        // Para que Ventas pueda leer el total final
        public decimal TotalFinal { get; private set; } = 0;
        public decimal TotalConfiteria { get; private set; } = 0;

        public Confiteria(decimal subtotalBoletos = 0)
        {
            InitializeComponent();
            this.subtotalBoletos = subtotalBoletos;
        }

        private void Confiteria_Load(object sender, EventArgs e)
        {
            // Columna Cantidad editable
            dgvProductos.EditMode = DataGridViewEditMode.EditOnEnter;

            // Mostrar boletos en el resumen
            lblBoletos.Text = "$" + subtotalBoletos.ToString("N2");

            CargarProductos();
            ActualizarResumen();
        }

        // ── CARGAR PRODUCTOS DESDE BD ─────────────────────────────────────
        private void CargarProductos()
        {
            try
            {
                dgvProductos.Rows.Clear();
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = @"SELECT nombre, precio, stock 
                                   FROM inventario 
                                   WHERE estado='activo' AND stock > 0
                                   ORDER BY nombre";
                    using (var cmd = new MySqlCommand(sql, con))
                    using (var dr = cmd.ExecuteReader())
                        while (dr.Read())
                            dgvProductos.Rows.Add(
                                dr["nombre"],
                                dr["precio"],
                                dr["stock"],
                                0  // cantidad inicial en 0
                            );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Solo si editaron la columna Cantidad (índice 3)
            if (e.ColumnIndex != dgvProductos.Columns["Cantidad"].Index) return;

            var cell = dgvProductos.Rows[e.RowIndex].Cells["Cantidad"];
            var stockCell = dgvProductos.Rows[e.RowIndex].Cells["Stock"];

            if (!int.TryParse(cell.Value?.ToString(), out int cantidad) || cantidad < 0)
            {
                cell.Value = 0;
                cantidad = 0;
            }

            // Validar que no supere el stock
            int stock = Convert.ToInt32(stockCell.Value);
            if (cantidad > stock)
            {
                MessageBox.Show($"Solo hay {stock} unidades disponibles.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cell.Value = stock;
            }

            ActualizarResumen();
        }

        // ── ACTUALIZAR RESUMEN ────────────────────────────────────────────
        private void ActualizarResumen()
        {
            decimal totalConfit = 0;

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.IsNewRow) continue;
                decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value ?? 0);
                int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value ?? 0);
                totalConfit += precio * cantidad;
            }

            decimal subtotal = subtotalBoletos + totalConfit;
            decimal iva = subtotal * 0.13m;
            decimal total = subtotal + iva;

            lblBoletos.Text = "$" + subtotalBoletos.ToString("N2");
            lblConfiteria.Text = "$" + totalConfit.ToString("N2");
            lblSubTotal.Text = "$" + subtotal.ToString("N2");
            lblIVA.Text = "$" + iva.ToString("N2");
            lblTotal.Text = "$" + total.ToString("N2");

            // Guardar para que Ventas los lea
            TotalConfiteria = totalConfit;
            TotalFinal = total;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            // Verificar si hay algo seleccionado
            bool hayProductos = false;
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.IsNewRow) continue;
                int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value ?? 0);
                if (cantidad > 0) { hayProductos = true; break; }
            }

            // Dentro de btnFinalizar_Click, antes de cerrar:
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.IsNewRow) continue;
                int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value ?? 0);
                if (cantidad <= 0) continue;

                string nombre = fila.Cells["Nombre"].Value?.ToString();
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = "UPDATE inventario SET stock = stock - @qty WHERE nombre = @nom AND stock >= @qty";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@qty", cantidad);
                        cmd.Parameters.AddWithValue("@nom", nombre);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            // Es opcional agregar confitería
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
