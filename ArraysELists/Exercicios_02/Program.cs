// Declare e aloque memória para um array de strings chamado alunos com 2 linhas e 5 colunas e a seguir realize as seguintes operações
//
//- Inicializar o array com dados referente aos nomes dos alunos recebidos via teclado informando o indice da linha e coluna de cada
//elemento que está sendo recebido;
//- Exibir no console os dados informados no array bem como o indice da linha e coluna de cada elemento;
//
// Usar os nomes dos alunos a seguir respeitando a ordem indicada:
//Maria, Paulo, Marta, Pedro, Carlos
//Silvia, amanda, Manoel, Paula, Alicia

string[,] alunos = new string[2, 5];

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"Aluno [{i},{j}]: ");
        alunos[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("\n RESULTADO \n");

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"[{i},{j}] {alunos[i, j]}");
    }
    Console.WriteLine();
}