namespace Mini_Proyecto_Cine
{
    partial class Ventas
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            lblIVA = new Label();
            lblSubTotal = new Label();
            label11 = new Label();
            label5 = new Label();
            label10 = new Label();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            AsientoVentas = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            label6 = new Label();
            btnSeleccionarAsientos = new Button();
            btnComprar = new Button();
            btnCancelar = new Button();
            cmbPelicula_ventas = new ComboBox();
            cmbFuncion_ventas = new ComboBox();
            txtNombre_ventas = new TextBox();
            txtTelefono_ventas = new TextBox();
            txtIVA_ventas = new TextBox();
            txtTotal_ventas = new TextBox();
            txtSubtotal_ventas = new TextBox();
            lblSala_ventas = new Label();
            lblHora_ventas = new Label();
            lblPrecio_ventas = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPrecio_ventas);
            groupBox1.Controls.Add(lblHora_ventas);
            groupBox1.Controls.Add(lblSala_ventas);
            groupBox1.Controls.Add(cmbFuncion_ventas);
            groupBox1.Controls.Add(cmbPelicula_ventas);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.FromArgb(0, 0, 192);
            groupBox1.Location = new Point(14, 40);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(583, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccion de funcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(23, 25);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Pelicula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(23, 61);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Funcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(23, 96);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Sala:";
            label2.Click += label2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(23, 167);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 8;
            label9.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(23, 133);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Hora:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTotal_ventas);
            groupBox2.Controls.Add(txtSubtotal_ventas);
            groupBox2.Controls.Add(txtIVA_ventas);
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(lblIVA);
            groupBox2.Controls.Add(lblSubTotal);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label10);
            groupBox2.ForeColor = Color.FromArgb(0, 0, 190);
            groupBox2.Location = new Point(14, 556);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(423, 153);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resumen de Pago";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotal.Location = new Point(248, 104);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 25);
            lblTotal.TabIndex = 11;
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(248, 65);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(0, 20);
            lblIVA.TabIndex = 10;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(248, 25);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(0, 20);
            lblSubTotal.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(8, 104);
            label11.Name = "label11";
            label11.Size = new Size(45, 20);
            label11.TabIndex = 9;
            label11.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(8, 25);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "SubTotal:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(6, 65);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 9;
            label10.Text = "IVA(13%):";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTelefono_ventas);
            groupBox3.Controls.Add(txtNombre_ventas);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.ForeColor = Color.FromArgb(0, 0, 190);
            groupBox3.Location = new Point(14, 249);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(714, 116);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del Cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(13, 76);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 6;
            label7.Text = "Telefono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(15, 35);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 7;
            label8.Text = "Nombre:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(14, 373);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(629, 175);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Asientos seleccionados";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AsientoVentas, Precio, SubTotal });
            dataGridView1.Location = new Point(15, 29);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(586, 137);
            dataGridView1.TabIndex = 6;
            // 
            // AsientoVentas
            // 
            AsientoVentas.HeaderText = "Asiento";
            AsientoVentas.MinimumWidth = 6;
            AsientoVentas.Name = "AsientoVentas";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(297, -427);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // btnSeleccionarAsientos
            // 
            btnSeleccionarAsientos.BackColor = Color.FromArgb(0, 0, 190);
            btnSeleccionarAsientos.ForeColor = Color.White;
            btnSeleccionarAsientos.Location = new Point(656, 65);
            btnSeleccionarAsientos.Margin = new Padding(3, 4, 3, 4);
            btnSeleccionarAsientos.Name = "btnSeleccionarAsientos";
            btnSeleccionarAsientos.Size = new Size(203, 105);
            btnSeleccionarAsientos.TabIndex = 9;
            btnSeleccionarAsientos.Text = "Seleccionar Asientos";
            btnSeleccionarAsientos.UseVisualStyleBackColor = false;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.Green;
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(606, 561);
            btnComprar.Margin = new Padding(3, 4, 3, 4);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(193, 60);
            btnComprar.TabIndex = 11;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(606, 640);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(193, 60);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cmbPelicula_ventas
            // 
            cmbPelicula_ventas.FormattingEnabled = true;
            cmbPelicula_ventas.Location = new Point(97, 22);
            cmbPelicula_ventas.Name = "cmbPelicula_ventas";
            cmbPelicula_ventas.Size = new Size(151, 28);
            cmbPelicula_ventas.TabIndex = 9;
            // 
            // cmbFuncion_ventas
            // 
            cmbFuncion_ventas.FormattingEnabled = true;
            cmbFuncion_ventas.Location = new Point(97, 58);
            cmbFuncion_ventas.Name = "cmbFuncion_ventas";
            cmbFuncion_ventas.Size = new Size(151, 28);
            cmbFuncion_ventas.TabIndex = 10;
            // 
            // txtNombre_ventas
            // 
            txtNombre_ventas.Location = new Point(97, 32);
            txtNombre_ventas.Name = "txtNombre_ventas";
            txtNombre_ventas.Size = new Size(125, 27);
            txtNombre_ventas.TabIndex = 8;
            // 
            // txtTelefono_ventas
            // 
            txtTelefono_ventas.Location = new Point(97, 73);
            txtTelefono_ventas.Name = "txtTelefono_ventas";
            txtTelefono_ventas.Size = new Size(125, 27);
            txtTelefono_ventas.TabIndex = 9;
            // 
            // txtIVA_ventas
            // 
            txtIVA_ventas.Location = new Point(97, 62);
            txtIVA_ventas.Name = "txtIVA_ventas";
            txtIVA_ventas.Size = new Size(125, 27);
            txtIVA_ventas.TabIndex = 10;
            // 
            // txtTotal_ventas
            // 
            txtTotal_ventas.Location = new Point(97, 101);
            txtTotal_ventas.Name = "txtTotal_ventas";
            txtTotal_ventas.Size = new Size(125, 27);
            txtTotal_ventas.TabIndex = 11;
            // 
            // txtSubtotal_ventas
            // 
            txtSubtotal_ventas.Location = new Point(97, 22);
            txtSubtotal_ventas.Name = "txtSubtotal_ventas";
            txtSubtotal_ventas.Size = new Size(125, 27);
            txtSubtotal_ventas.TabIndex = 12;
            // 
            // lblSala_ventas
            // 
            lblSala_ventas.AutoSize = true;
            lblSala_ventas.ForeColor = SystemColors.ControlText;
            lblSala_ventas.Location = new Point(97, 96);
            lblSala_ventas.Name = "lblSala_ventas";
            lblSala_ventas.Size = new Size(12, 20);
            lblSala_ventas.TabIndex = 11;
            lblSala_ventas.Text = ".";
            // 
            // lblHora_ventas
            // 
            lblHora_ventas.AutoSize = true;
            lblHora_ventas.ForeColor = SystemColors.ControlText;
            lblHora_ventas.Location = new Point(97, 133);
            lblHora_ventas.Name = "lblHora_ventas";
            lblHora_ventas.Size = new Size(12, 20);
            lblHora_ventas.TabIndex = 12;
            lblHora_ventas.Text = ".";
            // 
            // lblPrecio_ventas
            // 
            lblPrecio_ventas.AutoSize = true;
            lblPrecio_ventas.ForeColor = SystemColors.ControlText;
            lblPrecio_ventas.Location = new Point(97, 167);
            lblPrecio_ventas.Name = "lblPrecio_ventas";
            lblPrecio_ventas.Size = new Size(12, 20);
            lblPrecio_ventas.TabIndex = 13;
            lblPrecio_ventas.Text = ".";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 725);
            Controls.Add(btnCancelar);
            Controls.Add(btnComprar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(btnSeleccionarAsientos);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ventas";
            Text = "Ventas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label10;
        private Button btnSeleccionarAsientos;
        private Button btnComprar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn AsientoVentas;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn SubTotal;
        private Label label11;
        private Label lblTotal;
        private Label lblIVA;
        private Label lblSubTotal;
        private Button btnCancelar;
        private Label lblPrecio_ventas;
        private Label lblHora_ventas;
        private Label lblSala_ventas;
        private ComboBox cmbFuncion_ventas;
        private ComboBox cmbPelicula_ventas;
        private TextBox txtTotal_ventas;
        private TextBox txtSubtotal_ventas;
        private TextBox txtIVA_ventas;
        private TextBox txtTelefono_ventas;
        private TextBox txtNombre_ventas;
    }
}