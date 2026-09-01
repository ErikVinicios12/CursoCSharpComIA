// Partial class é uma funcionalidade do C# que permite dividir a definição de uma classe, struct ou interface em vários arquivos.
// Isso é útil para organizar o código, especialmente em projetos grandes, onde diferentes partes de uma classe podem ser implementadas
// em arquivos separados. Cada parte da classe deve ser marcada com a palavra-chave "partial" e todas as partes devem ter o mesmo nome
// e estar no mesmo namespace.

using PartialClass;

MinhaPartialClass minhaPartialClass = new MinhaPartialClass();

Console.WriteLine("Idade para nascimentos em: 07/08/2003");

var idade = minhaPartialClass.CalculaIdade(new DateTime(2003, 08, 07));
Console.WriteLine($"Idade: {Math.Round(idade.TotalDays / 365.25)} anos");

var data1 = DateTime.Now;
var data2 = new DateTime(2003, 08, 07);

var diferenca = minhaPartialClass.DiferencaEntreDatas(data1, data2);
Console.WriteLine($"Diferença entre as datas: {diferenca.TotalDays} dias");

Console.WriteLine();