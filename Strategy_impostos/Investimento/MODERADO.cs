using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.Investimento
{
    public class MODERADO : TipoInvestimento
    {
        Random random;

        public MODERADO()
        {
            this.random = new Random();
        }

        public double RealizaInvestimento(ContaBancaria conta)
        {
            if (random.Next(2) == 0)
                return conta.Valor * 0.025;
            else
                return conta.Valor * 0.007;
        }


    }
}
