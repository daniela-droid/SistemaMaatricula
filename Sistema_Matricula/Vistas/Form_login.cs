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
    public partial class Form_login : Form
    {
       

        public Form_login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.UseSystemPasswordChar = true;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;

        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = texusuario.Text.Trim();
            string clave = textBox2.Text.Trim();
            textBox2.PasswordChar = '*';
            if (Control_login.ValidarLogin(usuario, clave))
            {
               
                // Abrir el formulario principal
                 new Form1().Show();
                 this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void texusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void xrRichText1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
