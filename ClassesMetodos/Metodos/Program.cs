MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.Saudacao("Alice", DateTime.Now);

Aluno aluno = new Aluno();
aluno.Consultar();




class Aluno()
{
    public string? Nome;
    public int idade;
    public string? sexo;
    public string? aprovado;

    public void Consultar()
    {
        Aluno aluno = new Aluno();

        Console.Write("Nome:");
        aluno.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        aluno.idade = int.Parse(Console.ReadLine());
        Console.Write("Sexo: ");
        aluno.sexo = Console.ReadLine();
        Console.Write("Aprovado: ");
        aluno.aprovado = Console.ReadLine();

        Curso curso = new Curso();
        curso.Resultado(aluno);
    }
}

class Curso()
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\nAluno: {aluno.Nome}\n" +
            $"Idade: {aluno.idade}\n" +
            $"Sexo: {aluno.sexo}\n" +
            $"Aprovado: {aluno.aprovado}");

    }
}


class MinhaClasse() {
    public void Saudacao(string nome, DateTime data)
    {
        Console.WriteLine($"Bem-VInda, {nome}!!");
        //ExibirDataAtual();
        Console.WriteLine($"{data.ToShortDateString()}");
    }

    //void ExibirDataAtual()
    //{
    //    Console.WriteLine(DateTime.Now.ToShortDateString());
    //}
}