using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.Investimento
{
    public class ARROJADO : TipoInvestimento
    {
        Random random;

        public ARROJADO()
        {
            this.random = new Random();
        }

        public double RealizaInvestimento(ContaBancaria conta)
        {
            int chute = random.Next(10);
            if (chute >= 0 && chute <= 1) return conta.Valor * 0.5;
            else if (chute >= 2 && chute <= 4) return conta.Valor * 0.3;
            else return conta.Valor * 0.006;
        }
    }
}
