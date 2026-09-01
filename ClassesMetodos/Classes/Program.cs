Console.WriteLine("Hello, World!");

Pessoa p1 = new Pessoa();
p1.Nome = "Maria";
p1.Idade = 25;
p1.sexo = "feminino";

Console.WriteLine($"Nome: {p1.Nome}\n" +
    $"Idade: {p1.Idade}\n" +
    $"Sexo: {p1.sexo}");

Pessoa p2 = new Pessoa();
p2.Nome = "Manoel";
p2.Idade = 23;
p2.sexo = "masculino";

Console.WriteLine($"Nome: {p2.Nome}\n" +
    $"Idade: {p2.Idade}\n" +
    $"Sexo: {p2.sexo}");

class Pessoa
{
    public string? Nome;
    public int Idade;
    public string? sexo;


}