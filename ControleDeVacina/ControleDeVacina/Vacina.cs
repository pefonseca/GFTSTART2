using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeVacina
{
    public class Vacina
    {

        public string Tipo { get; set; }
        public DateTime Data { get; set; }

        public void ObtendoInfo()
        {
            Console.Write("Informe a vacina que tomou: ");
            Tipo = Console.ReadLine();
            Console.Write("Informe a data que tomou a vacina: ");
            DateTime Data = DateTime.Parse(Console.ReadLine());
            DateTime SegundaDose = Data.AddDays(14);

            if (Tipo == "Coronavac")
            {
                Console.WriteLine("Você tomou a vacina " + Tipo + "\nPrimeira dose: "+ Data + "\nSegunda dose: " + SegundaDose);
            }
            else if (Tipo == "Janssen") 
            {
                Console.WriteLine("Você tomou a vacina Janssen, dose única!");
            }
            else
            {
                Console.WriteLine("Vacina desconhecida!");
            }                        
        }
    }
}
