using Strategy_impostos.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.TemplateMethodRelatorio
{
    public interface Relatorio
    {
        string GerarRelatorio(List<ContaBancaria> contas);
    }
}
