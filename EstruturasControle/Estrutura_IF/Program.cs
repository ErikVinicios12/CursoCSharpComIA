Console.WriteLine(" Estrutura IF");

Console.WriteLine("Cliente especial [true/false]");
var resposta = Convert.ToBoolean(Console.ReadLine());

if (resposta)
{
    Console.WriteLine("Desconto aplicado");
}

Console.Write("Valor 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor 2: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
    Console.WriteLine("X maior que Y");

if (x < y)
    Console.WriteLine("X menor que Y");

if (x == y)
    Console.WriteLine("X é igual Y");
