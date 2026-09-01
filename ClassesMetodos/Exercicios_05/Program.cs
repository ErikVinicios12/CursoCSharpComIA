//t - Crie um método chamado ExibirInfo() que retorna void e que utiliza os parâmetros : Modelo, Montadora,
//Marca, Potencia e Ano e que exiba as informações destes atributos no console.
//u- Para este método defina o parâmetro Ano como opcional e faça duas  chamadas ao método usando o 
//conceito de argumentos nomeados 
//não informando o ano na primeira  chamada e informando o ano na segunda 
//chamada.
//v- Explique o uso do parâmetro opcional e dos argumentos nomeado

Veiculo veiculo = new Veiculo();

// Chamadas ao método ExibirInfo() usando argumentos nomeados
// Como não informamos o parâmetro opcional 'ano' na primeira chamada, ele assumirá o valor padrão definido no método (0)
veiculo.ExibirInfo(modelo: "Civic", montadora: "Honda", marca: "Sedan", potencia: 158);

// Segunda chamada com o parâmetro opcional 'ano' informado
// Aqui informamos o valor do parâmetro 'ano', que será usado no método
veiculo.ExibirInfo(modelo: "Corolla", montadora: "Toyota", marca: "Sedan", potencia: 139, ano: 2020);


public class Veiculo
{
    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 0)
    {
        Console.WriteLine($"\nModelo: {modelo}");
        Console.WriteLine($"Montadora: {montadora}");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Potência: {potencia} HP");
        if (ano != 0)
        {
            Console.WriteLine($"Ano: {ano}");
        }
        else
        {
            Console.WriteLine("Ano: Não informado");
        }
    }
}