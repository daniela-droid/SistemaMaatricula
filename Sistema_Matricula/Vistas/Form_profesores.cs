using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Matricula.Controladores;
using Sistema_Matricula.Modelos;

namespace Sistema_Matricula.Vistas
{
    public partial class Form_profesores: Form
    {
        public Form_profesores()
        {
            InitializeComponent();
            Buscar(textBuscar.Text.Trim());
        }
        bool insertar()
        {
            bool rpt = false;
            try
            {
                Modelos_profesores profesor = new Modelos_profesores()
                {
                    id = Convert.ToInt32(textid.Text.Trim()),
                    nombre = textnombre.Text.Trim(),
                    apellido = textapellido.Text.Trim(),
                    especialidad = textespecialidad.Text.Trim(),
                    celular = textcelular.Text.Trim()


                };
                string r = new controlador_profesores().Insertar(profesor);
                rpt = r.Equals("Ok") ? true : false;
            }
            catch (Exception)
            { rpt = false; }
            return rpt;
        }

        public void Buscar(string texto)
        {
           dataprofesores.DataSource = new controlador_profesores().Buscar(texto);
            dataprofesores.Refresh();
            utilidades.Dtctualizar(dataprofesores);
            habilitarcampos(true);
            try
            {
                if (dataprofesores.Columns.Count > 0)
                {
                    dataprofesores.Columns[2].Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }



        }
        void habilitarcampos(bool valor)
        {
            textid.Enabled=false;
            textnombre.Enabled = valor;
            textapellido.Enabled = valor;
            textespecialidad.Enabled = valor;
            textcelular.Enabled = valor;


        }

        void limpiarcampos()
        {
            textid.Clear();
            textnombre.Clear();
            textapellido.Clear();
            textespecialidad.Clear();
            textcelular.Clear();
        }
        private void Form_profesores_Load(object sender, EventArgs e)
        {
            Buscar(textBuscar.Text.Trim());
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(textBuscar.Text.Trim());
        }

        private void dataprofesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textid.Text = dataprofesores.CurrentRow.Cells["Id"].Value.ToString();
                textnombre.Text = dataprofesores.CurrentRow.Cells["Nombre"].Value.ToString();
                textapellido.Text = dataprofesores.CurrentRow.Cells["Apellido"].Value.ToString();   
                textespecialidad.Text = dataprofesores.CurrentRow.Cells["Especialidad"].Value.ToString();
                textcelular.Text = dataprofesores.CurrentRow.Cells["Celular"].Value.ToString();
            }
            catch (Exception)
            {
                throw;

            }
        }
        private void bnuevo_Click(object sender, EventArgs e)
        {
            panel_textbox.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (insertar())
                {
                    utilidades.Mensaje(Convert.ToInt32(textid.Text) == 0 ? "Registro insertado correctamente." :
                     "Registro actualizado correctamente.");
                    Buscar(textBuscar.Text.Trim());
                    limpiarcampos();
                    habilitarcampos(false);
                }
                else
                {
                    utilidades.Mensaje("Ocurrieron problemas al insertar Profesores.");
                }
            }
            catch (Exception )
            {
                
                throw;
            }
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            panel_textbox.Visible=false;
        }
        void eliminar(Int32 Id)
        {
            string rpt;
            Modelos_profesores prof = new Modelos_profesores()
            {
                id = Id
            };
            rpt = new controlador_profesores().Eliminar(prof);

            if (rpt.Equals("Ok"))
            {
                utilidades.Mensaje("Registro eliminado correctamente.");
                Buscar(textBuscar.Text.Trim());
            }
            else
            {
                utilidades.Mensaje("Ocurrieron problemas al eliminar el registro.");
            }
        }
        private void dataprofesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                result = MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    eliminar(Convert.ToInt32(dataprofesores.CurrentRow.Cells["Id"].Value));
                }
            }
            if (e.ColumnIndex == 1)
            {
                habilitarcampos(true);
                textid.Text = dataprofesores.CurrentRow.Cells["Id"].Value.ToString();
                textnombre.Text = dataprofesores.CurrentRow.Cells["Nombre"].Value.ToString();
                textapellido.Text = dataprofesores.CurrentRow.Cells["Apellido"].Value.ToString();
                textespecialidad.Text = dataprofesores.CurrentRow.Cells["Especialidad"].Value.ToString();
                textcelular.Text = dataprofesores.CurrentRow.Cells["Celular"].Value.ToString();
            }
        }
    }
}
