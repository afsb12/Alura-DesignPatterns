using System;
using System.Collections.Generic;
using System.Text;

namespace Investimento
{
    public class Requisicao
    {
        public EFormatoRelatorioConta Formato { get; private set; }

        public Requisicao(EFormatoRelatorioConta formato)
        {
            this.Formato = formato;
        }

    }
}
