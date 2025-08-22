/*
using System;
using System.Collections.Generic;
namespace Semana7;

public class HanoiSolver
{
    private Dictionary<string, Stack<int>> torres = new Dictionary<string, Stack<int>>
    {
        { "A", new Stack<int>() },
        { "B", new Stack<int>() },
        { "C", new Stack<int>() }
    };

    public void Resolver(int n)
    {
        torres["A"].Clear();
        torres["B"].Clear();
        torres["C"].Clear();

        for (int i = n; i >= 1; i--)
        {
            torres["A"].Push(i);
        }

        MostrarTorres();
        Hanoi(n, "A", "C", "B");
    }

    private void MoverDisco(string origen, string destino)
    {
        int disco = torres[origen].Pop();
        torres[destino].Push(disco);
        Console.WriteLine($"Mover disco {disco} de {origen} a {destino}");
        MostrarTorres();
    }

    private void Hanoi(int n, string origen, string destino, string auxiliar)
    {
        if (n == 1)
        {
            MoverDisco(origen, destino);
        }
        else
        {
            Hanoi(n - 1, origen, auxiliar, destino);
            MoverDisco(origen, destino);
            Hanoi(n - 1, auxiliar, destino, origen);
        }
    }

    private void MostrarTorres()
    {
        Console.WriteLine("Estado de las torres:");
        foreach (var torre in torres)
        {
            Console.Write($"{torre.Key}: ");
            foreach (var disco in torre.Value)
                Console.Write(disco + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

*/