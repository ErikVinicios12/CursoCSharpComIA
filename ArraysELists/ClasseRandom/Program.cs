Random random = new Random();

Console.WriteLine(random.Next());
Console.WriteLine(random.Next(20)); // entre 0 e 20
Console.WriteLine(random.Next(10, 20)); // entre 10 e 19
Console.WriteLine(random.NextDouble()); // aleatórios entre 0 e 1

byte[] randBytes = new byte[6];
random.NextBytes(randBytes);

for (int i = 0; i < randBytes.Length; i++)
{
    Console.WriteLine(randBytes[i]);
}