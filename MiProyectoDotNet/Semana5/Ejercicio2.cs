//Escribir un programa que almacene en una lista los siguientes precios: 50, 75, 46, 22, 80, 65, 8, y muestre por pantalla el menor y el mayor de los precios.
using System;
using System.Collections.Generic;
using System.Linq;

public class GestorPrecios
{
    private List<int> precios;

    public GestorPrecios()
    {
        precios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };
    }

    public int ObtenerPrecioMayor()
    {
        return precios.Max();
    }

    public int ObtenerPrecioMenor()
    {
        return precios.Min();
    }

    public void MostrarResultados()
    {
        Console.WriteLine($"Mayor precio: {ObtenerPrecioMayor()}");
        Console.WriteLine($"Menor precio: {ObtenerPrecioMenor()}");
    }
}
