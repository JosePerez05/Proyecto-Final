using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Carrera> Carrera { get; set; }

    }
}

