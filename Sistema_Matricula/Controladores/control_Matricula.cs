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
    public class control_Matricula
    {

        public string Insertar(Modelos_Matriculados matriculados)
        {
            string rpt = "";
            try
            {
                string Query = matriculados.id == 0 ? "Matricula_insertar" :
                    "matricula_actualizar";

                using (SqlConnection sqlcon = new SqlConnection(conexion.cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        if (matriculados.id > 0)
                        {
                            cmd.Parameters.AddWithValue("@id", matriculados.id);
                        }
    //                    
                        cmd.Parameters.AddWithValue("@id_estudiante", matriculados.id_estudiante);
                        cmd.Parameters.AddWithValue("@id_grupo", matriculados.id_grupo);
                        cmd.Parameters.AddWithValue("@Anio", matriculados.Anio);
                    
                        cmd.ExecuteNonQuery();
                        rpt = "Ok";
                    }
                    sqlcon.Dispose();



                }
            }
            catch (Exception ex)
            {
                utilidades.Mensaje("Error al insertar: " + ex.Message);
                throw;

            }
            return rpt;
        }


        public string Eliminar(Modelos_Matriculados id)
        {
            string rpt = "";
            try
            {
                string Query = "matricula_eliminar";
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
                string Query = "matricula_buscar";

                using (SqlConnection sqlcon = new SqlConnection(conexion.cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@textoBuscar", Texto);
                        using (SqlDataAdapter sqldt = new SqlDataAdapter(cmd))
                        {
                            sqldt.Fill(rpt);
                        }
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
