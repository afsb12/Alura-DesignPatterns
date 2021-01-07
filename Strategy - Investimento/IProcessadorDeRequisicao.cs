using System;
using System.Collections.Generic;
using System.Text;

namespace Investimento
{
    public interface IProcessadorDeRequisicao
    {
        IProcessadorDeRequisicao ProximoProcessador { get; set; }
        public void Processar(Requisicao requisicao, Contabancaria conta);
    }
}
