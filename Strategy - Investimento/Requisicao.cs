using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy___Investimento
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
