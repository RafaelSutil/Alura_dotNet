using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Conversoes_EOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");


            Console.WriteLine("Aprendendo a converter de double para inteiro:");
            double salario;
            salario = 1200.50;
            Console.WriteLine("Salario: " + salario);

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine("Salario em inteiro: " + salarioEmInteiro + "\n\n");

            long idade = 100000000000000; // Inteiro 2^64

            short qtdProdutos = 15000; // Inteiro 2^16

            float altura = 1.80f; // Decimal com menos casas decimais que double





            Console.ReadKey();
        }
    }
}
