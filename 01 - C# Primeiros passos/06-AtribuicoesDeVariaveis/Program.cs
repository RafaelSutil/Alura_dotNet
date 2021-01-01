using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atribuicao de variaveis");

            int idade = 32;
            int idadeGustavo = idade; //=32

            idade = 20;

            Console.WriteLine(idade); //20
            Console.WriteLine(idadeGustavo); //32

            Console.ReadKey();
        }
    }
}
