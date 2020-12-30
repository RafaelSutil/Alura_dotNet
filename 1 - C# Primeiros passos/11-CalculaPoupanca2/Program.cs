using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando poupanca 2");

            double valorInvestido = 100000;

            for(int contadorMes = 1; contadorMes <=12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Apos " + contadorMes + " meses, voce tera R$" + valorInvestido);
            }

            Console.ReadKey();
        }
    }
}
