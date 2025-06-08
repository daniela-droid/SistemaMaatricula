namespace Sistema_Matricula
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
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel_formularios = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_lado = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonProfesor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_grupos = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button_reportes = new System.Windows.Forms.Button();
            this.button_estudiante = new System.Windows.Forms.Button();
            this.button_matriculas = new System.Windows.Forms.Button();
            this.panel_arriba = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.panel_contenedor.SuspendLayout();
            this.panel_formularios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_lado.SuspendLayout();
            this.panel_arriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.White;
            this.panel_contenedor.Controls.Add(this.panel_formularios);
            this.panel_contenedor.Controls.Add(this.panel_arriba);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(0, 0);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1118, 614);
            this.panel_contenedor.TabIndex = 0;
            // 
            // panel_formularios
            // 
            this.panel_formularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.panel_formularios.Controls.Add(this.panel1);
            this.panel_formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_formularios.Location = new System.Drawing.Point(0, 118);
            this.panel_formularios.Margin = new System.Windows.Forms.Padding(2);
            this.panel_formularios.Name = "panel_formularios";
            this.panel_formularios.Size = new System.Drawing.Size(1118, 496);
            this.panel_formularios.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_lado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 496);
            this.panel1.TabIndex = 2;
            // 
            // panel_lado
            // 
            this.panel_lado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.panel_lado.Controls.Add(this.label6);
            this.panel_lado.Controls.Add(this.label5);
            this.panel_lado.Controls.Add(this.label4);
            this.panel_lado.Controls.Add(this.label2);
            this.panel_lado.Controls.Add(this.buttonProfesor);
            this.panel_lado.Controls.Add(this.label1);
            this.panel_lado.Controls.Add(this.button_grupos);
            this.panel_lado.Controls.Add(this.btn_exit);
            this.panel_lado.Controls.Add(this.button_reportes);
            this.panel_lado.Controls.Add(this.button_estudiante);
            this.panel_lado.Controls.Add(this.button_matriculas);
            this.panel_lado.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(175)))));
            this.panel_lado.Location = new System.Drawing.Point(0, 0);
            this.panel_lado.Margin = new System.Windows.Forms.Padding(2);
            this.panel_lado.Name = "panel_lado";
            this.panel_lado.Size = new System.Drawing.Size(279, 496);
            this.panel_lado.TabIndex = 1;
            this.panel_lado.Visible = false;
            this.panel_lado.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_lado_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 18F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(97, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "Profesores";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 18F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(100, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Reportes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 18F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(100, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grupos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(97, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matriculados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonProfesor
            // 
            this.buttonProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.buttonProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfesor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.buttonProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.buttonProfesor.Image = ((System.Drawing.Image)(resources.GetObject("buttonProfesor.Image")));
            this.buttonProfesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfesor.Location = new System.Drawing.Point(3, 272);
            this.buttonProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProfesor.Name = "buttonProfesor";
            this.buttonProfesor.Size = new System.Drawing.Size(261, 61);
            this.buttonProfesor.TabIndex = 2;
            this.buttonProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProfesor.UseVisualStyleBackColor = false;
            this.buttonProfesor.Click += new System.EventHandler(this.buttonProfesor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(97, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estudiantes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_grupos
            // 
            this.button_grupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.button_grupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_grupos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button_grupos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.button_grupos.Image = ((System.Drawing.Image)(resources.GetObject("button_grupos.Image")));
            this.button_grupos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_grupos.Location = new System.Drawing.Point(2, 132);
            this.button_grupos.Margin = new System.Windows.Forms.Padding(2);
            this.button_grupos.Name = "button_grupos";
            this.button_grupos.Size = new System.Drawing.Size(259, 61);
            this.button_grupos.TabIndex = 6;
            this.button_grupos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_grupos.UseVisualStyleBackColor = false;
            this.button_grupos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(1, 455);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(276, 41);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_reportes
            // 
            this.button_reportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.button_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reportes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button_reportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.button_reportes.Image = ((System.Drawing.Image)(resources.GetObject("button_reportes.Image")));
            this.button_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_reportes.Location = new System.Drawing.Point(3, 197);
            this.button_reportes.Margin = new System.Windows.Forms.Padding(2);
            this.button_reportes.Name = "button_reportes";
            this.button_reportes.Size = new System.Drawing.Size(258, 61);
            this.button_reportes.TabIndex = 5;
            this.button_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_reportes.UseVisualStyleBackColor = false;
            this.button_reportes.Click += new System.EventHandler(this.button_reportes_Click);
            // 
            // button_estudiante
            // 
            this.button_estudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.button_estudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_estudiante.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button_estudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.button_estudiante.Image = ((System.Drawing.Image)(resources.GetObject("button_estudiante.Image")));
            this.button_estudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_estudiante.Location = new System.Drawing.Point(2, 0);
            this.button_estudiante.Margin = new System.Windows.Forms.Padding(2);
            this.button_estudiante.Name = "button_estudiante";
            this.button_estudiante.Size = new System.Drawing.Size(258, 61);
            this.button_estudiante.TabIndex = 3;
            this.button_estudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_estudiante.UseVisualStyleBackColor = false;
            this.button_estudiante.Click += new System.EventHandler(this.button_estudiante_Click);
            // 
            // button_matriculas
            // 
            this.button_matriculas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_matriculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.button_matriculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_matriculas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button_matriculas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.button_matriculas.Image = ((System.Drawing.Image)(resources.GetObject("button_matriculas.Image")));
            this.button_matriculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_matriculas.Location = new System.Drawing.Point(4, 65);
            this.button_matriculas.Margin = new System.Windows.Forms.Padding(2);
            this.button_matriculas.Name = "button_matriculas";
            this.button_matriculas.Size = new System.Drawing.Size(258, 61);
            this.button_matriculas.TabIndex = 4;
            this.button_matriculas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_matriculas.UseVisualStyleBackColor = false;
            this.button_matriculas.Click += new System.EventHandler(this.button_matriculas_Click);
            // 
            // panel_arriba
            // 
            this.panel_arriba.BackColor = System.Drawing.Color.White;
            this.panel_arriba.Controls.Add(this.label3);
            this.panel_arriba.Controls.Add(this.button2);
            this.panel_arriba.Controls.Add(this.button_menu);
            this.panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_arriba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(214)))));
            this.panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.panel_arriba.Name = "panel_arriba";
            this.panel_arriba.Size = new System.Drawing.Size(1118, 118);
            this.panel_arriba.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(849, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 49);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sistema Matricula";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 118);
            this.button2.TabIndex = 3;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_menu
            // 
            this.button_menu.BackColor = System.Drawing.Color.White;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button_menu.ForeColor = System.Drawing.Color.White;
            this.button_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu.Location = new System.Drawing.Point(3, 1);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(203, 57);
            this.button_menu.TabIndex = 2;
            this.button_menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_menu.UseVisualStyleBackColor = false;
            this.button_menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1118, 614);
            this.Controls.Add(this.panel_contenedor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_contenedor.ResumeLayout(false);
            this.panel_formularios.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_lado.ResumeLayout(false);
            this.panel_lado.PerformLayout();
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Panel panel_lado;
        private System.Windows.Forms.Panel panel_arriba;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_reportes;
        private System.Windows.Forms.Button button_matriculas;
        private System.Windows.Forms.Button button_estudiante;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button_grupos;
        private System.Windows.Forms.Button buttonProfesor;
        private System.Windows.Forms.Panel panel_formularios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}

