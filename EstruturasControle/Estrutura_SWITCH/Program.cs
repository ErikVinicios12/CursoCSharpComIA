Console.WriteLine(" Estrutura Switch ");

Console.WriteLine("Valor da compra: R$ 600,00");
int compra = 600;
Console.Write("Quantidade de parcelas: ");
double parcelas = Convert.ToDouble(Console.ReadLine());

switch (parcelas)
{
    case 1:
        Console.WriteLine($"\nPrestação R${compra/parcelas}");
        break;
    case 2:
        Console.WriteLine($"\nPrestação R${compra / parcelas}");
        break;
    case 3:
        Console.WriteLine($"\nPrestação R${compra / parcelas}");
        break;
    default:
        Console.WriteLine("Valor Inválido");
        break;
}

Console.Write("\nNúmero: ");
int n = Convert.ToInt32(Console.ReadLine());

switch (n % 2)
{
    case (0):
        Console.WriteLine("PAR");
        break;
    case (1):
        Console.WriteLine("IMPAR");
        break;
}

Console.Write("\nInforme o nome do mês: ");
string nMes = Convert.ToString(Console.ReadLine()).ToLower();

switch (nMes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}

int cargo = 0;
int funcao = 0;

Console.Write("\nVocê é Gerente[1] ou Programador[2]? ");
cargo = Convert.ToInt32(Console.ReadLine());

switch (cargo)
{
    case 1:
        Console.WriteLine("\nBem vindo, Gerente! ");
        break;
    case 2:
        Console.Write("Você é Junior[1] ou Senior[2]? ");
        funcao = Convert.ToInt32(Console.ReadLine());
        switch (funcao)
        {
            case 1:
                Console.WriteLine("\nBem vindo, programador Junior! ");
                break;
            case 2:
                Console.WriteLine("\nBem vindo, programador senior! ");
                break;
        }
        break;
}