using Strategy_impostos.Impostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.Descontos
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if(aconteceuVendaCasada(orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            return ProximoDesconto.Desconta(orcamento);
        }

        private bool aconteceuVendaCasada(Orcamento orcamento)
        {
            if (existe("CANETA", orcamento) && existe("LAPIS", orcamento))
                return true;

            return false;
        }
        private bool existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }

    }
}
