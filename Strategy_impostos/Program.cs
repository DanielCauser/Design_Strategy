using Strategy_impostos.Descontos;
using Strategy_impostos.Impostos;
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
            //cálculo de imposto STRATEGY
            //var iss = new ISS();
            //var icms = new ICMS();
            //var iccc = new ICCC();

            //Orcamento orcamento = new Orcamento(500.0);
            //CalculadorDeImposto calcular = new CalculadorDeImposto();

            //calcular.RealizaCalculo(orcamento, iss);
            //calcular.RealizaCalculo(orcamento, icms);
            //calcular.RealizaCalculo(orcamento, iccc);


            //cálculo de investimento STRATEGY
            //var moderado = new MODERADO();
            //var arrojado = new ARROJADO();

            //var calculador = new RealizadorDeInvestimento();
            //var conta = new ContaBancaria(100.0);

            //calculador.RealizaInvestimento(conta, moderado); 
            //calculador.RealizaInvestimento(conta, arrojado); 


            //Cálcular descontos CHAIN OF RESPONSABILITY

            var orcamento = new Orcamento(500.0);
            //orcamento.AdcionaItem(new Item("CANETA AZUL", 500.0));
            //orcamento.AdcionaItem(new Item("CANETA AZUL", 500.0));
            //orcamento.AdcionaItem(new Item("CANETA AZUL", 500.0));
            //orcamento.AdcionaItem(new Item("XBOX", 250));
            //orcamento.AdcionaItem(new Item("MASCARA", 50));
            //orcamento.AdcionaItem(new Item("CELULAR", 50));
            //orcamento.AdcionaItem(new Item("TV", 50));
            //orcamento.AdcionaItem(new Item("ÁGUA", 50));


            orcamento.AdcionaItem(new Item("LAPIS", 500.0));
            orcamento.AdcionaItem(new Item("CANETA", 500.0));
            orcamento.AdcionaItem(new Item("CANETA AZUL", 500.0));

            var calcularDesconto = new CalculadorDeDesconto();
            var result = calcularDesconto.CalculaDesconto(orcamento);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
