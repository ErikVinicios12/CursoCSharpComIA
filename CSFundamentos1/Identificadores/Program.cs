using System.Net;

Console.WriteLine(" Definindo identificadores!");
Console.WriteLine("");

// indicadores válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

// indicadores inválidos
//int 5idade;
//int $valor;
//int valor#total;

// para nomes de variáveis -: camel case
string descontoTotal;
string desconto_Total;

// Constrantes : maiúscula

const double PI = 3.14;
const string PREFIXO = "11";
const string PREFIXO_SP = "11";

// Para nomes de classes e métodos: pascal case

class ImprimirTexto()
{
    public void ImprimirNome()
    {
        Console.WriteLine("Erik");
    }
}

