ClasseGenerica<int> intObj = new ClasseGenerica<int>();
ClasseGenerica<string> stringObj = new ClasseGenerica<string>();

intObj.Adicionar(10);
intObj.Adicionar(20);
intObj.Adicionar(30);
intObj.Adicionar(40);
intObj.Adicionar(50);
intObj.Adicionar(60);

stringObj.Adicionar("teste 1");
stringObj.Adicionar("teste 2");
stringObj.Adicionar("teste 3");

Console.WriteLine("Classe ClasseGenerica<M> de objetos int\n");
for(int i = 0; i < 5; i++)
{
    Console.WriteLine(intObj[i]);
}

Console.WriteLine("Classe ClasseGenerica<M> de objetos string");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(stringObj[i]);
}


public class ClasseGenerica<T>
{
    T[] obj = new T[5];
    int contador = 0;

    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador] = item;
        }
        contador++;
    }

    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}