using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.Descontos
{
    public class DescontoParaValorMaiorQue500Reais : Desconto
    {
        public Desconto ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
                return orcamento.Valor * 0.07;

            return ProximoDesconto.Desconta(orcamento);
        }
    }
}
