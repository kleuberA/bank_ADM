using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_ADM.Funcionarios
{
    public class Auxiliar: Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000) 
        {
            Console.WriteLine("Criando um auxiliar. No CPF: " + cpf + " com valor salarial de: " + 2000);
        }

        public override void AumentarSalario()
        {
            Salario *= 0.10;
        }

        public override double getBonificacao()
        {
            return Salario * 0.20;
        }
    }
}
