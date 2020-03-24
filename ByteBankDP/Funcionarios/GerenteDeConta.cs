using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankDP.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(double salario, string cpf) : base(salario, cpf)
        {

        }

        public override void AumentarSalário()
        {
            Salario *= 1.05;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
