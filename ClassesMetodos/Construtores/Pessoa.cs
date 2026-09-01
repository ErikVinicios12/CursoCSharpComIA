public class Pessoa
{
    public static int IdadeMinima;

    public int Idade {  get; set; }
    public string Nome { get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("Executando o construtor parametrizado");
        Nome = nome;
        Idade = idade;
    }

    static Pessoa()
    {
        Console.WriteLine("Executando o construtor estático");
        IdadeMinima = 18;
    }
}