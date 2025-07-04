﻿using System;

// Clase que representa un círculo
public class Circulo
{
    private double radio;

    // Constructor del círculo que recibe el radio
    public Circulo(double r)
    {
        radio = r;
    }

    // Método para calcular el área del círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Método para calcular el perímetro del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase que representa un cuadrado
public class Cuadrado
{
    private double lado;

    // Constructor del cuadrado que recibe el lado
    public Cuadrado(double l)
    {
        lado = l;
    }

    // Método para calcular el área del cuadrado
    public double CalcularArea()
    {
        return lado * lado;
    }

    // Método para calcular el perímetro del cuadrado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}

// Clase principal del programa
/*
//partial class Program
{
//    static void Mostrar()
     {
// Crear un objeto de tipo Circulo con radio 5
Circulo c = new Circulo(5);
        Console.WriteLine("CÍRCULO");
        Console.WriteLine("Área: " + c.CalcularArea());
        Console.WriteLine("Perímetro: " + c.CalcularPerimetro());

        // Crear un objeto de tipo Cuadrado con lado 4
        Cuadrado q = new Cuadrado(4);
        Console.WriteLine("\nCUADRADO");
        Console.WriteLine("Área: " + q.CalcularArea());
        Console.WriteLine("Perímetro: " + q.CalcularPerimetro());
    }
}
*/