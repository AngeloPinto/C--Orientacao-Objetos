using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOO
{
    class Pessoa
    {
        private int idade;
        private string nome;

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public int getIdade()
        {
            return this.idade;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
    }
}
