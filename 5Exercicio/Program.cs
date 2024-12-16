using _5Exercicio;

Console.WriteLine("### Alunos e notas ###\n");

var alunos = new Dictionary<int, Aluno>()
{
    {1, new Aluno("teste 1", 5.0) },
    {2, new Aluno("teste 2", 7.0) },
    {3, new Aluno("teste 3", 9.0) },
    {4, new Aluno("teste 4", 3.0) },
    {5, new Aluno("teste 5", 1.0) },
    {6, new Aluno("teste 6", 8.0) },
};

Operacoes.ExibirColecao(alunos);

Operacoes.pesquisaAluno(alunos);

Operacoes.ExibirColecao(alunos);

Operacoes.removerAluno(alunos);

Operacoes.ExibirColecao(alunos);

Operacoes.AdicionarAluno(alunos);

Operacoes.ExibirColecao(alunos);

var alunosOrdenados = alunos.OrderBy(x => x.Value.Nome);
foreach(var item in alunosOrdenados)
{
    Console.WriteLine($" ID: {item.Key} Aluno: {item.Value.Nome} Nota: {item.Value.Nota}");
}

alunos.Clear();

Operacoes.ExibirColecao(alunos);

Console.ReadKey();

