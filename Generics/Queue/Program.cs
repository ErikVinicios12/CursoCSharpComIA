// FIFO (First in First out)

Queue<string> diasSemana = new Queue<string>();
diasSemana.Enqueue("Segunda"); // Adiciona valor
diasSemana.Enqueue("Terça");
diasSemana.Enqueue("Quarta");

int[] array1 = new int[] { 2, 4, 6, 8 };
Queue<int> pares = new Queue<int>(array1);

var impares = new Queue<int>(3);
impares.Enqueue(1);
impares.Enqueue(3);
impares.Enqueue(5);

impares.Dequeue(); // remove e retorna o último (neste caso, 5)
impares.Peek(); // retorna sem remover o últumo item