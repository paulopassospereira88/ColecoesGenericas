var numeros = new HashSet<int>{1,2,3,4,5,6,7,8,9};
var frutas = new HashSet<string>(){ "uva", "banana", "pera" };

HashSet<int> pares = new HashSet<int>();

for (int i = 0; i < 6; i++)
{
    pares.Add(i * 2);
}
//Construtor usando IEnumerable
var lista1 = new List<int>(){1,2,3,4,5,6,7,8,9};
var conjunto = new HashSet<int>(lista1);