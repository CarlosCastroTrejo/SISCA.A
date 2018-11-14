namespace SISCA.A
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.SalirButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EjecutarBotton = new System.Windows.Forms.Button();
            this.EleccionAdminBox = new System.Windows.Forms.CheckedListBox();
            this.NominaAdminLabel = new System.Windows.Forms.Label();
            this.NominaAdminBox = new System.Windows.Forms.TextBox();
            this.NuevoAdminLabel = new System.Windows.Forms.Label();
            this.NombreAdminLabel = new System.Windows.Forms.Label();
            this.NombreAdminBox = new System.Windows.Forms.TextBox();
            this.ContrasenaAdminLabel = new System.Windows.Forms.Label();
            this.ContrasenaAdminBox = new System.Windows.Forms.TextBox();
            this.NominObli = new System.Windows.Forms.Label();
            this.NombreObli = new System.Windows.Forms.Label();
            this.ContraOblig = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(126)))), ((int)(((byte)(127)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 100);
            this.panel1.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.Location = new System.Drawing.Point(40, 128);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(122, 20);
            this.AdminLabel.TabIndex = 46;
            this.AdminLabel.Text = "Administrador";
            this.AdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalirButton
            // 
            this.SalirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.SalirButton.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirButton.ForeColor = System.Drawing.Color.White;
            this.SalirButton.Location = new System.Drawing.Point(44, 518);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(295, 52);
            this.SalirButton.TabIndex = 59;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = false;
            this.SalirButton.Click += new System.EventHandler(this.Continuar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "¿Qué deseas hacer?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EjecutarBotton
            // 
            this.EjecutarBotton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.EjecutarBotton.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EjecutarBotton.ForeColor = System.Drawing.Color.White;
            this.EjecutarBotton.Location = new System.Drawing.Point(44, 334);
            this.EjecutarBotton.Name = "EjecutarBotton";
            this.EjecutarBotton.Size = new System.Drawing.Size(174, 38);
            this.EjecutarBotton.TabIndex = 61;
            this.EjecutarBotton.Text = "Ejecutar";
            this.EjecutarBotton.UseVisualStyleBackColor = false;
            this.EjecutarBotton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EleccionAdminBox
            // 
            this.EleccionAdminBox.BackColor = System.Drawing.Color.White;
            this.EleccionAdminBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EleccionAdminBox.CheckOnClick = true;
            this.EleccionAdminBox.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EleccionAdminBox.ForeColor = System.Drawing.Color.Black;
            this.EleccionAdminBox.FormattingEnabled = true;
            this.EleccionAdminBox.Items.AddRange(new object[] {
            "Generar reporte de registro",
            "Agregar administrador"});
            this.EleccionAdminBox.Location = new System.Drawing.Point(46, 262);
            this.EleccionAdminBox.Name = "EleccionAdminBox";
            this.EleccionAdminBox.Size = new System.Drawing.Size(243, 66);
            this.EleccionAdminBox.TabIndex = 62;
            this.EleccionAdminBox.SelectedIndexChanged += new System.EventHandler(this.EleccionAdminBox_SelectedIndexChanged);
            // 
            // NominaAdminLabel
            // 
            this.NominaAdminLabel.AutoSize = true;
            this.NominaAdminLabel.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NominaAdminLabel.Location = new System.Drawing.Point(413, 242);
            this.NominaAdminLabel.Name = "NominaAdminLabel";
            this.NominaAdminLabel.Size = new System.Drawing.Size(57, 17);
            this.NominaAdminLabel.TabIndex = 63;
            this.NominaAdminLabel.Text = "Nómina";
            this.NominaAdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NominaAdminLabel.Visible = false;
            // 
            // NominaAdminBox
            // 
            this.NominaAdminBox.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NominaAdminBox.Location = new System.Drawing.Point(416, 262);
            this.NominaAdminBox.Name = "NominaAdminBox";
            this.NominaAdminBox.Size = new System.Drawing.Size(352, 24);
            this.NominaAdminBox.TabIndex = 64;
            this.NominaAdminBox.Visible = false;
            // 
            // NuevoAdminLabel
            // 
            this.NuevoAdminLabel.AutoSize = true;
            this.NuevoAdminLabel.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoAdminLabel.Location = new System.Drawing.Point(413, 183);
            this.NuevoAdminLabel.Name = "NuevoAdminLabel";
            this.NuevoAdminLabel.Size = new System.Drawing.Size(141, 17);
            this.NuevoAdminLabel.TabIndex = 65;
            this.NuevoAdminLabel.Text = "Nuevo administrador";
            this.NuevoAdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NuevoAdminLabel.Visible = false;
            // 
            // NombreAdminLabel
            // 
            this.NombreAdminLabel.AutoSize = true;
            this.NombreAdminLabel.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreAdminLabel.Location = new System.Drawing.Point(413, 318);
            this.NombreAdminLabel.Name = "NombreAdminLabel";
            this.NombreAdminLabel.Size = new System.Drawing.Size(59, 17);
            this.NombreAdminLabel.TabIndex = 66;
            this.NombreAdminLabel.Text = "Nombre";
            this.NombreAdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NombreAdminLabel.Visible = false;
            // 
            // NombreAdminBox
            // 
            this.NombreAdminBox.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreAdminBox.Location = new System.Drawing.Point(416, 338);
            this.NombreAdminBox.Name = "NombreAdminBox";
            this.NombreAdminBox.Size = new System.Drawing.Size(352, 24);
            this.NombreAdminBox.TabIndex = 67;
            this.NombreAdminBox.Visible = false;
            // 
            // ContrasenaAdminLabel
            // 
            this.ContrasenaAdminLabel.AutoSize = true;
            this.ContrasenaAdminLabel.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaAdminLabel.Location = new System.Drawing.Point(413, 388);
            this.ContrasenaAdminLabel.Name = "ContrasenaAdminLabel";
            this.ContrasenaAdminLabel.Size = new System.Drawing.Size(84, 17);
            this.ContrasenaAdminLabel.TabIndex = 68;
            this.ContrasenaAdminLabel.Text = "Contraseña";
            this.ContrasenaAdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ContrasenaAdminLabel.Visible = false;
            // 
            // ContrasenaAdminBox
            // 
            this.ContrasenaAdminBox.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaAdminBox.Location = new System.Drawing.Point(416, 408);
            this.ContrasenaAdminBox.Name = "ContrasenaAdminBox";
            this.ContrasenaAdminBox.Size = new System.Drawing.Size(352, 24);
            this.ContrasenaAdminBox.TabIndex = 69;
            this.ContrasenaAdminBox.Visible = false;
            // 
            // NominObli
            // 
            this.NominObli.AutoSize = true;
            this.NominObli.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NominObli.Location = new System.Drawing.Point(682, 241);
            this.NominObli.Name = "NominObli";
            this.NominObli.Size = new System.Drawing.Size(86, 18);
            this.NominObli.TabIndex = 70;
            this.NominObli.Text = "Obligatorio";
            this.NominObli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NominObli.Visible = false;
            // 
            // NombreObli
            // 
            this.NombreObli.AutoSize = true;
            this.NombreObli.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreObli.Location = new System.Drawing.Point(682, 318);
            this.NombreObli.Name = "NombreObli";
            this.NombreObli.Size = new System.Drawing.Size(86, 18);
            this.NombreObli.TabIndex = 71;
            this.NombreObli.Text = "Obligatorio";
            this.NombreObli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NombreObli.Visible = false;
            // 
            // ContraOblig
            // 
            this.ContraOblig.AutoSize = true;
            this.ContraOblig.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraOblig.Location = new System.Drawing.Point(682, 388);
            this.ContraOblig.Name = "ContraOblig";
            this.ContraOblig.Size = new System.Drawing.Size(86, 18);
            this.ContraOblig.TabIndex = 72;
            this.ContraOblig.Text = "Obligatorio";
            this.ContraOblig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ContraOblig.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(722, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(222, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 600);
            this.Controls.Add(this.ContraOblig);
            this.Controls.Add(this.NombreObli);
            this.Controls.Add(this.NominObli);
            this.Controls.Add(this.ContrasenaAdminLabel);
            this.Controls.Add(this.ContrasenaAdminBox);
            this.Controls.Add(this.NombreAdminLabel);
            this.Controls.Add(this.NombreAdminBox);
            this.Controls.Add(this.NuevoAdminLabel);
            this.Controls.Add(this.NominaAdminLabel);
            this.Controls.Add(this.NominaAdminBox);
            this.Controls.Add(this.EleccionAdminBox);
            this.Controls.Add(this.EjecutarBotton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminLabel);
            this.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCA.A";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EjecutarBotton;
        private System.Windows.Forms.CheckedListBox EleccionAdminBox;
        private System.Windows.Forms.Label NominaAdminLabel;
        public System.Windows.Forms.TextBox NominaAdminBox;
        private System.Windows.Forms.Label NuevoAdminLabel;
        private System.Windows.Forms.Label NombreAdminLabel;
        public System.Windows.Forms.TextBox NombreAdminBox;
        private System.Windows.Forms.Label ContrasenaAdminLabel;
        public System.Windows.Forms.TextBox ContrasenaAdminBox;
        private System.Windows.Forms.Label NominObli;
        private System.Windows.Forms.Label NombreObli;
        private System.Windows.Forms.Label ContraOblig;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}