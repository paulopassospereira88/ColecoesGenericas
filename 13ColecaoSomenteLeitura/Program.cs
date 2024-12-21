using System.Collections.ObjectModel;

var testeList1 = new List<string>()
{
    "teste 1",
    "teste 2",
    "teste 3",
    "teste 4",
};

var lista1 = new ReadOnlyCollection<string>(testeList1);

Console.WriteLine("\nLista de elementos somente para leitura");

foreach (var item in lista1)
{
    Console.WriteLine(item);
}

Console.WriteLine($"\n\nQuantidade de elementos : {lista1.Count}");

Console.Write("\nElemento 'teste 1' esta esta lista ? ");
Console.WriteLine(lista1.Contains("teste 1") ? "sim" : "não");

Console.WriteLine($"\nElemento do indice 3 : {lista1[3]}");
Console.WriteLine($"\nElemento teste 2 : {lista1.IndexOf("teste 2")}");

Console.WriteLine("\nInserindo um novo elemento na lista original");
testeList1.Add("teste 5");
Console.WriteLine("\nExibindo o novo elemento da lista");
foreach (var item in lista1)
{
    Console.WriteLine($"{item}");
}

Console.WriteLine("\n\nCopiandos os elementos da colecao para um array unidimensional");
string[] lista2 = new string[testeList1.Count + 2];
testeList1.CopyTo(lista2, 1);
Console.WriteLine($"\nO array copiado possui {lista2.Length} elementos");
foreach (var item in lista2)
{
    Console.WriteLine($"\"{item}\"");
}
