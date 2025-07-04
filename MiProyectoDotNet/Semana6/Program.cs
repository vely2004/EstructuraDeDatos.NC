using System;
using Semana6; // Importamos el namespace donde están las clases

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SEMANA 6 ===");
        Console.WriteLine("1. Invertir lista de enteros");
        Console.WriteLine("2. Manejar lista de estudiantes");
        Console.Write("Seleccione una opción (1-2): ");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                EjecutarListaInvertida();
                break;
            case "2":
                EjecutarListaEstudiantes();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    static void EjecutarListaInvertida()
    {
        var lista = new ListaInvertida();

        Console.Write("¿Cuántos elementos deseas agregar?: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidad))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el valor #{i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                lista.Agregar(valor);
            }
            else
            {
                Console.WriteLine("Valor inválido, se omitirá.");
            }
        }

        Console.WriteLine("\nLista original:");
        lista.Mostrar();

        lista.Invertir();

        Console.WriteLine("Lista invertida:");
        lista.Mostrar();
    }

    static void EjecutarListaEstudiantes()
    {
        var lista = new ListaEstudiantes();

        Console.Write("¿Cuántos estudiantes deseas ingresar?: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidad))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"\nEstudiante #{i + 1}:");

            Console.Write("Cédula: ");
            string cedula = Console.ReadLine();

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Correo: ");
            string correo = Console.ReadLine();

            Console.Write("Nota: ");
            if (!float.TryParse(Console.ReadLine(), out float nota))
            {
                Console.WriteLine("Nota inválida. Se registrará como 0.");
                nota = 0;
            }

            var estudiante = new Estudiante(cedula, nombre, apellido, correo, nota);
            lista.Agregar(estudiante);
        }

        Console.WriteLine("\nLista de estudiantes:");
        lista.Mostrar();

        lista.Contar(out int aprobados, out int reprobados);
        Console.WriteLine($"\nAprobados: {aprobados} | Reprobados: {reprobados}");
    }
}
