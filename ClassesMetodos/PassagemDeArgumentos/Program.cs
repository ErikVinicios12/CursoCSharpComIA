// This code demonstrates the use of the 'ref' keyword in C# to pass an argument by reference to a method.
// Quando coloca "Ref", é enviada a variavel original, e não uma cópia dela. Portanto,
// qualquer alteração feita na variável dentro do método afetará a variável original fora do método.

int x = 20;
Console.WriteLine("Valor de X antes do método Dobrar: " + x);

Calculo calc = new Calculo();
calc.Dobrar(ref x); 

Console.WriteLine("Valor de X depois do método Dobrar: " + x);


// This code demonstrates the use of the 'out' keyword in C# to return multiple values from a method.
// A variável "area" é declarada dentro do método CalculaAreaPerimetro, mas seu valor é retornado para
// a variável "area" fora do método, permitindo que o método retorne múltiplos valores.

Console.Write("Digite o valor do raio: ");
double raio = Convert.ToDouble(Console.ReadLine());

double perimetro = calc.CalculaAreaPerimetro(raio, out double area);
Console.WriteLine($"Perimetro da Circunferência: {perimetro}\n" +
    $"Área da Circunferência: {area}");


// This code demonstrates the use of named arguments in C# to improve code readability and clarity.
// este é um exemplo de passagem de argumentos nomeados, onde os parâmetros são passados para o método Enviar
Email email = new Email();
email.Enviar(destinatario: "bruno", corpo: "Feliz aniversário. Muitos anos de vida!");

public class Calculo
{
    public int Dobrar(ref int y) {
        y *= 2;
        Console.WriteLine("Valor de Y dentro do método Dobrar: " + y);
        return y;
    }

    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return area;
    }
}

public class Email
{
    // Este método demonstra a passagem de argumentos nomeados, onde os parâmetros são passados para o método Enviar
    // também é possível definir valores padrão para os parâmetros, como o parâmetro "assunto" que tem o valor padrão "Sem assunto".
    public void Enviar(string destinatario, string corpo, string assunto = "Sem assunto")
    {
        Console.WriteLine($"\nEnviando e-mail para: {destinatario}\nAssunto: {assunto}\nCorpo: {corpo}");
    }
}