// Dada uma classe Aluno definida com duas propriedades:
//
//1- Nome do tipo string
//2- Nota do tipo Double
//
// Crie uma lista de objetos do tipo Aluno usando a coleção List<T> com os seguintes dados que representam o nome e a nota do aluno:
//
//Maria, 8.75
//Manoel, 6.95
//Amanda, 7.25
//Carlos, 6.55
//Jaime, 8.50
//Debora, 5.95
//Alicia, 9.25
//Sandra, 5.55
//Marta, 7.85
//Sueli, 9.15
//
//A seguir relize as seguintes operações na lista de objetos Aluno criada:
//- Crie um método para exibir a lista de alunos com nome e nota, a média aritmética das notas e a quantidade de alunos na lista
//- Inclua na lista original os alunos: Bia, 7.75 e Mario, 8.95, e exiba novamente a lista de alunos
//- Localize na lista o aluno com nome 'Amanda' e a seguir remova este aluno da lista e exiba novamente a lista de alunos
//- Ordene a lista pelo nome do aluno e exiba a lista ordenada
//- Obtenha e exiba no console os alunos com nota maior ou igual a 8

List<Aluno> alunos = new List<Aluno>();

alunos.Add(new Aluno("Maria", 8.75));
alunos.Add(new Aluno("Manoel", 6.95));
alunos.Add(new Aluno("Amanda", 7.25));
alunos.Add(new Aluno("Carlos", 6.55));
alunos.Add(new Aluno("Jaime", 8.50));
alunos.Add(new Aluno("Debora", 5.95));
alunos.Add(new Aluno("Alicia", 9.25));
alunos.Add(new Aluno("Sandra", 5.55));
alunos.Add(new Aluno("Marta", 7.85));
alunos.Add(new Aluno("Sueli", 9.15));

ExibirInformacoes(alunos);

alunos.Add(new Aluno("Bia", 7.75));
alunos.Add(new Aluno("Mario", 8.95));

ExibirInformacoes(alunos);

if (alunos.Count(x => x.Nome.Equals("Amanda")) > 0)
    alunos.Remove(alunos.Find(x => x.Nome.Equals("Amanda")));

ExibirInformacoes(alunos);

ExibirInformacoes(alunos.OrderBy(x => x.Nome).ToList());

List<Aluno> alunosMaior8 = alunos.Where(x => x.Nota > 8).ToList();

ExibirInformacoes(alunosMaior8);

void ExibirInformacoes(List<Aluno> alunos)
{
    Console.WriteLine("\n");
    double media = 0;
    foreach (Aluno aluno in alunos)
    {
        Console.WriteLine($"Aluno: {aluno.Nome} - {aluno.Nota}");
        media += aluno.Nota;
    }
    media = media / alunos.Count();
    Console.WriteLine("\n");
    Console.WriteLine($"Quantidade de alunos: {alunos.Count()}\n" +
        $"Média: {Math.Round(media, 2)}");
}

public class Aluno
{
    private string? nome;
    public string? Nome { get; set; }
    private double nota;
    public double Nota { get; set; }
    public Aluno (string? nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }

}