Console.WriteLine(" Nullable types!");

int? i = null;
double? d = null;
bool? b = null;
Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

int? a = null;
int b2 = a ?? 0; // se a = null entao b recebe 0 senao b = a

int? x = 4;
int? y = 3;
int? z = x * y;

int? c = 100;

if (c.HasValue)
{
    Console.WriteLine($"b ={c}");
} else
{
    Console.WriteLine("b não possui um valor");
}