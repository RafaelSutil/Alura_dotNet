using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escopo");

            int idadeJoao = 18, quantidadePessoas = 1;
            bool acompanhado = quantidadePessoas >= 2;



            if (acompanhado)
            {
                //soh existe dentro do escopo
                string mensagemAdicional = "Joao esta acompanhado!";
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                string mensagemAdicional = "Joao nao esta acompanhado";
                Console.WriteLine(mensagemAdicional);
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Joao pode entrar.");

            }
            else
            {
                Console.WriteLine("Joao nao pode entrar");
            }


            Console.ReadKey();
        }
    }
}
