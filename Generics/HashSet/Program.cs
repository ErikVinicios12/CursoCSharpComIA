// HatshSet<T> é uma coleção genérica não ordenada que implementa a interface ISet<T> e representa um conjunto de itens exclusivos
// (não permite a inclusão de elementos duplicados)
// Acesso rapido á elementos e facilidade para manipular lista de dados, principalmente vindos do banco de dados

var timesSP = new HashSet<string>() { "Santos", "Palmeiras","São Paulo" };

var timesRJ = new HashSet<string>() { "Vasco", "Flamengo", "Fluminense" };

var timesBH = new HashSet<string>() { "Bahia", "Vitória", "Juazeiro" };

var timesMundiais = new HashSet<string>() { "Santos", "Palmeiras", "São Paulo", "Flamengo" };

if (!timesSP.Contains("Corinthians"))
    timesSP.Add("Corinthians");

if (timesSP.IsSubsetOf(timesMundiais)) // Analisa se há itens de timesSP em timesMundiais. Se sim, timesSP caracteriza-se como subconjunto de timesmundiais
    Console.WriteLine("TimesSP é um subconjunto de timesMundiais");

if (timesMundiais.IsSupersetOf(timesSP)) // se timesSP é um subconjunto de timesMundiais, então timesMundiais é um superconjunto de timesSP
    Console.WriteLine("TimesMundiais é um superconjunto de timesSP");

if (timesRJ.Overlaps(timesMundiais)) // verifica se há algum item de timesRJ em timesMundiais
    Console.WriteLine("Pelo menos um time do RJ tem titulo mundial");

if (!timesSP.SetEquals(timesRJ))
    Console.WriteLine("timesSP e timesRJ não contêm os mesmos elementos");

timesSP.UnionWith(timesRJ); // Junta timesSP com timesRJ
timesSP.UnionWith(timesBH); // Junta timesSp com timesBH
ExibirColecao(timesSP);
 
var todosTimesOrdenados = new SortedSet<string>(timesSP); // SortedSet é o HashSet ordenado
ExibirColecao(todosTimesOrdenados);

timesSP.IntersectWith(timesMundiais); // Separa os elementos comuns entre eles (os times que tem em ambos)
ExibirColecao(timesSP);

timesMundiais.ExceptWith(timesSP); // Exibe os elementos incomuns (times que tem em timesMundiais, mas não em timesSP)
ExibirColecao(timesMundiais);

timesMundiais.SymmetricExceptWith(timesSP); // Exibe os times que tem em um, mas não em outro
ExibirColecao(timesMundiais);

timesMundiais.Clear(); // Limpa a lista 
ExibirColecao(timesMundiais);

static void ExibirColecao(IEnumerable<string> colecao)
{
    Console.WriteLine();
    foreach (string colecaoItem in colecao)
    {
        Console.WriteLine($"{colecaoItem} ")
        ;
    }
}