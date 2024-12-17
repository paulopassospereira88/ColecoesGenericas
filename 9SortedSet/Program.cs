var numeros = new List<int>() {50, 20, 10, 80, 70, 60};
SortedSet<int> conjunto = new SortedSet<int>(numeros);

foreach (var VARIABLE in conjunto)
{
    Console.WriteLine(VARIABLE);
}