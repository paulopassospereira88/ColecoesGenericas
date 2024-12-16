using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Exercicio
{
    public class Aluno
    {
        private string? nome;
        private double nota;

        public Aluno(string? nome, double nota)
        {
            this.Nome = nome;
            this.Nota = nota;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Nota
        {
            get { return nota; }
            set { nota = value; }
        }
    }
}
