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
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label10 = new Label();
            btnSeleccionarAsientos = new Button();
            btnComprar = new Button();
            dataGridView1 = new DataGridView();
            AsientoVentas = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            label11 = new Label();
            lblSubTotal = new Label();
            lblIVA = new Label();
            lblTotal = new Label();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.FromArgb(0, 0, 192);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 151);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccion de funcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(20, 19);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Pelicula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(20, 46);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Funcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(20, 72);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Sala:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 100);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Hora:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(lblIVA);
            groupBox2.Controls.Add(lblSubTotal);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(12, 417);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 115);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resumen de Pago";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(12, 187);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(625, 87);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del Cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 57);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 6;
            label7.Text = "Telefono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 26);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 7;
            label8.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(20, 125);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 8;
            label9.Text = "Precio:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(12, 280);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(550, 131);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Asientos seleccionados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 19);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "SubTotal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, -320);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 49);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 9;
            label10.Text = "IVA(16%):";
            // 
            // btnSeleccionarAsientos
            // 
            btnSeleccionarAsientos.BackColor = Color.Navy;
            btnSeleccionarAsientos.ForeColor = Color.White;
            btnSeleccionarAsientos.Location = new Point(574, 49);
            btnSeleccionarAsientos.Name = "btnSeleccionarAsientos";
            btnSeleccionarAsientos.Size = new Size(178, 79);
            btnSeleccionarAsientos.TabIndex = 9;
            btnSeleccionarAsientos.Text = "Seleccionar Asientos";
            btnSeleccionarAsientos.UseVisualStyleBackColor = false;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.Green;
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(530, 421);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(169, 45);
            btnComprar.TabIndex = 11;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AsientoVentas, Precio, SubTotal });
            dataGridView1.Location = new Point(13, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(513, 103);
            dataGridView1.TabIndex = 6;
            // 
            // AsientoVentas
            // 
            AsientoVentas.HeaderText = "Asiento";
            AsientoVentas.Name = "AsientoVentas";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 78);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 9;
            label11.Text = "Total:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(217, 19);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(0, 15);
            lblSubTotal.TabIndex = 9;
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(217, 49);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(0, 15);
            lblIVA.TabIndex = 10;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotal.Location = new Point(217, 78);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(530, 480);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(169, 45);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 544);
            Controls.Add(btnCancelar);
            Controls.Add(btnComprar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(btnSeleccionarAsientos);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
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
    }
}