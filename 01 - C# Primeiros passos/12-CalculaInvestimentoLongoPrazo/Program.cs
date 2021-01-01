using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando poupanca 3");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;

            for (int contadorAno = 1; contadorAno <=5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine("Apos " + contadorMes + " meses, voce tera R$" + valorInvestido);
                }
                fatorRendimento += 0.001;
            }

            Console.WriteLine("Ao termino do investimento, voce tera R$" + valorInvestido);
                

            Console.ReadKey();
        }
    }
}
