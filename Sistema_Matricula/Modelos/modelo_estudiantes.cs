using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Matricula.Modelos
{
   public  class modelo_estudiantes
    {
      public int id{ get; set; }
       
       public string nombre { get; set; }
        public string apellido { get; set; }

        public string sexo { get; set; }
        public string cedula { get; set; }
        public int edad {  get; set; }  
        public int Celular { get; set; }    
        public string nombre_madre { get; set; }
        public string nombre_padre  { get; set; }
        public string comarca   { get; set; }

    }
}
//Edad int not null default 0,
//Celular int not null default 0,
//Nombre_de_la_Madre nvarchar(25),
//Nombre_del_Padre nvarchar (25),
//Comarca nvarchar (25);