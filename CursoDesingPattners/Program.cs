using Strategy.Impostos;
using StrategyImpostos;
using System;

namespace CursoDesingPattners
{
    class Program
    {
        static void Main(string[] args)
        {
            /* --------------------- TESTE ORÇAMENTO ---------------------------------
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();


            Orcamento orcamento = new Orcamento(5000.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCaulculo(orcamento, iss);
            calculador.RealizaCaulculo(orcamento, icms);
            calculador.RealizaCaulculo(orcamento, iccc);
            --------------------- TESTE ORÇAMENTO --------------------------------- */


            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));
            


            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);


            Console.ReadKey();
        }
    }
}
