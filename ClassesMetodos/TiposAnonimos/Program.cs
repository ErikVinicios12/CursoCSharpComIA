// This code demonstrates the use of anonymous types in C# 14.0. It creates an array of anonymous objects
// representing students, each with properties for name, age, course, and address. The address itself
// is also an anonymous type with properties for street, number, and city. The program then iterates
// through the array and prints out the details of each student.

// Geralmente tipos anonimos são usados para criar objetos temporários que não precisam de uma classe nomeada.
// Eles são úteis em situações onde você precisa de um objeto simples para armazenar dados, como em consultas LINQ
// ou quando você deseja retornar múltiplos valores de um método sem criar uma classe separada.
// Em resumo, usa quando você precisa de um objeto simples e temporário para armazenar dados sem a necessidade de criar uma classe nomeada.
var alunos = new[]
{
    new
    {
        Nome = "João",
        Idade = 20,
        Curso = "Engenharia",
        Endereco = new
        {
            Rua = "Rua A",
            Numero = 123,
            Cidade = "São Paulo"
        }
    },
    new
    {
        Nome = "Maria",
        Idade = 22,
        Curso = "Medicina",
        Endereco = new
        {
            Rua = "Rua B",
            Numero = 456,
            Cidade = "Rio de Janeiro"
        }
    }
};

foreach (var aluno in alunos)
{
    Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Curso: {aluno.Curso}");
    Console.WriteLine($"Endereço: {aluno.Endereco.Rua}, {aluno.Endereco.Numero}, {aluno.Endereco.Cidade}");
}