Stack<int> numeros = new Stack<int>();
numeros.Push(1);
numeros.Push(2);
numeros.Push(3);
numeros.Push(4);

Console.WriteLine($"- A pilha original contem {numeros.Count} itens");
ExibirNumeros(numeros);

Console.WriteLine($"\n- Item obtido da pilha (Peek) : {numeros.Peek()}");

Console.WriteLine($"\n- Item removido da pilha (Pop) : {numeros.Pop()}");
Console.WriteLine($"- A pilha original contem {numeros.Count} itens");
ExibirNumeros(numeros);

if (numeros.Contains(3))
{
    Console.WriteLine("\n- Item 3 esta na pilha");
}
else
{
    Console.WriteLine("\n- Item 3 nao esta na pilha");
}

Console.WriteLine("\n- Copiando a pilha usando ToArray");
var copia = new Stack<int>(numeros.ToArray());
ExibirNumeros(numeros);

Console.WriteLine("\n- Removendo todos os itens da pilha");
numeros.Clear();
Console.WriteLine($"{numeros.Count} itens na pilha");

static void ExibirNumeros<T>(IEnumerable<T> numeros)
{
    foreach (var item in numeros)
    {
        Console.WriteLine($"- Numero : {item} ");
    }
}

/*
int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Stack<int> pilha1 = new Stack<int>(array1);

var impares = new Stack<int>(3);
*/