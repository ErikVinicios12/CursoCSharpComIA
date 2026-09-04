List<string> nomes = new List<string>()
{
    "Alice",
    "Bob",
    "Charlie",
    "David",
};
 
var resultado = from nome in nomes       // Maneira 1 de consulta LINQ
                where nome.Length > 3
                orderby nome
                select nome;

var resultado2 = nomes.Where(nome => nome.Length > 3) // Maneira 2 de consulta LINQ
                     .OrderBy(nome => nome)
                     .Select(nome => nome); 
