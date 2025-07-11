using System;
using System.Collections.Generic;

namespace Semana7
{
    public class Verificador
    {
        public static string VerificarBalanceo(string expresion)
        {
            Stack<char> pila = new Stack<char>();
            Dictionary<char, char> pares = new Dictionary<char, char>
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };

            foreach (char c in expresion)
            {
                if (c == '(' || c == '[' || c == '{')
                    pila.Push(c);
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (pila.Count == 0 || pila.Pop() != pares[c])
                        return "Fórmula no balanceada";
                }
            }

            return pila.Count == 0 ? "Fórmula balanceada" : "Fórmula no balanceada";
        }
    }
}
