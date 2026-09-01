using Exercicios_01;
using System.Collections;

Generic<string> genericString = new Generic<string>();
genericString.Adicionar("Ana");
genericString.Adicionar("Bruno");
genericString.Adicionar("Davi");
genericString.Adicionar("Luana");
genericString.Adicionar("Lucy");

for (int i = 0; i < genericString.Count(); i++)
{
    Console.WriteLine(genericString[i]);
}