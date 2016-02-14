using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.Impostos
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500.0 && AlgumItemMaiorQue100(orcamento);
        }

        private bool AlgumItemMaiorQue100(Orcamento orcamento)
        {
            foreach (var i in orcamento.Itens)
                if (i.Valor > 100.0) { return true; }

            return false;
        }
    }
}
