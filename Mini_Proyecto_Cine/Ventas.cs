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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarAsientos_Click(object sender, EventArgs e)
        {
            FrmAsientos frm = new FrmAsientos();
            frm.ConfigurarSala(1); // cuando tengas BD pasás el id real

            if (frm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                decimal precio = 75; // precio temporal, viene de la funcion
                foreach (string asiento in frm.AsientosElegidos)
                {
                    dataGridView1.Rows.Add(asiento, precio.ToString("C"), precio.ToString("C"));
                }
                CalcularTotales(frm.AsientosElegidos.Count, precio);
            }
        }

        private void CalcularTotales(int cantAsientos, decimal precioUnitario)
        {
            decimal subtotal = cantAsientos * precioUnitario;
            decimal iva = subtotal * 0.13m;
            decimal total = subtotal + iva;

            txtSubtotal_ventas.Text = subtotal.ToString("C");
            txtIVA_ventas.Text = iva.ToString("C");
            txtTotal_ventas.Text = total.ToString("C");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtSubtotal_ventas.Clear();
            txtIVA_ventas.Clear();
            txtTotal_ventas.Clear();
        }
    }
}
