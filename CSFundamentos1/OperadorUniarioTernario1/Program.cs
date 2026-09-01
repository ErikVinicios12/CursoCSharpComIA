Console.WriteLine(" Operador Uniário e Ternário");

int positivo = 1;
int resultado;

resultado = +positivo;
Console.WriteLine(resultado);


Console.Write("\nInforme o número: ");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é {-n}");

Console.Write("\nInforme a temperatura: ");
double temp = Convert.ToInt32(Console.ReadLine());

string result = temp > 27 ? "quente" : "normal";

Console.WriteLine($"O tempo está {result}");

Console.Write("\nInforme o valor de X: ");
double x = Convert.ToInt32(Console.ReadLine());
Console.Write("\nInforme o valor de Y: ");
double y = Convert.ToInt32(Console.ReadLine());

string result2 = x > y ? "X é maior que Y" :
                 x < y ? "X é menor que Y" :
                 x == y ? "X é igual a Y" :
                 "Sem resultado";

Console.WriteLine(result2);