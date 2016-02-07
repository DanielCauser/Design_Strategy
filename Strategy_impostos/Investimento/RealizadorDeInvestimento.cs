using Strategy_impostos.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos
{
    public class RealizadorDeInvestimento
    {
        public void RealizaInvestimento(ContaBancaria conta, TipoInvestimento investimento)
        {
            var retornoInvestimento = investimento.RealizaInvestimento(conta);
            conta.Deposita(retornoInvestimento * 0.75);
            Console.WriteLine("Novo valor é de: " + conta.Valor);
        }
    }
}
