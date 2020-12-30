using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando variaveis ponto flutuante");

            double salario = 1200.70;
            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2;
            Console.WriteLine("15 / 2 = " + idade); //vai printar 7

            idade = 15.0 / 2;
            Console.WriteLine("15.0 / 2 = " + idade); //vai printar 7.5

            Console.ReadKey();
        }
    }
}
