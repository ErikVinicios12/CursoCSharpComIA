using Exercicios_04;

Queue<Pedido> filaPedidos = new Queue<Pedido>();

filaPedidos.Enqueue(new Pedido(101, 10.0));
filaPedidos.Enqueue(new Pedido(201, 20.0));
filaPedidos.Enqueue(new Pedido(301, 30.0));

Console.WriteLine($"\n Número de pedidos na fila: {filaPedidos.Count()}");

while (filaPedidos.Count > 0)
{
    Pedido proximoPedido = filaPedidos.Dequeue();
    Console.WriteLine($"Processando pedido {proximoPedido.Numero}\n" +
        $" Valor: {proximoPedido.Valor}");
}

filaPedidos.Enqueue(new Pedido(401, 40.0));
filaPedidos.Enqueue(new Pedido(501, 50.0));
filaPedidos.Enqueue(new Pedido(601, 60.0));

int numeroPedido = 501;

var pedido = filaPedidos.FirstOrDefault(x => x.Numero == numeroPedido);
if (pedido != null)
    Console.WriteLine($"O pedido {pedido.Numero} tem valor  {pedido.Valor}");
else
    Console.WriteLine("Pedido não encontrado");
