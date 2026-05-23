namespace Mini_Proyecto_Cine
{
    partial class Confiteria
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
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            lblIVA = new Label();
            lblSubTotal = new Label();
            lblConfiteria = new Label();
            lblBoletos = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnConfiteria = new Label();
            btnBoletos = new Label();
            btnFinalizar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(698, 291);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Stock, Cantidad });
            dataGridView1.Location = new Point(6, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(686, 254);
            dataGridView1.TabIndex = 0;
            // 
            // Producto
            // 
            Producto.FillWeight = 62.2083855F;
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Precio
            // 
            Precio.FillWeight = 90.1912842F;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 145;
            // 
            // Stock
            // 
            Stock.FillWeight = 113.822235F;
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.Width = 183;
            // 
            // Cantidad
            // 
            Cantidad.FillWeight = 133.778076F;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 215;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(lblIVA);
            groupBox2.Controls.Add(lblSubTotal);
            groupBox2.Controls.Add(lblConfiteria);
            groupBox2.Controls.Add(lblBoletos);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnConfiteria);
            groupBox2.Controls.Add(btnBoletos);
            groupBox2.Location = new Point(12, 319);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(698, 210);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resumen del pedido";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(616, 154);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 9;
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(622, 122);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(0, 15);
            lblIVA.TabIndex = 8;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(622, 98);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(0, 15);
            lblSubTotal.TabIndex = 7;
            // 
            // lblConfiteria
            // 
            lblConfiteria.AutoSize = true;
            lblConfiteria.Location = new Point(622, 60);
            lblConfiteria.Name = "lblConfiteria";
            lblConfiteria.Size = new Size(0, 15);
            lblConfiteria.TabIndex = 6;
            // 
            // lblBoletos
            // 
            lblBoletos.AutoSize = true;
            lblBoletos.Location = new Point(622, 36);
            lblBoletos.Name = "lblBoletos";
            lblBoletos.Size = new Size(0, 15);
            lblBoletos.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 163);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 4;
            label5.Text = "Total a Pagar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 132);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "IVA(16%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 102);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "SubTotal";
            // 
            // btnConfiteria
            // 
            btnConfiteria.AutoSize = true;
            btnConfiteria.Location = new Point(43, 72);
            btnConfiteria.Name = "btnConfiteria";
            btnConfiteria.Size = new Size(59, 15);
            btnConfiteria.TabIndex = 1;
            btnConfiteria.Text = "Confiteria";
            // 
            // btnBoletos
            // 
            btnBoletos.AutoSize = true;
            btnBoletos.Location = new Point(43, 36);
            btnBoletos.Name = "btnBoletos";
            btnBoletos.Size = new Size(46, 15);
            btnBoletos.TabIndex = 0;
            btnBoletos.Text = "Boletos";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(790, 319);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(128, 42);
            btnFinalizar.TabIndex = 2;
            btnFinalizar.Text = "Finalizar Compra";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(775, 241);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(155, 42);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Confiteria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 541);
            Controls.Add(btnCancelar);
            Controls.Add(btnFinalizar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Confiteria";
            Text = "Confiteria";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button btnFinalizar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Cantidad;
        private Label lblTotal;
        private Label lblIVA;
        private Label lblSubTotal;
        private Label lblConfiteria;
        private Label lblBoletos;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label btnConfiteria;
        private Label btnBoletos;
    }
}