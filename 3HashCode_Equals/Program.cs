string a = "teste";
string b = "teste";

int x = 100;
int y = 100;

Console.WriteLine(a.Equals(b));
Console.WriteLine(x.Equals(y));
Console.WriteLine();
Console.WriteLine(x.GetHashCode());
Console.WriteLine(y.GetHashCode());

var p1 = new Pessoa(1, "teste");
var p2 = new Pessoa(1, "teste");

Console.WriteLine(p1.Equals(p2));

Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p2.GetHashCode());

Console.ReadKey();

public class Pessoa
{
    private int id;
    private string? nome;

    public Pessoa(int id, string? nome)
    {
        this.Id = id;
        this.Nome = nome;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
}