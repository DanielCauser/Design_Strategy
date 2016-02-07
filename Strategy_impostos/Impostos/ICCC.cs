using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos
{
    public class ICCC : Imposto
    {
        public double CalcularImposto(Orcamento orcamento)
        {
            if (1000.0 > orcamento.Valor)
                return orcamento.Valor * 0.05;
            else if (1000.0 >= orcamento.Valor && 3000.00 <= orcamento.Valor)
                return orcamento.Valor * 0.07;
            else 
                return (orcamento.Valor * 0.08) + 30.0;
        }
    }
}
