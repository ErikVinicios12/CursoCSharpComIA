using System.Collections;

ArrayList lista = new ArrayList(); // incluir tamanho é opcional

// permite adicionar valores de tipos diferentes
lista.Add("String");
lista.Add(1);
lista.Add(true);
lista.Add('a');

// Adicionar uma lista em outra
ArrayList lista2 = new ArrayList() { "Maria", 5, true } ;

lista.AddRange(lista2); // inclui no final da lista
lista.InsertRange(2, lista2); // Adiciona no indice 2 da lista

// Remover elementos
lista.Remove('a'); // Remove pelo valor
lista.RemoveAt(2); // Remove pelo indice
lista.RemoveRange(0, 2); // Remove uma sequencia determinada (de, até)

ArrayList lista3 = new ArrayList() { "Bruno", "Amanda", "Marcelo", "Wesley"};
// Identificar elementos
lista3.Contains("Marcelo"); // returna true ou false

// Ordenação
lista3.Sort(); // ordena de forma ASCENDENTE (não funciona quando possui tipos diferentes)

// Limpar lista
lista3.Clear(); // Limpa a lista mantendo a capacidade