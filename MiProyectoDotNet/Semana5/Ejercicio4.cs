//Escribir un programa que almacene en una lista los números del 1 al 10 y los muestre por pantalla en orden inverso separados por comas.
using System;
using System.Collections.Generic;

class ListaNumeros
{
    private List<int> numeros;

    public ListaNumeros()
    {
        numeros = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }
    }

    public void MostrarInverso()
    {
        numeros.Reverse();
        Console.WriteLine(string.Join(", ", numeros));
    }
}