using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace Escuela
{
    public class Escuela
    {
        public List<Clase> Clases { get; set; }

        public Escuela()
        {
            Clases = new List<Clase>();
        }

        public void AgregarClase(Clase clase)
        {
            Clases.Add(clase);
        }
    }
}

