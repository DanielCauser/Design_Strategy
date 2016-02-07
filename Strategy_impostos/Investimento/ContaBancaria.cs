using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.Investimento
{
    public class ContaBancaria
    {
        public double Valor { get; private set; }

        public ContaBancaria(double valor)
        {
            this.Valor = valor;
        }
        public void Deposita(double valor)
        {
            this.Valor = valor + this.Valor;
        }
    }
}
