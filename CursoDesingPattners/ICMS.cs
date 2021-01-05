using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesingPattners
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
