using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleModelos
{
    public class Ator : Modelo
    {
        public string NivelAtor { get; set; }

        public Ator(string nome, double altura, int peso, int idade) : base(nome, altura, peso, idade)
        {

        }

        public void MostrarDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Tem: " + Altura + " de altura");
            Console.WriteLine("Pesando: " + Peso.ToString("F2", CultureInfo.InvariantCulture) + " KG");
            Console.WriteLine("Tem " + Idade + " anos");
            Console.WriteLine("Trabalha como Ator!");
        }
    }
}
