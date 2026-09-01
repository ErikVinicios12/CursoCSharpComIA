
//-Crie uma enumeração chamada Cores em um arquivo CarroEnum.cs que defina os seguintes membros :  
//Branco, Vermelho, Preto, Cinza, Prata e Azul
//- Inicie o valor da enumeração com 1
//- Inclua na classe Carro o campo Cor do tipo int que vai representar a cor do carro
//- Altere o construtor da classe incluindo o campo Cor para criar objetos usando a Cor selecionada
//- Defina um menu de opções exibindo o nome da Cor e o seu valor
//- Receba a seleção do usuário em uma variável do tipo int cor que vai ser usada para atribuir ao campo Cor
//- Altere o método ExibirInfo() incluindo o parâmetro cor do tipo int como parâmetro opcional e exiba o nome da
//cor a partir do valor da Cor recebida

using CarroEnum;

Console.WriteLine($"Cores disponíveis:");
foreach (var cor in Enum.GetValues(typeof(Cores)))
{
    Console.WriteLine($"\n{(int)cor} - {cor}");
}
Console.Write("\nSelecione a cor do carro: ");

int corSelecionada = Convert.ToInt32(Console.ReadLine());

Carro carro = new Carro("Fusca", 1970, corSelecionada);

carro.ExibirInfo(corSelecionada);
public class Carro
{
    private string? modelo;
    public string? Modelo { get; set; }
    private int ano;
    public int Ano { get; set; }
    private int cor;
    public int Cor { get; set; }
    public Carro(string modelo, int ano, int cor)
    {
        Modelo = modelo;
        Ano = ano;
        Cor = cor;
    }
    public void ExibirInfo(int cor = 0)
    {
        string nomeCor = Enum.GetName(typeof(Cores), cor);
        Console.WriteLine($"Modelo: {Modelo}, Ano: {Ano}, Cor: {nomeCor}");
    }
}