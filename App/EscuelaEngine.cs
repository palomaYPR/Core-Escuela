using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public EscuelaEngine(Escuela escuela)
        {
            this.Escuela = escuela;

        }
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                        ciudad: "Bogotá", pais: "Colombia"
                        );
            // comment
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            Random rnd = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var alum in curso.Alumnos)
                {
                    alum.evaluacion = new List<Evaluaciones>();                    

                    foreach (var asig in curso.Asignaturas)
                    {

                        for (int i = 0; i < 5; i++)
                        {                               
                            var evaluacion = new Evaluaciones
                            {
                                Nombre = asig.Nombre,
                                Alumno = alum,
                                Asignatura = asig,
                                Nota = (float)rnd.NextDouble()*5                                
                            };                              
                            
                            System.Console.WriteLine($"Evaluación N°{i+1} de: {evaluacion.Nombre} Alumno: {evaluacion.Alumno.Nombre} Asignatura: {evaluacion.Asignatura.Nombre} Nota: {evaluacion.Nota}");

                            alum.evaluacion.Add(evaluacion);
                        }
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{Nombre="Matematicas"},
                    new Asignatura{Nombre="Español"},
                    new Asignatura{Nombre="Geografía"},
                    new Asignatura{Nombre="Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a}" };
            return listaAlumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                        new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana },
                        new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana},
                        new Curso{Nombre = "301", Jornada = TiposJornada.Mañana},
                        new Curso(){ Nombre = "401", Jornada = TiposJornada.Mañana },
                        new Curso() {Nombre = "501", Jornada = TiposJornada.Mañana},
                        new Curso{Nombre = "501", Jornada = TiposJornada.Tarde}
            };

            Random rnd = new Random();

            foreach (var c in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 30);
                c.Alumnos = GenerarAlumnosAlAzar(cantRandom);
            }
        }
    }
}