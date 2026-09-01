using System.Collections;

//1 - Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize 
//as seguintes operações :  Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora
//a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
//b- Exiba os nomes da segunda e da penúltima fruta no console
//c- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
//d- Ordene a coleção de frutas na ordem ascendente
//e- Exiba no console a coleção de nomes de frutas na ordem inversa

//string[] frutas = new string[] { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };

//Console.WriteLine("\n Exibição com FOR \n");
//for (int i = 0; i < frutas.Length; i++)
//{
//    Console.Write($"{frutas[i]} ");
//}

//Exibir(frutas, "Exibição com FOREACH");

//Console.WriteLine($"\n\nSegunda: {frutas[1]}\n" +
//    $"Penúltima: {frutas[frutas.Count() - 2]}");

//frutas[2] = "Kiwi";
//frutas[frutas.Count() - 1] = "Caqui";

//Exibir(frutas, "Agora com Kiwi e Caqui");

//frutas.Sort();

//Exibir(frutas, "Ordenada");;

//Exibir(frutas.OrderDescending().ToArray(), "Ordem inversa");

//static void Exibir(string[] frutas, string texto)
//{
//    Console.WriteLine($"\n\n {texto} \n");
//    foreach (var fruta in frutas)
//    {
//        Console.Write($"{fruta} ");
//    }
//}



//2- Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas 
//etapas a seguir
//a-) Solicite via teclado o número de valores do array (deve ser um número inteiro)
//b-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
//c-) Solicite ao usuário um valor de um número inteiro a procurar no array
//d-) Exiba se o número informado existe no array de inteiros ou não     
//e-) Repita até que o texto ‘fim’ seja inserido via teclado
//while (true)
//{
//    try
//    {
//        Console.Write("Tamanho do array: ['fim' para sair] ");
//        var result = Console.ReadLine();
//        if (result == "fim")
//            break;

//        int tArray = Convert.ToInt32(result);

//        int[] array = new int[tArray];
//        Random random = new Random();
//        for (int i = 0; i < tArray; i++)
//        {
//            array[i] = random.Next(0, 20);
//        }

//        Console.Write("Digite um número: ");
//        int v = Convert.ToInt32(Console.ReadLine());

//        if (array.Contains(v))
//            Console.WriteLine($"\nValor encontrado no indice {array.IndexOf(v)}");
//        else
//            Console.WriteLine("\nValor não encontrado");
//    } catch (Exception e) {
//        Console.WriteLine("\nValor inválido\n");
//        continue;
//    }
//}



//3-Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo float , para 10 
//alunos divididos em 2 grupos de 5 alunos cada. Armazene as informações em um array bidimensional e a 
//seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).
//float[,] notas = new float[2, 10];
//float media1 = 0;
//float media2 = 0;
//for (int i = 0; i < notas.GetLength(0); i++)
//{
//    Console.WriteLine($"\n NOTAS GRUPO {i + 1}\n");
//    for (int j = 0; j < notas.GetLength(1); j++)
//    {
//        Console.Write($"Aluno {j + 1}: ");
//        var nota = (float)Convert.ToDecimal(Console.ReadLine());
//        if (i == 0)
//            media1 += nota;
//        else
//            media2 += nota;
//    }
//    Console.WriteLine();
//}

//media1 = media1 / notas.GetLength(1);
//media2 = media2 / notas.GetLength(1);

//Console.WriteLine($"\nMédia grupo 1: {media1}\n" +
//    $"Média grupo 2: {media2}");



//4- Crie um programa C# que usa uma ArrayList para armazenar uma lista de objetos pessoas. 
//a-) Primeiro crie uma classe chamada Pessoa.cs com duas propriedades (nome e idade) e um método Exibir() 
//para imprimir o nome e a idade;
//b -) A seguir crie uma ArrayList e solicite a informação dos nomes e idades de 3 pessoas via teclado 
//armazenando as informações na ArrayList. 
//c-) A seguir exiba no console a lista das pessoas com nome e idade
//d-) Inclua mais dois objetos Pessoa na lista e exiba a nova lista de pessoas
//e-) Remova o último elemento da coleção e exiba a lista completa
//Use seguintes dados iniciais:   Ana, 22  - Diná, 21  - Maria, 19
//Ao incluir os objetos pessoa use os dados :   Jaime,20  - Tânia,18
//ArrayList Pessoas = new ArrayList();
//Pessoa pessoa;

//for (int i = 0; i < 3; i++)
//{
//    pessoa = new Pessoa();
//    Console.WriteLine($"\n\n Pessoa {i + 1}\n");
//    Console.Write("Nome: ");
//    pessoa.Nome = Console.ReadLine();
//    Console.Write("Idade: ");
//    pessoa.Idade = Convert.ToInt32(Console.ReadLine());
//    Pessoas.Add(pessoa);
//}

//Console.WriteLine($"\n LISTA DE PESSOAS \n");

//foreach (Pessoa p in Pessoas)
//{
//    p.Exibir();
//}

//Pessoas.Add(new Pessoa() { Nome = "Jaime", Idade = 20 });
//Pessoas.Add(new Pessoa() { Nome = "Tania", Idade = 18 });

//Console.WriteLine($"\n LISTA COM MAIS 2 PESSOAS \n");

//foreach (Pessoa p in Pessoas)
//{
//    p.Exibir();
//}

//Pessoas.RemoveAt(Pessoas.Count - 1);

//Console.WriteLine($"\n LISTA SEM O ÚLTIMO \n");

//foreach (Pessoa p in Pessoas)
//{
//    p.Exibir();
//}



//5- Dada uma classe Produto contendo duas propriedades :  Nome(string) e Preco(decimal). Crie uma lista 
//de objetos do tipo Produto usando os seguinte dados:
//Clips, R$ 3,95 - Caneta, R$ 5,99 -- Lápis, R$ 4,15 - Estojo, R$ 6,99 e Caderno, R$ 7,55 
//A seguir realize as seguintes operações na lista de objetos Produto criada : 
//1 - Crie um método para exibir a relação de produtos , a soma total dos preços dos produtos, a média do 
//preço dos produtos e a quantidade de produtos na lista
//2- Inclua na lista o seguinte produto :  Mochila, R$ 22,44  e exiba novamente a lista de produtos
//3- Ordene a lista pelo nome do produto e exiba a lista ordenada
//4- Obtenha e exiba no console os produtos com preço inferior a R$ 5,00 
//5- Localize na lista o produto com nome Estojo
//List<Produto> produtos = new List<Produto>()
//{
//    new Produto() { Nome = "Clips", Preco = 3.95m},
//    new Produto() { Nome = "Caneta", Preco = 5.99m},
//    new Produto() { Nome = "Lápis", Preco = 4.15m},
//    new Produto() { Nome = "Estojo", Preco = 6.99m},
//    new Produto() { Nome = "Caderno", Preco = 7.55m}
//}; 

//Produto.Resumo(produtos, "LISTA");

//produtos.Add(new Produto() { Nome = "Mochila", Preco = 22.44m });

//Produto.Resumo(produtos, "LISTA COM MOCHILA");

//Produto.Resumo(produtos.OrderBy(x => x.Nome).ToList(), "LISTA ORDENADA");

//Produto.Resumo(produtos.Where(p => p.Preco < 5).ToList(), "LISTA PRODUTOS MENOR QUE 5");

//if (produtos.FirstOrDefault(p => p.Nome.Equals("Estojo")) != null)
//{
//    int indexEstojo = produtos.FindIndex(p => p.Nome.Equals("Estojo"));
//    Console.WriteLine($"\nProduto 'Estojo' está no index {indexEstojo}");
//}



//6- Crie um programa C# e defina um método chamado ProcessaObjetos() que possa receber um número 
//variáveis de argumentos e que possa exibir os seus valores e também o tipo do objeto (Use o método 
//GetType() herdado de Object) no console.
//Passe os seguintes argumentos ao invocar o método : ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null)

//ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null);
//void ProcessaObjetos(params ArrayList objetos) {
//    foreach (object obj in objetos)
//    {
//        if (obj == null)
//        {
//            Console.WriteLine($"Valor: null - Tipo: null");
//        } else if (obj.GetType() == typeof(string))
//        {
//            Console.WriteLine($"Valor: {obj} - Tipo: string");
//        } else if (obj.GetType() == typeof(decimal))
//        {
//            Console.WriteLine($"Valor: {obj} - Tipo: decimal");
//        } else if (obj.GetType() == typeof(Teste))
//        {
//            Console.WriteLine($"Valor: {obj} - Tipo: Teste");
//        } else if (obj.GetType() == typeof(int))
//        {
//            Console.WriteLine($"Valor: {obj} - Tipo: int");
//        }
//    }
//}



//7- Crie um indexador para uma classe Aluno para gerenciar uma coleção de nomes de alunos com no máximo 
//10 elementos.
//Para testar a implementação atribua nomes e obtenha os valores atribuídos usando o indexador criado

Aluno aluno = new Aluno();
for (int i = 0; i < 20; i++)
{
    Console.Write($"Digite o {i + 1} valor: ");
    aluno[i] = Console.ReadLine();

    foreach (var a in aluno.alunos)
    {
        Console.WriteLine(a);
    }
}
public class Aluno
{
    public string[] alunos = new string[10];
    public string this[int i]
    {
        get
        {
            if (i < alunos.Length)
            {
                return alunos[i];
            }
            return "Limite atingido!";
        }
        set
        {
            if (i < alunos.Length)
            {
                alunos[i] = value;
            }
        }
    }
}