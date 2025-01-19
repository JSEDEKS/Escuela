using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Escuela
{
    public class Clase
    {
        public string Identificador { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public List<Profesor> Profesores { get; set; }

        public Clase(string identificador)
        {
            Identificador = identificador;
            Estudiantes = new List<Estudiante>();
            Profesores = new List<Profesor>();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
        }
    }
}

