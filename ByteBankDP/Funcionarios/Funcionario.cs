using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankDP.Funcionarios
{
    public class Funcionario
    {
        // 0 = funcionário
        // 1 = diretor
        private int _tipo;

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao()
        {
            if (_tipo == 1)
                return Salario;

            return Salario * 0.10;
        }

    }
}
