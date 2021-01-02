using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            /*
            cliente.nome = "Guilherme";
            cliente.cpf = "123.456.789-10";
            cliente.profissao = "Desenvolvedor";
            */

            cliente.Nome = "Guilherme";
            cliente.CPF = "123.456.789-10";
            cliente.Profissao = "Desenvolvedor";



            /*
            // Usando as funcoes Definir e Obter
            conta.DefinirSaldo(-10);
            Console.WriteLine(conta.ObterSaldo());
            */

            //Usando get e set
            conta.Saldo = 50;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);


            Console.ReadKey();
        }
    }
}
