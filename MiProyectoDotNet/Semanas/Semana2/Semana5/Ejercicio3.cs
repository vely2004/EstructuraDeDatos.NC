//Escribir un programa que almacene las asignaturas de un curso en una lista y la muestre por pantalla el mensaje Yo estudio <asignatura>, donde <asignatura> es cada una de las asignaturas de la lista.
using System;
using System.Collections.Generic;

public class GestorAsignaturas
{
    private List<string> asignaturas;

    public GestorAsignaturas()
    {
        asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
    }

    public void MostrarAsignaturas()
    {
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}

public class ProgramaAsignaturas
{
    public static void Mostrar()
    {
        GestorAsignaturas gestor = new GestorAsignaturas();
        gestor.MostrarAsignaturas();
    }
}


