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
using Sistema_Matricula.Modelos;
using Sistema_Matricula.Controladores;
using DevExpress.Utils.Extensions;

namespace Sistema_Matricula.Vistas { 

public partial class frmestudiantes : Form
{
    public frmestudiantes()
    {
        InitializeComponent();
        Buscar(textBox1.Text.Trim());

    }

    bool insertar()
    {
        bool rpt = false;
        try
        {
                modelo_estudiantes estudiante = new modelo_estudiantes()
                {
                    id = Convert.ToInt32(texid.Text.Trim()),
                    nombre = textnombre.Text.Trim(),
                    apellido = textapellido.Text.Trim(),
                    sexo = combsexo.Text.Trim(),
                    cedula = textcedula.Text.Trim(),
                    edad = Convert.ToInt32(textedad.Text.Trim()),
                    Celular = Convert.ToInt32(textcelular.Text.Trim()),
                    nombre_madre=texnombreMadre.Text.Trim(),    
                    nombre_padre=textnombrePadre.Text.Trim(),
                    comarca=textcomarca.Text.Trim()


                };
            string r = new control_estudiantes().Insertar(estudiante);
            rpt = r.Equals("Ok") ? true : false; 
        }
        catch (Exception) 
            { rpt = false; }
        return rpt;
    }

    public void Buscar(string texto)
    {
        dataalumno.DataSource = new control_estudiantes().buscar(texto);
        dataalumno.Refresh();
        utilidades.Dtctualizar(dataalumno); 
        habilitarcampos(true);
        try
        {
            if (dataalumno.Columns.Count > 0)
            {
                dataalumno.Columns[2].Visible = false;
            }
        }
        catch (Exception)
        {

            throw;
        }



    }

    void eliminar (Int32 Id)
        {
            string rpt;
            modelo_estudiantes estudiante = new modelo_estudiantes()
            {
                id = Id
            };
            rpt = new control_estudiantes().eliminar(estudiante);

            if (rpt.Equals("Ok"))
            {
                utilidades.Mensaje("Registro eliminado correctamente.");
                Buscar(textBox1.Text.Trim());
            }
            else
            {
                utilidades.Mensaje("Ocurrieron problemas al eliminar el registro.");
            }
        }



    void limpiarcampos()
    {
        textnombre.Clear();
        textapellido.Clear();
        combsexo.Text = "F";
        textcedula.Clear();
        textedad.Clear();
        textcelular.Clear();
        texnombreMadre.Clear();
        textnombrePadre.Clear();
        textcomarca.Clear();
    }
    void habilitarcampos(bool valor)
    {
        texid.Enabled = false;
        textnombre.Enabled = valor;
        textapellido.Enabled = valor;
        combsexo.Enabled = valor;
        textcedula.Enabled = valor;
        textedad.Enabled = valor;
        textcelular.Enabled = valor;
        texnombreMadre.Enabled = valor;
        textnombrePadre.Enabled = valor;
        textcomarca.Enabled = valor;    
        }

    private void button2_Click(object sender, EventArgs e)
    {
      
    }

    private void frmestudiantes_Load(object sender, EventArgs e)
    {
        // TODO: esta línea de código carga datos en la tabla 'matriculasDataSet.Estudiantes' Puede moverla o quitarla según sea necesario.
      

    }

    private void buttguardar_Click(object sender, EventArgs e)
    {
        if (insertar())
        {
        utilidades.Mensaje(Convert.ToInt32(texid.Text) == 0 ?"Registro insertado correctamente." :
         "Registro actualizado correctamente.");
         Buscar(textBox1.Text.Trim());
         limpiarcampos();
         habilitarcampos(false);
        }else
         {
                utilidades.Mensaje("Ocurrieron problemas al insertar Estudiante.");
         }
    }

    private void buttcancelar_Click(object sender, EventArgs e)
    {
            panel_textos.Visible = false;
            //dataalumno.Dock = DockStyle.Fill;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
            Buscar(textBox1.Text.Trim());
            //dataalumno.Dock = DockStyle.Bottom;
        }

    private void dataalumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
                texid.Text = dataalumno.CurrentRow.Cells["Id"].Value.ToString();
                textnombre.Text = dataalumno.CurrentRow.Cells["Nombre"].Value.ToString();
                textapellido.Text = dataalumno.CurrentRow.Cells["Apellido"].Value.ToString();
                combsexo.Text = dataalumno.CurrentRow.Cells["Sexo"].Value.ToString();
                textcedula.Text = dataalumno.CurrentRow.Cells["Cedula"].Value.ToString();
                textedad.Text = dataalumno.CurrentRow.Cells["Edad"].Value.ToString();
                textcelular.Text = dataalumno.CurrentRow.Cells["Celular"].Value.ToString();
                texnombreMadre.Text = dataalumno.CurrentRow.Cells["Nombre_de_la_Madre"].Value.ToString();
                textnombrePadre.Text = dataalumno.CurrentRow.Cells["Nombre_del_Padre"].Value.ToString();
                textcomarca.Text = dataalumno.CurrentRow.Cells["Comarca"].Value.ToString();
            }
        catch (Exception) { throw; }
    }
        //boton nuevo
        private void button1_Click(object sender, EventArgs e)
        {
            panel_textos.Visible = true;
            limpiarcampos();

            habilitarcampos(true);
        }

        private void dataalumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                result = MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    eliminar(Convert.ToInt32(dataalumno.CurrentRow.Cells["Id"].Value));
                }
            }
            if (e.ColumnIndex == 1)
            {
                habilitarcampos(true);
                texid.Text = dataalumno.CurrentRow.Cells["Id"].Value.ToString();
                textnombre.Text = dataalumno.CurrentRow.Cells["Nombre"].Value.ToString();
                textapellido.Text = dataalumno.CurrentRow.Cells["Apellido"].Value.ToString();
                combsexo.Text = dataalumno.CurrentRow.Cells["Sexo"].Value.ToString();
                textcedula.Text = dataalumno.CurrentRow.Cells["Cedula"].Value.ToString();
                textedad.Text = dataalumno.CurrentRow.Cells["Edad"].Value.ToString();
                textcelular.Text = dataalumno.CurrentRow.Cells["Celular"].Value.ToString();
                texnombreMadre.Text = dataalumno.CurrentRow.Cells["Nombre_de_la_Madre"].Value.ToString();
                textnombrePadre.Text = dataalumno.CurrentRow.Cells["Nombre_del_Padre"].Value.ToString();
                textcomarca.Text = dataalumno.CurrentRow.Cells["Comarca"].Value.ToString();
            }
        }

        private void textcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelbuscar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
