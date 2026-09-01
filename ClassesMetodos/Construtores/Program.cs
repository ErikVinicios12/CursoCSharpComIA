Aluno aluno = new Aluno("João", 20, "Masculino", "Sim");

Console.WriteLine($"Nome: {aluno.Nome}");
Console.WriteLine($"Idade: {aluno.Idade}");
Console.WriteLine($"Sexo: {aluno.Sexo}");
Console.WriteLine($"Aprovado: {aluno.Aprovado}");

Console.WriteLine("\n Construtor estático e construtor parametrizado \n");

Pessoa p1 = new Pessoa(25, "Maria");
Console.WriteLine($"Pessoa: {p1.Nome}\n" +
    $"Idade: {p1.Idade}\n" +
    $"Idade Mínima: {Pessoa.IdadeMinima}");

Pessoa p2 = new Pessoa(12, "Bruno");
Console.WriteLine($"Pessoa: {p2.Nome}\n" +
    $"Idade: {p2.Idade}\n" +
    $"Idade Mínima: {Pessoa.IdadeMinima}");

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
    public Aluno(string? Nome) => this.Nome = Nome;

    public Aluno(string? Nome, int Idade, string? Sexo, string? Aprovado)
    {
        this.Nome = Nome;
        this.Idade = Idade;
        this.Sexo = Sexo;
        this.Aprovado = Aprovado;
    }
}
