using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Profesor
    {
        public int ProfesorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido  { get; set; }
        public List<Materia> Materia { get; set; }

    }
}

