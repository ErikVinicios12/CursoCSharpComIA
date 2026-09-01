//Exercícios fase 1

//1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
int idade = 35;
Console.WriteLine(idade);

//2- Crie uma variável chamada nome e  atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine(nome);

//3- Crie uma variável chamada altura e atribua a ela o valor 3.45.
float altura = 3.45f;

//4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine(data);

//5- Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;
const int ano = 12;
Console.WriteLine(ano);

//6 - Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o 
//valor 7.80 e exiba o seu valor.
double? nota = 7.80;
Console.WriteLine(nota);

//7- Quais as diferenças entre os tipos por valor e os tipos por referência ?
//R: Tipos por valor guardam o dado real na própria variável. Já os tipos por referencia guardam apenas o endereço/referência
//onde o dado real está

//8- Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
int x = 10;
double numero = 7.99;
char letra = 'C';
float temperatura = 27.4f;
bool ativo = false;
string nome2 = "Manoel";
decimal salario = 950.99m;
DateTime hoje = DateTime.Now;

//9- Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por 
//referência (R) :
//(V) int n = 1;
//(R) string titulo = "A vida";
//(V) float f = 12.45f;
//(V) double d = 5.45;
//(V) decimal valor = 10.99m;
//(V) char sexo = ‘M’;
//(R) object o = null;

//10- O que é um nullable type e qual a sua utilidade ?
//R: è um tipo que pode receber "null" como valor e serve para trabalhar com valores incertos

//11- O que é Camel Case ? Dê um exemplo de sua aplicação.
//R: Quando o identificador começa com letra minuscula. Usado para variáveis e coisas privadas/locais

//12- O que é Pascal Case ? Dê um exemplo de sua aplicação.
//R: Quando o identificador começa com letra minuscula. Usado para classes, métodos e coisas públicas

//13- Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a 
//seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a 
//operação de soma)
int x2 = 77;
int y = 66;
Console.WriteLine(x2+y);

//14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e 
//string.
//R: bool = false, char = '', int = 0, float = 0, decimal = 0, string = null

//15- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis 
//considerando a nomenclatura usada:
//(F) double 1valor = 12.45;
//(F) string #nome = "Pedro";
//(V) float _temperatura = 12.45f;
//(F) double int = 5;
//(F) decimal renda extra = 91.45m;
//(F) bool status$conta = false;
//(V) string titulo3 = “Tópico 1”;
//(V) float salario_mensal = 1999.55f;
//(V) int percentualValorDesconto = 5;
//(V) const bool MENSALIDADE_EM_DIA = true
