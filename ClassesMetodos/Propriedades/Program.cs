Produto p1 = new Produto();
p1.Nome = "Produto 1";
p1.Preco = 3.50;
p1.EstoqueMinimo = 10;

p1.Exibir();

public class Produto
{
    private string? nome; // campo (permite o acesso ao campo para quem criar uma instância da classe e não tem controle
                         // sobre o que é atribuído a ele)
    public string? Nome  // propr iedade (permite o acesso ao campo para quem criar uma instância da classe e tem controle
                         // sobre o que é atribuído a ele)
                         // Isso permite mais segurança e encapsulamento, pois você pode adicionar lógica adicional no
                         // getter e setter, como validação de dados ou transformação de valores.
    {
        get { return nome?.ToUpper(); } // getter (retorna o valor do campo)
        set { nome = value; } // setter (atribui um valor ao campo)
    }
    private double preco;
    public double Preco { 
        get {
            return preco;
        } 
        set {
            if (value < 5.00)
                preco = 5.00;
            else
                preco = value;
        } }
    private double desconto = 0.05;
    public double Desconto { get
        {
            return desconto;
        } }
    public double PrecoFinal { get
        {
            return Preco - (Preco * Desconto);
        } }
    private int estoqueMinimo;
    public int EstoqueMinimo
    {
        set
        {
            if (value < 0)
                estoqueMinimo = 0;
            else
                estoqueMinimo = value;
        }
    }

    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: {Preco.ToString("C")}");
        Console.WriteLine($"Desconto: {Desconto}");
        Console.WriteLine($"Preço Final: {PrecoFinal.ToString("C")}");
        Console.WriteLine($"Estoque Mínimo: {estoqueMinimo}");
    }
}