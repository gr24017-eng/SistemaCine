namespace Mini_Proyecto_Cine
{
    partial class Comprobante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            grbComprobante = new GroupBox();
            lblBoletos = new Label();
            label8 = new Label();
            lblSala = new Label();
            label6 = new Label();
            lblFuncion = new Label();
            label4 = new Label();
            lblPelicula = new Label();
            label2 = new Label();
            label10 = new Label();
            lblCofiteria = new Label();
            label12 = new Label();
            lblIva = new Label();
            label14 = new Label();
            btnAceptar = new Button();
            label15 = new Label();
            lblAsientos = new Label();
            label17 = new Label();
            lblTotal = new Label();
            grbComprobante.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 190);
            label1.Location = new Point(166, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 46);
            label1.TabIndex = 0;
            label1.Text = "CINE PLUS";
            // 
            // grbComprobante
            // 
            grbComprobante.Controls.Add(lblTotal);
            grbComprobante.Controls.Add(label17);
            grbComprobante.Controls.Add(lblAsientos);
            grbComprobante.Controls.Add(label15);
            grbComprobante.Controls.Add(btnAceptar);
            grbComprobante.Controls.Add(label14);
            grbComprobante.Controls.Add(lblIva);
            grbComprobante.Controls.Add(label12);
            grbComprobante.Controls.Add(lblCofiteria);
            grbComprobante.Controls.Add(label10);
            grbComprobante.Controls.Add(lblBoletos);
            grbComprobante.Controls.Add(label8);
            grbComprobante.Controls.Add(lblSala);
            grbComprobante.Controls.Add(label6);
            grbComprobante.Controls.Add(lblFuncion);
            grbComprobante.Controls.Add(label4);
            grbComprobante.Controls.Add(lblPelicula);
            grbComprobante.Controls.Add(label2);
            grbComprobante.ForeColor = Color.FromArgb(0, 0, 190);
            grbComprobante.Location = new Point(12, 66);
            grbComprobante.Name = "grbComprobante";
            grbComprobante.Size = new Size(510, 372);
            grbComprobante.TabIndex = 1;
            grbComprobante.TabStop = false;
            grbComprobante.Text = "Detalles de la compra";
            // 
            // lblBoletos
            // 
            lblBoletos.AutoSize = true;
            lblBoletos.ForeColor = SystemColors.ControlText;
            lblBoletos.Location = new Point(368, 69);
            lblBoletos.Name = "lblBoletos";
            lblBoletos.Size = new Size(12, 20);
            lblBoletos.TabIndex = 7;
            lblBoletos.Text = ".";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(258, 69);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 6;
            label8.Text = "Boletos:";
            // 
            // lblSala
            // 
            lblSala.AutoSize = true;
            lblSala.Location = new Point(102, 194);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(12, 20);
            lblSala.TabIndex = 5;
            lblSala.Text = ".";
            lblSala.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(9, 194);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 4;
            label6.Text = "Sala:";
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.ForeColor = SystemColors.ControlText;
            lblFuncion.Location = new Point(102, 133);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(12, 20);
            lblFuncion.TabIndex = 3;
            lblFuncion.Text = ".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(9, 133);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 2;
            label4.Text = "Funcion:";
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.ForeColor = SystemColors.ControlText;
            lblPelicula.Location = new Point(102, 69);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(12, 20);
            lblPelicula.TabIndex = 1;
            lblPelicula.Text = ".";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(9, 69);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 0;
            label2.Text = "Pelicula:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(258, 133);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 8;
            label10.Text = "Cofiteria:";
            // 
            // lblCofiteria
            // 
            lblCofiteria.AutoSize = true;
            lblCofiteria.ForeColor = SystemColors.ControlText;
            lblCofiteria.Location = new Point(368, 133);
            lblCofiteria.Name = "lblCofiteria";
            lblCofiteria.Size = new Size(12, 20);
            lblCofiteria.TabIndex = 9;
            lblCofiteria.Text = ".";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(258, 194);
            label12.Name = "label12";
            label12.Size = new Size(69, 20);
            label12.TabIndex = 10;
            label12.Text = "IVA(13%)";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.ForeColor = SystemColors.ControlText;
            lblIva.Location = new Point(368, 194);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(12, 20);
            lblIva.TabIndex = 11;
            lblIva.Text = ".";
            lblIva.Click += lblIva_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ControlText;
            label14.Location = new Point(47, 333);
            label14.Name = "label14";
            label14.Size = new Size(165, 20);
            label14.TabIndex = 12;
            label14.Text = "!Gracias por su compra!";
            // 
            // btnAceptar
            // 
            btnAceptar.ForeColor = SystemColors.ControlText;
            btnAceptar.Location = new Point(281, 324);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.ControlText;
            label15.Location = new Point(9, 257);
            label15.Name = "label15";
            label15.Size = new Size(68, 20);
            label15.TabIndex = 14;
            label15.Text = "Asientos:";
            // 
            // lblAsientos
            // 
            lblAsientos.AutoSize = true;
            lblAsientos.ForeColor = SystemColors.ControlText;
            lblAsientos.Location = new Point(102, 257);
            lblAsientos.Name = "lblAsientos";
            lblAsientos.Size = new Size(12, 20);
            lblAsientos.TabIndex = 15;
            lblAsientos.Text = ".";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.ControlText;
            label17.Location = new Point(258, 257);
            label17.Name = "label17";
            label17.Size = new Size(53, 20);
            label17.TabIndex = 16;
            label17.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.FromArgb(0, 0, 190);
            lblTotal.Location = new Point(368, 257);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(12, 20);
            lblTotal.TabIndex = 17;
            lblTotal.Text = ".";
            // 
            // Comprobante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 450);
            Controls.Add(grbComprobante);
            Controls.Add(label1);
            Name = "Comprobante";
            Text = "Comprobante";
            grbComprobante.ResumeLayout(false);
            grbComprobante.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grbComprobante;
        private Label lblBoletos;
        private Label label8;
        private Label lblSala;
        private Label label6;
        private Label lblFuncion;
        private Label label4;
        private Label lblPelicula;
        private Label label2;
        private Label lblTotal;
        private Label label17;
        private Label lblAsientos;
        private Label label15;
        private Button btnAceptar;
        private Label label14;
        private Label lblIva;
        private Label label12;
        private Label lblCofiteria;
        private Label label10;
    }
}