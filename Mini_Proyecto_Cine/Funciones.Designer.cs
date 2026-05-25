namespace Mini_Proyecto_Cine
{
    partial class Funciones
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
            txtHora = new TextBox();
            txtPrecio = new TextBox();
            cmbSala = new ComboBox();
            grbFunciones = new GroupBox();
            cmbPelicula = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            dtpFecha = new DateTimePicker();
            dgvFunciones = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Pelicula = new DataGridViewTextBoxColumn();
            Sala = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            grbFunciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            SuspendLayout();
            // 
            // txtHora
            // 
            txtHora.Location = new Point(403, 132);
            txtHora.Margin = new Padding(3, 2, 3, 2);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(110, 23);
            txtHora.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(645, 94);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 23);
            txtPrecio.TabIndex = 2;
            // 
            // cmbSala
            // 
            cmbSala.FormattingEnabled = true;
            cmbSala.Location = new Point(403, 35);
            cmbSala.Margin = new Padding(3, 2, 3, 2);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(110, 23);
            cmbSala.TabIndex = 3;
            // 
            // grbFunciones
            // 
            grbFunciones.Controls.Add(cmbPelicula);
            grbFunciones.Controls.Add(label5);
            grbFunciones.Controls.Add(label4);
            grbFunciones.Controls.Add(label3);
            grbFunciones.Controls.Add(label2);
            grbFunciones.Controls.Add(label1);
            grbFunciones.Controls.Add(btnCancelar);
            grbFunciones.Controls.Add(btnEliminar);
            grbFunciones.Controls.Add(btnEditar);
            grbFunciones.Controls.Add(btnGuardar);
            grbFunciones.Controls.Add(btnNuevo);
            grbFunciones.Controls.Add(dtpFecha);
            grbFunciones.Controls.Add(txtPrecio);
            grbFunciones.Controls.Add(txtHora);
            grbFunciones.Controls.Add(cmbSala);
            grbFunciones.Location = new Point(10, 9);
            grbFunciones.Margin = new Padding(3, 2, 3, 2);
            grbFunciones.Name = "grbFunciones";
            grbFunciones.Padding = new Padding(3, 2, 3, 2);
            grbFunciones.Size = new Size(1052, 234);
            grbFunciones.TabIndex = 5;
            grbFunciones.TabStop = false;
            grbFunciones.Text = "Datos de la funcion";
            // 
            // cmbPelicula
            // 
            cmbPelicula.FormattingEnabled = true;
            cmbPelicula.Location = new Point(132, 35);
            cmbPelicula.Margin = new Padding(3, 2, 3, 2);
            cmbPelicula.Name = "cmbPelicula";
            cmbPelicula.Size = new Size(110, 23);
            cmbPelicula.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(596, 97);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 15;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 134);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 14;
            label4.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 134);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 13;
            label3.Text = "Hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 40);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 12;
            label2.Text = "Sala";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 40);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 11;
            label1.Text = "Pelicula";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Location = new Point(666, 184);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(523, 184);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 128, 0);
            btnEditar.Location = new Point(390, 184);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Lime;
            btnGuardar.Location = new Point(254, 184);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.DodgerBlue;
            btnNuevo.Location = new Point(132, 184);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 22);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(132, 130);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.MaxDate = new DateTime(2026, 5, 22, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(110, 23);
            dtpFecha.TabIndex = 5;
            dtpFecha.Value = new DateTime(2026, 5, 22, 0, 0, 0, 0);
            // 
            // dgvFunciones
            // 
            dgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunciones.Columns.AddRange(new DataGridViewColumn[] { id, Pelicula, Sala, Fecha, Hora, Precio });
            dgvFunciones.Location = new Point(10, 248);
            dgvFunciones.Margin = new Padding(3, 2, 3, 2);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.RowHeadersWidth = 51;
            dgvFunciones.Size = new Size(1043, 225);
            dgvFunciones.TabIndex = 6;
            dgvFunciones.CellContentClick += dgvFunciones_CellClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 80;
            // 
            // Pelicula
            // 
            Pelicula.HeaderText = "Pelicula";
            Pelicula.MinimumWidth = 6;
            Pelicula.Name = "Pelicula";
            Pelicula.ReadOnly = true;
            Pelicula.Width = 280;
            // 
            // Sala
            // 
            Sala.HeaderText = "Sala";
            Sala.MinimumWidth = 6;
            Sala.Name = "Sala";
            Sala.ReadOnly = true;
            Sala.Width = 210;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 190;
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.MinimumWidth = 6;
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            Hora.Width = 190;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 190;
            // 
            // Funciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 476);
            Controls.Add(dgvFunciones);
            Controls.Add(grbFunciones);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Funciones";
            Text = "Funciones";
            grbFunciones.ResumeLayout(false);
            grbFunciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtHora;
        private TextBox txtPrecio;
        private ComboBox cmbSala;
        private GroupBox grbFunciones;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DateTimePicker dtpFecha;
        private DataGridView dgvFunciones;
        private Label label5;
        private ComboBox cmbPelicula;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Pelicula;
        private DataGridViewTextBoxColumn Sala;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Precio;
    }
}