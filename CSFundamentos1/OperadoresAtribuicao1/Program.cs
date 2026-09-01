Console.WriteLine(" Operadores de atribuição ");

// usando operadores atribuição com tipos numéricos
var x = 10;

Console.WriteLine($"Valor inicial de X: {x}" +
    $"\nX+=5 -->  {x+=5}" +
    $"\nX-=3 -->  {x-=5}" +
    $"\nX*=5 -->  {x*=5}" +
    $"\nX/=5 -->  {x/=5}" +
    $"\nX%=5 -->  {x%=5}");

string y = "123";

Console.WriteLine($"\nO valor inicial de Y: {y}" +
    $"\ny+=\"456\" --> {y+="456"}");