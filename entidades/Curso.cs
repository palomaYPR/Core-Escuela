using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public Curso(string uniqueId, string nombre, TiposJornada jornada) 
        {
            this.UniqueId = uniqueId;
                this.Nombre = nombre;
                this.Jornada = jornada;
               
        }
                public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Curso()=> UniqueId = Guid.NewGuid().ToString();
        
    }
}