//r - Crie um método AumentarPotenciaVelocidade que recebe o parâmetro int potencia e  retorna um int
//como valor da nova potência. Neste método use parâmetro out  e passe a variável velocidade e que vai 
//retornar a nova velocidade como um double.
//(incremente a potência de 7 e calcule a nova velocidade multiplicando a potência por 1.75)
//s- Faça a chamada ao método exibindo os valores da nova potencia e da nova velocidade e explique o 
//comportamento do parâmetro out

int potencia = 10;

Console.WriteLine($"Potência inicial: {potencia}");
Velocimetro velocimetro = new Velocimetro();
potencia = velocimetro.AumentarPotenciaVelocidade(potencia, out double velocidade);

Console.WriteLine($"Nova potência: {potencia}\n" +
    $"Nova velocidade: {velocidade}");
public class Velocimetro
{
    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }
}