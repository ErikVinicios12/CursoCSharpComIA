public abstract class Forma
{
    public string Cor { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    public void Descricao()
    {
        Console.WriteLine("Sou uma classe abstrata");
    }

    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();
}