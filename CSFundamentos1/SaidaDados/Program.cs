Console.WriteLine(" Saida de dados: formatação! \n");

int idade = 25;
string nome = "Maria";

// Usando interpolação
Console.WriteLine($"{nome} tem {idade} anos");

// Usando concatenação
Console.WriteLine(nome + " tem " + idade + " anos");

//Usando place holders
Console.WriteLine("{0} tem {1} anos", nome, idade);
