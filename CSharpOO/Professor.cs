using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpOO
{
    class Professor : Pessoa
    {
        private double _valorHora;
        private int _tipo;
        private int _bonus;
        public List<Aluno> alunos = new List<Aluno>();

        public int Tipo 
        {
            get => _tipo;
            set => _tipo = value;
        }

        public int Bonus 
        {
            get => _bonus;
            set => _bonus = value;
        }
        
        public double ValorHora
        {
            get => _valorHora;
            set => _valorHora = value;
        }

        public void imprimir()
        {
            WriteLine("Nome: {0}", this.getNome());
            WriteLine("Idade: {0}", this.getIdade());
            WriteLine("\n-------------------------------------------------\n");
        }

        public double CalcularSalario(int horas) 
        {
            return this._valorHora * horas;
        }

        public double CalcularSalario(int horas, double bonificacao) 
        {
            double valor = this._valorHora * horas;
            double perc  = bonificacao / 100;
            return valor + (valor * perc);
        }

        public double CalcularSalarioFinal(int horas)
        {
            if (this._tipo == 1) 
            {
                return this.CalcularSalario(horas);
            } else 
            {
                return this.CalcularSalario(horas, this._bonus);
            }
        }

        public void AddAluno(Aluno aluno)
        {
            this.alunos.Add(aluno); 
        }

        public void ImprimirAlunos()
        {
            foreach(Aluno aluno in this.alunos)
            {
                WriteLine("Aluno: {0}", aluno.getNome());
            }
            WriteLine("\n-------------------------------------------------\n");
        }
    }

}
