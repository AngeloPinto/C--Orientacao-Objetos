using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpOO
{
    class Departamento
    {
        private string _nome;
        public List<Professor> professores = new List<Professor>();
        private Escola _escola = new Escola();

        public string Nome 
        {
            get => _nome;
            set => _nome = value;
        }

        public Escola Escola
        {
            get => _escola;
            set => _escola = value;
        }

        public void AddProfessor(Professor professor)
        {
            this.professores.Add(professor);
        }

        public void ListarProfessores()
        {
            foreach (Professor professor in this.professores)
            {
                WriteLine("Professor: {0}", professor.getNome());
            }

            WriteLine("\n-------------------------------------------------\n");
        }

    }
}
