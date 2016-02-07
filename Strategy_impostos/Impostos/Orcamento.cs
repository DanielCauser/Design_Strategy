using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_impostos.Impostos;

namespace Strategy_impostos
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens {get; private set;}
    
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdcionaItem(Item item)
        {
            this.Itens.Add(item);
        }
    }
}
