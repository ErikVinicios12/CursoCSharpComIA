// AS serve para converter tipo. Caso a conver~soa nao ocorra, ele gera resultado null ao invés de erro

object carroObj = new Carro();

try
{
    var x = (string)carroObj; // gera exception
} catch (Exception e) { 
    
}

var x = carroObj as Carro; // resulta null se ñão converte
if (x == null)
{
    Console.WriteLine("Impossivel converter");
} else
{
    Console.WriteLine("Conversão feita!");
}

// IS apenas verifica se o objeto é daquele tipo, faz a conversão e retorna true or false

if (carroObj is Carro) // verifica se carroObj é do tipo Carro (nesca caso, false)
    Console.WriteLine("Conversão feita! ");
else
    Console.WriteLine("Impossivel converter");


class Carro
{

}

