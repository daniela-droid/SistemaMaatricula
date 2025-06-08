using Sistema_Matricula.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Matricula.Modelos;

namespace Sistema_Matricula.Vistas
{
    public partial class frmGrupos: Form
    {
        public frmGrupos()
        {
            InitializeComponent();
            Buscar(textbuscar.Text.Trim());
             
        }

        public void Buscar(string Texto)
        {
            try
            {
                dataGrupos.DataSource = new Controladores.Controlador_Grupos().Buscar(Texto);   
                dataGrupos.Refresh();
                utilidades.Dtctualizar(dataGrupos);

               if (dataGrupos.Columns.Count > 0)
                {
                    dataGrupos.Columns[2].Visible = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool Insertar()
        {
            bool rpt = false;
            try
            {
                Modelos_grupos grupos = new Modelos_grupos()
                {
                    id = Convert.ToInt32(textid.Text.Trim()),
                    NombreGrupo = combogrupo.Text.Trim(),
                    DiaSemana = combodiasemana.Text.Trim(),
                    Horario = comboHorario.Text.Trim()

                };
                string r = new Controladores.Controlador_Grupos().Insertar(grupos);
                rpt = r.Equals("Ok") ? true : false;


            }
            catch (Exception )
            {
                rpt = false;

            }
            return rpt;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Buscar(textbuscar.Text.Trim());
        }
      void  limpiarcampos()
        {
            //textid.Clear();
            combogrupo.SelectedIndex = -1;
            combodiasemana.SelectedIndex = -1;
            comboHorario.SelectedIndex = -1;
        }

        void habilitarcampos(bool valor)
        {
            textid.Enabled = false;
            combogrupo.Enabled = valor;
            combodiasemana.Enabled = valor;
            comboHorario.Enabled = valor;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textid.Text = dataGrupos.CurrentRow.Cells["Id"].Value.ToString();
                combogrupo.Text = dataGrupos.CurrentRow.Cells["NombreGrupo"].Value.ToString();
                combodiasemana.Text = dataGrupos.CurrentRow.Cells["DiaSemana"].Value.ToString();
                comboHorario.Text = dataGrupos.CurrentRow.Cells["Horario"].Value.ToString();

            }

            catch (Exception)
            {
                throw;

            }
        }
        private void buttonnuevo_Click(object sender, EventArgs e)
        {
            habilitarcampos(true);
            panel_texbox.Visible = true;
        }

        void eliminar(Int32 Id)
        {
            string rpt;
            Modelos_grupos grupos = new Modelos_grupos()
            {
                id = Id
            };
            rpt = new Controladores.Controlador_Grupos().Eliminar(grupos);

            if (rpt.Equals("Ok"))
            {
                utilidades.Mensaje("Registro Eliminado Correctamente.");
                Buscar(textbuscar.Text);
            }
            else
            {
                utilidades.Mensaje("Ocurrieron errores al eliminar Estudiante.");
            }
        }



        private void guardar_Click(object sender, EventArgs e)
        {
            if (Insertar())
            {
                utilidades.Mensaje(Convert.ToInt32(textid.Text) == 0 ?
"Registro insertado Correctamente." : "Registro Actualizado Correctamente.");
                Buscar(textbuscar.Text.Trim());
                habilitarcampos(false);
                limpiarcampos();


            }
            else
            {
                utilidades.Mensaje("Ocurrieron errores al insertar Estudiante.");
            }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            panel_texbox.Visible = false;
        }

        private void frmGrupos_Load(object sender, EventArgs e)
        {
            Buscar("");
            limpiarcampos();
            habilitarcampos(false);
        }

        private void dataGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                result = MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    eliminar(Convert.ToInt32(dataGrupos.CurrentRow.Cells["Id"].Value));
                }
            } 
             if (e.ColumnIndex == 1)
             {
                    habilitarcampos(true);
                textid.Text = dataGrupos.CurrentRow.Cells["Id"].Value.ToString();
                combogrupo.Text = dataGrupos.CurrentRow.Cells["NombreGrupo"].Value.ToString();
                combodiasemana.Text = dataGrupos.CurrentRow.Cells["DiaSemana"].Value.ToString();
                comboHorario.Text = dataGrupos.CurrentRow.Cells["Horario"].Value.ToString();


             }
        }
    }
}
