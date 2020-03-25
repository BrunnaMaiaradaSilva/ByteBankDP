using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankDP.Funcionarios;
using ByteBankDP.Sistemas;

namespace ByteBankDP
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();

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

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor diretor = new Diretor(8000, "777.777.777-99");
            diretor.Senha = "123";

            sistemaInterno.Logar(diretor, "123");
            sistemaInterno.Logar(diretor, "abc");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123";

            sistemaInterno.Logar(parceiro, "123");
        }
    }
}   
