using Strategy_impostos.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.TemplateMethodRelatorio
{
    public class GeradorDeRelatorio
    {
        public void GerarRelatorio(List<ContaBancaria> contas, Relatorio relatorio)
        {
            //double valor = imposto.CalcularImposto(orcamento);
            var resultado = relatorio.GerarRelatorio(contas);
            Console.WriteLine(resultado);
        }
    }
}
