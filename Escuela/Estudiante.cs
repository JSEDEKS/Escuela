using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    public class Estudiante : Persona
    {
        public int NumeroUnico { get; set; }

        public Estudiante(string nombre, int numeroUnico) : base(nombre)
        {
            NumeroUnico = numeroUnico;
        }
    }
}

