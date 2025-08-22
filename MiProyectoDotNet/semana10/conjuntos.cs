using System;
using System.Collections.Generic;
using System.Linq;
//Crea un conjunto de ciudadanos ficticios=500
HashSet<string> ciudadanos = new HashSet<string>();
for (int i = 1; i<= 500; i++)
{
    ciudadanos.Add(" Ciudadano " + i);
}
//Conjunto de ciudadanos vacunados
HashSet<string> vacunaPfizer = new HashSet<string>();
HashSet<string> vacunaAstra = new HashSet<string>();
// Selección aleatoria de 75 vacunados por vacuna
Random rnd = new Random();
List<string> ListaDeCiudadanos = ciudadanos.ToList();
while (vacunaPfizer.Count < 75)
{
    vacunaPfizer.Add(ListaDeCiudadanos[rnd.Next(ListaDeCiudadanos.Count)]);
}
while (vacunaAstra.Count < 75)
{
    vacunaAstra.Add(ListaDeCiudadanos[rnd.Next(ListaDeCiudadanos.Count)]);
}
//Utilizando conceptos de teoría de conjuntos 
//ciudadanos con ambas dosis (intersección)
var ambasDosis = vacunaPfizer.Intersect(vacunaAstra).ToHashSet();
//Ciudadanos vacunados únicamente con Pfizer( diferencia)
var soloPfizer = vacunaPfizer.Except(vacunaAstra).ToHashSet();
//Ciudadanos vacunados únicamente con AstraZeneca (diferencia)
var soloAstra = vacunaAstra.Except(vacunaPfizer).ToHashSet();
// Ciudadanos vacunados (unión)
var vacunados = vacunaPfizer.Union(vacunaAstra).ToHashSet();
//No vacunados (Diferencia)
var noVacunados = ciudadanos.Except(vacunados).ToHashSet();
//Presentando resultados
Console.WriteLine("----Ciudadanos no vacunados----");
foreach (var c in noVacunados) Console.WriteLine(c);
Console.WriteLine("\n ----Ciudadanos con ambas dosis----");
foreach (var c in ambasDosis) Console.WriteLine(c);
Console.WriteLine("\n ----Ciudadanos vacunados únicamente con Pfizer----");
foreach (var c in soloPfizer) Console.WriteLine(c);
Console.WriteLine("\n ----Ciudadanos vacunados únicamente con AstraZeneca----");
foreach (var c in soloAstra) Console.WriteLine(c);
