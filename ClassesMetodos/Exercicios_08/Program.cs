//w3 - Crie uma struct chamada Cliente e defina os campos Nome e Email do tipo string e a propriedade Idade
//do tipo int
//w4- Validar a informação da Idade de forma que se a idade informada for menor que 18 seja atribuído 18 ao 
//valor da idade.
//w5- Crie um construtor para a struct usando os campos Nome e Email e a propriedade Idade como parâmetros 
//de entrada para criar um objeto do tipo Cliente
//w6- Crie um método estático que retorne void chamado ExibirInfo que receba os parâmetros nome, email e 
//idade e exiba as informações de Nome, Email e Idade. Defina idade como um parâmetro opcional.
//w7- Crie um objeto cliente da struct Cliente usando o construtor criado e exiba as informações chamando duas 
//vezes o método ExibirInfo usando argumentos nomeados. Na primeira chamada informe todos os parâmetros e 
//na segunda não informe o ano.
//w8- Explique o que uma struct e qual a principal diferença entre struct e classe

Cliente c1 = new Cliente("João", "joao@email.com", 25);
Cliente.ExibirInfo(nome: c1.Nome, email: c1.Email, idade: c1.Idade);
Cliente.ExibirInfo(nome: c1.Nome, email: c1.Email); // idade will default to 18

struct Cliente
{
    public string Nome;
    public string Email;
    private int idade;
    public int Idade
    {
        get { return idade; }
        set { idade = value < 18 ? 18 : value; }
    }
    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade; // This will invoke the property setter and validate the age
    }
    public static void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"Nome: {nome}, Email: {email}, Idade: {idade}");
    }
}