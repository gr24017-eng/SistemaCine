using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mini_Proyecto_Cine
{
    public partial class FrmAsientos : Form
    {
        public List<string> AsientosElegidos => asientosSeleccionados;
        public decimal PrecioUnitario { get; set; } = 0;

        Color colorDisponible = Color.FromArgb(92, 184, 92);
        Color colorOcupado = Color.FromArgb(180, 180, 180);
        Color colorSeleccionado = Color.FromArgb(128, 128, 255);
        List<string> asientosSeleccionados = new List<string>();
        List<string> _ocupados = new List<string>();

        public FrmAsientos()
        {
            InitializeComponent();
        }

        private void FrmAsientos_Load(object sender, EventArgs e)
        {
            foreach (Control c in p_asientos.Controls)
            {
                if (c is Button b && b.Text.Length >= 2
                    && char.IsLetter(b.Text[0]) && char.IsDigit(b.Text[1]))
                {
                    b.UseVisualStyleBackColor = false;
                    b.BackColor = colorDisponible;
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderColor = Color.White;
                    b.Tag = "disponible";
                    b.Click += btnAsiento_Click;
                }
            }

            // Marcar ocupados DESPUÉS de inicializar botones
            if (_ocupados.Count > 0)
                MarcarOcupados(_ocupados);
        }

        private void btnAsiento_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Tag?.ToString() == "ocupado") return;

            if (btn.Tag?.ToString() == "disponible")
            {
                btn.BackColor = colorSeleccionado;
                btn.Tag = "seleccionado";
                asientosSeleccionados.Add(btn.Text);
            }
            else if (btn.Tag?.ToString() == "seleccionado")
            {
                btn.BackColor = colorDisponible;
                btn.Tag = "disponible";
                asientosSeleccionados.Remove(btn.Text);
            }
            ActualizarResumen();
        }

        private void ActualizarResumen()
        {
            lblAsientosSeleccionados.Text = string.Join(", ", asientosSeleccionados);
            lblCantAsientos.Text = asientosSeleccionados.Count + " asientos";
            if (PrecioUnitario > 0)
                lblTotal.Text = (asientosSeleccionados.Count * PrecioUnitario).ToString("C");
        }

        public void ConfigurarSala(int idSala)
        {
            foreach (Control c in p_asientos.Controls)
                if (c is Button) c.Visible = true;

            switch (idSala)
            {
                case 1:
                    OcultarFila("F");
                    for (char f = 'A'; f <= 'E'; f++) OcultarBoton(f + "10");
                    break;
                case 2: break;
                case 3:
                    OcultarFila("F");
                    for (char f = 'A'; f <= 'E'; f++)
                        for (int i = 6; i <= 10; i++) OcultarBoton(f + i.ToString());
                    break;
                case 4:
                    OcultarFila("E"); OcultarFila("F");
                    for (char f = 'A'; f <= 'D'; f++) OcultarBoton(f + "10");
                    break;
            }
        }

        public void MarcarOcupados(List<string> ocupados)
        {
            _ocupados = ocupados;
            foreach (Control c in p_asientos.Controls)
            {
                if (c is Button b && ocupados.Contains(b.Text))
                {
                    b.UseVisualStyleBackColor = false;
                    b.BackColor = colorOcupado;
                    b.Tag = "ocupado";
                    b.Enabled = false;
                }
            }
        }

        private void OcultarFila(string fila)
        {
            foreach (Control c in p_asientos.Controls)
                if (c is Button b && b.Text.StartsWith(fila))
                    b.Visible = false;
        }

        private void OcultarBoton(string nombre)
        {
            foreach (Control c in p_asientos.Controls)
                if (c is Button b && b.Text == nombre)
                    b.Visible = false;
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