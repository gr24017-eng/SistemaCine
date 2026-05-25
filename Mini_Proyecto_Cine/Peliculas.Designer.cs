namespace Mini_Proyecto_Cine
{
    partial class Peliculas
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
            cmbCategoria = new ComboBox();
            groupBox1 = new GroupBox();
            btnQuitar = new Button();
            lblImagen = new Label();
            lblEstado = new Label();
            lblDescripción = new Label();
            lblDuración = new Label();
            lblCategoria = new Label();
            lblClasificacion = new Label();
            lblNombre = new Label();
            pictureBox1 = new PictureBox();
            btnCargar = new Button();
            txtDescripcion = new TextBox();
            txtDuracion = new TextBox();
            txtNombre = new TextBox();
            cmbEstado = new ComboBox();
            cmbClasificacion = new ComboBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Clasificacion = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            grbListado = new GroupBox();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            txtBuscar = new TextBox();
            btnNuevo = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grbListado.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Acción", "Terror", "Romance", "Ficcion", "Comedia", "Suspenso ", "Musical", "Policial", "Animada" });
            cmbCategoria.Location = new Point(116, 88);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(241, 23);
            cmbCategoria.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnQuitar);
            groupBox1.Controls.Add(lblImagen);
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(lblDescripción);
            groupBox1.Controls.Add(lblDuración);
            groupBox1.Controls.Add(lblCategoria);
            groupBox1.Controls.Add(lblClasificacion);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnCargar);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtDuracion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(cmbClasificacion);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 507);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la pelicula";
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(254, 430);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(87, 33);
            btnQuitar.TabIndex = 16;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Location = new Point(16, 389);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(50, 15);
            lblImagen.TabIndex = 15;
            lblImagen.Text = "Imagen:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(16, 332);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 14;
            lblEstado.Text = "Estado:";
            // 
            // lblDescripción
            // 
            lblDescripción.AutoSize = true;
            lblDescripción.Location = new Point(16, 220);
            lblDescripción.Name = "lblDescripción";
            lblDescripción.Size = new Size(72, 15);
            lblDescripción.TabIndex = 13;
            lblDescripción.Text = "Descripción:";
            // 
            // lblDuración
            // 
            lblDuración.AutoSize = true;
            lblDuración.Location = new Point(16, 168);
            lblDuración.Name = "lblDuración";
            lblDuración.Size = new Size(87, 15);
            lblDuración.TabIndex = 12;
            lblDuración.Text = "Duración(min):";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(16, 88);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 11;
            lblCategoria.Text = "Categoria:";
            // 
            // lblClasificacion
            // 
            lblClasificacion.AutoSize = true;
            lblClasificacion.Location = new Point(16, 132);
            lblClasificacion.Name = "lblClasificacion";
            lblClasificacion.Size = new Size(77, 15);
            lblClasificacion.TabIndex = 10;
            lblClasificacion.Text = "Clasificación:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 45);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(116, 353);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 123);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(254, 380);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(87, 33);
            btnCargar.TabIndex = 6;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(116, 197);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(241, 110);
            txtDescripcion.TabIndex = 5;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(116, 168);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(241, 23);
            txtDuracion.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 23);
            txtNombre.TabIndex = 3;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "En cartelera", "Próximamente", "Finalizada", "Suspendida" });
            cmbEstado.Location = new Point(116, 324);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(241, 23);
            cmbEstado.TabIndex = 2;
            // 
            // cmbClasificacion
            // 
            cmbClasificacion.FormattingEnabled = true;
            cmbClasificacion.Items.AddRange(new object[] { "AA (Todo publico)", "A (Mayores de 12)", "B (Mayores de 15)", "C (Mayores de 18) " });
            cmbClasificacion.Location = new Point(116, 129);
            cmbClasificacion.Name = "cmbClasificacion";
            cmbClasificacion.Size = new Size(241, 23);
            cmbClasificacion.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 37);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 16;
            label8.Text = "Buscar:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Categoria, Clasificacion, Duracion, Estado });
            dataGridView1.Location = new Point(13, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 254);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Clasificacion
            // 
            Clasificacion.HeaderText = "Clasificación";
            Clasificacion.Name = "Clasificacion";
            // 
            // Duracion
            // 
            Duracion.HeaderText = "Duración";
            Duracion.Name = "Duracion";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // grbListado
            // 
            grbListado.Controls.Add(btnCancelar);
            grbListado.Controls.Add(btnEliminar);
            grbListado.Controls.Add(btnGuardar);
            grbListado.Controls.Add(btnEditar);
            grbListado.Controls.Add(txtBuscar);
            grbListado.Controls.Add(btnNuevo);
            grbListado.Controls.Add(label8);
            grbListado.Controls.Add(dataGridView1);
            grbListado.Location = new Point(410, 12);
            grbListado.Name = "grbListado";
            grbListado.Size = new Size(581, 507);
            grbListado.TabIndex = 18;
            grbListado.TabStop = false;
            grbListado.Text = "Listado peliculas ";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SlateGray;
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(468, 430);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 33);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(365, 430);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 33);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(123, 430);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 33);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 128, 0);
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(258, 430);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 33);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(94, 34);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(231, 23);
            txtBuscar.TabIndex = 23;
            txtBuscar.TextChanged += txtBuscar_TextChanged_1;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Navy;
            btnNuevo.ForeColor = SystemColors.ButtonHighlight;
            btnNuevo.Location = new Point(13, 430);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(88, 33);
            btnNuevo.TabIndex = 19;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // Peliculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 531);
            Controls.Add(grbListado);
            Controls.Add(groupBox1);
            Name = "Peliculas";
            Text = "Peliculas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grbListado.ResumeLayout(false);
            grbListado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbCategoria;
        private GroupBox groupBox1;
        private TextBox txtDuracion;
        private TextBox txtNombre;
        private ComboBox cmbEstado;
        private ComboBox cmbClasificacion;
        private Label lblImagen;
        private Label lblEstado;
        private Label lblDescripción;
        private Label lblDuración;
        private Label lblCategoria;
        private Label lblClasificacion;
        private Label lblNombre;
        private PictureBox pictureBox1;
        private Button btnCargar;
        private TextBox txtDescripcion;
        private Label label8;
        private Button btnQuitar;
        private DataGridView dataGridView1;
        private GroupBox grbListado;
        private Button btnNuevo;
        private TextBox txtBuscar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Clasificacion;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Estado;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnEditar;
    }
}