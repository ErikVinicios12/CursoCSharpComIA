using System;
using System.Collections.Generic;
using System.Linq;

var alunosNotas = new Dictionary<string, double>
{
    ["Maria"] = 7,
    ["Eric"] = 8,
    ["Ana"] = 9,
    ["Alex"] = 6,
    ["Diná"] = 5
};

Exibir(alunosNotas);

alunosNotas["Ana"] = 10;
alunosNotas.Remove("Diná");
alunosNotas["Vilma"] = 7;

// You can pass the dictionary directly or an ordered sequence
Exibir(alunosNotas.OrderBy(x => x.Key));

alunosNotas.Clear();
static void Exibir(IEnumerable<KeyValuePair<string, double>> alunosNotas)
{
    Console.WriteLine();
    foreach (var item in alunosNotas)   
    {
        Console.WriteLine($"{item.Key} - {item.Value}");
    }
}