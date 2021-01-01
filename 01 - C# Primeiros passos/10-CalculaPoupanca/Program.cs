using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula Poupanca");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {

                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Apos " + contadorMes + " mes, voce tera R$" + valorInvestido);
                contadorMes++;
            }
            

            Console.ReadKey();
        }
    }
}
