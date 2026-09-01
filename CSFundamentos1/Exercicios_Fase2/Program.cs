//Exercícios fase 2

//1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :  
//Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings.
//string nome = "Paulo";
//int idade = 17;
//double nota = 7.5;
//Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\nNota: {nota}");

//2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
//escapes.
//Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\nNota: {nota}");

//3- Para qual tipo de dados você pode converter um float implicitamente ?
//( ) int
//(X) double
//( ) long
//( ) decimal

//4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?  
//( ) int para long
//(X) double para long 
//(X) double para float
//(X) decimal para float
//(X) long para int
//(X) double para decimal

//5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando 
//a concatenação e também a interpolação de strings
//Console.Write("\nDigite o 1o número: ");
//int n1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Digite o 2o número: ");
//int n2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Digite o 3o número: ");
//int n3 = Convert.ToInt32(Console.ReadLine());
//string result = n3.ToString() + n2.ToString() + n1.ToString();
//Console.Write($"\n{result}");

//6- Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
//(F) long resultado = 1.32;
//(V) var nome = “Maria”;
//(V) string resultado = 100.ToString();
//(V) A sequência de escape \n inclui uma nova linha
//(F) float f = 5.45;  
//(V) decimal valor = (decimal)10.99f;
//(F) var status = null;
//(V) object o = 12.45m; 
//(V) string titulo = true.ToString(); 
//(F)A sequencia \t inclui uma tabulação vertical

//7- Escreva um programa para receber dois valores via teclado do tipo double e a seguir 
//realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo 
//exibindo o resultado:
//Console.Write("\nValor 1: ");
//double v1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Valor 2: ");
//double v2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"\nSoma: {v1 + v2}\n" +
//    $"Subtração: {v1 - v2}\n" +
//    $"Multiplicação: {v1 * v2}\n" +
//    $"Exponenciação: {Math.Pow(n1, n2)}\n" +
//    $"Divisão: {v1 / v2}\n" +
//    $"Módulo: {v1 % v2}\n");

//8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de 
//a b e c .
//a = 1 , b = 12  e c = -13
//const int A = 1;
//const int B = 12;
//const int C = -13;
//const double DELTA = (B ^ 2 - 4 * A * C);

//double x1 = (-B + Math.Sqrt(DELTA)) / 2 * A;
//double x2 = (-B - Math.Sqrt(DELTA)) / 2 * A;

//Console.WriteLine($"X1 = {x1}\nX2 = {x2}");

//9- Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e 
//Senha é um inteiro. Se o nome for igual a ‘admin’  ou ‘maria’ e a senha for igual a ‘123’ 
//então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login 
//inválido’: (use o operador condicional ternário)
//Console.Write("Login: ");
//string login = Console.ReadLine();
//Console.Write("Senha: ");
//int senha = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine((login == "admin" || login == "maria") && senha == 123 ? "Login feito com sucesso!" : "Login inválido");

//10- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando 
//a nomenclatura usada:
//(V) string? nome; é um exemplo de nullable reference type;
//(F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
//(F) A ordem de precedência dos operadores lógicos é :  ! , || e && (NOT, OR e AND)
//(V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
//(F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
//(F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
//(V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
//(F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
//(F) Para x = 5, a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
//(V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
//(V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"

//11- Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no 
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
//Console.Write("Valor X: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.Write("Valor Y: ");
//int y = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(x % 2 == 0 ? "X é par" : "X é impar");
//Console.WriteLine(y % 2 == 0 ? "Y é par" : "Y é impar");

//12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no 
//console o resultado das seguintes operações :   (x ^ 2->x ao quadrado) (pi = 3.1415)-6 + x * 5
//(13-2) * x
//(x + -2) * (20 / x)
//(12 + x) / (x - 4)
//3 x^2 + x + 10
//pi * x^2
//Console.Write("Valor de X: ");
//int x = Convert.ToInt32(Console.ReadLine());
//const double PI = 3.1415;

//Console.WriteLine($"-6 + x * 5 = {-6 + x * 5}");
//Console.WriteLine($"(13 - 2) * x = {(13 - 2) * x}");
//Console.WriteLine($"(x + -2) * (20 / x) = {(x + -2) * (20 / x)}");
//Console.WriteLine($"(12 + x) / (x - 4) = {(12 + x) / (x - 4)}");
//Console.WriteLine($"3 x ^ 2 + x + 10 = {3 * (Math.Pow(x, 2)) + x + 10}");
//Console.WriteLine($"pi* x^2 = {PI * Math.Pow(x, 2)}");


//13- Considere o seguinte trecho de código:
//int y = 5;
//y = (y++) + y + (++y);
//Console.WriteLine(y);
//y = y++ + y + ++y;
//Console.WriteLine(y);


//14- Escreva um programa que solicite a temperatura em graus Celsius e converta para 
//Kelvin e Farhenheit usando as fórmulas a seguir:-Converter para Kelvin => K = C + 273; -Converter para Farhenheit => F = (C * 9) / 5 + 32;
//Console.Write("Temperatura em Celsius: ");
//double celsius = Convert.ToDouble(Console.ReadLine());

//double kelvin = celsius + 273;
//double farhenheit = (celsius * 9) / 5 + 32;

//Console.WriteLine($"\nCelsius: {celsius}\n" +
//    $"Kelvin: {kelvin}\n" +
//    $"Farhenheit: {farhenheit}");

//15 -Escolha a opção que representa a  exibição do resultado para o código usando os 
//operadores de decremento e incremento  (prée pós) : 
//var numero = 5;
//Console.WriteLine(numero++);
//numero = 1;
//Console.WriteLine(++numero);
//numero = 2;
//Console.WriteLine(numero--);
//numero = 3;
//Console.WriteLine(--numero);
//Console.ReadKey();
//(X) 5, 2, 2, 2;
//( ) 6, 3, 2, 2;
//( ) 5, 2, 1, 2;
//( ) 6, 2, 1, 3;