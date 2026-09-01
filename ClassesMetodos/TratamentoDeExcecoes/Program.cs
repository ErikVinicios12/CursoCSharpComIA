Console.Write("Informe o valor de X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de Y: ");
int y = Convert.ToInt32(Console.ReadLine());
try {
    int z = x / y;
    Console.WriteLine($"O resultado da divisão de {x} por {y} é: {z}");
} catch (Exception e) {
    Console.WriteLine("Erro: {0}.", e.Message);
    Console.WriteLine("Detalhes: {0}.", e.StackTrace);
}
finally
{
    Console.WriteLine("Fim do programa.");
}