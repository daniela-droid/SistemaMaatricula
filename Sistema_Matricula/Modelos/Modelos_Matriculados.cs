using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Matricula.Modelos
{
   public class Modelos_Matriculados
    {

     public int id { get; set; }

     public int id_estudiante { get; set; }

     public string estudiante { get; set; }
     public int id_grupo { get; set; }

    public string grupo { get; set; }

    public string DiaSemana { get; set; }   

    public string Horario { get; set; }
    public string Anio { get; set; }
  // public DateTime  fechamatricula { get; set; }


    }
}
