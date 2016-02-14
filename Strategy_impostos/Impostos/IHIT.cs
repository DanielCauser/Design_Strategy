using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.Impostos
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return 0.01 * orcamento.Itens.Count;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100.0;
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return DoisItensComMesmoNome(orcamento);
        }

        private bool DoisItensComMesmoNome(Orcamento orcamento)
        {
            List<string> lista = new List<string>();

            foreach (var i in orcamento.Itens)
                if (lista.Contains(i.Nome)) { return true; }
                else { lista.Add(i.Nome); }

            return false;
        }
    }
}
