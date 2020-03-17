using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpOO
{
    class Escola
    {
        private string _nome;
        private List<Departamento> departamentos = new List<Departamento>();

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public void AddDepartamento(Departamento departamento)
        {
            this.departamentos.Add(departamento);
        }

        public void ListarDepartamentos()
        {
            foreach(Departamento departamento in departamentos)
            {
                WriteLine("Departamento {0}", departamento.Nome);
            }

            WriteLine("\n-------------------------------------------------\n");
        }

    }
}
