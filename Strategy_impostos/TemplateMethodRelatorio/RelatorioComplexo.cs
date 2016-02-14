using Strategy_impostos.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.TemplateMethodRelatorio
{
    public class RelatorioComplexo : TemplateMethodRelatorio
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
            return "BB - Rua dos bancos - 11 666-6666" + Console.Out.NewLine;
        }

        protected override string GerarRodape()
        {
            return "danielcauser@gmail.com " + DateTime.Now.ToString() + Console.Out.NewLine;
        }
    }
}
