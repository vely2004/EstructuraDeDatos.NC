// Escribir un programa que almacene las asignaturas de un curso
using System;
using System.Collections.Generic;

public class Ejercicio1
{
    public static void Mostrar()
    {
        List<string> lista = new List<string> { "Lenguaje", "Matemáticas", "Ciencias", "Sociales" };
        Console.WriteLine("Asignaturas del curso:");
        foreach (string asignatura in lista)
        {
            Console.WriteLine(asignatura);
        }
    }
}
