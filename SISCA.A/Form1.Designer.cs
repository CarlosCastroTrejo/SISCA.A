namespace SISCA.A
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RegistraObliga = new System.Windows.Forms.Label();
            this.NombreObliga = new System.Windows.Forms.Label();
            this.Continuar = new System.Windows.Forms.Button();
            this.Llenar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.AlumnoObliga = new System.Windows.Forms.Label();
            this.CarreraObliga = new System.Windows.Forms.Label();
            this.EntradaBox = new System.Windows.Forms.TextBox();
            this.EntradaB = new System.Windows.Forms.Label();
            this.HoraBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AlumnoBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CarreraBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MatriculaBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de usuarios MakerSpace";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(126)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(386, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 18);
            this.label11.TabIndex = 39;
            this.label11.Text = "Obligatorio";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(153, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "¡Atencion! ";
            // 
            // RegistraObliga
            // 
            this.RegistraObliga.AutoSize = true;
            this.RegistraObliga.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistraObliga.Location = new System.Drawing.Point(653, 189);
            this.RegistraObliga.Name = "RegistraObliga";
            this.RegistraObliga.Size = new System.Drawing.Size(211, 20);
            this.RegistraObliga.TabIndex = 43;
            this.RegistraObliga.Text = "¡Registra todos tus datos!";
            this.RegistraObliga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegistraObliga.Visible = false;
            // 
            // NombreObliga
            // 
            this.NombreObliga.AutoSize = true;
            this.NombreObliga.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreObliga.Location = new System.Drawing.Point(811, 241);
            this.NombreObliga.Name = "NombreObliga";
            this.NombreObliga.Size = new System.Drawing.Size(86, 18);
            this.NombreObliga.TabIndex = 40;
            this.NombreObliga.Text = "Obligatorio";
            this.NombreObliga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NombreObliga.Visible = false;
            // 
            // Continuar
            // 
            this.Continuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.Continuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Continuar.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continuar.ForeColor = System.Drawing.Color.White;
            this.Continuar.Location = new System.Drawing.Point(602, 518);
            this.Continuar.Name = "Continuar";
            this.Continuar.Size = new System.Drawing.Size(295, 52);
            this.Continuar.TabIndex = 37;
            this.Continuar.Text = "Continuar";
            this.Continuar.UseVisualStyleBackColor = false;
            this.Continuar.Click += new System.EventHandler(this.Continuar_Click);
            // 
            // Llenar
            // 
            this.Llenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.Llenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Llenar.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llenar.ForeColor = System.Drawing.Color.White;
            this.Llenar.Location = new System.Drawing.Point(522, 183);
            this.Llenar.Name = "Llenar";
            this.Llenar.Size = new System.Drawing.Size(74, 35);
            this.Llenar.TabIndex = 36;
            this.Llenar.Text = "Llenar";
            this.Llenar.UseVisualStyleBackColor = false;
            this.Llenar.Click += new System.EventHandler(this.Llenar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(68, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Confirma que tus datos sean correctos";
            // 
            // AlumnoObliga
            // 
            this.AlumnoObliga.AutoSize = true;
            this.AlumnoObliga.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlumnoObliga.Location = new System.Drawing.Point(811, 375);
            this.AlumnoObliga.Name = "AlumnoObliga";
            this.AlumnoObliga.Size = new System.Drawing.Size(86, 18);
            this.AlumnoObliga.TabIndex = 42;
            this.AlumnoObliga.Text = "Obligatorio";
            this.AlumnoObliga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AlumnoObliga.Visible = false;
            // 
            // CarreraObliga
            // 
            this.CarreraObliga.AutoSize = true;
            this.CarreraObliga.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarreraObliga.Location = new System.Drawing.Point(811, 310);
            this.CarreraObliga.Name = "CarreraObliga";
            this.CarreraObliga.Size = new System.Drawing.Size(86, 18);
            this.CarreraObliga.TabIndex = 41;
            this.CarreraObliga.Text = "Obligatorio";
            this.CarreraObliga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CarreraObliga.Visible = false;
            // 
            // EntradaBox
            // 
            this.EntradaBox.Enabled = false;
            this.EntradaBox.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntradaBox.Location = new System.Drawing.Point(602, 463);
            this.EntradaBox.Name = "EntradaBox";
            this.EntradaBox.Size = new System.Drawing.Size(295, 24);
            this.EntradaBox.TabIndex = 35;
            // 
            // EntradaB
            // 
            this.EntradaB.AutoSize = true;
            this.EntradaB.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntradaB.Location = new System.Drawing.Point(785, 443);
            this.EntradaB.Name = "EntradaB";
            this.EntradaB.Size = new System.Drawing.Size(112, 17);
            this.EntradaB.TabIndex = 34;
            this.EntradaB.Text = "Entrada / Salida";
            this.EntradaB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoraBox
            // 
            this.HoraBox.Enabled = false;
            this.HoraBox.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraBox.Location = new System.Drawing.Point(44, 463);
            this.HoraBox.Name = "HoraBox";
            this.HoraBox.Size = new System.Drawing.Size(304, 24);
            this.HoraBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Hora / Fecha";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlumnoBox
            // 
            this.AlumnoBox.Enabled = false;
            this.AlumnoBox.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlumnoBox.Location = new System.Drawing.Point(44, 396);
            this.AlumnoBox.Name = "AlumnoBox";
            this.AlumnoBox.Size = new System.Drawing.Size(853, 24);
            this.AlumnoBox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Alumno / Colaborador";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarreraBox
            // 
            this.CarreraBox.Enabled = false;
            this.CarreraBox.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarreraBox.Location = new System.Drawing.Point(44, 331);
            this.CarreraBox.Name = "CarreraBox";
            this.CarreraBox.Size = new System.Drawing.Size(853, 24);
            this.CarreraBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Carrera / Cargo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NombreBox
            // 
            this.NombreBox.Enabled = false;
            this.NombreBox.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreBox.Location = new System.Drawing.Point(44, 261);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(853, 24);
            this.NombreBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nombre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MatriculaBox
            // 
            this.MatriculaBox.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatriculaBox.Location = new System.Drawing.Point(44, 194);
            this.MatriculaBox.Name = "MatriculaBox";
            this.MatriculaBox.Size = new System.Drawing.Size(428, 24);
            this.MatriculaBox.TabIndex = 25;
            this.MatriculaBox.TextChanged += new System.EventHandler(this.MatriculaBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Matricula";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Registro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(44, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 52);
            this.panel2.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 600);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegistraObliga);
            this.Controls.Add(this.CarreraBox);
            this.Controls.Add(this.NombreObliga);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Continuar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Llenar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AlumnoObliga);
            this.Controls.Add(this.MatriculaBox);
            this.Controls.Add(this.CarreraObliga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EntradaBox);
            this.Controls.Add(this.NombreBox);
            this.Controls.Add(this.EntradaB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HoraBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AlumnoBox);
            this.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCA.A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label RegistraObliga;
        private System.Windows.Forms.Label NombreObliga;
        private System.Windows.Forms.Button Continuar;
        private System.Windows.Forms.Button Llenar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label AlumnoObliga;
        private System.Windows.Forms.Label CarreraObliga;
        private System.Windows.Forms.TextBox EntradaBox;
        private System.Windows.Forms.Label EntradaB;
        private System.Windows.Forms.TextBox HoraBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AlumnoBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CarreraBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox MatriculaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}

