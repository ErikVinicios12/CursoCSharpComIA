Cadastro cadastro = new Cadastro();
Cliente cliente = cadastro.Registrar();
cadastro.ExibirDados(cliente);

// alterar renda
cliente = cadastro.Registrar(cliente);
cadastro.ExibirDados("Renda alterada", cliente);
public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? Nome, int Idade, decimal Renda)
    {
        this.Nome = Nome;
        this.Idade = Idade;
        this.Renda = Renda;
    }
}

public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new Cliente("Maria", 23, 3000);
        return cliente;
    }

    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }

    public void ExibirDados(Cliente cliente)
    {
        Console.WriteLine($"Nome: {cliente.Nome}, Idade: {cliente.Idade}, Renda: {cliente.Renda}");
    }

    public void ExibirDados(string texto, Cliente cliente)
    {
        Console.WriteLine($"\n{texto}\t");
        Console.WriteLine($"Nome: {cliente.Nome}, Idade: {cliente.Idade}, Renda: {cliente.Renda}");
    }
}