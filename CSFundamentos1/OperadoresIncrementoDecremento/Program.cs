Console.WriteLine(" Operadores incremento e decremento");

int x = 10;
x++;
Console.WriteLine(x);
x--;
Console.WriteLine(x);

// pós-incremento --> primeiro resolve depois incrementa
int y = 0;
Console.WriteLine($"Y = {y}");

int resultado1 = y++ + 10;

Console.WriteLine($"pós-incremento --> {resultado1}" +
    $"\nValor de Y: {y}");

// pós-incremento --> primeiro incrementa depois resolve
int z = 0;
Console.WriteLine($"Z = {z}");
int resultado2 = ++z + 10;

Console.WriteLine($"pós-incrementro --> {resultado2}" +
    $"\nValor de Z: {z}");



// pós-decremento --> primeiro resolve depois decrementa
int y2 = 0;
Console.WriteLine($"\n\nY2 = {y2}");

int resultado3 = y2-- + 10;

Console.WriteLine($"pós-decremento --> {resultado3}" +
    $"\nValor de Y2: {y}");

// pós-decremento --> primeiro decrementa depois resolve
int z2 = 0;
Console.WriteLine($"Z2 = {z2}");
int resultado4 = --z2 + 10;

Console.WriteLine($"pós-decremento --> {resultado4}" +
    $"\nValor de Z2: {z2}");