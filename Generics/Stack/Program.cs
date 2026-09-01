// lilo (last in last out)
// Útil quando você precisa de armazenamento temporário para obter informações, ou seja, quando talvez
//você queira descartar um elemento depois de recuperar seu valor
// Não da suporte a indexador

Stack<string> diasSemana = new Stack<string>();
diasSemana.Push("Segunda");
diasSemana.Push("Terça");
diasSemana.Push("Quarta");

int[] array1 = new int[] { 2, 4, 6, 8 };
Stack<int> pares = new Stack<int>(array1);

var impares = new Stack<int>(3);
impares.Push(1);
impares.Push(3);
impares.Push(5);

impares.Pop(); // retorna sem remover o primeiro elemento (neste caso, 1_
impares.Peek(); // Remove e retorna o ultimo elemento

if (impares.Contains(20))
    Console.WriteLine("Tem o item 20");
else
    Console.WriteLine("Não tem o ítem 20");

impares.Clear(); // limpa a lista