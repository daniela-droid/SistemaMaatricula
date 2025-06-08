using Sistema_Matricula.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Matricula.Controladores
{
   public class controlador_profesores
    {
        public string Insertar(Modelos_profesores profesor)

        {
            string rpt = "";

            try
            {
                string Query = profesor.id == 0 ? "profesor_insertar" :
                    "profesor_actualizar";

                using (SqlConnection sqlcon = new SqlConnection(conexion.cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        if (profesor.id > 0)
                        {
                            cmd.Parameters.AddWithValue("@id", profesor.id);
                        }

                        cmd.Parameters.AddWithValue("@Nombre", profesor.nombre);
                        cmd.Parameters.AddWithValue("@Apellido", profesor.apellido);
                        cmd.Parameters.AddWithValue("@Especialidad", profesor.especialidad);
                        cmd.Parameters.AddWithValue("@Celular", profesor.celular);
                        cmd.ExecuteNonQuery();
                        rpt = "Ok";
                    }

                    sqlcon.Dispose();
                }

            }
            catch (Exception ex)
            {
                rpt = ex.Message;
                throw;

            }
            return rpt;


        }

        public string Eliminar(Modelos_profesores id)
        {
            string rpt = "";
            try
            {
                string Query = "profesor_eliminar";
                using (SqlConnection sqlcon = new SqlConnection(conexion.cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id.id);
                        cmd.ExecuteNonQuery();
                        rpt = "Ok";
                    }
                    sqlcon.Dispose();
                }
            }
            catch (Exception ex)
            {
                rpt = ex.Message;

                throw;
            }
            return rpt;


        }


        public DataTable Buscar(string Texto)
        {

            DataTable rpt = new DataTable();
            try
            {
                string Query = "profesor_buscar";
                using (SqlConnection sqlcon = new SqlConnection(conexion.cn))
                {

                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@textobuscar", Texto);
                        SqlDataAdapter sqldt = new SqlDataAdapter(cmd);
                        sqldt.Fill(rpt);

                    }
                    sqlcon.Dispose();
                }

            }
            catch (Exception ex)
            {
                rpt = null;
                throw;


            }
            return rpt;
        }








    }
}
