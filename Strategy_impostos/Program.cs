using Strategy_impostos.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_impostos
{
    class Program
    {
        static void Main(string[] args)
        {
            //cálculo de imposto
            //var iss = new ISS();
            //var icms = new ICMS();
            //var iccc = new ICCC();

            //Orcamento orcamento = new Orcamento(500.0);
            //CalculadorDeImposto calcular = new CalculadorDeImposto();

            //calcular.RealizaCalculo(orcamento, iss);
            //calcular.RealizaCalculo(orcamento, icms);
            //calcular.RealizaCalculo(orcamento, iccc);
            
            
            //cálculo de investimento
            var moderado = new MODERADO();
            var arrojado = new ARROJADO();

            var calculador = new RealizadorDeInvestimento();
            var conta = new ContaBancaria(100.0);

            calculador.RealizaInvestimento(conta, moderado); 
            calculador.RealizaInvestimento(conta, arrojado); 
            

            Console.ReadKey();
        }
    }
}
