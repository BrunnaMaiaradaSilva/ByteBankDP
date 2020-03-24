using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankDP.Funcionarios;

namespace ByteBankDP
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer designer = new Designer(4000, "777.777.777-99");
            Diretor diretor = new Diretor(8000, "777.777.777-99");
            GerenteDeConta gerenteDeConta = new GerenteDeConta(7000, "777.777.777-99");
            Auxiliar auxiliar = new Auxiliar(2000, "777.777.777-99");

            gerenciadorBonificacao.Registrar(designer);
            gerenciadorBonificacao.Registrar(auxiliar);
            gerenciadorBonificacao.Registrar(diretor);
            gerenciadorBonificacao.Registrar(gerenteDeConta);

            Console.WriteLine("Total de bonificações " + 
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}   
