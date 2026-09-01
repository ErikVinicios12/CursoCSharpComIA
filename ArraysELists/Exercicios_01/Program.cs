// Crie um programa C# que receba via teclado o nome de cinco alunos e armazene os nomes em um array chamado nomes e, a seguir receba também
// via teclado a nota, como um double, dos cinco alunos e armazene os valores em um array chamado notas
//
// A seguir realize as seguintes operações:
//
// Acessar e exibir no console os nomes dos alunos armazenados no array nomes;
// Acessar e exibir no console as notas dos slunos armazenados no array notas;
// Calcular a média aritmética das notas e exibir no console o valor obtido;

string[] nomes = new string[5];

double[] notas = new double[5];

double media = 0;

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"\n    ALUNO {i+1}    \n");
    Console.Write("Nome: ");
    nomes[i] = Console.ReadLine();
    Console.Write("\nNota: ");
    notas[i] = Convert.ToDouble(Console.ReadLine());

    media += notas[i];
}

media = media / notas.Length;
Console.WriteLine($"\n    RESUMO     \n");

for (int i = 0; i < nomes.Length; i++)
    Console.Write($"{nomes[i]} - {notas[i]}\n");

Console.WriteLine($"\nMÉDIA GERAL: {media}");