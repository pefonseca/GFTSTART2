using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFuncionarios
{
    public class Funcionarios
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }

        public void ImprimirDados()
        {
            Console.Write("Informe seu nome: ");
            Nome = Console.ReadLine();

            Console.Write("Informe seu cargo: ");
            Cargo = Console.ReadLine();

            Console.Write("Informe seu salário: ");
            Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSeus dados: ");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Cargo: " + Cargo);
            Console.WriteLine("Salario: R$" + Salario.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void DadosTrabalho()
        {
            if (Cargo == "Estagiario" && Salario <= 800)
            {
                Console.WriteLine("Trabalho 100% Home Office");
            }
            else if (Cargo == "Junior" && Salario <= 1200)
            {
                Console.WriteLine("Trabalho Presencial");
            }
            else if (Cargo == "Senior" && Salario <= 2500)
            {
                Console.WriteLine("Trabalho Híbrido");
            }
            else
            {
                Console.WriteLine("Cargo desconhecido!");
            }
        }
    }
}
