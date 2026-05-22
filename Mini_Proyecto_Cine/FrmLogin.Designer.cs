namespace Mini_Proyecto_Cine
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel1 = new Panel();
            lblUsuario = new Label();
            lblContraseña = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblContraseña);
            panel1.Controls.Add(lblUsuario);
            panel1.Location = new Point(187, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 361);
            panel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(122, 163);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(102, 219);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 105);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "CINE PLUS";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(244, 160);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(141, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(244, 211);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(141, 23);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(287, 302);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.palomitas_de_maiz;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(285, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 76);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 519);
            Controls.Add(panel1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnIngresar;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private Label label3;
        private Label lblContraseña;
        private Label lblUsuario;
    }
}