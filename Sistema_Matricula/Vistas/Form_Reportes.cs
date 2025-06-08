using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Matricula.Controladores;
using Sistema_Matricula.Modelos;

namespace Sistema_Matricula.Vistas
{
    public partial class Form_Reportes : Form
    {
        public Form_Reportes()
        {
            InitializeComponent();
        }

        private void Form_Reportes_Load(object sender, EventArgs e)
        {

        }

        private void button_rmatricula_Click(object sender, EventArgs e)
        {
            var reporte = new Controlador_Reporte();
            data_reporte.DataSource = reporte.VerMatriculas();
            utilidades.Dtctualizar(data_reporte);
           
        }

        private void button_restudainte_Click(object sender, EventArgs e)
        {

        }

        private void buton_rgrupo_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void data_reporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
