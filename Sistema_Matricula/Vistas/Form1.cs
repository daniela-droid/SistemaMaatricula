using DevExpress.CodeParser;
using Sistema_Matricula.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Matricula.Vistas;
using Sistema_Matricula.Controladores;


namespace Sistema_Matricula
{
    public partial class Form1 : Form
    {
        string FORMbuscador = " ";
        frmestudiantes Estudiantes;
        frmGrupos Grupos;
        frmMatriculas Matriculas;
        Form_profesores profesor;
        Form_Reportes reportes;
       
        public Form1()
        {
           
            InitializeComponent();

            Estudiantes = new frmestudiantes();
            Grupos = new frmGrupos();
            profesor = new Form_profesores();
           
        }
        // If(FORMbuscador == "Estudiantes") Estudiantes.buscar();

      
      
        

       
        private void button1_Click(object sender, EventArgs e)
        {
            panel_lado.Visible = false;
            AbrirFormulario(new fromulario_descripcion());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_lado.Visible = true;
           AbrirFormulario(new fromulario_descripcion());
        }

        private void panel_lado_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_login login = new Form_login();
            login.Close();
        }
        void AbrirFormulario(Form nuevoFormulario)
        {
            if (nuevoFormulario != null)
            {
                nuevoFormulario.TopLevel = false;
                nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
                nuevoFormulario.Dock = DockStyle.Fill;

                // Revisamos si ya existe un formulario del mismo tipo
                foreach (Control control in panel_formularios.Controls)
                {
                    if (control is Form formularioExistente &&
                        formularioExistente.GetType() == nuevoFormulario.GetType())
                    {
                        formularioExistente.BringToFront();
                        return; // Ya está, no se agrega de nuevo
                    }
                }

                panel_formularios.Controls.Add(nuevoFormulario);
                nuevoFormulario.BringToFront();
                nuevoFormulario.Show();
            }
        }
        private void button_estudiante_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmestudiantes());
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        //boton grupos
        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmGrupos());
        }

        private void button_reportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form_Reportes());
        }

        private void buttonProfesor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form_profesores());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_matriculas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmMatriculas());
        }
    }
}
