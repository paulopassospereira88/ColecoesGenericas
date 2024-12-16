using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Exercicio
{
    public class Operacoes
    {
        public static void AdicionarAluno(Dictionary<int, Aluno> alunos)
        {
            Console.WriteLine("Informe o ID do aluno");
            int novoId = Convert.ToInt32(Console.ReadLine());

            if (!alunos.ContainsKey(novoId))
            {
                Console.WriteLine("Informe o nome do aluno");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe a nota do aluno");
                double nota = Convert.ToDouble(Console.ReadLine());

                alunos.Add(novoId, new Aluno(nome, nota));
                Console.WriteLine($"\n Aluno com ID {novoId} adicionado com sucesso");
            }
            else
            {
                Console.WriteLine("\nCodigo ja existe");
            }
        }

        public static void ExibirColecao(Dictionary<int, Aluno> alunos)
        {
            foreach (var item in alunos)
            {
                Console.WriteLine($" ID: {item.Key} Aluno: {item.Value.Nome} Nota: {item.Value.Nota}");
            }
        }

        public static void pesquisaAluno(Dictionary<int, Aluno> alunos)
        {
            do
            {
                Console.WriteLine("\nInforme o ID do aluno a localizar (99 sai)");
                int id = Convert.ToInt32(Console.ReadLine());

                if (id == 99)
                {
                    break;
                }

                var result = alunos.ContainsKey(id);
                if (result)
                {
                    Console.WriteLine("Informe a nota (1 a 10)");
                    var nota = Convert.ToDouble(Console.ReadLine());
                    alunos[id].Nota = nota;
                }
                else
                {
                    Console.WriteLine($"{id} do aluno nao encontrado");
                }
            } while (true);
        }

        public static void removerAluno(Dictionary<int, Aluno> alunos)
        {
            Console.WriteLine("\nInforme o ID do aluno a remover");
            int id = Convert.ToInt32(Console.ReadLine());

            if (alunos.ContainsKey(id))
            {
                alunos.Remove(id);
                Console.WriteLine("\nAluno removido com sucesso");
            } else
            {
                Console.WriteLine($"\nID {id} do aluno nao encontrado");
            }
        }
    }
}
