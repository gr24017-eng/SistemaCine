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
            lnkRecuperar = new LinkLabel();
            pictureBox1 = new PictureBox();
            btnIngresar = new Button();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            lblContraseña = new Label();
            lblUsuario = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lnkRecuperar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(txtContra);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblContraseña);
            panel1.Controls.Add(lblUsuario);
            panel1.Location = new Point(214, 99);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 481);
            panel1.TabIndex = 0;
            // 
            // lnkRecuperar
            // 
            lnkRecuperar.AutoSize = true;
            lnkRecuperar.Location = new Point(279, 325);
            lnkRecuperar.Name = "lnkRecuperar";
            lnkRecuperar.Size = new Size(178, 20);
            lnkRecuperar.TabIndex = 7;
            lnkRecuperar.TabStop = true;
            lnkRecuperar.Text = "¿Olvidaste tu contraseña?";
            lnkRecuperar.LinkClicked += lnkRecuperar_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.palomitas_de_maiz;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(326, 35);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 101);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(342, 360);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(86, 31);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(279, 263);
            txtContra.Margin = new Padding(3, 4, 3, 4);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(219, 27);
            txtContra.TabIndex = 4;
            txtContra.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(279, 213);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(219, 27);
            txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 140);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "CINE PLUS";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(179, 267);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(190, 217);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 692);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox txtContra;
        private TextBox txtUsuario;
        private Label label3;
        private Label lblContraseña;
        private Label lblUsuario;
        private LinkLabel lnkRecuperar;  // ← era Label label
    }
}