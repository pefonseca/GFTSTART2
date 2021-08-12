using System;

namespace ControleModelos
{
    class Program
    {
        static void Main(string[] args)
        {
            Ator ator = new Ator("João", 1.81, 80, 20);
            Ator ator1 = new Ator("Josias", 1.75, 90, 22);
            Ator ator2 = new Ator("Jericó", 1.71, 70, 23);
            Ator ator3 = new Ator("Jaime", 1.65, 60, 24);
            Modelo modelo = new Modelo("Mauro", 1.81, 80, 20);
            Modelo modelo1 = new Modelo("Matheus", 1.75, 50, 30);
            Modelo modelo2 = new Modelo("Bill", 1.61, 100, 40);
            Modelo modelo3 = new Modelo("Pedro", 1.91, 90, 50);

            ator.MostrarDados();
            Console.WriteLine("");
            ator1.MostrarDados();
            Console.WriteLine("");
            ator2.MostrarDados();
            Console.WriteLine("");
            ator3.MostrarDados();
            Console.WriteLine("");
            modelo.MostrarDados();
            Console.WriteLine("");
            modelo1.MostrarDados();
            Console.WriteLine("");
            modelo2.MostrarDados();
            Console.WriteLine("");
            modelo3.MostrarDados();
        }
    }
}
