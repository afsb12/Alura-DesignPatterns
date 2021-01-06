using CursoDesingPattners;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyImpostos
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }
        double Desconta(Orcamento orcamento);
    }
}
