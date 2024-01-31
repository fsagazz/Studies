using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    class Aluno
    {
        private string nome;

        private int idade;

        private string matricula;


        public Aluno(string aNome,  int aIdade, string aMatricula)
        {
            Nome = aNome;
            Idade = aIdade;
            Matricula = aMatricula;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
    }
}
