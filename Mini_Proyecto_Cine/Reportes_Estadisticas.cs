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
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mini_Proyecto_Cine
{
    public partial class Reportes_Estadisticas : Form
    {
        public Reportes_Estadisticas()
        {
            InitializeComponent();
        }

        private void Reportes_Estadisticas_Load(object sender, EventArgs e)
        {
            // ComboBox
            cmbSelecion_repor.Items.Clear();
            cmbSelecion_repor.Items.Add("Ventas diarias");
            cmbSelecion_repor.Items.Add("Películas más vistas");
            cmbSelecion_repor.SelectedIndex = 0;

            // Rango por defecto: últimos 7 días
            dtpDesde.Value = DateTime.Today.AddDays(-6);
            dtpHasta.Value = DateTime.Today;

            // Configurar charts ANTES de cargar datos
            ConfigurarChartLineas();
            ConfigurarChartPie();

            CargarTarjetas();
            GenerarReporte();
        }

        private void ConfigurarChartLineas()
        {
            // Renombrar Series1 → "Ventas ($)"
            chartVentas_dia.Series["Series1"].Name = "Ventas ($)";
            chartVentas_dia.Series["Ventas ($)"].ChartType = SeriesChartType.Line;
            chartVentas_dia.Series["Ventas ($)"].Color = Color.DodgerBlue;
            chartVentas_dia.Series["Ventas ($)"].BorderWidth = 3;
            chartVentas_dia.Series["Ventas ($)"].MarkerStyle = MarkerStyle.Circle;
            chartVentas_dia.Series["Ventas ($)"].MarkerSize = 8;
            chartVentas_dia.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/MM";
            chartVentas_dia.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "C0";
            chartVentas_dia.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            chartVentas_dia.BackColor = Color.White;
        }

        private void ConfigurarChartPie()
        {
            // Renombrar Series1 → "Boletos"
            chartMas_vistas.Series["Series1"].Name = "Boletos";
            chartMas_vistas.Series["Boletos"].ChartType = SeriesChartType.Pie;
            chartMas_vistas.Series["Boletos"]["PieLabelStyle"] = "Outside";
            chartMas_vistas.Series["Boletos"]["PieLineColor"] = "Black";
            chartMas_vistas.BackColor = Color.White;
        }

        private void CargarTarjetas()
        {
            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string hoy = DateTime.Today.ToString("yyyy-MM-dd");
                    string mes = DateTime.Today.ToString("yyyy-MM");

                    // Ventas totales hoy
                    using (var cmd = new MySqlCommand(
                        "SELECT IFNULL(SUM(total),0) FROM ventas WHERE DATE(fecha_venta)=@hoy", con))
                    {
                        cmd.Parameters.AddWithValue("@hoy", hoy);
                        lblVentasHoy.Text = "$" + Convert.ToDecimal(cmd.ExecuteScalar()).ToString("N2");
                    }

                    // Boletos vendidos hoy
                    using (var cmd = new MySqlCommand(
                        "SELECT IFNULL(SUM(cantidad_boletos),0) FROM ventas WHERE DATE(fecha_venta)=@hoy", con))
                    {
                        cmd.Parameters.AddWithValue("@hoy", hoy);
                        lblBoletosHoy.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                    }

                    // Ingresos confitería hoy
                    using (var cmd = new MySqlCommand(
                        "SELECT IFNULL(SUM(total_confiteria),0) FROM ventas WHERE DATE(fecha_venta)=@hoy", con))
                    {
                        cmd.Parameters.AddWithValue("@hoy", hoy);
                        lblConfitHoy.Text = "$" + Convert.ToDecimal(cmd.ExecuteScalar()).ToString("N2");
                    }

                    // Ventas totales del mes
                    using (var cmd = new MySqlCommand(
                        "SELECT IFNULL(SUM(total),0) FROM ventas WHERE DATE_FORMAT(fecha_venta,'%Y-%m')=@mes", con))
                    {
                        cmd.Parameters.AddWithValue("@mes", mes);
                        lblVentasMes.Text = "$" + Convert.ToDecimal(cmd.ExecuteScalar()).ToString("N2");
                        string mesAnio = dtpDesde.Value.ToString("MMMM yyyy",
                        new System.Globalization.CultureInfo("es-ES"));
                        lblSubMes.Text = char.ToUpper(mesAnio[0]) + mesAnio.Substring(1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar resumen: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha Desde no puede ser mayor que Hasta.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            CargarTarjetas();
            CargarChartVentasDia();
            CargarChartPeliculas();
            CargarDetalle();
        }

        private void CargarChartVentasDia()
        {
            chartVentas_dia.Series["Ventas ($)"].Points.Clear();
            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = @"SELECT DATE(fecha_venta) AS dia, 
                                          IFNULL(SUM(total),0) AS total
                                   FROM ventas
                                   WHERE DATE(fecha_venta) BETWEEN @desde AND @hasta
                                   GROUP BY dia ORDER BY dia";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@desde", dtpDesde.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@hasta", dtpHasta.Value.ToString("yyyy-MM-dd"));
                        using (var dr = cmd.ExecuteReader())
                            while (dr.Read())
                                chartVentas_dia.Series["Ventas ($)"].Points
                                    .AddXY(Convert.ToDateTime(dr["dia"]), Convert.ToDouble(dr["total"]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráfica de ventas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarChartPeliculas()
        {
            chartMas_vistas.Series["Boletos"].Points.Clear();
            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    // ← nombre correcto: p.nombre (no p.titulo)
                    string sql = @"SELECT p.nombre AS titulo,
                                          IFNULL(SUM(v.cantidad_boletos),0) AS boletos
                                   FROM ventas v
                                   JOIN funciones f ON v.id_funcion = f.id_funcion
                                   JOIN peliculas p ON f.id_pelicula = p.id_pelicula
                                   WHERE DATE(v.fecha_venta) BETWEEN @desde AND @hasta
                                   GROUP BY p.nombre
                                   ORDER BY boletos DESC
                                   LIMIT 6";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@desde", dtpDesde.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@hasta", dtpHasta.Value.ToString("yyyy-MM-dd"));
                        using (var dr = cmd.ExecuteReader())
                            while (dr.Read())
                                chartMas_vistas.Series["Boletos"].Points
                                    .AddXY(dr["titulo"].ToString(), Convert.ToInt32(dr["boletos"]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráfica de películas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDetalle()
        {
            dgvDetalle_reporte.Rows.Clear();
            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = @"SELECT DATE(fecha_venta)               AS Fecha,
                                          SUM(cantidad_boletos)           AS Boletos,
                                          SUM(subtotal)                   AS VentaBoletos,
                                          IFNULL(SUM(total_confiteria),0) AS Confiteria,
                                          SUM(total)                      AS Total
                                   FROM ventas
                                   WHERE DATE(fecha_venta) BETWEEN @desde AND @hasta
                                   GROUP BY DATE(fecha_venta)
                                   ORDER BY Fecha";

                    int sumaBoletos = 0;
                    decimal sumaVB = 0, sumaC = 0, sumaT = 0;

                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@desde", dtpDesde.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@hasta", dtpHasta.Value.ToString("yyyy-MM-dd"));
                        using (var dr = cmd.ExecuteReader())
                            while (dr.Read())
                            {
                                int b = Convert.ToInt32(dr["Boletos"]);
                                decimal vb = Convert.ToDecimal(dr["VentaBoletos"]);
                                decimal c = Convert.ToDecimal(dr["Confiteria"]);
                                decimal t = Convert.ToDecimal(dr["Total"]);

                                dgvDetalle_reporte.Rows.Add(
                                    Convert.ToDateTime(dr["Fecha"]).ToString("dd/MM/yyyy"),
                                    b, "$" + vb.ToString("N2"),
                                    "$" + c.ToString("N2"),
                                    "$" + t.ToString("N2"));

                                sumaBoletos += b; sumaVB += vb; sumaC += c; sumaT += t;
                            }
                    }

                    // Fila de totales en verde
                    int idx = dgvDetalle_reporte.Rows.Add(
                        "TOTAL", sumaBoletos,
                        "$" + sumaVB.ToString("N2"),
                        "$" + sumaC.ToString("N2"),
                        "$" + sumaT.ToString("N2"));

                    foreach (DataGridViewCell cell in dgvDetalle_reporte.Rows[idx].Cells)
                    {
                        cell.Style.ForeColor = Color.Green;
                        cell.Style.Font = new Font(dgvDetalle_reporte.Font, FontStyle.Bold);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
