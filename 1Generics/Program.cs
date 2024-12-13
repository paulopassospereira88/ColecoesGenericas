Teste<int, int> teste = new Teste<int, int>();
//Teste<string, string> teste1 = new Teste<string, string>();

int p1 = 10;
int p2 = 10;

float f1 = 4.5f;

string s1 = "teste";
string s2 = "teste";

teste.Comparar(p1, p2);
teste.Comparar(s1, s2);
teste.Comparar(p1, f1);

public class Teste<T1, T2> where T1: struct where T2 : struct
{

    public void Comparar<T1, T2>(T1 p1, T2 p2)
    {
        Console.WriteLine($"Os tipos : {p1.GetType()} e {p2.GetType()}\n");
        var result = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} sao iguais ? {result}");
    }

    //public void Comparar<T>(T p1, T p2)
    //{
    //    Console.WriteLine($"Os tipos : {p1.GetType()} e {p2.GetType()}\n");
    //    var result = p1.Equals(p2);
    //    Console.WriteLine($"{p1} e {p2} sao iguais ? {result}");
    //}
}
