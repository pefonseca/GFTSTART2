using System;

namespace ControleFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionario = new Funcionarios();

            funcionario.ImprimirDados();

            Console.WriteLine("\nTipo de trabalho: \n");

            funcionario.DadosTrabalho();
        }
    }
}
