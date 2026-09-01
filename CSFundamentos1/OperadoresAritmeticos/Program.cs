Console.WriteLine(" Operadores aritméticos ");

Console.Write("Digite o valor de X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nSoma: {x + y} \n" +
    $"Subtração: {x - y} \n" +
    $"Multiplicação: {x * y} \n" +
    $"Divisão: {(double) x / y} \n" +
    $"Módulo: {x % y} \n");

// métodos Math

Console.WriteLine($"Raiz quadrada de X: {Math.Sqrt(x)}\n" +
    $"Potência de X elevado a Y: {Math.Pow(x,y)}\n" +
    $"Valor mínimo entra X e Y:  {Math.Min(x,y)}\n" +
    $"Valor máximo entra X e Y:  {Math.Max(x, y)}\n" +
    $"Cosseno de X:  {Math.Cos(x)}\n" +
    $"Seno de X:  {Math.Sin(x)}\n" +
    $"Exponencial de X:  {Math.Exp(x)}\n");