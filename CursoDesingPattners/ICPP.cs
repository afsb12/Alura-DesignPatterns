using CursoDesingPattners;
using System;
using System.Collections.Generic;
using System.Text;

namespace Impostos
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override double MaximmaTaxacaoOrcamento(Orcamento orcamento)
        {
            return orcamento.Valor * 0.7;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.5;
        }
    }
}
