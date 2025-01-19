using System;

namespace Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear la escuela
            Escuela escuela = new Escuela();

            // Crear la primera clase
            Clase claseMatematicas = new Clase("Matemáticas");

            // Estudiantes para Matemáticas
            Estudiante estudiante1 = new Estudiante("Juan Pérez", 1);
            Estudiante estudiante2 = new Estudiante("María López", 2);
            Estudiante estudiante3 = new Estudiante("Pedro Martínez", 3);

            // Profesor para Matemáticas
            Profesor profesorMatematicas = new Profesor("Carlos Rodríguez");
            Curso cursoAlgebra = new Curso("Álgebra", 5, 20);
            Curso cursoGeometria = new Curso("Geometría", 4, 15);

            profesorMatematicas.AgregarCurso(cursoAlgebra);
            profesorMatematicas.AgregarCurso(cursoGeometria);

            // Agregar estudiantes y profesor a la clase de Matemáticas
            claseMatematicas.AgregarEstudiante(estudiante1);
            claseMatematicas.AgregarEstudiante(estudiante2);
            claseMatematicas.AgregarEstudiante(estudiante3);
            claseMatematicas.AgregarProfesor(profesorMatematicas);

            // Crear la segunda clase
            Clase claseCiencias = new Clase("Ciencias");

            // Estudiantes para Ciencias
            Estudiante estudiante4 = new Estudiante("Ana García", 4);
            Estudiante estudiante5 = new Estudiante("Luis Fernández", 5);

            // Profesor para Ciencias
            Profesor profesorCiencias = new Profesor("Laura Gómez");
            Curso cursoBiologia = new Curso("Biología", 3, 10);
            Curso cursoFisica = new Curso("Física", 6, 25);

            profesorCiencias.AgregarCurso(cursoBiologia);
            profesorCiencias.AgregarCurso(cursoFisica);

            // Agregar estudiantes y profesor a la clase de Ciencias
            claseCiencias.AgregarEstudiante(estudiante4);
            claseCiencias.AgregarEstudiante(estudiante5);
            claseCiencias.AgregarProfesor(profesorCiencias);

            // Crear una tercera clase
            Clase claseHistoria = new Clase("Historia");

            // Estudiantes para Historia
            Estudiante estudiante6 = new Estudiante("Sofía Torres", 6);
            Estudiante estudiante7 = new Estudiante("David Ruiz", 7);

            // Profesor para Historia
            Profesor profesorHistoria = new Profesor("Fernando Ramírez");
            Curso cursoHistoriaUniversal = new Curso("Historia Universal", 4, 18);
            Curso cursoHistoriaModerna = new Curso("Historia Moderna", 2, 12);

            profesorHistoria.AgregarCurso(cursoHistoriaUniversal);
            profesorHistoria.AgregarCurso(cursoHistoriaModerna);

            // Agregar estudiantes y profesor a la clase de Historia
            claseHistoria.AgregarEstudiante(estudiante6);
            claseHistoria.AgregarEstudiante(estudiante7);
            claseHistoria.AgregarProfesor(profesorHistoria);

            // Agregar las clases a la escuela
            escuela.AgregarClase(claseMatematicas);
            escuela.AgregarClase(claseCiencias);
            escuela.AgregarClase(claseHistoria);

            // Imprimir información de la escuela
            Console.WriteLine("Clases en la escuela:");
            foreach (var clase in escuela.Clases)
            {
                Console.WriteLine($"Clase: {clase.Identificador}");
                Console.WriteLine("Estudiantes:");
                foreach (var estudiante in clase.Estudiantes)
                {
                    Console.WriteLine($"- {estudiante.Nombre} (ID: {estudiante.NumeroUnico})");
                }
                Console.WriteLine("Profesores:");
                foreach (var profesor in clase.Profesores)
                {
                    Console.WriteLine($"- {profesor.Nombre}");
                    Console.WriteLine("  Cursos:");
                    foreach (var curso in profesor.Cursos)
                    {
                        Console.WriteLine($"    - {curso.Nombre} (Clases: {curso.RecuentoClases}, Ejercicios: {curso.RecuentoEjercicios})");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
