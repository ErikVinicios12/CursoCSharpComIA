//g - Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não 
//use a palavra-chave this)
//h- Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro
//i- Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que 
//vai retornar um double representando a velocidade máxima do carro
//( Para calcular a velocidade multiplique a potencia por 1.75)
//j- Explique o comportamento da palavra return

public class Carro
{
    public string Modelo { get; set; }
    public string Montadora { get; set; }
    // Construtor que permite criar um carro usando apenas Modelo e Montadora
    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }
    // Método que calcula a velocidade máxima com base na potência
    public double VelocidadeMaxima(int potencia)
    {
        // Retorna a velocidade máxima calculada multiplicando a potência por 1.75
        return potencia * 1.75;
    } 
}