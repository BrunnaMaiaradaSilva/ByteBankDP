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
            Funcionario brunna = new Funcionario(1);

            brunna.Nome = "Brunna";
            brunna.CPF = "445.654.789-25";
            brunna.Salario = 4890;

            Console.WriteLine(brunna.Nome);

            Console.WriteLine(brunna.GetBonificacao());

            Console.ReadLine();
        }
    }
}
