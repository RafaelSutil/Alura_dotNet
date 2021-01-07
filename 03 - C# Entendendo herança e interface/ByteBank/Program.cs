using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //CalcularBonificacao();

            UsarSistema();

            /*
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "123.456.789-10");
            carlos.Nome = "Carlos";

            Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);

            carlos.AumentarSalario();
            Console.WriteLine("Novo salario do carlos " + carlos.Salario);

            gerenciador.Registrar(carlos);



            Diretor roberta = new Diretor("789.456.132-01");
            roberta.Nome = "Roberta";

            Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);

            roberta.AumentarSalario();
            Console.WriteLine("Novo salario da roberta " + roberta.Salario);

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine(gerenciador.GetTotalBonificacao());
            */

            Console.ReadKey();
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("111.111.111-11");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("222.222.222-22");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("333.333.333-33");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("444.444.444-44");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificacoes do mes: " + gerenciadorBonificacao.GetTotalBonificacao());


        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("222.222.222-22");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("444.444.444-44");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");

        }
    }
}
