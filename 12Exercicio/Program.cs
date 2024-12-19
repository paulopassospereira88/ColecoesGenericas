Queue<Pedido> filaPedidos = new Queue<Pedido>();

filaPedidos.Enqueue(new Pedido(101, 10.0));
filaPedidos.Enqueue(new Pedido(201, 20.0));
filaPedidos.Enqueue(new Pedido(301, 30.0));
filaPedidos.Enqueue(new Pedido(401, 40.0));

Console.WriteLine($"\nNumero de pedidos na fila : {filaPedidos.Count}");

while(filaPedidos.Count > 0)
{
    Pedido proximoPedido = filaPedidos.Dequeue();
    Console.WriteLine($"Procesando pedido {proximoPedido.Numero}," +
        $"valor {proximoPedido.Valor}");
}

Console.WriteLine($"\nNumero de pedidos na fila : {filaPedidos.Count}");

filaPedidos.Enqueue(new Pedido(501, 50.0));
filaPedidos.Enqueue(new Pedido(601, 60.0));
filaPedidos.Enqueue(new Pedido(701, 70.0));
filaPedidos.Enqueue(new Pedido(801, 80.0));

Console.WriteLine($"\nNumero de pedidos na fila : {filaPedidos.Count}");

int numeroPedido = 501;
Pedido? pedidoLocalizado = filaPedidos
    .FirstOrDefault(p => p.Numero == numeroPedido);

if(pedidoLocalizado != null)
{
    Console.WriteLine($"Pedido {numeroPedido} localizado na fila, " +
        $"valor {pedidoLocalizado.Valor}");
} 
else
{
    Console.WriteLine($"Pedido {pedidoLocalizado} não encontrado na fila");
}

class Pedido
{
    public Pedido(int numero, double valor)
    {
        Numero = numero;
        Valor = valor;
    }

    public int Numero { get; set; }
    public double Valor { get; set; }
}