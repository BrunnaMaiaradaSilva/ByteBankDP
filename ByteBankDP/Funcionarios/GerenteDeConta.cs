using ByteBankDP.Sistemas;

namespace ByteBankDP.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
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
