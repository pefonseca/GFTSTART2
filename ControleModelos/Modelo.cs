using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleModelos
{
    public class Modelo
    {
        public string Nome { get; set; }
        public double Altura { get; set; }
        public int Peso { get; set; }
        public int Idade { get; set; }

        public Modelo(string nome, double altura, int peso, int idade)
        {
            Nome = nome;
            Altura = altura;
            Peso = peso;
            Idade = idade;
        }

        public void MostrarDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Tem: " + Altura + " de altura");
            Console.WriteLine("Pesando: " + Peso.ToString("F2", CultureInfo.InvariantCulture) + " KG");
            Console.WriteLine("Tem " + Idade + " anos");
            Console.WriteLine("Trabalha como Modelo!");
        }
    }
}
