using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Matricula.Modelos
{
    public class utilidades
    {

        public string Uusario { get; set; }
        public string password { get; set; }

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

        public static void ButtonsActualizados()
        {
            GraphicsPath GetFigurePath(Rectangle rect, int radius)
            {
                GraphicsPath path = new GraphicsPath();
                float curveSize = radius * 2F;
               
                path.StartFigure();
                path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
                path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
                path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
                path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
                path.CloseFigure();
                return path;
            }

        }
    }
}
