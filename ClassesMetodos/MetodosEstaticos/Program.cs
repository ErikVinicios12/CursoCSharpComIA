using System.Security.Cryptography;

var soma = Calculadora.Somar(10, 10);
var divisao = Calculadora.Dividir(10, 2);
var multiplicacao = Calculadora.Multiplicar(10, 10);
var subtracao = Calculadora.Subtrair(10, 5);

A a1 = new A();
a1.x = 10;
A a2 = new A();
a2.x = 20;

A.y = 30;
// Como Y é y um campo estático, ele é compartilhado entre todas as instâncias da classe A.
// Portanto, quando você altera o valor de Y, ele afeta todas as instâncias da classe A.
// Ou seja, a1 e a2 compartilham o mesmo valor de Y. (30)

Console.WriteLine($"a1 X = {a1.x}");
Console.WriteLine($"a2 X = {a2.x}");
Console.WriteLine($"Y = {A.y}");

public class A
{
    public int x;
    public static int y;
}
public static class Calculadora
{
    public static int Somar(int a, int b)
    {
        return a + b;
    }
    public static int Subtrair(int a, int b)
    {
        return a - b;
    }
    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }
    public static double Dividir(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Não é possível dividir por zero.");
        }
        return a / b;
    }
}