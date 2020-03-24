using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankDP.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(double salario, string cpf) : base(salario, cpf)
        {

        }

        public override void AumentarSalário()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        { 
            return Salario * 0.5;
        }
    }
}
