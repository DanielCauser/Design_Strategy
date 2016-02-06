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
            //var iss = new ISS();
            //var icms = new ICMS();

            //Orcamento orcamento = new Orcamento(500.0);

            //CalculadorDeImposto calcular = new CalculadorDeImposto();

            //calcular.RealizaCalculo(orcamento, iss);
            //calcular.RealizaCalculo(orcamento, icms);

            var iccc = new ICCC();
            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImposto calcular = new CalculadorDeImposto();
            calcular.RealizaCalculo(orcamento, iccc);

            Console.ReadKey();
        }
    }
}
