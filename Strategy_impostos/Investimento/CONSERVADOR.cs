using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.Investimento
{
    public class CONSERVADOR : TipoInvestimento
    {
        public double RealizaInvestimento(ContaBancaria conta)
        {
            return conta.Valor * 0.08;
        }
    }
}
