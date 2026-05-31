using MySql.Data.MySqlClient;

namespace Mini_Proyecto_Cine
{
    public partial class FrmCartelera : Form
    {
        public FrmCartelera()
        {
            InitializeComponent();
            CargarCartelera();
        }

        private void CargarCartelera()
        {
            flpPeliculas.Controls.Clear();

            MySqlConnection con = Conexion.ObtenerConexion();
            try
            {
                con.Open();
                string sql = "SELECT id_pelicula, nombre, imagen FROM peliculas WHERE estado='En cartelera'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id_pelicula"]);
                    string nombre = dr["nombre"].ToString();
                    byte[] imgBytes = dr["imagen"] != DBNull.Value ? (byte[])dr["imagen"] : null;

                    // Panel por película
                    Panel panel = new Panel();
                    panel.Size = new Size(180, 260);
                    panel.Margin = new Padding(15);
                    panel.Cursor = Cursors.Hand;
                    panel.BackColor = Color.White;
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Tag = id;

                    // Imagen
                    PictureBox pic = new PictureBox();
                    pic.Size = new Size(160, 200);
                    pic.Location = new Point(10, 10);
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Tag = id;
                    pic.BackColor = Color.LightGray;
                    if (imgBytes != null)
                    {
                        using MemoryStream ms = new MemoryStream(imgBytes);
                        pic.Image = Image.FromStream(ms);
                    }

                    // Nombre
                    Label lbl = new Label();
                    lbl.Text = nombre;
                    lbl.Location = new Point(5, 215);
                    lbl.Size = new Size(170, 40);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    lbl.Tag = id;

                    // Click en cualquier parte abre ventas
                    panel.Click += Pelicula_Click;
                    pic.Click += Pelicula_Click;
                    lbl.Click += Pelicula_Click;

                    panel.Controls.Add(pic);
                    panel.Controls.Add(lbl);
                    flpPeliculas.Controls.Add(panel);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { con.Close(); }
        }

        private void Pelicula_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            int idPelicula = Convert.ToInt32(ctrl.Tag);

            frm_Ventas ventas = new frm_Ventas();
            ventas.Show();
            this.Hide();
        }
    }
}