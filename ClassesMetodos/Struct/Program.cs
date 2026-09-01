Cliente cliente = new Cliente("João", 30);
cliente.ExibirInformacoes();

struct Cliente
{
    public string Nome;
    public int Idade;
    public Cliente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}