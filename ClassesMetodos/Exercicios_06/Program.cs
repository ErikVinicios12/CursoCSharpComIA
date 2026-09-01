//x - Crie um campo estático ValorIpva do tipo double que  vai definir o valor percentual do IPVA cobrado para 
//todos os carros
//y- Crie um método estático ObterValorIPVA que atribua o valor 4 ao campo ValorIpva
//z- Acesse o valor do campo ValorIpva e exiba no console. Explique o comportamento da palavra-chave static


// A palavra-chave static em C# é usada para declarar membros que pertencem à própria classe,
// em vez de a uma instância específica da classe. Isso significa que você não precisa criar
// um objeto da classe para acessar membros estáticos; eles podem ser acessados diretamente
// através do nome da classe. No exemplo fornecido, o campo ValorIpva e o método ObterValorIPVA
// são estáticos, permitindo que sejam acessados sem a necessidade de instanciar a classe Veiculo.

Veiculo.ObterValorIPVA();
Console.WriteLine($"Valor do IPVA: {Veiculo.ValorIpva}");

public static class Veiculo
{
    public static double ValorIpva;
    public static void ObterValorIPVA()
    {
        ValorIpva = 4.0;
    }
}