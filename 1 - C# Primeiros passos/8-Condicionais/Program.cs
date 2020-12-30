using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Condicionais 2");

            int idadeJoao = 16, quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Joao pode entrar.");
            }
            else
            {
                Console.WriteLine("Joao nao pode entrar");
            }

            if (idadeJoao >= 18 && acompanhado)
            {
                Console.WriteLine("Joao pode entrar.");
            }
            else
            {
                Console.WriteLine("Joao nao pode entrar");
            }

            //Ctrl + E + D -> Formata o codigo!

            Console.ReadKey();
        }
    }
}

