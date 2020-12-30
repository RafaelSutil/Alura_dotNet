using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caracteres e textos");

            //Caractere
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            //Letra A tabela ascii
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            //Letra B tabela ascii
            primeiraLetra = (char)(65 + 1);
            Console.WriteLine(primeiraLetra);

            //strings
            string titulo = "Isso eh uma string " + 123;
            Console.WriteLine(titulo);

            string cursosProgramacao = @" - .NET
 - Java
 - Javascript";
            Console.WriteLine(cursosProgramacao);

            Console.ReadKey();
        }
    }
}
