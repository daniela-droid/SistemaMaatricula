using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    //sqlcon.Open();
                    //using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    //{
                    //    cmd.CommandType = CommandType.StoredProcedure;
                    //    cmd.Parameters.AddWithValue("@textoBuscar", Texto);
                    //    using (SqlDataAdapter sqldt = new SqlDataAdapter(cmd))
                    //    {
                    //        sqldt.Fill(rpt);
                    //    }
                    //}
                    //sqlcon.Dispose();
                 
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







    }
}
