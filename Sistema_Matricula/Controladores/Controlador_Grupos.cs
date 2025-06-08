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
    public class Controlador_Grupos
    {
        public string Insertar(Modelos_grupos grupos)
        {
            string rpt = "";

            try
            {
                string Query = grupos.id == 0 ? "grupos_insertar" :
                    "grupos_actualizar";

                using (SqlConnection sqlcon = new SqlConnection(conexion.cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        if (grupos.id > 0)
                        {
                            cmd.Parameters.AddWithValue("@id", grupos.id);
                        }

                        cmd.Parameters.AddWithValue("@NombreGrupo", grupos.NombreGrupo);
                        cmd.Parameters.AddWithValue("@DiaSemana", grupos.DiaSemana);
                        cmd.Parameters.AddWithValue("@Horario", grupos.Horario);
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


        public string Eliminar(Modelos_grupos id)
        {
            string rpt = "";
            try
            {
                string Query = "grupo_eliminar";
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
            }catch (Exception ex) 
            {
                rpt = ex.Message;
                
                throw; }
            return rpt;
        
           
        }


        public DataTable Buscar(string Texto)
        {

            DataTable rpt = new DataTable();
            try
            {
                string Query = "grupo_buscar";
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