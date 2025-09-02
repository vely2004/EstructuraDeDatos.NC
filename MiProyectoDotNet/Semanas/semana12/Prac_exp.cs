using System;
using System.Collections.Generic;
using System.Linq;

class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public string Codigo { get; set; }
    public int Año { get; set; }
    public bool Disponible { get; set; }

    public Libro(string titulo, string autor, string genero, string codigo, int año, bool disponible)
    {
        Titulo = titulo;
        Autor = autor;
        Genero = genero;
        Codigo = codigo;
        Año = año;
        Disponible = disponible;
    }
}

class Biblioteca
{
    // Diccionario principal: Código → Libro
    static Dictionary<string, Libro> BibliotecaLibros = new Dictionary<string, Libro>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n----- Biblioteca -----");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Buscar por título");
            Console.WriteLine("3. Buscar por autor");
            Console.WriteLine("4. Buscar por género");
            Console.WriteLine("5. Buscar por código o ID");
            Console.WriteLine("6. Buscar por año");
            Console.WriteLine("7. Mostrar todos los libros");
            Console.WriteLine("8. Eliminar libro");
            Console.WriteLine("9. Salir");
            Console.Write("Seleccione una opción (1-9): ");
            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": RegistrarLibro(); break;
                case "2": BuscarPorTitulo(); break;
                case "3": BuscarPorAutor(); break;
                case "4": BuscarPorGenero(); break;
                case "5": BuscarPorCodigo(); break;
                case "6": BuscarPorAño(); break;
                case "7": MostrarTodos(); break;
                case "8": EliminarLibro(); break;
                case "9": Console.WriteLine("Saliendo..."); return;
                default: Console.WriteLine("Opción no válida."); break;
            }
        }
    }

    static void RegistrarLibro()
    {
        Console.Write("Ingrese el código del libro: ");
        string? codigo = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(codigo))
        {
            Console.WriteLine("El código no puede estar vacío.");
            return;
        }

        if (BibliotecaLibros.ContainsKey(codigo))
        {
            Console.WriteLine("El libro con este código ya existe.");
            return;
        }

        Console.Write("Ingrese el título: ");
        string? titulo = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(titulo))
        {
            Console.WriteLine("El título no puede estar vacío.");
            return;
        }

        Console.Write("Ingrese el autor: ");
        string? autor = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(autor))
        {
            Console.WriteLine("El autor no puede estar vacío.");
            return;
        }

        Console.Write("Ingrese el género: ");
        string? genero = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(genero))
        {
            Console.WriteLine("El género no puede estar vacío.");
            return;
        }

        Console.Write("Ingrese el año de publicación: ");
        int? año = int.TryParse(Console.ReadLine()?.Trim(), out var tempAño) ? tempAño : null;
        Console.Write("¿Está disponible? (s/n): ");
        bool disponible = Console.ReadLine()?.ToLower() == "s";

        BibliotecaLibros[codigo] = new Libro(titulo, autor, genero, codigo, año ?? 0, disponible);
        Console.WriteLine("Libro registrado exitosamente.");
    }

    static void EliminarLibro()
    {
        Console.Write("Ingrese el código del libro a eliminar: ");
        string? codigo = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(codigo))
        {
            Console.WriteLine("El código no puede estar vacío.");
            return;
        }

        if (BibliotecaLibros.Remove(codigo))
            Console.WriteLine("Libro eliminado con éxito.");
        else
            Console.WriteLine("No se encontró un libro con ese código.");
    }

    static void BuscarPorCodigo()
    {
        Console.Write("Ingrese el código del libro: ");
        string? codigo = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(codigo))
        {
            Console.WriteLine("El código no puede estar vacío.");
            return;
        }

        if (BibliotecaLibros.ContainsKey(codigo))
            MostrarLibro(codigo, BibliotecaLibros[codigo]);
        else
            Console.WriteLine("No se encontró un libro con ese código.");
    }

    static void BuscarPorTitulo()
    {
        Console.Write("Ingrese el título: ");
        string? titulo = Console.ReadLine()?.Trim().ToLower();

        if (string.IsNullOrEmpty(titulo))
        {
            Console.WriteLine("El título no puede estar vacío.");
            return;
        }

        var resultados = BibliotecaLibros.Where(x => x.Value.Titulo.ToLower().Contains(titulo));
        if (resultados.Any())
        {
            foreach (var libro in resultados)
                MostrarLibro(libro.Key, libro.Value);
        }
        else
            Console.WriteLine("No se encontraron libros con ese título.");
    }

    static void BuscarPorAutor()
    {
        Console.Write("Ingrese el autor: ");
        string? autor = Console.ReadLine()?.Trim().ToLower();

        if (string.IsNullOrEmpty(autor))
        {
            Console.WriteLine("El autor no puede estar vacío.");
            return;
        }

        var resultados = BibliotecaLibros.Where(x => x.Value.Autor.ToLower().Contains(autor));
        if (resultados.Any())
        {
            foreach (var libro in resultados)
                MostrarLibro(libro.Key, libro.Value);
        }
        else
            Console.WriteLine("No se encontraron libros de ese autor.");
    }

    static void BuscarPorGenero()
    {
        Console.Write("Ingrese el género: ");
        string? genero = Console.ReadLine()?.Trim().ToLower();

        if (string.IsNullOrEmpty(genero))
        {
            Console.WriteLine("El género no puede estar vacío.");
            return;
        }

        var resultados = BibliotecaLibros.Where(x => x.Value.Genero.ToLower().Contains(genero));
        if (resultados.Any())
        {
            foreach (var libro in resultados)
                MostrarLibro(libro.Key, libro.Value);
        }
        else
            Console.WriteLine("No se encontraron libros de ese género.");
    }

    static void BuscarPorAño()
    {
        Console.Write("Ingrese el año de publicación: ");
        int? año = int.TryParse(Console.ReadLine()?.Trim(), out var tempAño) ? tempAño : null;

        var resultados = BibliotecaLibros.Where(x => x.Value.Año == año);
        if (resultados.Any())
        {
            Console.WriteLine($"Libros publicados en el año {año}:");
            foreach (var libro in resultados)
                MostrarLibro(libro.Key, libro.Value);
        }
        else
            Console.WriteLine("No se encontraron libros de ese año.");
    }

    static void MostrarTodos()
    {
        if (BibliotecaLibros.Count == 0)
        {
            Console.WriteLine("No hay libros registrados.");
            return;
        }

        Console.WriteLine("Listado de libros en la biblioteca:");
        foreach (var libro in BibliotecaLibros)
            MostrarLibro(libro.Key, libro.Value);
    }

    static void MostrarLibro(string codigo, Libro libro)
    {
        Console.WriteLine($"Código: {codigo}, Título: {libro.Titulo}, Autor: {libro.Autor}, Género: {libro.Genero}, Año: {libro.Año}, Disponible: {libro.Disponible}");
    }
}
