using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Escuela
{
    public class Profesor : Persona
    {
        public List<Curso> Cursos { get; set; }

        public Profesor(string nombre) : base(nombre)
        {
            Cursos = new List<Curso>();
        }

        public void AgregarCurso(Curso curso)
        {
            Cursos.Add(curso);
        }
    }
}

