using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Condicionais");

            int idadeJoao = 16, quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Joao possui mais de 18 anos de idade.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Joao nao possui mais de 18 anos mas esta acompanhado.");
                }
                else
                {
                    Console.WriteLine("Joao nao possui mais de 18 anos.");
                }

            }

            //Ctrl + E + D -> Formata o codigo!

            Console.ReadKey();
        }
    }
}
