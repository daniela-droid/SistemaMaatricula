using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Matricula.Modelos;

namespace Sistema_Matricula.Controladores
{
    class Controlador_Reporte
    {

        public DataTable VerMatriculas()
        {

            DataTable rpt = new DataTable();
            try
            {
               using (SqlConnection sqlcon = new SqlConnection(conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand("rep_matriculas_general", sqlcon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                   }
                 }
            catch (Exception ex)
            {
                rpt = null;
                throw;


            }
            return rpt;
        }
        public DataTable verEstudiantes()
        {
            DataTable rpt = new DataTable();
            try

            { using (SqlConnection sqlcon = new SqlConnection(conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand("rep_Estudiante", sqlcon);
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                         SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(rpt); //debes invocar a rpt no dt
                        return rpt;

                    }
                }
            }
            catch (Exception ex)
            {
                rpt = null;
                throw;
            }
            return rpt;
        }

        public DataTable verestudianteporgrupo()
        {
            DataTable rpt = new DataTable();
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand("rep_estudiante_por_grupo", sqlcon);
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(rpt);
                        return rpt;
                    }
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
