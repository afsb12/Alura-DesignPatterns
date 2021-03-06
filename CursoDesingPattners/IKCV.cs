﻿using CursoDesingPattners;
using System;
using System.Collections.Generic;
using System.Text;

namespace Impostos
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
        }

        public override double MaximmaTaxacaoOrcamento(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento) 
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;
        }
            
    }
}
