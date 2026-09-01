// Interface é como uma classe suporte.
// Ela não pode ser instanciada
// Uma classe pode herdar multiplas interface
// Seu nome deve usar "I" no começo do nome. Ex: "IController", "IDemo"

IControle d = new Demo();
d.Nome = "Teste";
d.Exibir();
interface IControle
{

    // não pode ter construtor
    string Nome { get; set; }
    void Desenhar();
    public void Exibir()
    {
        Console.WriteLine("Exibindo...")
    }
}

interface IGrafico
{
    void Pintar();
}

public class Demo : IControle, IGrafico
{
    public string Nome { get; set; } = string.Empty;

    public void Desenhar()
    {
        Console.WriteLine("Desenhando...");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando...");
    }
}