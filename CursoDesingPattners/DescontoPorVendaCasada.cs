using CursoDesingPattners;
using StrategyImpostos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Impostos
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public List<string>  ItensCasados { get; set; }

        public DescontoPorVendaCasada()
        {
            ItensCasados = new List<string>();

            ItensCasados.Add("LAPIS");
            ItensCasados.Add("CANETA");
        }

        public double Desconta(Orcamento orcamento)
        {
            foreach (var item in ItensCasados)
            {
                if(Existe(item, orcamento))
                    return orcamento.Valor * 0.05;
            }

            return Proximo.Desconta(orcamento);
        }

        public bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
