using CursoDesingPattners;
using Impostos;
using StrategyImpostos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Impostos
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();


            d1.Proximo = d2;
            d3.Proximo = d4;


            return d1.Desconta(orcamento);
        }
    }
}
