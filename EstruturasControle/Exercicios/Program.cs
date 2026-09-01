using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

Console.WriteLine(" Exercicios ");

//1 - Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
//Modelo de saída:
//Encontre o maior dentre 3 números:
//Primeiro Número : 65465  
//Segundo Número : 64658     
//Terceiro Número : 65464       
//O primeiro número : 65465 é o maior

//int maior = 0;
//for (int i = 1; i<=3 ; i++)
//{
//    Console.Write($"Digite o {i}o número: ");
//    int n = Convert.ToInt32(Console.ReadLine());
//    if (i == 1 || n > maior)
//        maior = n;
//}
//Console.WriteLine($"\nO maior número é {maior}");




//2- Escreva um programa para calcular a raiz da equação quadrática :
//- Considere a, b e c números inteiros (positivos, negativos e o zero)
//- Para calcular as raízes use a fórmula de Báskara;
//- Solicite a entrada de a , b  e c e informe se existe ou não raiz real 
//Dica:  Utilize os recursos da classe Math e use a instrução if-else-if
//Modelo de saídas:
//Cálculo da equação do segundo grau (ax^2+bx+c) :
//Informe o valor de a :   2
//Informe o valor de b :   3
//Informe o valor de c :   4
//As raízes são imaginárias;
//Sem solução para os números reais.
//onde
//Cálculo da equação do segundo grau (ax^2+bx+c) :
//Informe o valor de a :   1
//Informe o valor de b :   -1
//Informe o valor de c :   -12
//Ambas as raízes são reais e diferentes
//Primeira raiz x1= 4
//Segunda raiz  x2= -3
//while (true)
//{
//    Console.Write($"Informe o valor de A: ");
//    int a = Convert.ToInt32(Console.ReadLine());
//    Console.Write($"Informe o valor de B: ");
//    int b = Convert.ToInt32(Console.ReadLine());
//    Console.Write($"Informe o valor de C: ");
//    int c = Convert.ToInt32(Console.ReadLine());

//    double delta = Math.Pow(b, 2) - 4 * a * c;

//    if (delta < 0)
//    {
//        Console.WriteLine("Não existe raiz real");
//        break;
//    } else if (delta>=0) {
//        var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//        if (delta == 0)
//        {
//            Console.WriteLine($"Existe uma raiz real´: {x1}");
//            break;
//        }
//        var x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//        Console.WriteLine("\nExistem duas raizes reais:\n" +
//            $"Rais 1: {x1}\n" +
//            $"Raiz 2: {x2}");
//        break;
//    }
//}



//3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop 
//while, do-while e for.
//Modelo de saída:
//Os 10 primeiros números naturais são :
//1 2 3 4 5 6 7 8 9 10
//A soma dos números é : 55

//int soma = 0;
//Console.Write("\nOs 10 primeiros números naturais são:\n");

//for (int i = 1; i <= 10; i++)
//{
//    Console.Write($"{i} ");
//    soma += i;
//}

////int i = 1;
//////while (i <= 10)
//////{
//////    Console.Write($"{i} ");
//////    soma += i;
//////    i++;
//////}

//////do
//////{
//////    Console.Write($"{i} ");
//////    soma += i;
//////    i++;
//////} while (i <= 10);

//Console.WriteLine($"\n\nA soma dos números é: {soma}");



//4- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero 
//recebido via teclado                                                                                                  ----
//- Verifique se o número é maior que zero e emita uma mensagem
//- Considere a tabela de multiplicação de 1 até 10
//- Após exibir a tabela torne a solicitar outro número 
//- Para sair do loop defina uma condição de saída 
//Dica:  Use os loop while e for e para sair a instrução break

//while (true)
//{
//    Console.WriteLine("\n");
//    Console.Write("Digite um número maior que 0: [0 para sair] ");
//    int n = Convert.ToInt32(Console.ReadLine());
//    if (n == 0)
//        break;

//    if (n < 0)
//        continue;

//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine($"{n} X {i} = {n*i}");
//    }
//}



//5- Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de 
//resposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder.
//Nãoutilize a instrução break.
//Abaixo um modelo de saida esperado : 
//Qual a instrução para sair de um loop ?
//a.quit
//b.continue
//c.break
//d.exit
//Qual a opção correta ? (Tecle x para sair)
//Dica :  Usar loop while e instruções if-elseif

//string opt = "";

//while (opt != "X" && opt != "C")
//{
//    Console.Write("\nQual a instrução para sair de um loop?\n" +
//        "A - quit\n" +
//        "B - continue\n" +
//        "C - break\n" +
//        "D - exit\n\n" +
//        "Qual a opção correta? [Tecle X para sair] ");
//    opt = Console.ReadLine().ToString().ToUpper();
//    if (opt != "X" && opt == "C")
//        Console.WriteLine("\nResposta Correta! ");
//}



//6- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 
//maneiras diferentes:-Incrementando 2 em cada passo - Incrementando 1 em cada passo - Com e loop infinito (use "break" e "continue")

//for (int i = 10; i <= 20; i += 2)
//{
//    if (i == 16)
//        continue;

//    Console.Write($"{i} ");

//}

//Console.WriteLine("\n");

//for (int i = 10; i <= 20; i++)
//{
//    if (i % 2 != 0 || i == 16)
//        continue;

//    Console.Write($"{i} ");
//}

//Console.WriteLine("\n");

//int v = 10;
//while (true)
//{
//    if (v > 20)
//        break;
//    if (v == 16)
//    {
//        v += 2;
//        continue;
//    }
//    Console.Write($"{v} ");
//    v += 2;
//}



//7- Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*).  Ex:
//*
//**
//***
//****(dica: loop aninhado)

//for (int i = 0; i <= 10; i++)
//{
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}



//8- Escreva um programa para calcular o fatorial de um número inteiro. 
//O fatorial de um número é representado por : n! =>  n * (n – 1) *(n – 2) ....2 * 1
//Exemplo: fatorial de 6 é representado por  6! = 6*5*4*3*2*1

//Console.WriteLine("Digite um número: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write($"{n}! = ");
//int result = 1;
//for (int i = n; i > 0; i--)
//{
//    Console.Write($"{i}");
//    result *= i;
//    Console.Write(i > 1 ? " * " : " = ");
//}
//Console.Write(result);



//9- Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado
//Modelo de saída:
//2 x 1 = 2
//2 x 2 = 4
//2 x 3 = 6
//2 x 4 = 8
//2 x 5 = 10
//2 x 6 = 12
//2 x 7 = 14
//2 x 8 = 16
//2 x 9 = 18
//2 x 10 = 20
//3 x 1 = 3
//3 x 2 = 6
//3 x 3 = 9
//3 x 4 = 12
//3 x 5 = 15
//3 x 6 = 18
//3 x 7 = 21
//3 x 8 = 24
//3 x 9 = 27
//3 x 10 = 30
//...

//int i = 2;
//do
//{
//    int j = 1;
//    do
//    {
//        Console.WriteLine($"{i} X {j} = {i * j}");
//        j++;
//    } while (j <= 10);
//    i++;
//    Console.WriteLine("\n");
//} while (i <= 6);



//10- Crie um programa  que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de 
//um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a 
//instrução switch, break e default em um loop infinito e defina uma condição de saida.)
//Nota      Avaliação
//10           A+
//9            A
//7 e 8        B
//6            C
//5            E
//0 a 4        F

//while (true)
//{
//    Console.Write("\nNota do aluno (0 a 10) [Digite -1 para sair]: ");
//    int nota = Convert.ToInt32(Console.ReadLine());
//    if (nota == -1 )
//        break;

//    switch (nota)
//    {
//        case 10:
//            Console.WriteLine("Avaliação: A+");
//            break;
//        case 9:
//            Console.WriteLine("Avaliação: A");
//            break;
//        case 8:
//        case 7:
//            Console.WriteLine("Avaliação: B");
//            break;
//        case 6:
//            Console.WriteLine("Avaliação: C");
//            break;
//        case 5:
//            Console.WriteLine("Avaliação: E");
//            break;
//        case 4:
//        case 3:
//        case 2:
//        case 1:
//        case 0:
//            Console.WriteLine("Avaliação: F");
//            break;
//        default:
//            Console.WriteLine("Nota inválida. Digite um número entre 0 e 10.");
//            break;
//    }
//}

//11- Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números 
//inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e 
//quando isso ocorrer exibir uma mensagem de alerta)
//Modelos de saída esperados:
//Informe o primeiro número:      
//78
//Informe o operando (+, -, /, *): +
//Informe o segundo número:        
//Informe o primeiro número:      
//1
//Informe o operando (+, -, /, *): /
//22
//78 + 22 = 100
//Informe o segundo número:        
//0
//Não existe divisão por zero !!!
//1 /  0 =  8   (Símbolo de infinito

//while (true) {
//    Console.Write("\nInforme o primeiro número: ");
//    int num1 = Convert.ToInt32(Console.ReadLine());
//    Console.Write("Informe o operando (+, -, /, *): ");
//    string operando = Console.ReadLine();
//    Console.Write("Informe o segundo número: ");
//    int num2 = Convert.ToInt32(Console.ReadLine());
//    if ((num1 == 0) || (num2 == 0))
//        Console.WriteLine("Não existe divisão por zero !!!");
//    else
//    {
//        switch (operando)
//        {
//            case "+":
//                Console.WriteLine($"{num1} {operando} {num2} = {num1 + num2}");
//                break;
//            case "-":
//                Console.WriteLine($"{num1} {operando} {num2} = {num1 - num2}");
//                break;
//            case "*":
//                Console.WriteLine($"{num1} {operando} {num2} = {num1 * num2}");
//                break;
//            case "/":
//                Console.WriteLine($"{num1} {operando} {num2} = {(double)num1 / num2}");
//                break;
//            default:
//                Console.WriteLine("Operando inválido. Use +, -, *, ou /.");
//                break;
//        }
//    }
//}
