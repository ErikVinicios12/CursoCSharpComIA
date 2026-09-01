// Coleção somente leitura (não permite a modificação dos dados)
// Garante proteção de dados e não modificação dos dados originais 
// Ao modificar a lista original, a lista readonly também é modificada
// Para mais segurança, a lista original precisa estar como private

using System.Collections.ObjectModel;

var planetas = new List<string>() { "Mercúrio", "Vênus", "Terra", "Marte" };

var listaPlanetas = new ReadOnlyCollection<string>(planetas); // Maneira 1
var listaPlanetas2 = planetas.AsReadOnly(); // Maneira 2 

foreach (var planet in listaPlanetas) {
    Console.WriteLine(planet);
}

listaPlanetas.Count();

if (listaPlanetas.Contains("Júpter"))
    Console.WriteLine("Possui Júpter");
else
    Console.WriteLine("Não possui Júpter");

var terra = listaPlanetas[2];
var indexMarte = listaPlanetas.IndexOf("Marte");