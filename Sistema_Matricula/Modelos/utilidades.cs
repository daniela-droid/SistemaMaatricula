using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Matricula.Modelos
{
    public class utilidades
    {
        public static void Mensaje(string msj, bool IsError = false, string TITULO = "Matricula")
        {
            if (IsError)
            {
                MessageBox.Show(msj, TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show(msj, TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        public static void Dtctualizar(DataGridView dt)
        {
            dt.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(9);
            dt.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Tahoma"), 12, FontStyle.Regular);
            
            foreach (DataGridViewColumn col in dt.Columns)
            {

                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }


    }
}
