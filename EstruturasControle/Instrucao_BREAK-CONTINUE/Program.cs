Console.WriteLine(" Instrução Break-Continue ");

for (int i = 0; i <= 10; i++)
{
    if (i == 4)
        continue;
    Console.WriteLine(i);
}

for (; ;)
{
    Console.Write("\nDigite uma letra: ");
    string v = Console.ReadLine().ToUpper();
    Console.WriteLine("");
    if (v == "X")
    {
        Console.WriteLine("Tchau...");
        break;
    }
}

int n = 1;
while (n <= 10)
{
    if (n == 4)
        continue;
    Console.WriteLine(n);
    if (n == 8)
        break;
    n++;
}
