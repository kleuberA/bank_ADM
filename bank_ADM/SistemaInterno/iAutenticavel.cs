using bank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_ADM.SistemaInterno
{
    public interface iAutenticavel
    {

        public bool Autenticar(string senha);
    }
}
