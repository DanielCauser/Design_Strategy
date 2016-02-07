using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.Descontos
{
    public class CalculadorDeDesconto
    {
        public double CalculaDesconto(Orcamento orcamento)
        {
            var d1 = new DescontoParaMaisDe5Itens();
            var d2 = new DescontoParaValorMaiorQue500Reais();
            var d3 = new DescontoPorVendaCasada();
            var d4 = new SemDesconto();


            d1.ProximoDesconto = d2;
            d2.ProximoDesconto = d3;
            d3.ProximoDesconto = d4;

            return d1.Desconta(orcamento);

        }
    }
}
