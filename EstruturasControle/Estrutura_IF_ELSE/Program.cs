Console.WriteLine(" Instrução If_Else");

Console.Write("Informe a nota do aluno: ");
var nota = Convert.ToInt32(Console.ReadLine());

if (nota > 5)
    Console.WriteLine("Aluno aprovado! ");
else
    Console.WriteLine("Aluno Reprovado");

Console.Write("Valor de X: ");
var x = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor de Y: ");
var y = Convert.ToInt32(Console.ReadLine());

if (x > y)
    Console.WriteLine("X é maior que Y");
else
{
    if (x < y)
        Console.WriteLine("X é menor que Y");
    else
        Console.WriteLine("Ambos são iguais");
}
