// Array seria o vetor ou matrix
// armazena valor do mesmo tipo
// sintaxe - TipoDados[] NomeDoArray = new TipoDados[tamanho]

// declaração do array
using Arrays;

int[] numeros;

// alocar memória
numeros = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

string[] nomes = new string[5] { "Ana", "Maria", "Bruno", "Carlos", "Rafael" };

string[] nomes2 = { "Joao", "Pedro", "Alex", "Julio", "Diego" };

Console.WriteLine(nomes[2]);
Console.WriteLine("\n");

for (int i = 0; i < nomes2.Length; i++)
    Console.WriteLine(nomes2[i]);

Console.WriteLine("\n Array original \n");

foreach (var nome in nomes)
    Console.WriteLine(nome);

Console.WriteLine("\n Array reverso \n");

Array.Reverse(nomes);

foreach (var nome in nomes)
    Console.WriteLine(nome);

Console.WriteLine("\n Array misturado \n");

Array.Sort(nomes);

foreach (var nome in nomes)
    Console.WriteLine(nome);

Console.Write("\nQual nome você deseja? ");
var n = Console.ReadLine();

int indice = Array.BinarySearch(nomes, n);

if (indice >= 0)
    Console.WriteLine($"\n{n} está no indice {indice}");
else
    Console.WriteLine("\nNome não encontrado");

// Um programa para calcular a soma de um número variável de números inteiros

int[] valores = new int[5] { 1, 2, 3, 4, 5 };
var soma = Calculadora.Somar(valores);
var soma2 = Calculadora.Somar(2, 3, 5, 6, 3);  // por haver "params" no método, desta maneira ele identifica um array de inteiros

Console.WriteLine($"\nSoma 1: {soma}");
Console.WriteLine($"\nSoma 2: {soma2}");

// arrays com mais de 1 dimensão
int[,] a = new int[2, 2] { 
    { 0, 1 },
    { 2, 3 } 
};

int[,] b = new int[2, 2];
b[0,0] = 1;

Console.WriteLine("\n\nArray A \n");
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write($"{a[i, j]} ");
    }
    Console.WriteLine("");
}