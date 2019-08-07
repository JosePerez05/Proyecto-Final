using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public  class Carrera
    {
        public int CarreraId { get; set; }
        public string Nombre { get; set; }
        public int EstudianteForeingKey{ get; set; }
        public Estudiante Estudiante { get; set; }

    }
}



