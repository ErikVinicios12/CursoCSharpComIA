Console.WriteLine(" Estrutura if_Else_If");

Console.Write("Digite a nota: ");
double nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
    Console.WriteLine("Aluno Reprovado");
else if (nota >= 5 && nota < 6)
    Console.WriteLine("Aluno em Recuperação");
else if (nota >= 6 && nota <= 9)
    Console.WriteLine("Aluno Aprovado");
else if (nota > 9)
    Console.WriteLine("Aluno aprovado com distinção");