using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos.Descontos
{
    public interface Desconto
    {
        Desconto ProximoDesconto { get; set; }

        double Desconta(Orcamento orcamento);
    }
}
