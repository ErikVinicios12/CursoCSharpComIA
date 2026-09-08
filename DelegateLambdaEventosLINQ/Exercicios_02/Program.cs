//1 - Considere as seguintes assertivas sobre delegates na linguagem C#. Indique se cada uma é verdadeira 
//ou falsa: 
//a-(V) Um delegate é um tipo de dado que pode ser usado para encapsular um método e chamá-lo
//posteriormente. 
//b-(V) Para declarar um delegate em C#, é necessário especificar o tipo de retorno do método que ele 
//encapsula, bem como os tipos de parâmetros. 
//c-(V) É possível usar o operador += para adicionar vários métodos a um delegate, que serão chamados em
//sequência quando o delegate for invocado.
//d-(V) O delegate pode ser passado como parâmetro para outro método, permitindo que o método receptor
//invoque o método encapsulado no delegate. 
//e-(V) O uso de delegates pode melhorar a modularidade e a flexibilidade do código, permitindo que um 
//método seja substituído por outro sem que isso afete o restante do código. 
//f-(F) Delegates só podem ser usados para encapsular métodos estáticos, não métodos de instância. 
//g-(F) O delegate é um recurso exclusivo da linguagem C#, e não pode ser encontrado em outras linguagens de 
//programação. 
//h-(V) Delegates são frequentemente usados em eventos, para permitir que um objeto notifique outros 
//objetos quando ocorre alguma ação. 



//2- Implemente um programa que use delegates para somar dois números inteiros. O programa deve seguir 
//as seguintes especificações: 
//a - Defina um delegate chamado OperacaoMatematica que recebe dois inteiros como parâmetros e retorna
//um inteiro. 
//b-Defina um método que implementam a operação de soma: que recebe os dois inteiros como parâmetros
//c-Crie um objeto delegate do tipo OperacaoMatematica e atribua a ele ao método definido.
//d-Chame o delegate passando os parâmetros necessários e exiba o resultado da operação na tela. 
//Dica: Utilize o método Invoke do delegate para invocar a operação matemática.

//OperacaoMatematica op = Somar;

//Console.WriteLine($"Resultado da soma: {op.Invoke(10, 5)}"); // Exibindo o resultado da operação na tela");
//int Somar(int a, int b)
//{
//    return a + b;
//}
//delegate int OperacaoMatematica(int x, int y);



//3- Implemente um programa em C# que use multicast delegates para exibir uma mensagem de boas-vindas 
//ao usuário.O programa deve seguir as seguintes especificações: 
//a- Defina um multicast delegate chamado MensagemBoasVindas que não recebe parâmetros e não retorna
//nenhum valor.
//b- Defina duas funções que exibem uma mensagem de boas-vindas: uma em português e outra em inglês. 
//c- Crie um objeto delegate do tipo MensagemBoasVindas e adicione as duas funções criadas a ele usando o
//operador +=. 
//d- Chame o delegate para executar as duas funções e exibir as mensagens de boas-vindas.
//MensagemBoasVindas boasVindas = ExibirMensagemPortugues;
//boasVindas += ExibirMensagemIngles;
//boasVindas.Invoke();

//void ExibirMensagemPortugues()
//{
//    Console.WriteLine("Bem-vindo ao programa!");
//}

//void ExibirMensagemIngles()
//{
//    Console.WriteLine("Welcome to the program!");
//}
//delegate void MensagemBoasVindas();



//4- Dado o código abaixo, assinale com verdadeiro ou falso cada afirmação sobre os delegates Action,
//Predicate e Func da linguagem C#: 
//int[] numeros = { 1, 2, 3, 4, 5 }
//;
//// Delegate Action 
//Action<int> exibirNumero = num => Console.WriteLine(num);
//Array.ForEach(numeros, exibirNumero);
//// Delegate Predicate 
//Predicate<int> ehPar = num => num % 2 == 0;
//bool todosPares = Array.TrueForAll(numeros, ehPar);
//// Delegate Func 
//Delegates , Lambda, LINQ 
//Func<int, int, int> somar = (a, b) => a + b;
//int resultado = somar(10, 20);
//Console.WriteLine(todosPares);
//Console.WriteLine(resultado);
//Console.ReadKey();
//a-(V) O delegate Action é usado para encapsular um método que recebe um parâmetro e não retorna nenhum
//valor. (Verdadeiro ou Falso)
//b-(V) O método Array.ForEach é usado para percorrer todos os elementos de um array e executar um delegate
//para cada um deles. (Verdadeiro ou Falso)
//c-(V) O delegate Predicate é usado para encapsular um método que recebe um parâmetro e retorna um valor
//booleano. (Verdadeiro ou Falso)
//d-(V) O método Array.TrueForAll retorna true se todos os elementos de um array satisfazem uma condição 
//especificada por um delegate. (Verdadeiro ou Falso)
//e-(V) O delegate Func é usado para encapsular um método que recebe um ou mais parâmetros e retorna um
//valor. (Verdadeiro ou Falso)
//f-(V) O delegate Func pode ter até 16 parâmetros de entrada e um tipo de retorno genérico. (Verdadeiro ou
//Falso)
//g-(V) No exemplo acima, o delegate Func é usado para definir um método que soma dois números inteiros. 
//(Verdadeiro ou Falso)
//h-(V) No exemplo acima, o método somar recebe dois parâmetros e retorna um valor. (Verdadeiro ou Falso) 



//5- Imagine que você precisa criar um método que imprima na tela os números pares de uma lista de inteiros 
//de 1 a 20. 
//Para isso, você deve utilizar um delegate Action<int> que receba um número inteiro como parâmetro e
//imprima na tela apenas os números pares. 
//int[] list = new int[5] { 1, 2, 3, 4, 5 };

//Action<int> imprimirPares = numero =>
//{
//    if (numero % 2 == 0)
//    {
//        Console.WriteLine(numero);
//    }
//};

//Array.ForEach(list, imprimirPares);



//6- Crie um programa onde um método que receba dois números inteiros e retorne o resultado da operação
//de adição ou subtração desses números, a ser definida em tempo de execução por um delegate Func<int, int,
//int>.
//Func<int, int, int> operacao = (a, b) => a + b; // Operação de adição
//int resultadoAdicao = operacao(10, 5);
//Console.WriteLine($"Resultado da adição: {resultadoAdicao}");
//operacao = (a, b) => a - b; // Operação de subtração
//int resultadoSubtracao = operacao(10, 5);
//Console.WriteLine($"Resultado da subtração: {resultadoSubtracao}");



//7- Suponha que você possui uma lista de planetas com informações sobre o nome, diâmetro e massa de cada
//planeta.  
//Crie um programa e implemente um método que recebe essa lista e um delegate Predicate<Planeta> para
//filtrar os planetas de acordo com um critério específico.
//Planeta[] listaPlanetas = new Planeta[]
//{
//    new Planeta("Mercúrio", 4879, 3.285e23),
//    new Planeta("Vênus", 12104, 4.867e24),
//    new Planeta("Terra", 12742, 5.972e24),
//    new Planeta("Marte", 6779, 6.39e23),
//    new Planeta("Júpiter", 139820, 1.898e27),
//    new Planeta("Saturno", 116460, 5.683e26),
//    new Planeta("Urano", 50724, 8.681e25),
//    new Planeta("Netuno", 49244, 1.024e26)
//};

//Predicate<Planeta> filtroPlanetas = planeta => planeta.Diametro > 10000; // Exemplo de critério: filtrar planetas com diâmetro maior que 10.000 km

//Array.TrueForAll(listaPlanetas, filtroPlanetas); // Verifica se todos os planetas atendem ao critério do filtro
//class Planeta
//{
//    public string Nome { get; set; }
//    public double Diametro { get; set; }
//    public double Massa { get; set; }
//    public Planeta(string nome, double diametro, double massa)
//    {
//        Nome = nome;
//        Diametro = diametro;
//        Massa = massa;
//    }
//}



//8 - Qual é a definição correta de expressão lambda em C#? 
//a)(X) Uma função anônima que pode ser passada como argumento para outros métodos e que pode ser 
//definida em apenas uma linha de código. 
//b)( ) Uma função que sempre retorna um valor booleano. 
//c)( ) Uma função que sempre tem um único parâmetro de entrada. 
//d)( ) Uma função que sempre retorna um valor inteiro. 



//9- Crie um método de extensão para a classe List<int> na linguagem C# que, dado uma lista de inteiros, 
//retorne a soma de todos os elementos da lista que são ímpares. 
//Em seguida, crie um programa que instancie uma lista de inteiros com alguns números ímpares e alguns 
//números pares e use o método de extensão criado para obter a soma dos números ímpares da lista. 
//List<int> minhaLista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int somaImpares = minhaLista.SomarImpares();
//Console.WriteLine(somaImpares);



//10 - Exercicios sobre LINQ 
//Delegates , Lambda, LINQ 

//Exercício 1: Utilizando o método Where 
//Dado um array de strings, escreva um programa em C# que use a biblioteca LINQ para obter somente as 
//strings que contenham a letra 'a'. 
//string[] palavras = { "casa", "carro", "bicicleta", "avião", "ônibus" };
//var palavrasComA = palavras.Where(p => p.Contains('a'));
//Console.WriteLine("Palavras com a letra 'a':");
//foreach (var palavra in palavrasComA)
//{
//    Console.WriteLine(palavra);
//}



//Exercício 2: Utilizando o método OrderBy 
//Dado um array de inteiros, escreva um programa em C# que use a biblioteca LINQ para ordenar os valores 
//em ordem crescente. 
//int[] nums = { 5, 2, 8, 1, 4 };

//foreach (int num in nums.OrderBy(n => n))
//{
//    Console.WriteLine(num);
//}



//Exercício 3: Utilizando o método GroupBy 
//Dado um array de strings, escreva um programa em C# que use a biblioteca LINQ para agrupar as strings por 
//tamanho 
//string[] palavras = { "casa", "carro", "bicicleta", "avião", "ônibus" };
//var palavrasAgrupadas = palavras.GroupBy(p => p.Length);
//foreach (var grupo in palavrasAgrupadas)
//{
//    Console.WriteLine($"Palavras com {grupo.Key} letras:");
//    foreach (var palavra in grupo)
//    {
//        Console.WriteLine(palavra);
//    }
//}


//Exercício 4: Utilizando o método FirstOrDefault 
//Dado um array de inteiros, escreva um programa em C# que use a biblioteca LINQ para obter o primeiro 
//número par do array.
//int[] nums = { 5, 2, 8, 1, 4 };
//int primeiroPar = nums.FirstOrDefault(n => n % 2 == 0);
//Console.WriteLine($"O primeiro número par é: {primeiroPar}");
