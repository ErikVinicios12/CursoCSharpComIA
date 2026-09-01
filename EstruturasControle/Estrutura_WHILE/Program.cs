Console.WriteLine(" Instrução While ");

var i = 1;

while (i<=10)
{
    Console.WriteLine(i);
    i++;
}

Console.Write("\nDigite um número: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    int cont = 1;

    while (cont <= 10)
    {
        Console.WriteLine($"{n} X {cont} = {n * cont}");
        cont++;
    }
} else
{
    Console.WriteLine("Número precisa ser maior que 0");
}

while (true)
{
    Console.WriteLine("\nInforme um número (999 para sair) : ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 999) break;

    if (num % 2 == 0)
        Console.WriteLine("Par");
    else
        Console.WriteLine("Impar");
}

int x = 0; 

while (x<5)
{
    int y = 0;
    while (y<5)
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    x++;
    Console.WriteLine();
}
