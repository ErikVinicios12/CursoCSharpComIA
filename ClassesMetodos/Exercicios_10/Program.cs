//-Explique como poderíamos substituir o método ObterValorIPVA() de forma a inicializar o campo estático 
//ValorIpva quando uma instância da classe fosse criada.
//- Implemente o código que realiza essa substituição
//- Qual o efeito de alterar o modificador de acesso do campo estático ValorIpva de public para internal ?
// R: a alteração do modificador de acesso de public para internal restringe o acesso ao campo ValorIpva
// apenas para o assembly em que a classe Veiculo está definida. Isso significa que outras classes fora
// desse assembly não poderão acessar diretamente o campo ValorIpva, promovendo um maior encapsulamento
// e controle sobre como o valor é acessado e modificado.
//-Qual o efeito de alterar o modificador de acesso do campo estático ValorIpva de public para private
// R: a alteração do modificador de acesso de public para private restringe o acesso ao campo ValorIpva
// apenas para o assembly em que a classe Veiculo está definida. Isso significa que outras classes fora
// desse assembly não poderão acessar diretamente o campo ValorIpva, promovendo um maior encapsulamento
// e controle sobre como o valor é acessado e modificado.

public class Veiculo
{
    public static decimal ValorIpva { get; private set; }
    public Veiculo()
    {
        // Inicializa o campo estático ValorIpva quando uma instância da classe é criada
        ObterValorIPVA();
    }
    private void ObterValorIPVA()
    {
        // Lógica para calcular o valor do IPVA
        ValorIpva = 1000.00m; // Exemplo de valor fixo para simplificação
    }
}