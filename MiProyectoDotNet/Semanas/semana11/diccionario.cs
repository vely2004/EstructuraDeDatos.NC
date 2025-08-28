using System;
using System.Collections.Generic;
using System.Linq.Expressions;
class Diccionarioe_i
{
    static void Main()
    {
        //Creando un diccionario (español e inglés)
        Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
          {"tiempo", "time"},
            {"persona", "person"},
            {"año", "year"},
            {"camino", "way"},
            {"forma", "way"},
            {"día", "day"},
            {"cosa", "thing"},
            {"hombre", "man"},
            {"mundo", "world"},
            {"vida", "life"},
            {"mano", "hand"},
            {"parte", "part"},
            {"niño", "child"},
            {"niña", "child"},
            {"ojo", "eye"},
            {"mujer", "woman"},
            {"lugar", "place"},
            {"trabajo", "work"},
            {"semana", "week"},
            {"caso", "case"},
            {"punto", "point"},
            {"tema", "point"},
            {"gobierno", "government"},
            {"empresa", "company"},
            {"compañía", "company"}
        };
        int opcion;
        do
        {
            Console.WriteLine("\n>>>>>>>>>>>>Menú<<<<<<<<<<<<<");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar una palabra al diccionario");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Intente de nuevo");
                opcion = -1;
            }
            switch (opcion)
            {
                case 1:
                    TraducirFrase(diccionario);
                    break;
                case 2:
                    AgregarPalabra(diccionario);
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        } while (opcion != 0);
    }
    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.WriteLine("\n Ingrese una frase en español");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(' ', ',', '.', ';', ':', '!', '?');
        string traduccion = frase;

        foreach (string palabra in palabras)
        {
            if (diccionario.ContainsKey(palabra.ToLower()))
            {
                traduccion = traduccion.Replace(palabra, diccionario[palabra.ToLower()]);

            }
        }

        Console.WriteLine("\n Traducción Parcial: ");
        Console.WriteLine(traduccion);
    }
    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese la palabra en español");
        string esp = Console.ReadLine().Trim().ToLower();

        Console.Write("\n Ingrese la traducción al inglés: ");
        string ing = Console.ReadLine().Trim();

        if (!diccionario.ContainsKey(esp))
        {
            diccionario.Add(esp, ing);
            Console.WriteLine($" Palabra agregada: {esp} - {ing}");
        }
        else
        {
            Console.WriteLine(" La palabra ya existe en el diccionario");

        }
    }
}
