using CursoDesingPattners;
using System;
using System.Collections.Generic;
using System.Text;

namespace Impostos
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
                return MaximmaTaxacaoOrcamento(orcamento);

            return MinimaTaxacao(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximmaTaxacaoOrcamento(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);


    }
}
