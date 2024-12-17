var timesSP = new HashSet<string>() { "Santos", "Palmeiras", "Sao Paulo" };
var timesRJ = new HashSet<string>() { "Vasco", "Flamengo", "Fluminense" };
var timesBA = new HashSet<string>() { "Bahia", "Vitoria", "Juazeiro" };
var timesMundiais = new HashSet<string>() { "Santos", "Palmeiras", "Sao Paulo", "Flamengo" };

if (!timesSP.Contains("Corinthians"))
{
    timesSP.Add("Corinthians");
}

//var resultado = timesBA.Remove("Juazeiro");

if (timesSP.IsSubsetOf(timesMundiais))
{
    Console.WriteLine("timesSP e um subconjunto de timesMundiais\n");
}

if (timesMundiais.IsSupersetOf(timesSP))
{
    Console.WriteLine("timesMundiais  e um subconjunto de timesSP\n");
}

if (timesRJ.Overlaps(timesMundiais))
{
    Console.WriteLine("Pelo menos um time do RJ tem titulo Mundial");
}

if (!timesSP.SetEquals(timesRJ))
{
    Console.WriteLine("\ntimeSP e timesRJ nao contem os mesmo elementos");
}

/*
Console.WriteLine("\n-Juntando os HashSet<T> : SP, RJ e BA");
timesSP.UnionWith(timesRJ);
timesSP.UnionWith(timesBA);

ExibirColecao(timesSP);

Console.WriteLine("\n-Juntando os Times : SP, RJ, BA ordenados");
var todosTimes = new SortedSet<string>(timesSP);
ExibirColecao(todosTimes);
*/

Console.WriteLine("\nIntersecao de dois HashSet<T> : timeSP e timesMundiais");
timesSP.IntersectWith(timesMundiais);
ExibirColecao(timesSP);

Console.WriteLine("\nDiferenca de dois HashSet<T> : timesMundiais e timesSP");
timesMundiais.ExceptWith(timesSP);
ExibirColecao(timesMundiais);

Console.WriteLine("\nDiferenca de dois HashSet<T> : timesMundiais e timesSP com SymmetricExceptWith");
timesMundiais.SymmetricExceptWith(timesSP);
ExibirColecao(timesMundiais);

Console.WriteLine("\nRemove todos os elementos de timesMundias");
timesMundiais.Clear();
ExibirColecao(timesMundiais);
static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
    {
        Console.WriteLine($"{item}");
    }
}