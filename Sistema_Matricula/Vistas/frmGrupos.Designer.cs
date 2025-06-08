namespace Sistema_Matricula.Vistas
{
    partial class frmGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGrupos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_texbox = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboHorario = new System.Windows.Forms.ComboBox();
            this.combodiasemana = new System.Windows.Forms.ComboBox();
            this.combogrupo = new System.Windows.Forms.ComboBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonnuevo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbuscar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrupos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_texbox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGrupos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 537);
            this.panel1.TabIndex = 0;
            // 
            // dataGrupos
            // 
            this.dataGrupos.AllowUserToAddRows = false;
            this.dataGrupos.AllowUserToDeleteRows = false;
            this.dataGrupos.BackgroundColor = System.Drawing.Color.White;
            this.dataGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            this.dataGrupos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrupos.Location = new System.Drawing.Point(0, 284);
            this.dataGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrupos.Name = "dataGrupos";
            this.dataGrupos.ReadOnly = true;
            this.dataGrupos.RowHeadersWidth = 62;
            this.dataGrupos.RowTemplate.Height = 28;
            this.dataGrupos.Size = new System.Drawing.Size(1091, 253);
            this.dataGrupos.TabIndex = 2;
            this.dataGrupos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrupos_CellClick);
            this.dataGrupos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.MinimumWidth = 8;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 150;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.MinimumWidth = 8;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 150;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_texbox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1091, 472);
            this.panel3.TabIndex = 1;
            // 
            // panel_texbox
            // 
            this.panel_texbox.Controls.Add(this.label8);
            this.panel_texbox.Controls.Add(this.label9);
            this.panel_texbox.Controls.Add(this.comboHorario);
            this.panel_texbox.Controls.Add(this.combodiasemana);
            this.panel_texbox.Controls.Add(this.combogrupo);
            this.panel_texbox.Controls.Add(this.cancelar);
            this.panel_texbox.Controls.Add(this.guardar);
            this.panel_texbox.Controls.Add(this.label4);
            this.panel_texbox.Controls.Add(this.label3);
            this.panel_texbox.Controls.Add(this.label2);
            this.panel_texbox.Controls.Add(this.label1);
            this.panel_texbox.Controls.Add(this.textid);
            this.panel_texbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_texbox.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.panel_texbox.Location = new System.Drawing.Point(0, 0);
            this.panel_texbox.Margin = new System.Windows.Forms.Padding(2);
            this.panel_texbox.Name = "panel_texbox";
            this.panel_texbox.Size = new System.Drawing.Size(1091, 472);
            this.panel_texbox.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label8.Location = new System.Drawing.Point(979, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 14);
            this.label8.TabIndex = 5;
            this.label8.Text = "Guardar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label9.Location = new System.Drawing.Point(976, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 14);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cancelar";
            // 
            // comboHorario
            // 
            this.comboHorario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboHorario.FormattingEnabled = true;
            this.comboHorario.Items.AddRange(new object[] {
            "Maniana",
            "Tarde"});
            this.comboHorario.Location = new System.Drawing.Point(444, 86);
            this.comboHorario.Margin = new System.Windows.Forms.Padding(2);
            this.comboHorario.Name = "comboHorario";
            this.comboHorario.Size = new System.Drawing.Size(180, 22);
            this.comboHorario.TabIndex = 12;
            // 
            // combodiasemana
            // 
            this.combodiasemana.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodiasemana.FormattingEnabled = true;
            this.combodiasemana.Items.AddRange(new object[] {
            "Lunes Y Miercoles",
            "Martes Y Jueves",
            ""});
            this.combodiasemana.Location = new System.Drawing.Point(444, 26);
            this.combodiasemana.Margin = new System.Windows.Forms.Padding(2);
            this.combodiasemana.Name = "combodiasemana";
            this.combodiasemana.Size = new System.Drawing.Size(180, 22);
            this.combodiasemana.TabIndex = 11;
            // 
            // combogrupo
            // 
            this.combogrupo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combogrupo.FormattingEnabled = true;
            this.combogrupo.Items.AddRange(new object[] {
            "Grupo 1",
            "Grupo 2",
            "Grupo 3",
            "Grupo 4",
            "Grupo 5",
            "Grupo 6",
            "Grupo 7",
            "Grupo 8",
            "Grupo 9",
            "Grupo 10"});
            this.combogrupo.Location = new System.Drawing.Point(128, 88);
            this.combogrupo.Margin = new System.Windows.Forms.Padding(2);
            this.combogrupo.Name = "combogrupo";
            this.combogrupo.Size = new System.Drawing.Size(191, 22);
            this.combogrupo.TabIndex = 10;
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.White;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cancelar.ForeColor = System.Drawing.Color.White;
            this.cancelar.Image = ((System.Drawing.Image)(resources.GetObject("cancelar.Image")));
            this.cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelar.Location = new System.Drawing.Point(921, 90);
            this.cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(112, 50);
            this.cancelar.TabIndex = 9;
            this.cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.White;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Tahoma", 9F);
            this.guardar.ForeColor = System.Drawing.Color.White;
            this.guardar.Image = ((System.Drawing.Image)(resources.GetObject("guardar.Image")));
            this.guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardar.Location = new System.Drawing.Point(921, 27);
            this.guardar.Margin = new System.Windows.Forms.Padding(2);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(112, 50);
            this.guardar.TabIndex = 8;
            this.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.Location = new System.Drawing.Point(349, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Turno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.Location = new System.Drawing.Point(349, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dias de\r\nSemana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.Location = new System.Drawing.Point(59, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grupo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(68, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id:";
            // 
            // textid
            // 
            this.textid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textid.Location = new System.Drawing.Point(128, 17);
            this.textid.Margin = new System.Windows.Forms.Padding(2);
            this.textid.Multiline = true;
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(191, 29);
            this.textid.TabIndex = 0;
            this.textid.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.buttonnuevo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textbuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 65);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label7.Location = new System.Drawing.Point(979, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nuevo";
            // 
            // buttonnuevo
            // 
            this.buttonnuevo.BackColor = System.Drawing.Color.White;
            this.buttonnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonnuevo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.buttonnuevo.ForeColor = System.Drawing.Color.White;
            this.buttonnuevo.Image = ((System.Drawing.Image)(resources.GetObject("buttonnuevo.Image")));
            this.buttonnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonnuevo.Location = new System.Drawing.Point(921, 11);
            this.buttonnuevo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonnuevo.Name = "buttonnuevo";
            this.buttonnuevo.Size = new System.Drawing.Size(112, 50);
            this.buttonnuevo.TabIndex = 3;
            this.buttonnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonnuevo.UseVisualStyleBackColor = false;
            this.buttonnuevo.Click += new System.EventHandler(this.buttonnuevo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(60, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Grupos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(155, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buscar:";
            // 
            // textbuscar
            // 
            this.textbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.textbuscar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbuscar.Location = new System.Drawing.Point(225, 32);
            this.textbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textbuscar.Multiline = true;
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(653, 25);
            this.textbuscar.TabIndex = 0;
            this.textbuscar.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // frmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 537);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGrupos";
            this.ShowIcon = false;
            this.Text = "frmGrupos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGrupos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrupos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel_texbox.ResumeLayout(false);
            this.panel_texbox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrupos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_texbox;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textbuscar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonnuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combogrupo;
        private System.Windows.Forms.ComboBox combodiasemana;
        private System.Windows.Forms.ComboBox comboHorario;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}