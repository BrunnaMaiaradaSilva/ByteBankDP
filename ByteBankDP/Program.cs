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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario brunna = new Funcionario(4890,"445.654.789-25");

            brunna.Nome = "Brunna";
           
            gerenciador.Registrar(brunna);

            Diretor roberta = new Diretor(4890, "445.681.269-28");
            roberta.Nome = "Roberta";

            gerenciador.Registrar(roberta);

            Console.WriteLine(brunna.Nome);
            Console.WriteLine(brunna.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine(gerenciador.GetTotalBonificacao());

            brunna.AumentarSalário();
            Console.WriteLine("Novo salário: " + brunna.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Console.ReadLine();
        }
    }
}
