Console.WriteLine(" Inferência Tipos (var) ");

var idade = 25;
var nome = "Maria";
var salario = 25000.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");


// var limitações

// var salario = null
// var titulo;
// var salario, imposto, total;
// NÃO PODE MUDAR O TIPO APÓS INICIALIZAR

var teste = new Teste();
teste.MeuMetodo();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu Método");
    }
}
