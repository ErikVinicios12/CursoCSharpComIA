// Dictionary<Tkey, TValue> - 
// Tkey - Tipo da chave 
// TValue - Tipo do valor

Dictionary<string, int> cpfs = new Dictionary<string, int>();

cpfs.Add("Pedro", 1232312);
cpfs.Add("Ana", 5345346);
cpfs.Add("Julia", 6434554);
cpfs.Add("Marcelo", 7643245);

if (!cpfs.ContainsKey("Alex"))
    cpfs.Add("Alex", 5434532);

foreach (var cpf in cpfs)
{
    Console.Write(cpf.Key + " - "); // Retorna a chave
    Console.Write(cpf.Value); // Retorna o valor
    Console.WriteLine("\n");
}

SortedDictionary<int, string> brics = new SortedDictionary<int, string>() // basicamente é um dictionary ordenado pela chave
{
    {20, "Brasil"},
    {10, "China" },
    {40, "India" },
    {30, "URSS" }
};

if (brics.ContainsKey(70))
    Console.WriteLine("Esta chave já existe");
else
    brics.Add(70, "África do Sul");

var brasil = brics[20];

brics[20] = "Argentina";

brics.Remove(10);

if (brics.TryGetValue(20, out string argentina)) {
    Console.WriteLine("Valor 20 encontrado");
} else
{
    Console.WriteLine("Valor 20 não encontrado");
}

foreach (var pais in brics)
{
    Console.WriteLine($"{pais.Key} - {pais.Value}");
}