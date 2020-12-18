using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
         public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public List<Asignatura> Asignaturas { get; set; }

        public List<Evaluaciones> evaluacion { get; set; }
        public Alumno()=> UniqueId = Guid.NewGuid().ToString();
    }
}