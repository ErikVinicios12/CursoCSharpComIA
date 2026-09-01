List<string> lista = new List<string>();

lista.Add("Ana");
lista.Add("Maria");
lista.Add("Rony");
lista.Add("Jefferson");
lista.Insert(2, "Pietra");
List<string> lista2 = new List<string>() { "Bruno", "Rebeca", "Mario", "Antonia"};
lista.AddRange(lista2);
lista.InsertRange(2, lista2);

lista.Remove("Rony");
lista.RemoveAt(2);
lista.RemoveRange(0, 3);

lista[1] = "Segundo Nome";
lista.Contains("Segundo Nome");
string segundo = lista[1];
string ultimo = lista.LastOrDefault();


var find = lista.Find(x => x.Equals("Rebeca")); // expressão lambda
var findlast = lista.FindLast(x => x.Contains('a'));
var findindex = lista.FindIndex(x => x.StartsWith('R'));
var findlastindex = lista.FindLastIndex(x => x.StartsWith('B'));
var findAll = lista.FindAll(x => x.Contains('a')); 

ExibirLista(lista);
lista.Sort();
ExibirLista(lista);

static void ExibirLista(List<string> lista)
{
    foreach (string item in lista) // também se usa laço for
    {
        Console.WriteLine(item);
    }
}