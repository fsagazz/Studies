using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    class Turma
    {
        private string nome;
        private int quantidademaximaalunos;
        private List<Aluno> alunos = new List<Aluno>();

        public Turma (string aNome, int aQuant)
        {
            QuantidadeMaximaAlunos = aQuant;
            Nome = aNome;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int QuantidadeMaximaAlunos
        {
            get { return quantidademaximaalunos; }
            set { quantidademaximaalunos = value; }
        }

        public List<Aluno> Alunos
        {
            get { return alunos; }
            set { alunos = value; }
        }
        public void AdicionarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public void RemoverAluno(int aIndex)
        {
            alunos.RemoveAt(aIndex);
        }

        public void ObterQuantidadDeAlunos()
        {
            Console.WriteLine("A quantidade de alunos na sala é: {0}", alunos.Count());
        }
    }
}
