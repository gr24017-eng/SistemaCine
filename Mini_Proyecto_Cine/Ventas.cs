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
    public partial class frm_Ventas : Form
    {// Variables de estado
        int idFuncionSeleccionada = 0;
        int idSalaSeleccionada = 0;
        decimal precioFuncion = 0;
        List<string> asientosElegidos = new List<string>();

        public frm_Ventas()
        {
            InitializeComponent();

        }
        private void btnSeleccionarAsientos_Click(object sender, EventArgs e)
        {
            if (idFuncionSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una función primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmAsientos frm = new FrmAsientos();
            frm.PrecioUnitario = precioFuncion;
            frm.ConfigurarSala(idSalaSeleccionada);

            // Marcar asientos ya ocupados desde la BD
            frm.MarcarOcupados(ObtenerAsientosOcupados(idFuncionSeleccionada));

            if (frm.ShowDialog() == DialogResult.OK)
            {
                asientosElegidos = frm.AsientosElegidos;
                dataGridView1.Rows.Clear();

                foreach (string asiento in asientosElegidos)
                    dataGridView1.Rows.Add(asiento,
                        precioFuncion.ToString("C"),
                        precioFuncion.ToString("C"));

                CalcularTotales();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void frm_Ventas_Load(object sender, EventArgs e)
        {
            CargarPeliculas();
            LimpiarFormulario();
        }

        // ── CARGAR COMBOS ────────────────────────────────────────────────
        private void CargarPeliculas()
        {
            try
            {
                cmbPelicula_ventas.Items.Clear();
                cmbPelicula_ventas.Items.Add(new ComboItem { Id = 0, Texto = "-- Seleccione --" });

                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = "SELECT id_pelicula, nombre FROM peliculas WHERE estado='En Cartelera'";
                    using (var cmd = new MySqlCommand(sql, con))
                    using (var dr = cmd.ExecuteReader())
                        while (dr.Read())
                            cmbPelicula_ventas.Items.Add(new ComboItem
                            {
                                Id = dr.GetInt32("id_pelicula"),
                                Texto = dr.GetString("nombre")
                            });
                }
                cmbPelicula_ventas.DisplayMember = "Texto";
                cmbPelicula_ventas.ValueMember = "Id";
                cmbPelicula_ventas.SelectedIndex = 0;
                cmbPelicula_ventas.SelectedIndexChanged += cmbPelicula_ventas_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar películas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPelicula_ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFuncion_ventas.Items.Clear();
            LimpiarDetalleFuncion();

            if (cmbPelicula_ventas.SelectedItem is ComboItem item && item.Id > 0)
                CargarFunciones(item.Id);
        }

        private void CargarFunciones(int idPelicula)
        {
            try
            {
                cmbFuncion_ventas.Items.Clear();
                cmbFuncion_ventas.Items.Add(new ComboItem { Id = 0, Texto = "-- Seleccione --" });

                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = @"SELECT f.id_funcion, s.nombre AS sala, f.fecha, f.hora, f.precio
                                   FROM funciones f
                                   INNER JOIN salas s ON f.id_sala = s.id_sala
                                   WHERE f.id_pelicula = @id AND f.fecha >= CURDATE()";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", idPelicula);
                        using (var dr = cmd.ExecuteReader())
                            while (dr.Read())
                            {
                                string texto = $"{dr["fecha"]:dd/MM/yyyy} {dr["hora"]} - {dr["sala"]}";
                                cmbFuncion_ventas.Items.Add(new ComboItem
                                {
                                    Id = dr.GetInt32("id_funcion"),
                                    Texto = texto
                                });
                            }
                    }
                }
                cmbFuncion_ventas.DisplayMember = "Texto";
                cmbFuncion_ventas.ValueMember = "Id";
                cmbFuncion_ventas.SelectedIndex = 0;
                cmbFuncion_ventas.SelectedIndexChanged += cmbFuncion_ventas_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar funciones: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFuncion_ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarDetalleFuncion();
            if (!(cmbFuncion_ventas.SelectedItem is ComboItem item) || item.Id == 0) return;

            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = @"SELECT f.id_sala, f.hora, f.precio, s.nombre AS sala
                                   FROM funciones f
                                   INNER JOIN salas s ON f.id_sala = s.id_sala
                                   WHERE f.id_funcion = @id";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", item.Id);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                idFuncionSeleccionada = item.Id;
                                idSalaSeleccionada = dr.GetInt32("id_sala");
                                precioFuncion = dr.GetDecimal("precio");

                                lblSala_ventas.Text = dr.GetString("sala");
                                lblHora_ventas.Text = dr["hora"].ToString();
                                lblPrecio_ventas.Text = precioFuncion.ToString("C");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> ObtenerAsientosOcupados(int idFuncion)
        {
            var ocupados = new List<string>();
            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = "SELECT numero FROM asientos WHERE id_funcion=@id AND estado='ocupado'";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", idFuncion);
                        using (var dr = cmd.ExecuteReader())
                            while (dr.Read())
                                ocupados.Add(dr.GetString("numero"));
                    }
                }
            }
            catch { }
            return ocupados;
        }

        // ── CALCULAR TOTALES ─────────────────────────────────────────────
        private void CalcularTotales()
        {
            decimal subtotal = asientosElegidos.Count * precioFuncion;
            decimal iva = subtotal * 0.13m;
            decimal total = subtotal + iva;

            txtSubtotal_ventas.Text = subtotal.ToString("C");
            txtIVA_ventas.Text = iva.ToString("C");
            txtTotal_ventas.Text = total.ToString("C");
        }
        private void LimpiarFormulario()
        {
            dataGridView1.Rows.Clear();
            asientosElegidos.Clear();
            txtNombre_ventas.Clear();
            txtTelefono_ventas.Clear();
            txtSubtotal_ventas.Clear();
            txtIVA_ventas.Clear();
            txtTotal_ventas.Clear();
            LimpiarDetalleFuncion();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre_ventas.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (asientosElegidos.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un asiento.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    using (var trans = con.BeginTransaction())
                    {
                        try
                        {
                            decimal subtotal = asientosElegidos.Count * precioFuncion;
                            decimal iva = subtotal * 0.13m;
                            decimal total = subtotal + iva;

                            // 1. Insertar venta
                            string sqlVenta = @"INSERT INTO ventas 
                                (id_usuario, id_funcion, subtotal, iva, total, cantidad_boletos, total_confiteria)
                                VALUES (@idu, @idf, @sub, @iva, @tot, @boletos, @confit);
                                SELECT LAST_INSERT_ID();";
                            int idVenta = 0;
                            using (var cmd = new MySqlCommand(sqlVenta, con, trans))
                            {
                                cmd.Parameters.AddWithValue("@idu", Sesion.IdUsuario);
                                cmd.Parameters.AddWithValue("@idf", idFuncionSeleccionada);
                                cmd.Parameters.AddWithValue("@sub", subtotal);
                                cmd.Parameters.AddWithValue("@iva", iva);
                                cmd.Parameters.AddWithValue("@tot", total);
                                cmd.Parameters.AddWithValue("@boletos", asientosElegidos.Count);
                                cmd.Parameters.AddWithValue("@confit", 0); 
                                idVenta = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            // 2. Insertar asientos + marcarlos ocupados
                            foreach (string asiento in asientosElegidos)
                            {
                                // Obtener id_asiento o insertar si no existe
                                string sqlGetAsiento = @"SELECT id_asiento FROM asientos 
                                    WHERE id_sala=@s AND id_funcion=@f AND numero=@n";
                                int idAsiento = 0;
                                using (var cmd = new MySqlCommand(sqlGetAsiento, con, trans))
                                {
                                    cmd.Parameters.AddWithValue("@s", idSalaSeleccionada);
                                    cmd.Parameters.AddWithValue("@f", idFuncionSeleccionada);
                                    cmd.Parameters.AddWithValue("@n", asiento);
                                    var res = cmd.ExecuteScalar();
                                    if (res != null)
                                        idAsiento = Convert.ToInt32(res);
                                }

                                if (idAsiento == 0)
                                {
                                    // Insertar asiento nuevo como ocupado
                                    string sqlInsAsiento = @"INSERT INTO asientos 
                                        (id_sala, id_funcion, numero, estado) 
                                        VALUES (@s, @f, @n, 'ocupado');
                                        SELECT LAST_INSERT_ID();";
                                    using (var cmd = new MySqlCommand(sqlInsAsiento, con, trans))
                                    {
                                        cmd.Parameters.AddWithValue("@s", idSalaSeleccionada);
                                        cmd.Parameters.AddWithValue("@f", idFuncionSeleccionada);
                                        cmd.Parameters.AddWithValue("@n", asiento);
                                        idAsiento = Convert.ToInt32(cmd.ExecuteScalar());
                                    }
                                }
                                else
                                {
                                    // Marcar como ocupado
                                    string sqlUpd = "UPDATE asientos SET estado='ocupado' WHERE id_asiento=@id";
                                    using (var cmd = new MySqlCommand(sqlUpd, con, trans))
                                    {
                                        cmd.Parameters.AddWithValue("@id", idAsiento);
                                        cmd.ExecuteNonQuery();
                                    }
                                }

                                // Insertar detalle de venta
                                string sqlDetalle = @"INSERT INTO detalle_ventas 
                                    (id_venta, id_asiento, cantidad, precio) 
                                    VALUES (@v, @a, 1, @p)";
                                using (var cmd = new MySqlCommand(sqlDetalle, con, trans))
                                {
                                    cmd.Parameters.AddWithValue("@v", idVenta);
                                    cmd.Parameters.AddWithValue("@a", idAsiento);
                                    cmd.Parameters.AddWithValue("@p", precioFuncion);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            trans.Commit();

                            // Abrir confitería (opcional para el cliente)
                            decimal subBoletos = asientosElegidos.Count * precioFuncion;
                            Confiteria confiteria = new Confiteria(subBoletos);
                            confiteria.ShowDialog(); // No importa si cancela, igual abre comprobante

                            // Actualizar total_confiteria si hubo compra en confitería
                            if (confiteria.TotalConfiteria > 0)
                            {
                                using (var con2 = Conexion.ObtenerConexion())
                                {
                                    con2.Open();
                                    string sqlUpConfit = "UPDATE ventas SET total_confiteria=@tc WHERE id_venta=@iv";
                                    using (var cmd = new MySqlCommand(sqlUpConfit, con2))
                                    {
                                        cmd.Parameters.AddWithValue("@tc", confiteria.TotalConfiteria);
                                        cmd.Parameters.AddWithValue("@iv", idVenta);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            // Comprobante con totales combinados
                            string peliculaComp = (cmbPelicula_ventas.SelectedItem as ComboItem)?.Texto ?? "";
                            string funcionComp = (cmbFuncion_ventas.SelectedItem as ComboItem)?.Texto ?? "";
                            string salaComp = lblSala_ventas.Text;
                            decimal subComp = subBoletos;
                            decimal ivaComp = (subBoletos + confiteria.TotalConfiteria) * 0.13m;
                            decimal totalComp = subBoletos + confiteria.TotalConfiteria + ivaComp;

                            Comprobante comp = new Comprobante(
                                peliculaComp, funcionComp, salaComp,
                                asientosElegidos, subComp, ivaComp, totalComp);
                            comp.ShowDialog();

                            LimpiarFormulario();

                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Error al guardar la venta: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDetalleFuncion()
        {
            lblSala_ventas.Text = ".";
            lblHora_ventas.Text = ".";
            lblPrecio_ventas.Text = ".";
            idFuncionSeleccionada = 0;
            idSalaSeleccionada = 0;
            precioFuncion = 0;
        }
    }
}
