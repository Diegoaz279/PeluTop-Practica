namespace PeluTop_Practica
{
    partial class CONFIRMACION
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
            this.lblPeluqueros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNombre = new RJCodeAdvance.RJControls.RJComboBox();
            this.cmbPeluquero = new RJCodeAdvance.RJControls.RJComboBox();
            this.cmbServicio = new RJCodeAdvance.RJControls.RJComboBox();
            this.cmbPrecio = new RJCodeAdvance.RJControls.RJComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirnarCita = new RJCodeAdvance.RJControls.RJButton();
            this.BtnCancelarCita = new RJCodeAdvance.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lblPeluqueros
            // 
            this.lblPeluqueros.AutoSize = true;
            this.lblPeluqueros.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeluqueros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.lblPeluqueros.Location = new System.Drawing.Point(174, 73);
            this.lblPeluqueros.Name = "lblPeluqueros";
            this.lblPeluqueros.Size = new System.Drawing.Size(651, 127);
            this.lblPeluqueros.TabIndex = 43;
            this.lblPeluqueros.Text = "CONFIRMACION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 45;
            this.label2.Text = "Perluquero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 46;
            this.label3.Text = "Servicio:";
            // 
            // cmbNombre
            // 
            this.cmbNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbNombre.BorderColor = System.Drawing.Color.White;
            this.cmbNombre.BorderSize = 1;
            this.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbNombre.ForeColor = System.Drawing.Color.DimGray;
            this.cmbNombre.IconColor = System.Drawing.Color.Red;
            this.cmbNombre.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbNombre.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbNombre.Location = new System.Drawing.Point(56, 311);
            this.cmbNombre.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Padding = new System.Windows.Forms.Padding(1);
            this.cmbNombre.Size = new System.Drawing.Size(200, 39);
            this.cmbNombre.TabIndex = 47;
            this.cmbNombre.Texts = "";
            this.cmbNombre.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox1_OnSelectedIndexChanged);
            // 
            // cmbPeluquero
            // 
            this.cmbPeluquero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPeluquero.BorderColor = System.Drawing.Color.White;
            this.cmbPeluquero.BorderSize = 1;
            this.cmbPeluquero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbPeluquero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbPeluquero.ForeColor = System.Drawing.Color.DimGray;
            this.cmbPeluquero.IconColor = System.Drawing.Color.Red;
            this.cmbPeluquero.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbPeluquero.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbPeluquero.Location = new System.Drawing.Point(280, 311);
            this.cmbPeluquero.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbPeluquero.Name = "cmbPeluquero";
            this.cmbPeluquero.Padding = new System.Windows.Forms.Padding(1);
            this.cmbPeluquero.Size = new System.Drawing.Size(200, 39);
            this.cmbPeluquero.TabIndex = 48;
            this.cmbPeluquero.Texts = "";
            // 
            // cmbServicio
            // 
            this.cmbServicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbServicio.BorderColor = System.Drawing.Color.White;
            this.cmbServicio.BorderSize = 1;
            this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbServicio.ForeColor = System.Drawing.Color.DimGray;
            this.cmbServicio.IconColor = System.Drawing.Color.Red;
            this.cmbServicio.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbServicio.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbServicio.Location = new System.Drawing.Point(506, 311);
            this.cmbServicio.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Padding = new System.Windows.Forms.Padding(1);
            this.cmbServicio.Size = new System.Drawing.Size(240, 39);
            this.cmbServicio.TabIndex = 49;
            this.cmbServicio.Texts = "";
            this.cmbServicio.OnSelectedIndexChanged += new System.EventHandler(this.cmbServicio_OnSelectedIndexChanged);
            // 
            // cmbPrecio
            // 
            this.cmbPrecio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPrecio.BorderColor = System.Drawing.Color.White;
            this.cmbPrecio.BorderSize = 1;
            this.cmbPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbPrecio.ForeColor = System.Drawing.Color.DimGray;
            this.cmbPrecio.IconColor = System.Drawing.Color.Red;
            this.cmbPrecio.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbPrecio.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbPrecio.Location = new System.Drawing.Point(770, 311);
            this.cmbPrecio.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbPrecio.Name = "cmbPrecio";
            this.cmbPrecio.Padding = new System.Windows.Forms.Padding(1);
            this.cmbPrecio.Size = new System.Drawing.Size(200, 39);
            this.cmbPrecio.TabIndex = 51;
            this.cmbPrecio.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(766, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 50;
            this.label4.Text = "Precio:";
            // 
            // btnConfirnarCita
            // 
            this.btnConfirnarCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirnarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.btnConfirnarCita.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.btnConfirnarCita.BorderColor = System.Drawing.Color.Red;
            this.btnConfirnarCita.BorderRadius = 20;
            this.btnConfirnarCita.BorderSize = 0;
            this.btnConfirnarCita.FlatAppearance.BorderSize = 0;
            this.btnConfirnarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirnarCita.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirnarCita.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfirnarCita.Location = new System.Drawing.Point(506, 417);
            this.btnConfirnarCita.Name = "btnConfirnarCita";
            this.btnConfirnarCita.Size = new System.Drawing.Size(207, 57);
            this.btnConfirnarCita.TabIndex = 61;
            this.btnConfirnarCita.Text = "CONFIRMAR CITA";
            this.btnConfirnarCita.TextColor = System.Drawing.Color.Gainsboro;
            this.btnConfirnarCita.UseVisualStyleBackColor = false;
            this.btnConfirnarCita.Click += new System.EventHandler(this.btnServicio4_Click);
            // 
            // BtnCancelarCita
            // 
            this.BtnCancelarCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancelarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.BtnCancelarCita.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.BtnCancelarCita.BorderColor = System.Drawing.Color.Red;
            this.BtnCancelarCita.BorderRadius = 20;
            this.BtnCancelarCita.BorderSize = 0;
            this.BtnCancelarCita.FlatAppearance.BorderSize = 0;
            this.BtnCancelarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarCita.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarCita.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCancelarCita.Location = new System.Drawing.Point(290, 417);
            this.BtnCancelarCita.Name = "BtnCancelarCita";
            this.BtnCancelarCita.Size = new System.Drawing.Size(174, 57);
            this.BtnCancelarCita.TabIndex = 62;
            this.BtnCancelarCita.Text = "CANCERLAR";
            this.BtnCancelarCita.TextColor = System.Drawing.Color.Gainsboro;
            this.BtnCancelarCita.UseVisualStyleBackColor = false;
            this.BtnCancelarCita.Click += new System.EventHandler(this.BtnCancelarCita_Click);
            // 
            // CONFIRMACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(997, 623);
            this.Controls.Add(this.BtnCancelarCita);
            this.Controls.Add(this.btnConfirnarCita);
            this.Controls.Add(this.cmbPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.cmbPeluquero);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeluqueros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CONFIRMACION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIRMACION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPeluqueros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJComboBox cmbNombre;
        private RJCodeAdvance.RJControls.RJComboBox cmbPeluquero;
        private RJCodeAdvance.RJControls.RJComboBox cmbServicio;
        private RJCodeAdvance.RJControls.RJComboBox cmbPrecio;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJButton btnConfirnarCita;
        private RJCodeAdvance.RJControls.RJButton BtnCancelarCita;
    }
}