﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesingPattners
{
    public class CalculadorDeImpostos
    {
        public void RealizaCaulculo(Orcamento orcamento, IImposto imposto) 
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }

    }
}
