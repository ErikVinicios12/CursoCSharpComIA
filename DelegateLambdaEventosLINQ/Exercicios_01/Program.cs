// Considere que você enteja desenvolvendo um sistema que gerencia uma lista de pessoas. Cada pessoa possui um nome e uma idade. Para mimplementar
// algumas funcionalidades desse sistema, você precisará utilizar delegates. Siga as instruções abaixo para decidir qual delegate utilizar em cada caso:
List<Pessoa> pessoas = new List<Pessoa>()
{
    new Pessoa("João", 25),
    new Pessoa("Maria", 17),
    new Pessoa("Pedro", 30),
    new Pessoa("Ana", 15),
    new Pessoa("Lucas", 20)
};

//1- Você precisa percorrer a lista de pessoas e imprimir o nome e a idade de cada uma.
Console.WriteLine("\n Lista Completa \n");
Acao acao = Pessoa.ImprimirPessoas;
acao(pessoas);

//2- Você precisa filtrar a lista de pessoas, retornando apenas aquelas que possuem idade maior do que 18 anos.
Console.WriteLine("\n Pessoas com idade maior que 18 \n");
acao(pessoas.FindAll(p => p.Idade > 18));

//3- Você precisa obter o nome e idade da pessoa e mais velha da lista 
Console.WriteLine("\n Pessoa mais velha \n");
acao = delegate (List<Pessoa> p) {
    Pessoa pessoaMaisVelha = p.MaxBy(pe => pe.Idade);
    Console.WriteLine($"Nome: {pessoaMaisVelha.Nome}, Idade: {pessoaMaisVelha.Idade}");
};
acao(pessoas);

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public static void ImprimirPessoas(List<Pessoa> pessoas)
    {
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
        }
    }
}
public delegate void Acao(List<Pessoa> pessoas);