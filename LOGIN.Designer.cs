namespace PeluTop_Practica
{
    partial class fmlLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.btniNGRESAR = new RJCodeAdvance.RJControls.RJButton();
            this.txtUsuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.lblRegistrarse = new System.Windows.Forms.LinkLabel();
            this.txtContraseña = new RJCodeAdvance.RJControls.RJTextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 583);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.rjCircularPictureBox1);
            this.panel2.Controls.Add(this.iconPictureBox3);
            this.panel2.Controls.Add(this.btniNGRESAR);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Controls.Add(this.lblRegistrarse);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtContraseña);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 583);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 0;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::PeluTop_Practica.Properties.Resources.IMG;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(123, 23);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(196, 196);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 25;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 26;
            this.iconPictureBox3.Location = new System.Drawing.Point(307, 308);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(27, 26);
            this.iconPictureBox3.TabIndex = 21;
            this.iconPictureBox3.TabStop = false;
            // 
            // btniNGRESAR
            // 
            this.btniNGRESAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btniNGRESAR.BackColor = System.Drawing.Color.White;
            this.btniNGRESAR.BackgroundColor = System.Drawing.Color.White;
            this.btniNGRESAR.BorderColor = System.Drawing.Color.Black;
            this.btniNGRESAR.BorderRadius = 20;
            this.btniNGRESAR.BorderSize = 3;
            this.btniNGRESAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniNGRESAR.FlatAppearance.BorderSize = 0;
            this.btniNGRESAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniNGRESAR.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniNGRESAR.ForeColor = System.Drawing.Color.Black;
            this.btniNGRESAR.Location = new System.Drawing.Point(141, 457);
            this.btniNGRESAR.Name = "btniNGRESAR";
            this.btniNGRESAR.Size = new System.Drawing.Size(150, 42);
            this.btniNGRESAR.TabIndex = 18;
            this.btniNGRESAR.Text = "INGRESAR";
            this.btniNGRESAR.TextColor = System.Drawing.Color.Black;
            this.btniNGRESAR.UseVisualStyleBackColor = false;
            this.btniNGRESAR.Click += new System.EventHandler(this.btniNGRESAR_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderColor = System.Drawing.Color.Black;
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.Red;
            this.txtUsuario.BorderRadius = 20;
            this.txtUsuario.BorderSize = 1;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.Location = new System.Drawing.Point(81, 300);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(20, 7, 10, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.Size = new System.Drawing.Size(269, 39);
            this.txtUsuario.TabIndex = 22;
            this.txtUsuario.Texts = "Usuario";
            this.txtUsuario.UnderlinedStyle = false;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 26;
            this.iconPictureBox2.Location = new System.Drawing.Point(307, 380);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(27, 26);
            this.iconPictureBox2.TabIndex = 6;
            this.iconPictureBox2.TabStop = false;
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.DisabledLinkColor = System.Drawing.Color.Black;
            this.lblRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarse.ForeColor = System.Drawing.Color.White;
            this.lblRegistrarse.LinkColor = System.Drawing.Color.White;
            this.lblRegistrarse.Location = new System.Drawing.Point(162, 515);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(102, 22);
            this.lblRegistrarse.TabIndex = 3;
            this.lblRegistrarse.TabStop = true;
            this.lblRegistrarse.Text = "Registrarse";
            this.lblRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegistrarse_LinkClicked);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txtContraseña.BorderColor = System.Drawing.Color.Black;
            this.txtContraseña.BorderFocusColor = System.Drawing.Color.Red;
            this.txtContraseña.BorderRadius = 20;
            this.txtContraseña.BorderSize = 1;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContraseña.Location = new System.Drawing.Point(81, 372);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Padding = new System.Windows.Forms.Padding(20, 7, 10, 7);
            this.txtContraseña.PasswordChar = false;
            this.txtContraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContraseña.PlaceholderText = "";
            this.txtContraseña.Size = new System.Drawing.Size(269, 39);
            this.txtContraseña.TabIndex = 19;
            this.txtContraseña.Texts = "Contraseña";
            this.txtContraseña.UnderlinedStyle = false;
            this.txtContraseña._TextChanged += new System.EventHandler(this.txtContraseñaa__TextChanged);
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(-22, -22);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 50;
            this.btnCerrar.Location = new System.Drawing.Point(958, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 48);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // fmlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PeluTop_Practica.Properties.Resources.IMG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 583);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmlLogin";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblRegistrarse;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton btniNGRESAR;
        private RJCodeAdvance.RJControls.RJTextBox txtContraseña;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private RJCodeAdvance.RJControls.RJTextBox txtUsuario;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
    }
}