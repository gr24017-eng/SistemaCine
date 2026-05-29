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
    public partial class Comprobante : Form
    {
        public Comprobante(string pelicula, string funcion, string sala,
                           List<string> asientos, decimal subtotal,
                           decimal iva, decimal total)
        {
            InitializeComponent();

            lblPelicula.Text = pelicula;
            lblFuncion.Text = funcion;
            lblSala.Text = sala;
            lblAsientos.Text = string.Join(", ", asientos);
            lblBoletos.Text = asientos.Count + " boleto(s) — $" + subtotal.ToString("N2");
            lblCofiteria.Text = "$0.00";
            lblIva.Text = "$" + iva.ToString("N2");
            lblTotal.Text = "$" + total.ToString("N2");

            btnAceptar.Click += (s, e) => this.Close();
        }

    }
}
