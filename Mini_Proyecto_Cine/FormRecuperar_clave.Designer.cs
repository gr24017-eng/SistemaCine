namespace Mini_Proyecto_Cine
{
    partial class FormRecuperar_clave
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            btnSolicitarCodigo = new Button();
            panelCambio = new Panel();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNuevaClave = new Label();
            txtNuevaClave = new TextBox();
            btnCambiarClave = new Button();
            panelCambio.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(130, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(220, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recuperar Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(30, 75);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(130, 72);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(220, 27);
            txtUsuario.TabIndex = 2;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(30, 120);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(130, 117);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(220, 27);
            txtCorreo.TabIndex = 4;
            // 
            // btnSolicitarCodigo
            // 
            btnSolicitarCodigo.Location = new Point(130, 162);
            btnSolicitarCodigo.Name = "btnSolicitarCodigo";
            btnSolicitarCodigo.Size = new Size(130, 32);
            btnSolicitarCodigo.TabIndex = 5;
            btnSolicitarCodigo.Text = "Enviar código";
            btnSolicitarCodigo.UseVisualStyleBackColor = true;
            btnSolicitarCodigo.Click += btnSolicitarCodigo_Click;
            // 
            // panelCambio
            // 
            panelCambio.Controls.Add(lblCodigo);
            panelCambio.Controls.Add(txtCodigo);
            panelCambio.Controls.Add(lblNuevaClave);
            panelCambio.Controls.Add(txtNuevaClave);
            panelCambio.Controls.Add(btnCambiarClave);
            panelCambio.Location = new Point(0, 210);
            panelCambio.Name = "panelCambio";
            panelCambio.Size = new Size(420, 180);
            panelCambio.TabIndex = 6;
            panelCambio.Visible = false;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(30, 15);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(120, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código recibido:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(160, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(190, 27);
            txtCodigo.TabIndex = 1;
            // 
            // lblNuevaClave
            // 
            lblNuevaClave.AutoSize = true;
            lblNuevaClave.Location = new Point(30, 60);
            lblNuevaClave.Name = "lblNuevaClave";
            lblNuevaClave.Size = new Size(130, 20);
            lblNuevaClave.TabIndex = 2;
            lblNuevaClave.Text = "Nueva contraseña:";
            // 
            // txtNuevaClave
            // 
            txtNuevaClave.Location = new Point(160, 57);
            txtNuevaClave.Name = "txtNuevaClave";
            txtNuevaClave.Size = new Size(190, 27);
            txtNuevaClave.TabIndex = 3;
            txtNuevaClave.UseSystemPasswordChar = true;
            // 
            // btnCambiarClave
            // 
            btnCambiarClave.Location = new Point(130, 108);
            btnCambiarClave.Name = "btnCambiarClave";
            btnCambiarClave.Size = new Size(150, 32);
            btnCambiarClave.TabIndex = 4;
            btnCambiarClave.Text = "Cambiar contraseña";
            btnCambiarClave.UseVisualStyleBackColor = true;
            btnCambiarClave.Click += btnCambiarClave_Click;
            // 
            // FormRecuperar_clave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 400);
            Controls.Add(lblTitulo);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblCorreo);
            Controls.Add(txtCorreo);
            Controls.Add(btnSolicitarCodigo);
            Controls.Add(panelCambio);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRecuperar_clave";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Recuperar Contraseña";
            panelCambio.ResumeLayout(false);
            panelCambio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Button btnSolicitarCodigo;
        private Panel panelCambio;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNuevaClave;
        private TextBox txtNuevaClave;
        private Button btnCambiarClave;
    }
}