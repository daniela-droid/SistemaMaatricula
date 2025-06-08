using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Matricula.Controladores
{
    public class conexion
    {
      public static  string cn = "Data Source=DESKTOP-8IM4S7R\\SQLEXPRESS;Initial Catalog=Matriculas;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cn);
            // ¡NO abras aquí! El que la use debe abrirla
            return conexion;
        }
    }
}

//public static string Cn = "Data Source=DESKTOP-R42SMTR\\SQLEXPRESS;Initial Catalog=UNIVERSIDAD;Integrated Security=True;TrustServerCertificate=True";
//    }
//}