using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Matricula.Controladores
{
    public class Control_login
    {
        public static bool ValidarLogin(string usuario, string clave)
        {
            using (SqlConnection sqlcon = new SqlConnection(conexion.cn))
            {
                sqlcon.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Clave = @Clave";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Clave", clave);

                int count = (int)cmd.ExecuteScalar();
                return count >= 1;
            }
        }


    }
}
