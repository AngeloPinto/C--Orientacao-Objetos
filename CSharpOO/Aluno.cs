using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpOO
{
    class Aluno : Pessoa
    {
        private string matricula;
        private bool presente;
        public List<Professor> professores = new List<Professor>();

        public string Matricula 
        {
            get => matricula;
            set => matricula = value;
        }
        public bool Presente
        {
            get => presente;
            set => presente = value;
        }

        public void imprimir()
        {
            WriteLine("Nome: {0}", this.getNome());
            WriteLine("Idade: {0}", this.getIdade());
            WriteLine("Matricula: {0}", this.Matricula);
            WriteLine("Presente: {0}", this.Presente);
            WriteLine("\n-------------------------------------------------\n");
        }

        public void addProfessor(Professor professor) 
        {
            this.professores.Add(professor);
        }

    }
}
