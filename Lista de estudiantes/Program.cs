using System;
using System.Collections.Generic;

class Program
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public int Calificacion { get; set; }

        public Estudiante(string nombre, int calificacion)
        {
            Nombre = nombre;
            Calificacion = calificacion;
        }
    }

    static List<Estudiante> estudiantes = new List<Estudiante>();

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- Gestión de Estudiantes ---");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Eliminar estudiante");
            Console.WriteLine("3. Mostrar lista de estudiantes");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarEstudiante();
                    break;
                case 2:
                    EliminarEstudiante();
                    break;
                case 3:
                    MostrarEstudiantes();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 0);
    }

    static void AgregarEstudiante()
    {
        Console.Write("Nombre del estudiante: ");
        string nombre = Console.ReadLine();
        Console.Write("Calificación del estudiante: ");
        int calificacion = int.Parse(Console.ReadLine());
        estudiantes.Add(new Estudiante(nombre, calificacion));
        Console.WriteLine("Estudiante agregado.");
    }

    static void EliminarEstudiante()
    {
        Console.Write("Nombre del estudiante a eliminar: ");
        string nombre = Console.ReadLine();
        estudiantes.RemoveAll(e => e.Nombre == nombre);
        Console.WriteLine("Estudiante eliminado.");
    }

    static void MostrarEstudiantes()
    {
        Console.WriteLine("\nLista de estudiantes:");
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Calificación: {estudiante.Calificacion}");
        }
    }
}
