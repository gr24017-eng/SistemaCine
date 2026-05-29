namespace Mini_Proyecto_Cine
{
    partial class Control_inventario
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
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtBuscar_inve = new TextBox();
            dgvInventario = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            pbInventario = new PictureBox();
            btnLimpiar_inve = new Button();
            btnEliminar_inve = new Button();
            btnEditar_inve = new Button();
            btnGuardar_inve = new Button();
            btnNuevo_inve = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbEstado_inve = new ComboBox();
            cmbCategoria_inve = new ComboBox();
            txtPrecio_inve = new TextBox();
            txtStock_inve = new TextBox();
            txtNombre_inve = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbInventario).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtBuscar_inve);
            groupBox2.Controls.Add(dgvInventario);
            groupBox2.Location = new Point(12, 411);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1039, 311);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado de Productos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(825, 16);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 17;
            label6.Text = "Buscar:";
            // 
            // txtBuscar_inve
            // 
            txtBuscar_inve.Location = new Point(900, 13);
            txtBuscar_inve.Name = "txtBuscar_inve";
            txtBuscar_inve.Size = new Size(133, 27);
            txtBuscar_inve.TabIndex = 16;
            txtBuscar_inve.TextChanged += txtBuscar_inve_TextChanged;
            // 
            // dgvInventario
            // 
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { ID, Producto, Categoria, Precio, Stock, Estado });
            dgvInventario.Location = new Point(6, 46);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(1027, 259);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellClick += dgvInventario_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbInventario);
            groupBox1.Controls.Add(btnLimpiar_inve);
            groupBox1.Controls.Add(btnEliminar_inve);
            groupBox1.Controls.Add(btnEditar_inve);
            groupBox1.Controls.Add(btnGuardar_inve);
            groupBox1.Controls.Add(btnNuevo_inve);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbEstado_inve);
            groupBox1.Controls.Add(cmbCategoria_inve);
            groupBox1.Controls.Add(txtPrecio_inve);
            groupBox1.Controls.Add(txtStock_inve);
            groupBox1.Controls.Add(txtNombre_inve);
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1039, 395);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Producto";
            // 
            // pbInventario
            // 
            pbInventario.Location = new Point(611, 26);
            pbInventario.Name = "pbInventario";
            pbInventario.Size = new Size(269, 235);
            pbInventario.TabIndex = 15;
            pbInventario.TabStop = false;
            // 
            // btnLimpiar_inve
            // 
            btnLimpiar_inve.Location = new Point(807, 347);
            btnLimpiar_inve.Name = "btnLimpiar_inve";
            btnLimpiar_inve.Size = new Size(94, 29);
            btnLimpiar_inve.TabIndex = 14;
            btnLimpiar_inve.Text = "Limpiar";
            btnLimpiar_inve.UseVisualStyleBackColor = true;
            btnLimpiar_inve.Click += btnLimpiar_inve_Click;
            // 
            // btnEliminar_inve
            // 
            btnEliminar_inve.Location = new Point(629, 347);
            btnEliminar_inve.Name = "btnEliminar_inve";
            btnEliminar_inve.Size = new Size(94, 29);
            btnEliminar_inve.TabIndex = 13;
            btnEliminar_inve.Text = "Eliminar";
            btnEliminar_inve.UseVisualStyleBackColor = true;
            btnEliminar_inve.Click += btnEliminar_inve_Click;
            // 
            // btnEditar_inve
            // 
            btnEditar_inve.Location = new Point(457, 347);
            btnEditar_inve.Name = "btnEditar_inve";
            btnEditar_inve.Size = new Size(94, 29);
            btnEditar_inve.TabIndex = 12;
            btnEditar_inve.Text = "Editar";
            btnEditar_inve.UseVisualStyleBackColor = true;
            btnEditar_inve.Click += btnEditar_inve_Click;
            // 
            // btnGuardar_inve
            // 
            btnGuardar_inve.Location = new Point(283, 347);
            btnGuardar_inve.Name = "btnGuardar_inve";
            btnGuardar_inve.Size = new Size(94, 29);
            btnGuardar_inve.TabIndex = 11;
            btnGuardar_inve.Text = "Guardar";
            btnGuardar_inve.UseVisualStyleBackColor = true;
            btnGuardar_inve.Click += btnGuardar_inve_Click;
            // 
            // btnNuevo_inve
            // 
            btnNuevo_inve.Location = new Point(111, 347);
            btnNuevo_inve.Name = "btnNuevo_inve";
            btnNuevo_inve.Size = new Size(94, 29);
            btnNuevo_inve.TabIndex = 10;
            btnNuevo_inve.Text = "Nuevo";
            btnNuevo_inve.UseVisualStyleBackColor = true;
            btnNuevo_inve.Click += btnNuevo_inve_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 284);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 9;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 224);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 8;
            label4.Text = "Stock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 160);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 101);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 6;
            label2.Text = "Categoria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 41);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            // 
            // cmbEstado_inve
            // 
            cmbEstado_inve.FormattingEnabled = true;
            cmbEstado_inve.Location = new Point(191, 281);
            cmbEstado_inve.Name = "cmbEstado_inve";
            cmbEstado_inve.Size = new Size(171, 28);
            cmbEstado_inve.TabIndex = 4;
            // 
            // cmbCategoria_inve
            // 
            cmbCategoria_inve.FormattingEnabled = true;
            cmbCategoria_inve.Location = new Point(191, 98);
            cmbCategoria_inve.Name = "cmbCategoria_inve";
            cmbCategoria_inve.Size = new Size(171, 28);
            cmbCategoria_inve.TabIndex = 3;
            // 
            // txtPrecio_inve
            // 
            txtPrecio_inve.Location = new Point(191, 157);
            txtPrecio_inve.Name = "txtPrecio_inve";
            txtPrecio_inve.Size = new Size(171, 27);
            txtPrecio_inve.TabIndex = 2;
            // 
            // txtStock_inve
            // 
            txtStock_inve.Location = new Point(191, 221);
            txtStock_inve.Name = "txtStock_inve";
            txtStock_inve.Size = new Size(171, 27);
            txtStock_inve.TabIndex = 1;
            // 
            // txtNombre_inve
            // 
            txtNombre_inve.Location = new Point(191, 38);
            txtNombre_inve.Name = "txtNombre_inve";
            txtNombre_inve.Size = new Size(171, 27);
            txtNombre_inve.TabIndex = 0;
            // 
            // Control_inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 733);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Control_inventario";
            Text = "Control_inventario";
            Load += Control_inventario_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtBuscar_inve;
        private DataGridView dgvInventario;
        private GroupBox groupBox1;
        private PictureBox pbInventario;
        private Button btnLimpiar_inve;
        private Button btnEliminar_inve;
        private Button btnEditar_inve;
        private Button btnGuardar_inve;
        private Button btnNuevo_inve;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbEstado_inve;
        private ComboBox cmbCategoria_inve;
        private TextBox txtPrecio_inve;
        private TextBox txtStock_inve;
        private TextBox txtNombre_inve;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Estado;
    }
}