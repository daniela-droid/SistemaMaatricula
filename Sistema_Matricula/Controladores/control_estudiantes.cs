using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.CodeParser;
using Sistema_Matricula.Modelos;
using Sistema_Matricula.Vistas;


namespace Sistema_Matricula.Controladores
{
    public class control_estudiantes
    {

        public string Insertar(modelo_estudiantes estudiante)
        {
            string rpt = " ";
            try
            {
                string Query = estudiante.id == 0 ? "estudiante_insertar" : "estudiante_actualizar";
                using (SqlConnection sqlcon = new SqlConnection(conexion.cn))
                {
                    sqlcon.Open();  
                    using(SqlCommand cmd = new SqlCommand(Query,sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        if (estudiante.id > 0)
                        {
                            cmd.Parameters.AddWithValue("@Id", estudiante.id);
                        }
                        cmd.Parameters.AddWithValue("@Nombre", estudiante.nombre);
                        cmd.Parameters.AddWithValue("@Apellido", estudiante.apellido);
                        cmd.Parameters.AddWithValue("@Sexo", estudiante.sexo);
                        cmd.Parameters.AddWithValue("@Cedula", estudiante.cedula);
                        cmd.Parameters.AddWithValue("@Edad", estudiante.edad);
                        cmd.Parameters.AddWithValue("@Celular",estudiante.Celular);
                        cmd.Parameters.AddWithValue("@Nombre_de_la_Madre",estudiante.nombre_madre);
                        cmd.Parameters.AddWithValue("@Nombre_del_padre",estudiante.nombre_padre);
                        cmd.Parameters.AddWithValue("@Comarca", estudiante.comarca);
                        cmd.ExecuteNonQuery();
                        rpt = "Ok";
                        //Edad int not null default 0,
                        //Celular int not null default 0,
                        //Nombre_de_la_Madre nvarchar(25),
                        //Nombre_del_Padre nvarchar (25),
                        //Comarca nvarchar (25);
                    }
                    sqlcon.Dispose();
                }

            }
            catch (Exception ex)
            { rpt = ex.Message;throw; }
            return rpt;

        }



        public string eliminar(modelo_estudiantes estudiantes)
        {

            string rpt = " ";
            try 
            {
                string Query = "estudiante_eliminar";
                using (SqlConnection sqlcon = new SqlConnection(conexion.cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", estudiantes.id);
                        cmd.ExecuteNonQuery();
                        rpt = "Ok";

                    }
                    sqlcon.Dispose();
                }
            }
            catch(Exception ex){ rpt = ex.Message; throw; }
            return rpt;
        }

        public DataTable buscar(string texto)
        {
            DataTable rpt = new DataTable();
            try
            {
                string Query = "estudiante_buscar";
                using (SqlConnection sqlcon = new SqlConnection(conexion.cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@textoBuscar", texto);
                        SqlDataAdapter sqldt = new SqlDataAdapter(cmd);
                        sqldt.Fill(rpt);



                    }
                    sqlcon.Dispose();
                }
            }
            catch (Exception ex) { rpt.Columns.Clear(); }
            return rpt;
        }
    }
}
