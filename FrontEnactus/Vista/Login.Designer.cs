namespace FrontEnactus
{
    partial class WinLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.AccesoButton = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ResetPsw = new System.Windows.Forms.Label();
            this.NewUsr = new System.Windows.Forms.Label();
            this.ImgLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Quicksand Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.Titulo.Location = new System.Drawing.Point(92, 68);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(397, 46);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Acceder al sistema";
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // AccesoButton
            // 
            this.AccesoButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AccesoButton.Location = new System.Drawing.Point(220, 412);
            this.AccesoButton.Name = "AccesoButton";
            this.AccesoButton.Size = new System.Drawing.Size(138, 50);
            this.AccesoButton.TabIndex = 1;
            this.AccesoButton.Text = "Acceder";
            this.AccesoButton.UseVisualStyleBackColor = false;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(49, 200);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(474, 26);
            this.Username.TabIndex = 2;
            this.Username.Text = "Usuario";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(49, 266);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(474, 26);
            this.Password.TabIndex = 3;
            this.Password.Text = "Contraseña";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ResetPsw
            // 
            this.ResetPsw.AutoSize = true;
            this.ResetPsw.Location = new System.Drawing.Point(203, 316);
            this.ResetPsw.Name = "ResetPsw";
            this.ResetPsw.Size = new System.Drawing.Size(168, 20);
            this.ResetPsw.TabIndex = 4;
            this.ResetPsw.Text = "Recuperar contraseña";
            // 
            // NewUsr
            // 
            this.NewUsr.AutoSize = true;
            this.NewUsr.Location = new System.Drawing.Point(199, 349);
            this.NewUsr.Name = "NewUsr";
            this.NewUsr.Size = new System.Drawing.Size(177, 20);
            this.NewUsr.TabIndex = 5;
            this.NewUsr.Text = "Registrar nuevo usuario";
            this.NewUsr.Click += new System.EventHandler(this.label2_Click);
            // 
            // ImgLogin
            // 
            this.ImgLogin.Image = global::FrontEnactus.Properties.Resources.Login;
            this.ImgLogin.Location = new System.Drawing.Point(579, -1);
            this.ImgLogin.Name = "ImgLogin";
            this.ImgLogin.Size = new System.Drawing.Size(561, 612);
            this.ImgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgLogin.TabIndex = 6;
            this.ImgLogin.TabStop = false;
            this.ImgLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // WinLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1141, 607);
            this.Controls.Add(this.ImgLogin);
            this.Controls.Add(this.NewUsr);
            this.Controls.Add(this.ResetPsw);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.AccesoButton);
            this.Controls.Add(this.Titulo);
            this.Name = "WinLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button AccesoButton;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label ResetPsw;
        private System.Windows.Forms.Label NewUsr;
        private System.Windows.Forms.PictureBox ImgLogin;
    }
}

