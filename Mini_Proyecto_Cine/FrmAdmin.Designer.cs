namespace Mini_Proyecto_Cine
{
    partial class FrmAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            btnCerrar = new Button();
            btnSalas = new Button();
            btnUsuarios = new Button();
            btnReportes = new Button();
            btnInventario = new Button();
            btnVentas = new Button();
            btnFunciones = new Button();
            btnPeliculas = new Button();
            btnInicio = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Pelicula = new DataGridViewTextBoxColumn();
            Sala = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblBienve = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnSalas);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnFunciones);
            panel1.Controls.Add(btnPeliculas);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 701);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(129, 67);
            label2.Name = "label2";
            label2.Size = new Size(85, 41);
            label2.TabIndex = 10;
            label2.Text = "PLUS";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(7, 631);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(191, 52);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar Sesión";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnSalas
            // 
            btnSalas.Location = new Point(7, 571);
            btnSalas.Margin = new Padding(3, 4, 3, 4);
            btnSalas.Name = "btnSalas";
            btnSalas.Size = new Size(191, 52);
            btnSalas.TabIndex = 8;
            btnSalas.Text = "Salas";
            btnSalas.UseVisualStyleBackColor = true;
            btnSalas.Click += btnSalas_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(7, 511);
            btnUsuarios.Margin = new Padding(3, 4, 3, 4);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(191, 52);
            btnUsuarios.TabIndex = 7;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(7, 451);
            btnReportes.Margin = new Padding(3, 4, 3, 4);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(191, 52);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(7, 391);
            btnInventario.Margin = new Padding(3, 4, 3, 4);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(191, 52);
            btnInventario.TabIndex = 5;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(7, 331);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(191, 52);
            btnVentas.TabIndex = 4;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnFunciones
            // 
            btnFunciones.Location = new Point(7, 271);
            btnFunciones.Margin = new Padding(3, 4, 3, 4);
            btnFunciones.Name = "btnFunciones";
            btnFunciones.Size = new Size(191, 52);
            btnFunciones.TabIndex = 3;
            btnFunciones.Text = "Funciones";
            btnFunciones.UseVisualStyleBackColor = true;
            btnFunciones.Click += btnFunciones_Click;
            // 
            // btnPeliculas
            // 
            btnPeliculas.Location = new Point(7, 211);
            btnPeliculas.Margin = new Padding(3, 4, 3, 4);
            btnPeliculas.Name = "btnPeliculas";
            btnPeliculas.Size = new Size(191, 52);
            btnPeliculas.TabIndex = 2;
            btnPeliculas.Text = "Peliculas";
            btnPeliculas.UseVisualStyleBackColor = true;
            btnPeliculas.Click += btnPeliculas_Click;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(7, 151);
            btnInicio.Margin = new Padding(3, 4, 3, 4);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(191, 52);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(64, 67);
            label1.Name = "label1";
            label1.Size = new Size(82, 41);
            label1.TabIndex = 1;
            label1.Text = "CINE";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.palomitas_de_maiz;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 97);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Pelicula, Sala, Fecha, Hora, Precio });
            dataGridView1.Location = new Point(275, 411);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(841, 245);
            dataGridView1.TabIndex = 1;
            // 
            // Pelicula
            // 
            Pelicula.HeaderText = "Pelicula";
            Pelicula.MinimumWidth = 6;
            Pelicula.Name = "Pelicula";
            // 
            // Sala
            // 
            Sala.HeaderText = "Sala";
            Sala.MinimumWidth = 6;
            Sala.Name = "Sala";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.MinimumWidth = 6;
            Hora.Name = "Hora";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblBienve);
            panel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(258, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(538, 325);
            panel2.TabIndex = 2;
            // 
            // lblBienve
            // 
            lblBienve.AutoSize = true;
            lblBienve.Location = new Point(49, 17);
            lblBienve.Name = "lblBienve";
            lblBienve.Size = new Size(207, 23);
            lblBienve.TabIndex = 0;
            lblBienve.Text = "Bienvenido Administrador";
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 699);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmAdmin";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnInicio;
        private Button btnCerrar;
        private Button btnSalas;
        private Button btnUsuarios;
        private Button btnReportes;
        private Button btnInventario;
        private Button btnVentas;
        private Button btnFunciones;
        private Button btnPeliculas;
        private DataGridView dataGridView1;
        private Label label2;
        private Panel panel2;
        private Label lblBienve;
        private DataGridViewTextBoxColumn Pelicula;
        private DataGridViewTextBoxColumn Sala;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Precio;
    }
}
