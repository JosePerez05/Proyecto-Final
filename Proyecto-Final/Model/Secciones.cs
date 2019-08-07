using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Secciones
    {
        public int SeccionId { get; set; }
        public int MateriaForeingKey { get; set; }
        public string Aula { get; set; }
        public Materia Materia { get; set; }
    }
}

