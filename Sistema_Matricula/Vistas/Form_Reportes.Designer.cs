
namespace Sistema_Matricula.Vistas
{
    partial class Form_Reportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_botones = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.buton_rgrupo = new System.Windows.Forms.Button();
            this.button_restudainte = new System.Windows.Forms.Button();
            this.button_rmatricula = new System.Windows.Forms.Button();
            this.panel_data = new System.Windows.Forms.Panel();
            this.data_reporte = new System.Windows.Forms.DataGridView();
            this.panel_botones.SuspendLayout();
            this.panel_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_botones
            // 
            this.panel_botones.BackColor = System.Drawing.Color.White;
            this.panel_botones.Controls.Add(this.button4);
            this.panel_botones.Controls.Add(this.buton_rgrupo);
            this.panel_botones.Controls.Add(this.button_restudainte);
            this.panel_botones.Controls.Add(this.button_rmatricula);
            this.panel_botones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_botones.Location = new System.Drawing.Point(702, 0);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.Size = new System.Drawing.Size(375, 504);
            this.panel_botones.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(58, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(228, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "Crear PDF";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buton_rgrupo
            // 
            this.buton_rgrupo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_rgrupo.ForeColor = System.Drawing.Color.Black;
            this.buton_rgrupo.Location = new System.Drawing.Point(58, 169);
            this.buton_rgrupo.Name = "buton_rgrupo";
            this.buton_rgrupo.Size = new System.Drawing.Size(228, 43);
            this.buton_rgrupo.TabIndex = 2;
            this.buton_rgrupo.Text = "Reporte Estudiantes por Grupo";
            this.buton_rgrupo.UseVisualStyleBackColor = true;
            this.buton_rgrupo.Click += new System.EventHandler(this.buton_rgrupo_Click);
            // 
            // button_restudainte
            // 
            this.button_restudainte.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_restudainte.ForeColor = System.Drawing.Color.Black;
            this.button_restudainte.Location = new System.Drawing.Point(58, 107);
            this.button_restudainte.Name = "button_restudainte";
            this.button_restudainte.Size = new System.Drawing.Size(228, 43);
            this.button_restudainte.TabIndex = 1;
            this.button_restudainte.Text = "Reporte General de Estudiante";
            this.button_restudainte.UseVisualStyleBackColor = true;
            this.button_restudainte.Click += new System.EventHandler(this.button_restudainte_Click);
            // 
            // button_rmatricula
            // 
            this.button_rmatricula.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rmatricula.ForeColor = System.Drawing.Color.Black;
            this.button_rmatricula.Location = new System.Drawing.Point(58, 39);
            this.button_rmatricula.Name = "button_rmatricula";
            this.button_rmatricula.Size = new System.Drawing.Size(228, 43);
            this.button_rmatricula.TabIndex = 0;
            this.button_rmatricula.Text = "Reporte General de Matricula";
            this.button_rmatricula.UseVisualStyleBackColor = true;
            this.button_rmatricula.Click += new System.EventHandler(this.button_rmatricula_Click);
            // 
            // panel_data
            // 
            this.panel_data.Controls.Add(this.data_reporte);
            this.panel_data.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_data.Location = new System.Drawing.Point(0, 0);
            this.panel_data.Name = "panel_data";
            this.panel_data.Size = new System.Drawing.Size(705, 504);
            this.panel_data.TabIndex = 1;
            // 
            // data_reporte
            // 
            this.data_reporte.AllowUserToAddRows = false;
            this.data_reporte.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_reporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_reporte.BackgroundColor = System.Drawing.Color.White;
            this.data_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_reporte.Dock = System.Windows.Forms.DockStyle.Left;
            this.data_reporte.Location = new System.Drawing.Point(0, 0);
            this.data_reporte.Name = "data_reporte";
            this.data_reporte.ReadOnly = true;
            this.data_reporte.Size = new System.Drawing.Size(705, 504);
            this.data_reporte.TabIndex = 0;
            this.data_reporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_reporte_CellContentClick);
            // 
            // Form_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 504);
            this.Controls.Add(this.panel_data);
            this.Controls.Add(this.panel_botones);
            this.Name = "Form_Reportes";
            this.ShowIcon = false;
            this.Text = "Form_Reportes";
            this.Load += new System.EventHandler(this.Form_Reportes_Load);
            this.panel_botones.ResumeLayout(false);
            this.panel_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_reporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_botones;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buton_rgrupo;
        private System.Windows.Forms.Button button_restudainte;
        private System.Windows.Forms.Button button_rmatricula;
        private System.Windows.Forms.Panel panel_data;
        private System.Windows.Forms.DataGridView data_reporte;
    }
}