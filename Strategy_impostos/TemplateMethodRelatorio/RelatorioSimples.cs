using Strategy_impostos.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.TemplateMethodRelatorio
{
    public class RelatorioSimples : TemplateMethodRelatorio
    {
        protected override string GerarCorpo(List<ContaBancaria> contas)
        {
            string corpo = string.Empty;
            foreach (var c in contas)
            {
                corpo = corpo.ToString() + Console.Out.NewLine + c.Valor.ToString();
            }
            return corpo;
        }

        protected override string GerarCabecalho()
        {
            return "BB" + Console.Out.NewLine;
        }

        protected override string GerarRodape()
        {
            return "11 6666666" + Console.Out.NewLine;
        }
    }
}
