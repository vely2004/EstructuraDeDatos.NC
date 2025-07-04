//Programa que pida al usuario una palabra y muestre por pantalla el número de veces que contiene cada vocal.
using System;
using System.Collections.Generic;

class ContadorVocales
{
    private string palabra;

    public ContadorVocales(string palabra)
    {
        this.palabra = palabra.ToLower();
    }

    public Dictionary<char, int> ContarVocales()
    {
        Dictionary<char, int> vocales = new Dictionary<char, int>()
        {
            {'a', 0},
            {'e', 0},
            {'i', 0},
            {'o', 0},
            {'u', 0}
        };

        foreach (char c in palabra)
        {
            if (vocales.ContainsKey(c))
            {
                vocales[c]++;
            }
        }

        return vocales;
    }

    public void MostrarResultado()
    {
        var resultado = ContarVocales();
        Console.WriteLine($"En la palabra '{palabra}' hay:");

        foreach (var kvp in resultado)
        {
            Console.WriteLine($"Vocal '{kvp.Key}': {kvp.Value} veces");
        }
    }
}