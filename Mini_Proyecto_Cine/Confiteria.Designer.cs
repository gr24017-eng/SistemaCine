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
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(798, 388);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Stock, Cantidad });
            dataGridView1.Location = new Point(7, 41);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(784, 339);
            dataGridView1.TabIndex = 0;
            // 
            // Producto
            // 
            Producto.FillWeight = 62.2083855F;
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            // 
            // Precio
            // 
            Precio.FillWeight = 90.1912842F;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // Stock
            // 
            Stock.FillWeight = 113.822235F;
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            // 
            // Cantidad
            // 
            Cantidad.FillWeight = 133.778076F;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
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
            groupBox2.Location = new Point(14, 425);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(798, 280);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resumen del pedido";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(343, 234);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 9;
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(343, 185);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(0, 20);
            lblIVA.TabIndex = 8;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(343, 132);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(0, 20);
            lblSubTotal.TabIndex = 7;
            // 
            // lblConfiteria
            // 
            lblConfiteria.AutoSize = true;
            lblConfiteria.Location = new Point(343, 81);
            lblConfiteria.Name = "lblConfiteria";
            lblConfiteria.Size = new Size(0, 20);
            lblConfiteria.TabIndex = 6;
            // 
            // lblBoletos
            // 
            lblBoletos.AutoSize = true;
            lblBoletos.Location = new Point(343, 36);
            lblBoletos.Name = "lblBoletos";
            lblBoletos.Size = new Size(0, 20);
            lblBoletos.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 234);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 4;
            label5.Text = "Total a Pagar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 185);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "IVA(16%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 132);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "SubTotal";
            // 
            // btnConfiteria
            // 
            btnConfiteria.AutoSize = true;
            btnConfiteria.Location = new Point(49, 81);
            btnConfiteria.Name = "btnConfiteria";
            btnConfiteria.Size = new Size(74, 20);
            btnConfiteria.TabIndex = 1;
            btnConfiteria.Text = "Confiteria";
            // 
            // btnBoletos
            // 
            btnBoletos.AutoSize = true;
            btnBoletos.Location = new Point(49, 36);
            btnBoletos.Name = "btnBoletos";
            btnBoletos.Size = new Size(59, 20);
            btnBoletos.TabIndex = 0;
            btnBoletos.Text = "Boletos";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(903, 425);
            btnFinalizar.Margin = new Padding(3, 4, 3, 4);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(146, 56);
            btnFinalizar.TabIndex = 2;
            btnFinalizar.Text = "Finalizar Compra";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(903, 321);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 56);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Confiteria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 721);
            Controls.Add(btnCancelar);
            Controls.Add(btnFinalizar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
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