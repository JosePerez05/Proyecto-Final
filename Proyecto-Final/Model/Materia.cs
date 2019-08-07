using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Materia
    {
        public int MateriaId { get; set; }
        public string Nombre { get; set; }
        public int CantCre { get; set; }
        public int ProfesorForeingKey { get; set; }
        public Profesor Profesor { get; set; }
        public List<Secciones> Secciones { get; set; }
    }
}

