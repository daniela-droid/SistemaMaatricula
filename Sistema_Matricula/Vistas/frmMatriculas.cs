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
    public partial class frmMatriculas: Form
    {
        public frmMatriculas()
        {
            InitializeComponent();
          
            verestudiante();
            actualizarestudiante = true;
            verGrupo();
            actualizargrupo = true;
            verdiasemana();
           
            veresturno();

            Buscar(" ");
        }
        bool insertar()
        {
            bool rpt = false;
            try
            {
                Modelos_Matriculados matriculados = new Modelos_Matriculados()
                {
                    // este puedes omitir si el ID es autoincremental
                 
                    id =string.IsNullOrWhiteSpace(texid.Text) ? 0 :  Convert.ToInt32(texid.Text), // para update
                    id_estudiante = Convert.ToInt32(combEstudiante.SelectedValue),  
                    id_grupo = Convert.ToInt32(comGrupo.SelectedValue),           
                    Anio = textanio.Text.Trim()
                };

                string r = new control_Matricula().Insertar(matriculados);
                rpt = r.Equals("Ok");
            }
            catch (Exception)
            {
                rpt = false;
            }

            return rpt;
        }
        void Buscar(string Texto)
        {
            datamatriculas.DataSource = new control_Matricula().Buscar(Texto);
            datamatriculas.Refresh();
            utilidades.Dtctualizar(datamatriculas);
            habilitarcampos(true);
            try
            {
                if (datamatriculas.Columns.Count > 0)
                {
                    datamatriculas.Columns[2].Visible = false;
                    datamatriculas.Columns[3].Visible = true;
                    datamatriculas.Columns[5].Visible = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        void habilitarcampos(bool valor)
        {
            texid.Enabled = false;
            //comboidestud.Enabled = false;
            combEstudiante.Enabled = valor;
           // comboidG.Enabled = false;
            comGrupo.Enabled = valor;
            comDiaSemana.Enabled = valor;
            comoTurno.Enabled = valor;
            textanio.Enabled = valor;
        }
        void limpiarcampos()
        {
            texid.Clear();
            combEstudiante.SelectedItem = 1;
            comGrupo.SelectedItem = 1;
            comDiaSemana.SelectedItem = 1;
            comoTurno.SelectedItem = 1;
            textanio.Clear();
           // comboidG.Items.Clear();
           // comboidestud.Items.Clear(); 
        }
        private void frmMatriculas_Load(object sender, EventArgs e)
        {
            Buscar(textBuscar.Text.Trim());
           

        }

        private void button_Click(object sender, EventArgs e)
        {
            p_textos.Visible = true;
            habilitarcampos(true);
            //BOTON NUEVO
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            if (insertar())
            {

           
                if (combEstudiante.SelectedValue == null || comGrupo.SelectedValue == null)
                {
                    MessageBox.Show("Selecciona un estudiante y un grupo válido.");
                    return;
                }
                utilidades.Mensaje(Convert.ToInt32(texid.Text) == 0 ? "Matriculado Con Exito.":
                    "Actualizado Correctamente.");
                Buscar(textBuscar.Text.Trim());
                datamatriculas.Refresh();
                limpiarcampos();
                habilitarcampos(false);
            }
            else
            {
                utilidades.Mensaje("Ocurrieron problemas al Matricular.");
            }
         }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            p_textos.Visible = false;
        }
        //estudiante llamar en combobox
        void verestudiante()
        {
            combEstudiante.DataSource = new control_estudiantes().buscar("");
            combEstudiante.Refresh();

            combEstudiante.DisplayMember = "nombre";
            combEstudiante.ValueMember = "id";
        }

        public static bool actualizarestudiante= false;
        void verGrupo()
        {
            comGrupo.DataSource = new Controlador_Grupos().Buscar("");
            comGrupo.Refresh();

            comGrupo.DisplayMember = "NombreGrupo";
            comGrupo.ValueMember = "id";

        }
        public static bool actualizargrupo = false;
        void verdiasemana()
        {
            comDiaSemana.DataSource = new Controlador_Grupos().Buscar("");
            comDiaSemana.Refresh();
            comDiaSemana.DisplayMember = "DiaSemana"; // Lo que se muestra
            comGrupo.ValueMember = "Id";

        }
        public static bool actualizardia = false;
        void veresturno()
        {
            comoTurno.DataSource = new Controlador_Grupos().Buscar("");
            comoTurno.Refresh();

            comoTurno.DisplayMember = "Horario"; // Lo que se muestra
            comGrupo.ValueMember = "Id";

        }
        public static bool actualizarturno = false;
        private void dataMatriculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void datamatriculas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                texid.Text = datamatriculas.CurrentRow.Cells["Id"].Value.ToString();
               // comboidestud.Text = datamatriculas.CurrentRow.Cells["id_estudiante"].Value.ToString();
               // comboidG.Text = datamatriculas.CurrentRow.Cells["id_grupo"].Value.ToString();
                textanio.Text = datamatriculas.CurrentRow.Cells["Anio"].Value.ToString();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(textBuscar.Text.Trim());
        }
         void eliminar(Int32 Id)
        {
            string rpt;
           Modelos_Matriculados matri= new Modelos_Matriculados()
            {
                id = Id
            };
            rpt = new control_Matricula().Eliminar(matri);

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
        private void datamatriculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                result = MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    eliminar(Convert.ToInt32(datamatriculas.CurrentRow.Cells["Id"].Value));
                }

            }
            if (e.ColumnIndex == 1)
            {
                habilitarcampos(true);
                texid.Text = datamatriculas.CurrentRow.Cells["Id"].Value.ToString();
              //  comboidestud.Text = datamatriculas.CurrentRow.Cells["id_estudiante"].Value.ToString();
               // comboidG.Text = datamatriculas.CurrentRow.Cells["id_grupo"].Value.ToString();
                textanio.Text = datamatriculas.CurrentRow.Cells["Anio"].Value.ToString();



            }




        }
    }
}
