using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMoto
{
    public class Moto
    {
        public double Valor { get; set; }
        public int QuantidadeParcelas { get; set; }

        public void MostrarDados() 
        {
            Console.Write("Informe o valor da moto: ");
            Valor = double.Parse(Console.ReadLine());

            double Calculo = Valor - (Valor * 0.30);
            Console.Write("Informe a quantidade de parcelas da moto: ");
            QuantidadeParcelas = int.Parse(Console.ReadLine());
            
            if (QuantidadeParcelas == 1)
            {
                Console.WriteLine("Preço final (Pagamento a vista): R$ " + Calculo.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Parcelas: " + QuantidadeParcelas);
            }
            else
            {
                if (QuantidadeParcelas == 5)
                {                    
                    double CalculoParcela = Valor + (Valor * 0.04);
                    double ValorParcela = CalculoParcela / 5;
                    Console.WriteLine("Valor final da Moto: R$ " + CalculoParcela.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Parcelas: " + QuantidadeParcelas);
                    Console.WriteLine("Valor de cada parcela: R$ " + ValorParcela); 
                }
                else if (QuantidadeParcelas == 11)
                {
                    double CalculoParcela = Valor + (Valor * 0.07);
                    double ValorParcela = CalculoParcela / 11;
                    Console.WriteLine("Valor final da Moto: R$ " + CalculoParcela.ToString("N2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Parcelas: " + QuantidadeParcelas);
                    Console.WriteLine("Valor de cada parcela: R$ " + ValorParcela);
                }
                else if (QuantidadeParcelas == 17)
                {
                    double CalculoParcela = Valor + (Valor * 0.10);
                    double ValorParcela = CalculoParcela / 17;
                    Console.WriteLine("Valor final da Moto: R$ " + CalculoParcela.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Parcelas: " + QuantidadeParcelas);
                    Console.WriteLine("Valor de cada parcela: R$ " + ValorParcela);
                }
                else if (QuantidadeParcelas == 23)
                {
                    double CalculoParcela = Valor + (Valor * 0.13);
                    double ValorParcela = CalculoParcela / 23;
                    Console.WriteLine("Valor final da Moto: R$ " + CalculoParcela.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Parcelas: " + QuantidadeParcelas);
                    Console.WriteLine("Valor de cada parcela: R$ " + ValorParcela);
                }
                else if (QuantidadeParcelas == 29)
                {
                    double CalculoParcela = Valor + (Valor * 0.16);
                    double ValorParcela = CalculoParcela / 29;
                    Console.WriteLine("Valor final da Moto: R$ " + CalculoParcela.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Parcelas: " + QuantidadeParcelas);
                    Console.WriteLine("Valor de cada parcela: R$ " + ValorParcela);
                }
                else
                {
                    Console.WriteLine("Para essa parcela não existe calculo!");
                }
            }
        }
    }
}
