using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno joao = new Aluno();
            joao.setNome("Joãozinho da Silva");
            joao.setIdade(15);
            joao.Matricula = "123";
            joao.Presente = true;
            joao.imprimir();

            Aluno rita = new Aluno();
            rita.setNome("Ritinha da Silva");
            rita.setIdade(16);
            rita.Matricula = "456";
            rita.Presente = false;
            rita.imprimir();


            Professor jose = new Professor();

            jose.setNome("José da Silva");
            jose.setIdade(35);
            jose.ValorHora = 30;
            jose.Tipo = 1;
            WriteLine("Salário: {0:c}", jose.CalcularSalarioFinal(120));
            jose.imprimir();
            jose.AddAluno(joao);
            jose.AddAluno(rita);
            jose.ImprimirAlunos();
            

            Professor maria = new Professor();

            maria.setNome("Maria da Silva");
            maria.setIdade(40);
            maria.ValorHora = 30;
            maria.Tipo = 2;
            maria.Bonus = 15;
            WriteLine("Salário: {0:c}", maria.CalcularSalarioFinal(120));
            maria.imprimir();
            maria.AddAluno(rita);
            maria.ImprimirAlunos();

            ReadKey();
        }
    }
}
