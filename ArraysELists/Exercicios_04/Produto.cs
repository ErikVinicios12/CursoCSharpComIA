public class Produto
{
    private string? _nome;
    public string? Nome { get; set; }
    private decimal _preco;
    public decimal Preco { get; set; }

    public static void Resumo(List<Produto> produtos, string texto)
    {
        Console.WriteLine($"\n {texto} \n");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome} - {produto.Preco.ToString("C")}");
        }

        var totalPrecos = produtos.Sum(x  => x.Preco);
        Console.WriteLine($"TOTAL: {totalPrecos.ToString("C")}");

        var media = totalPrecos / produtos.Count();
        Console.WriteLine($"MÉDIA: {media.ToString("C")}");

        Console.WriteLine($"Quantidade: {produtos.Count}");
    }
}
