// Delegate é literalmente delegar um método para usar um método de outro objeto, ou seja,
// é uma referência a um método. Delegates são tipos que representam referências a métodos
// com uma lista de parâmetros e um tipo de retorno específico. Eles são usados para passar
// métodos como argumentos para outros métodos, permitindo a criação de eventos e callbacks.

using Delegate;

Operacao op = Calculadora.Somar;
var soma = op(10, 5);
Console.WriteLine($"Soma: {soma}");

op = Calculadora.Subtrair; // Nota-se que é possível atribuir diferentes métodos à mesma variável de delegate, desde que eles tenham a mesma assinatura.
var subtracao = op(10, 5);
Console.WriteLine($"Subtração: {subtracao}");

op = Calculadora.Multiplicar;
var multiplicacao = op(10, 5);
Console.WriteLine($"Multiplicação: {multiplicacao}");

op = Calculadora.Dividir;
var divisao = op(10, 5);
Console.WriteLine($"Divisão: {divisao}");

// Multicast Delegates: Delegates podem ser combinados para formar uma lista de métodos a serem chamados.
// Isso é feito usando o operador += para adicionar métodos à lista e o operador -= para removê-los.
// Quando um multicast delegate é invocado, todos os métodos na lista são chamados na ordem em que foram adicionados.

Operacao op2 = Calculadora.ExibirSoma;
op2 += Calculadora.ExibirSubtracao; // Adicionando outro método ao delegate

op2(2, 3); // Chamando o delegate, que invocará ambos os métodos

op2 -= Calculadora.ExibirSubtracao; // Removendo o método do delegate

// Método anônimo: Um método anônimo é um método sem nome que pode ser definido no local onde é usado. Ele é útil quando você precisa de
// um método simples e não quer criar uma função separada para ele. Em C#, métodos anônimos podem ser criados usando expressões lambda ou
// a palavra-chave delegate.

Operacao op3 = delegate (double x, double y)
{
    Console.WriteLine("Método anônimo chamado.");
    return x + y;
};

op3(4, 7);

// Usando expressão lambda para criar um método anônimo mais conciso

var nomes = new List<String> { "Alice", "Bob", "Charlie" };
string? resultado = nomes.Find(nome => nome.StartsWith("A")); // Usando expressão lambda para encontrar o primeiro nome que começa com "A"

// Predicate<T>: Um Predicate<T> é um tipo de delegate que representa um método que recebe um parâmetro do tipo T e retorna um valor booleano.
// Ele é comumente usado para definir condições de filtragem ou pesquisa em coleções.

Predicate<int> delegatePar = x => x % 2 == 0; // Usando expressão lambda para definir um Predicate que verifica se um número é par

// Action<T>: Um Action<T> é um tipo de delegate que representa um método que recebe um parâmetro do tipo T e não retorna nenhum valor (void).

Action<int> delegateDobra = x => Console.WriteLine(x * 2); // Usando expressão lambda para definir um Action que imprime o dobro de um número

// Func<T>: Um Func<T> é um tipo de delegate que representa um método que recebe parâmetros e retorna um valor. Ele pode ter até 16 parâmetros
// de entrada e um parâmetro de saída (o tipo de retorno).
 //  Entrada  Saida
Func<double, double> delegateCalcRaiz = x => Math.Sqrt(x); // Usando expressão lambda para definir um Func que calcula a raiz quadrada de um número
public delegate double Operacao(double x, double y);