Console.WriteLine("\n### Criando o SortedDictionary ###");

var teste1 = new SortedDictionary<int, string>()
{
    {4, "teste 4" },
    {3, "teste 3" },
    {2, "teste 2" },
    {1, "teste 1" },
};

Console.WriteLine("\n-Incluindo o elemento de chave = 5 e valor teste 5");
if (teste1.ContainsKey(5))
{
    Console.WriteLine("Chave ja existe");
}
else
{
    teste1.Add(5, "teste 5");
}

foreach (var item in teste1)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.WriteLine($"\nNumero de pares de chaves no dicionario : {teste1.Count}");
Console.WriteLine($"\nAcessando um elemento pela chave {teste1[5]}");

teste1[5] = "novo teste 5";
Console.WriteLine($"\nAcessando um elemento pela chave {teste1[5]}");
teste1.Remove(5);


Console.WriteLine($"Existe o valor 'teste 1' -> {teste1.ContainsValue("teste 1")}");

if(teste1.TryGetValue(2, out string? valor))
{
    Console.WriteLine($"Valor da chave 2 : {valor}");
}