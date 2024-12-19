string[] cursos = { "C#", "Phyton", "Java", "SQL", "ASP.NET" };
Queue<string> fila1 = new Queue<string>(cursos);

Console.WriteLine("No. de Elementos na fila 1 : " + fila1.Count());

ExbirFila(fila1);
fila1.Enqueue(".NET MAUI");
ExbirFila(fila1);

Console.WriteLine("\n- Obtem o primeiro item da fila com Peek");
var elemento = fila1.Peek();
Console.WriteLine(elemento);

Console.WriteLine("\n- Metodo Dequeue - remove item do inicio da fila");
fila1.Dequeue();
ExbirFila(fila1);

if (fila1.Contains("C#"))
{
    Console.WriteLine("C# esta na fila");
}else
{
    Console.WriteLine("C# NÃO esta na fila");
}

static void ExbirFila<T>(IEnumerable<T> fila1)
{
    foreach (var item in fila1)
    {
        Console.WriteLine($"\nCurso : {item}");
    }
}
