namespace Sistema_Matricula.Vistas
{
    partial class frmMatriculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatriculas));
            this.panelbuscar = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p_textos = new System.Windows.Forms.Panel();
            this.datamatriculas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.textanio = new System.Windows.Forms.TextBox();
            this.comoTurno = new System.Windows.Forms.ComboBox();
            this.comGrupo = new System.Windows.Forms.ComboBox();
            this.combEstudiante = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bcancelar = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.texid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comDiaSemana = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelbuscar.SuspendLayout();
            this.p_textos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datamatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbuscar
            // 
            this.panelbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.panelbuscar.Controls.Add(this.label14);
            this.panelbuscar.Controls.Add(this.label8);
            this.panelbuscar.Controls.Add(this.button);
            this.panelbuscar.Controls.Add(this.textBuscar);
            this.panelbuscar.Controls.Add(this.label6);
            this.panelbuscar.Controls.Add(this.label1);
            this.panelbuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbuscar.Location = new System.Drawing.Point(0, 0);
            this.panelbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.panelbuscar.Name = "panelbuscar";
            this.panelbuscar.Size = new System.Drawing.Size(1077, 65);
            this.panelbuscar.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(974, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 14);
            this.label14.TabIndex = 6;
            this.label14.Text = "Nuevo";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(160, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 27);
            this.label8.TabIndex = 5;
            this.label8.Text = "Buscar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.White;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Image = ((System.Drawing.Image)(resources.GetObject("button.Image")));
            this.button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button.Location = new System.Drawing.Point(916, 11);
            this.button.Margin = new System.Windows.Forms.Padding(2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(112, 50);
            this.button.TabIndex = 4;
            this.button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.textBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBuscar.ForeColor = System.Drawing.Color.Black;
            this.textBuscar.Location = new System.Drawing.Point(224, 30);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBuscar.Multiline = true;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(653, 25);
            this.textBuscar.TabIndex = 3;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(162)))));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(172, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matriculas";
            // 
            // p_textos
            // 
            this.p_textos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.p_textos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_textos.Controls.Add(this.datamatriculas);
            this.p_textos.Controls.Add(this.label9);
            this.p_textos.Controls.Add(this.textanio);
            this.p_textos.Controls.Add(this.comoTurno);
            this.p_textos.Controls.Add(this.comGrupo);
            this.p_textos.Controls.Add(this.combEstudiante);
            this.p_textos.Controls.Add(this.label15);
            this.p_textos.Controls.Add(this.label16);
            this.p_textos.Controls.Add(this.bcancelar);
            this.p_textos.Controls.Add(this.bguardar);
            this.p_textos.Controls.Add(this.texid);
            this.p_textos.Controls.Add(this.label7);
            this.p_textos.Controls.Add(this.label5);
            this.p_textos.Controls.Add(this.comDiaSemana);
            this.p_textos.Controls.Add(this.label4);
            this.p_textos.Controls.Add(this.label3);
            this.p_textos.Controls.Add(this.label2);
            this.p_textos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_textos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_textos.Location = new System.Drawing.Point(0, 65);
            this.p_textos.Margin = new System.Windows.Forms.Padding(2);
            this.p_textos.Name = "p_textos";
            this.p_textos.Size = new System.Drawing.Size(1077, 422);
            this.p_textos.TabIndex = 2;
            // 
            // datamatriculas
            // 
            this.datamatriculas.AllowUserToAddRows = false;
            this.datamatriculas.AllowUserToDeleteRows = false;
            this.datamatriculas.BackgroundColor = System.Drawing.Color.White;
            this.datamatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            this.datamatriculas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datamatriculas.GridColor = System.Drawing.Color.White;
            this.datamatriculas.Location = new System.Drawing.Point(0, 205);
            this.datamatriculas.Name = "datamatriculas";
            this.datamatriculas.ReadOnly = true;
            this.datamatriculas.Size = new System.Drawing.Size(1073, 213);
            this.datamatriculas.TabIndex = 27;
            this.datamatriculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datamatriculas_CellClick);
            this.datamatriculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datamatriculas_CellContentClick_1);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 14);
            this.label9.TabIndex = 26;
            this.label9.Text = "Anio:";
            // 
            // textanio
            // 
            this.textanio.Location = new System.Drawing.Point(462, 122);
            this.textanio.Name = "textanio";
            this.textanio.Size = new System.Drawing.Size(189, 22);
            this.textanio.TabIndex = 25;
            // 
            // comoTurno
            // 
            this.comoTurno.FormattingEnabled = true;
            this.comoTurno.Location = new System.Drawing.Point(462, 79);
            this.comoTurno.Name = "comoTurno";
            this.comoTurno.Size = new System.Drawing.Size(189, 22);
            this.comoTurno.TabIndex = 24;
            // 
            // comGrupo
            // 
            this.comGrupo.FormattingEnabled = true;
            this.comGrupo.Location = new System.Drawing.Point(88, 128);
            this.comGrupo.Name = "comGrupo";
            this.comGrupo.Size = new System.Drawing.Size(189, 22);
            this.comGrupo.TabIndex = 23;
            // 
            // combEstudiante
            // 
            this.combEstudiante.FormattingEnabled = true;
            this.combEstudiante.Location = new System.Drawing.Point(88, 81);
            this.combEstudiante.Name = "combEstudiante";
            this.combEstudiante.Size = new System.Drawing.Size(189, 22);
            this.combEstudiante.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(965, 43);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 14);
            this.label15.TabIndex = 7;
            this.label15.Text = "Guardar";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(965, 113);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 14);
            this.label16.TabIndex = 8;
            this.label16.Text = "Cancelar";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bcancelar
            // 
            this.bcancelar.BackColor = System.Drawing.Color.White;
            this.bcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcancelar.ForeColor = System.Drawing.Color.White;
            this.bcancelar.Image = ((System.Drawing.Image)(resources.GetObject("bcancelar.Image")));
            this.bcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bcancelar.Location = new System.Drawing.Point(911, 99);
            this.bcancelar.Margin = new System.Windows.Forms.Padding(2);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(115, 51);
            this.bcancelar.TabIndex = 0;
            this.bcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bcancelar.UseVisualStyleBackColor = false;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // bguardar
            // 
            this.bguardar.BackColor = System.Drawing.Color.White;
            this.bguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bguardar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.ForeColor = System.Drawing.Color.White;
            this.bguardar.Image = ((System.Drawing.Image)(resources.GetObject("bguardar.Image")));
            this.bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bguardar.Location = new System.Drawing.Point(911, 32);
            this.bguardar.Margin = new System.Windows.Forms.Padding(2);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(115, 49);
            this.bguardar.TabIndex = 5;
            this.bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bguardar.UseVisualStyleBackColor = false;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // texid
            // 
            this.texid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texid.Location = new System.Drawing.Point(86, 31);
            this.texid.Margin = new System.Windows.Forms.Padding(2);
            this.texid.Multiline = true;
            this.texid.Name = "texid";
            this.texid.Size = new System.Drawing.Size(191, 29);
            this.texid.TabIndex = 10;
            this.texid.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dias de Semana:";
            // 
            // comDiaSemana
            // 
            this.comDiaSemana.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comDiaSemana.FormattingEnabled = true;
            this.comDiaSemana.Location = new System.Drawing.Point(462, 35);
            this.comDiaSemana.Margin = new System.Windows.Forms.Padding(2);
            this.comDiaSemana.Name = "comDiaSemana";
            this.comDiaSemana.Size = new System.Drawing.Size(191, 22);
            this.comDiaSemana.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Turno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grupo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estudiante:";
            // 
            // frmMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 487);
            this.Controls.Add(this.p_textos);
            this.Controls.Add(this.panelbuscar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMatriculas";
            this.ShowIcon = false;
            this.Text = "frmMatriculas";
            this.Load += new System.EventHandler(this.frmMatriculas_Load);
            this.panelbuscar.ResumeLayout(false);
            this.panelbuscar.PerformLayout();
            this.p_textos.ResumeLayout(false);
            this.p_textos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datamatriculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbuscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p_textos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.TextBox texid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comDiaSemana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comGrupo;
        private System.Windows.Forms.ComboBox combEstudiante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textanio;
        private System.Windows.Forms.ComboBox comoTurno;
        private System.Windows.Forms.DataGridView datamatriculas;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}