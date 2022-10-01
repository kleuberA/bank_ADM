using bank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bank_ADM.Funcionarios
{
    public  class Diretor: FuncionarioAutenticavel
    {

        public override double getBonificacao()
        {
            
            return Salario * 0.5;
        }

        public Diretor(string cpf): base(cpf, 5000)
        {
            Console.WriteLine("Criando um diretor. No CPF: " + cpf + " com valor salarial de: " + 5000);
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }


    }
}
