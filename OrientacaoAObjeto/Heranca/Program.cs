Funcionario func = new Funcionario();
func.Nome = "José";
func.Email = "jose@email.com";
func.Empresa = "Google Inc.";
func.Salario = 9000;

Console.WriteLine("Funcionario");
Console.WriteLine(func.Empresa);
Console.WriteLine(func.Salario);
 
func.Identificar();

Aluno aluno = new Aluno();
aluno.Nome = "João";
aluno.Email = "joão@email.com";
aluno.Curso = "Engenharia";
aluno.Nota = 9;

Console.WriteLine("Aluno");
Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);

aluno.Identificar();

public class Pessoa
{
    private string? _nome;
    public string? Nome {  get { return _nome; } set { _nome = value; } }
    private string? _email;
    public string? Email { get { return _email;  } set { _email = value; } }
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }
    public virtual void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

public class Funcionario : Pessoa // Funcionario herda Pessoa
{
    public string Empresa { get; set; }
    public decimal Salario { get; set; }
    public Funcionario()
    {
        Console.WriteLine("Construtor da classe Funcionario");
    }

    public override void Identificar()
    {
        Console.Write($"{Empresa} - {Salario}");
    }
}

public class Aluno : Pessoa // Aluno herda de pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
    public Aluno()
    {
        Console.WriteLine("Construtor da classe Aluno");
    }

    public override void Identificar()
    {
        Console.Write($"{Curso} - {Nota}");
    }
}

public sealed class ClasseSelada() // classes/metodos/propriedades sealed significa que não podem ser herdados
{
    
}