using System;
using Semana7;

class Program
{
    static void Main()
    {
        Console.WriteLine("Selecciona una opción:");
        Console.WriteLine("1. Verificar paréntesis balanceados");
        Console.WriteLine("2. Resolver Torres de Hanoi");
        Console.Write("Opción: ");
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            Console.WriteLine("Ingresa la expresión matemática:");
            string expresion = Console.ReadLine();
            string resultado = Verificador.VerificarBalanceo(expresion);
            Console.WriteLine(resultado);
        }
        else if (opcion == "2")
        {
            Console.Write("Ingresa el número de discos: ");
            int n = int.Parse(Console.ReadLine());

            HanoiSolver hanoi = new HanoiSolver();
            hanoi.Resolver(n);
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
    }
}
