// Generics é quando se usa <T> (sendo T o tipo)
// Serve pra quando um método/classe trabalha com parametros de tipos diferentes

Teste.Comparar(1, 3.1);


// método "Equal"

string a = "José";
string b = "José";

Console.WriteLine(a.Equals(b)); // returna true

Pessoa p1 = new Pessoa(1, "Bruno");
Pessoa p2 = new Pessoa(1, "Bruno");

Console.WriteLine(p1.Equals(p2)); // retorna false, pois Pessoa é um objeto por referencia

// método "GetHashCode"

Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p2.GetHashCode());
public class Pessoa
{
    private int _id;
    private string? _nome;

    public Pessoa(int id, string? nome)
    {
        _id = id;
        _nome = nome;
    }


}
public static class Teste
{                              //where T1 : struct where T2 : struct (significa que t1 e t2 precisam ser tipo por valor, ou seja, não pode ser string
    public static void Comparar<T1, T2>(T1 p1, T2 p2) where T1 : struct where T2 : struct 
    {
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {2} são iguais? {resultado}");
    }
}