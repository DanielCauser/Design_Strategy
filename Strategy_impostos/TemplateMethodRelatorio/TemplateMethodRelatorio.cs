using Strategy_impostos.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.TemplateMethodRelatorio
{
    public abstract class TemplateMethodRelatorio : Relatorio
    {
        public string GerarRelatorio(List<ContaBancaria> contas)
        {
            StringBuilder s = new StringBuilder();
            s.Append(GerarCabecalho() + Console.Out.NewLine);
            s.Append(GerarCorpo(contas) + Console.Out.NewLine);
            s.Append(GerarRodape() + Console.Out.NewLine);
            return s.ToString();
        }

        protected abstract string GerarCorpo(List<ContaBancaria> contas);

        protected abstract string GerarCabecalho();

        protected abstract string GerarRodape();
    }
}
