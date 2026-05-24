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
    public partial class FrmAsientos : Form
    {
        // Propiedad para que Ventas pueda leer los asientos elegidos
        public List<string> AsientosElegidos => asientosSeleccionados;
        public decimal PrecioUnitario { get; set; } = 0;
        public FrmAsientos()
        {
            InitializeComponent();
            this.Load += FrmAsientos_Load1;
        }

        private void FrmAsientos_Load1(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ConfigurarSala(int idSala)
        {
            // Primero mostrar todos los botones
            foreach (Control c in panel1.Controls)
                if (c is Button) c.Visible = true;

            // Ocultar según la sala
            string[] filasOcultar = { };
            int[] colsOcultar = { };

            switch (idSala)
            {
                case 1: // 45 butacas: filas A-E, cols 1-9
                    OcultarFila("F");
                    OcultarBoton("A10"); OcultarBoton("B10"); OcultarBoton("C10");
                    OcultarBoton("D10"); OcultarBoton("E10");
                    break;
                case 2: // 60 butacas: todo visible
                    break;
                case 3: // 25 butacas: filas A-E, cols 1-5
                    OcultarFila("F");
                    for (int i = 6; i <= 10; i++)
                    {
                        OcultarBoton("A" + i); OcultarBoton("B" + i);
                        OcultarBoton("C" + i); OcultarBoton("D" + i);
                        OcultarBoton("E" + i);
                    }
                    break;
                case 4: // 36 butacas: filas A-D, cols 1-9
                    OcultarFila("E"); OcultarFila("F");
                    OcultarBoton("A10"); OcultarBoton("B10");
                    OcultarBoton("C10"); OcultarBoton("D10");
                    break;
            }
        }

        private void OcultarFila(string fila)
        {
            foreach (Control c in panel1.Controls)
                if (c is Button b && b.Text.StartsWith(fila))
                    b.Visible = false;
        }

        private void OcultarBoton(string nombre)
        {
            foreach (Control c in panel1.Controls)
                if (c is Button b && b.Text == nombre)
                    b.Visible = false;
        }


        // Colores
        Color disponible = Color.Green;
        Color ocupado = Color.Gray;
        Color seleccionado = Color.FromArgb(128, 128, 255);

        List<string> asientosSeleccionados = new List<string>();

        private void btnAsiento_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == disponible)
            {
                btn.BackColor = seleccionado;
                asientosSeleccionados.Add(btn.Text);
            }
            else if (btn.BackColor == seleccionado)
            {
                btn.BackColor = disponible;
                asientosSeleccionados.Remove(btn.Text);
            }

            // Actualizar resumen
            lblAsientosSeleccionados.Text = string.Join(", ", asientosSeleccionados);
            lblCantAsientos.Text = asientosSeleccionados.Count + " asientos";
            // lblTotal se calculará cuando tengas el precio de la función
        }
        private void FrmAsientos_Load(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is Button b && b.Text != "")
                {
                    b.BackColor = Color.Green; // todos disponibles por ahora
                    b.Click += btnAsiento_Click;
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (asientosSeleccionados.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un asiento.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            asientosSeleccionados.Clear();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
