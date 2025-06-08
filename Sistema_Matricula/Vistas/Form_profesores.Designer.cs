namespace Sistema_Matricula.Vistas
{
    partial class Form_profesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_profesores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_textbox = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bguardar = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textcelular = new System.Windows.Forms.TextBox();
            this.textespecialidad = new System.Windows.Forms.TextBox();
            this.textapellido = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.dataprofesores = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bnuevo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_textbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataprofesores)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataprofesores);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 487);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_textbox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1077, 177);
            this.panel3.TabIndex = 1;
            // 
            // panel_textbox
            // 
            this.panel_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.panel_textbox.Controls.Add(this.label9);
            this.panel_textbox.Controls.Add(this.label10);
            this.panel_textbox.Controls.Add(this.bguardar);
            this.panel_textbox.Controls.Add(this.bcancelar);
            this.panel_textbox.Controls.Add(this.label5);
            this.panel_textbox.Controls.Add(this.label4);
            this.panel_textbox.Controls.Add(this.label3);
            this.panel_textbox.Controls.Add(this.label2);
            this.panel_textbox.Controls.Add(this.label1);
            this.panel_textbox.Controls.Add(this.textcelular);
            this.panel_textbox.Controls.Add(this.textespecialidad);
            this.panel_textbox.Controls.Add(this.textapellido);
            this.panel_textbox.Controls.Add(this.textnombre);
            this.panel_textbox.Controls.Add(this.textid);
            this.panel_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_textbox.Location = new System.Drawing.Point(0, 0);
            this.panel_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.panel_textbox.Name = "panel_textbox";
            this.panel_textbox.Size = new System.Drawing.Size(1077, 177);
            this.panel_textbox.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(973, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 13;
            this.label9.Text = "Guardar";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(973, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 14);
            this.label10.TabIndex = 14;
            this.label10.Text = "Cancelar";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bguardar
            // 
            this.bguardar.BackColor = System.Drawing.Color.White;
            this.bguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bguardar.ForeColor = System.Drawing.Color.White;
            this.bguardar.Image = ((System.Drawing.Image)(resources.GetObject("bguardar.Image")));
            this.bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bguardar.Location = new System.Drawing.Point(912, 35);
            this.bguardar.Margin = new System.Windows.Forms.Padding(2);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(115, 49);
            this.bguardar.TabIndex = 12;
            this.bguardar.UseVisualStyleBackColor = false;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.BackColor = System.Drawing.Color.White;
            this.bcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancelar.ForeColor = System.Drawing.Color.White;
            this.bcancelar.Image = ((System.Drawing.Image)(resources.GetObject("bcancelar.Image")));
            this.bcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bcancelar.Location = new System.Drawing.Point(912, 94);
            this.bcancelar.Margin = new System.Windows.Forms.Padding(2);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(115, 49);
            this.bcancelar.TabIndex = 13;
            this.bcancelar.UseVisualStyleBackColor = false;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.Location = new System.Drawing.Point(467, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.Location = new System.Drawing.Point(467, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Especialidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.Location = new System.Drawing.Point(97, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.Location = new System.Drawing.Point(97, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id:";
            // 
            // textcelular
            // 
            this.textcelular.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textcelular.Location = new System.Drawing.Point(593, 75);
            this.textcelular.Margin = new System.Windows.Forms.Padding(2);
            this.textcelular.Multiline = true;
            this.textcelular.Name = "textcelular";
            this.textcelular.Size = new System.Drawing.Size(191, 29);
            this.textcelular.TabIndex = 4;
            // 
            // textespecialidad
            // 
            this.textespecialidad.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textespecialidad.Location = new System.Drawing.Point(593, 18);
            this.textespecialidad.Margin = new System.Windows.Forms.Padding(2);
            this.textespecialidad.Multiline = true;
            this.textespecialidad.Name = "textespecialidad";
            this.textespecialidad.Size = new System.Drawing.Size(191, 29);
            this.textespecialidad.TabIndex = 3;
            // 
            // textapellido
            // 
            this.textapellido.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textapellido.Location = new System.Drawing.Point(163, 130);
            this.textapellido.Margin = new System.Windows.Forms.Padding(2);
            this.textapellido.Multiline = true;
            this.textapellido.Name = "textapellido";
            this.textapellido.Size = new System.Drawing.Size(191, 29);
            this.textapellido.TabIndex = 2;
            // 
            // textnombre
            // 
            this.textnombre.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textnombre.Location = new System.Drawing.Point(163, 77);
            this.textnombre.Margin = new System.Windows.Forms.Padding(2);
            this.textnombre.Multiline = true;
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(191, 29);
            this.textnombre.TabIndex = 1;
            // 
            // textid
            // 
            this.textid.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textid.Location = new System.Drawing.Point(163, 18);
            this.textid.Margin = new System.Windows.Forms.Padding(2);
            this.textid.Multiline = true;
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(191, 29);
            this.textid.TabIndex = 0;
            this.textid.Text = "0";
            // 
            // dataprofesores
            // 
            this.dataprofesores.AllowUserToAddRows = false;
            this.dataprofesores.AllowUserToDeleteRows = false;
            this.dataprofesores.BackgroundColor = System.Drawing.Color.White;
            this.dataprofesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataprofesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            this.dataprofesores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataprofesores.Location = new System.Drawing.Point(0, 242);
            this.dataprofesores.Margin = new System.Windows.Forms.Padding(2);
            this.dataprofesores.Name = "dataprofesores";
            this.dataprofesores.ReadOnly = true;
            this.dataprofesores.RowHeadersWidth = 62;
            this.dataprofesores.RowTemplate.Height = 28;
            this.dataprofesores.Size = new System.Drawing.Size(1077, 245);
            this.dataprofesores.TabIndex = 1;
            this.dataprofesores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataprofesores_CellClick);
            this.dataprofesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataprofesores_CellContentClick);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.bnuevo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 65);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(977, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nuevo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bnuevo
            // 
            this.bnuevo.BackColor = System.Drawing.Color.White;
            this.bnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnuevo.ForeColor = System.Drawing.Color.White;
            this.bnuevo.Image = ((System.Drawing.Image)(resources.GetObject("bnuevo.Image")));
            this.bnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnuevo.Location = new System.Drawing.Point(912, 12);
            this.bnuevo.Margin = new System.Windows.Forms.Padding(2);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(115, 49);
            this.bnuevo.TabIndex = 10;
            this.bnuevo.UseVisualStyleBackColor = false;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(41, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Profesores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(174, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Buscar:";
            // 
            // textBuscar
            // 
            this.textBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.textBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBuscar.Location = new System.Drawing.Point(228, 27);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBuscar.Multiline = true;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(653, 25);
            this.textBuscar.TabIndex = 5;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // Form_profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 487);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_profesores";
            this.ShowIcon = false;
            this.Text = "Form_profesores";
            this.Load += new System.EventHandler(this.Form_profesores_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_textbox.ResumeLayout(false);
            this.panel_textbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataprofesores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataprofesores;
        private System.Windows.Forms.Panel panel_textbox;
        private System.Windows.Forms.TextBox textcelular;
        private System.Windows.Forms.TextBox textespecialidad;
        private System.Windows.Forms.TextBox textapellido;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
    }
}