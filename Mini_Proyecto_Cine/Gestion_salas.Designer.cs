namespace Mini_Proyecto_Cine
{
    partial class Gestion_salas
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
            dgvSalas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Numero_sala = new DataGridViewTextBoxColumn();
            Capacidad = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtDescripcion_salas = new TextBox();
            txtCapacidad_salas = new TextBox();
            pbGestion_salas = new PictureBox();
            btnLimpiar_salas = new Button();
            btnEliminar_salas = new Button();
            btnEditar_salas = new Button();
            btnGuardar_salas = new Button();
            btnNuevo_salas = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbEstado_salas = new ComboBox();
            txtNum_sala_salas = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGestion_salas).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSalas);
            groupBox2.Location = new Point(13, 412);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1039, 311);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado de Salas";
            // 
            // dgvSalas
            // 
            dgvSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalas.Columns.AddRange(new DataGridViewColumn[] { ID, Numero_sala, Capacidad, Descripcion, Estado });
            dgvSalas.Location = new Point(6, 26);
            dgvSalas.Name = "dgvSalas";
            dgvSalas.RowHeadersWidth = 51;
            dgvSalas.Size = new Size(1027, 279);
            dgvSalas.TabIndex = 0;
            dgvSalas.CellClick += dgvSalas_CellClick;
            // 
            // ID
            // 
            ID.FillWeight = 28.4752941F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 80;
            // 
            // Numero_sala
            // 
            Numero_sala.FillWeight = 11.8986053F;
            Numero_sala.HeaderText = "Numero de Sala";
            Numero_sala.MinimumWidth = 6;
            Numero_sala.Name = "Numero_sala";
            Numero_sala.ReadOnly = true;
            Numero_sala.Width = 195;
            // 
            // Capacidad
            // 
            Capacidad.FillWeight = 11.8986053F;
            Capacidad.HeaderText = "Capacidad";
            Capacidad.MinimumWidth = 6;
            Capacidad.Name = "Capacidad";
            Capacidad.ReadOnly = true;
            Capacidad.Width = 170;
            // 
            // Descripcion
            // 
            Descripcion.FillWeight = 435.8289F;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 325;
            // 
            // Estado
            // 
            Estado.FillWeight = 11.8986053F;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 200;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescripcion_salas);
            groupBox1.Controls.Add(txtCapacidad_salas);
            groupBox1.Controls.Add(pbGestion_salas);
            groupBox1.Controls.Add(btnLimpiar_salas);
            groupBox1.Controls.Add(btnEliminar_salas);
            groupBox1.Controls.Add(btnEditar_salas);
            groupBox1.Controls.Add(btnGuardar_salas);
            groupBox1.Controls.Add(btnNuevo_salas);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbEstado_salas);
            groupBox1.Controls.Add(txtNum_sala_salas);
            groupBox1.Location = new Point(13, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1039, 395);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Sala ";
            // 
            // txtDescripcion_salas
            // 
            txtDescripcion_salas.Location = new Point(191, 157);
            txtDescripcion_salas.Name = "txtDescripcion_salas";
            txtDescripcion_salas.Size = new Size(171, 27);
            txtDescripcion_salas.TabIndex = 17;
            // 
            // txtCapacidad_salas
            // 
            txtCapacidad_salas.Location = new Point(191, 95);
            txtCapacidad_salas.Name = "txtCapacidad_salas";
            txtCapacidad_salas.Size = new Size(171, 27);
            txtCapacidad_salas.TabIndex = 16;
            // 
            // pbGestion_salas
            // 
            pbGestion_salas.Location = new Point(611, 26);
            pbGestion_salas.Name = "pbGestion_salas";
            pbGestion_salas.Size = new Size(269, 235);
            pbGestion_salas.TabIndex = 15;
            pbGestion_salas.TabStop = false;
            // 
            // btnLimpiar_salas
            // 
            btnLimpiar_salas.Location = new Point(807, 347);
            btnLimpiar_salas.Name = "btnLimpiar_salas";
            btnLimpiar_salas.Size = new Size(94, 29);
            btnLimpiar_salas.TabIndex = 14;
            btnLimpiar_salas.Text = "Limpiar";
            btnLimpiar_salas.UseVisualStyleBackColor = true;
            btnLimpiar_salas.Click += btnLimpiar_salas_Click;
            // 
            // btnEliminar_salas
            // 
            btnEliminar_salas.Location = new Point(629, 347);
            btnEliminar_salas.Name = "btnEliminar_salas";
            btnEliminar_salas.Size = new Size(94, 29);
            btnEliminar_salas.TabIndex = 13;
            btnEliminar_salas.Text = "Eliminar";
            btnEliminar_salas.UseVisualStyleBackColor = true;
            btnEliminar_salas.Click += btnEliminar_salas_Click;
            // 
            // btnEditar_salas
            // 
            btnEditar_salas.Location = new Point(457, 347);
            btnEditar_salas.Name = "btnEditar_salas";
            btnEditar_salas.Size = new Size(94, 29);
            btnEditar_salas.TabIndex = 12;
            btnEditar_salas.Text = "Editar";
            btnEditar_salas.UseVisualStyleBackColor = true;
            btnEditar_salas.Click += btnEditar_salas_Click;
            // 
            // btnGuardar_salas
            // 
            btnGuardar_salas.Location = new Point(283, 347);
            btnGuardar_salas.Name = "btnGuardar_salas";
            btnGuardar_salas.Size = new Size(94, 29);
            btnGuardar_salas.TabIndex = 11;
            btnGuardar_salas.Text = "Guardar";
            btnGuardar_salas.UseVisualStyleBackColor = true;
            btnGuardar_salas.Click += btnGuardar_salas_Click;
            // 
            // btnNuevo_salas
            // 
            btnNuevo_salas.Location = new Point(111, 347);
            btnNuevo_salas.Name = "btnNuevo_salas";
            btnNuevo_salas.Size = new Size(94, 29);
            btnNuevo_salas.TabIndex = 10;
            btnNuevo_salas.Text = "Nuevo";
            btnNuevo_salas.UseVisualStyleBackColor = true;
            btnNuevo_salas.Click += btnNuevo_salas_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(115, 268);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 9;
            label5.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 160);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 7;
            label3.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 98);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 6;
            label2.Text = "Capacidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 45);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 5;
            label1.Text = "Numero de sala:";
            // 
            // cmbEstado_salas
            // 
            cmbEstado_salas.FormattingEnabled = true;
            cmbEstado_salas.Location = new Point(191, 265);
            cmbEstado_salas.Name = "cmbEstado_salas";
            cmbEstado_salas.Size = new Size(171, 28);
            cmbEstado_salas.TabIndex = 4;
            // 
            // txtNum_sala_salas
            // 
            txtNum_sala_salas.Location = new Point(191, 38);
            txtNum_sala_salas.Name = "txtNum_sala_salas";
            txtNum_sala_salas.Size = new Size(171, 27);
            txtNum_sala_salas.TabIndex = 0;
            // 
            // Gestion_salas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 734);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Gestion_salas";
            Text = "Gestion_salas";
            Load += Gestion_salas_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSalas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGestion_salas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvSalas;
        private GroupBox groupBox1;
        private PictureBox pbGestion_salas;
        private Button btnLimpiar_salas;
        private Button btnEliminar_salas;
        private Button btnEditar_salas;
        private Button btnGuardar_salas;
        private Button btnNuevo_salas;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbEstado_salas;
        private TextBox txtNum_sala_salas;
        private TextBox txtCapacidad_salas;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Numero_sala;
        private DataGridViewTextBoxColumn Capacidad;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
        private TextBox txtDescripcion_salas;
    }
}