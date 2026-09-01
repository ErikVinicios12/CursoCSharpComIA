Console.WriteLine(" Instrução FOR \n");

Console.Write("Digite um número aior que 0: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{n} X {i} = {n * i}");
    }
}
else
    Console.WriteLine("Número inválido! ");

for (int i = 0, j = 0; i+j <= 20; i++, j++)
    Console.WriteLine($"I = {i}, j = {j}");
