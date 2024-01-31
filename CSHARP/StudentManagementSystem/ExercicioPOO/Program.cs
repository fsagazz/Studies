using System;
using System.Collections.Generic;
namespace ExercicioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Turma sala = new Turma("Turma De C#", 20);
            Aluno AlunoUm = new Aluno("José", 20, "1111");
            Aluno AlunoDois = new Aluno("Maria", 21, "2222");
            Aluno AlunoTres = new Aluno("Bonifácio", 22, "3333");

            sala.AdicionarAluno(AlunoUm);
            sala.AdicionarAluno(AlunoDois);
            sala.AdicionarAluno(AlunoTres);
            
            sala.ObterQuantidadDeAlunos();

            sala.RemoverAluno(1);

            sala.ObterQuantidadDeAlunos();

            AlunoTres.Nome = "Josefino";
            AlunoTres.Idade = 20;
            AlunoTres.Matricula = "4444";

            foreach (Aluno c in sala.Alunos)
            {
                Console.WriteLine("Nome: {0}. Idade: {1}. Matricula: {2}", c.Nome, c.Idade, c.Matricula);
            }
        }
    }
}   