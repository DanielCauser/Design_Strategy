using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.Descontos
{
    public class DescontoParaMaisDe5Itens : Desconto
    {
        public Desconto ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.1;

            return ProximoDesconto.Desconta(orcamento);
        }
    }
}
