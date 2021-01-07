using Investimento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Investimento
{
    public class ProcessadorRequisicaoPorcento : IProcessadorDeRequisicao
    {
        public IProcessadorDeRequisicao ProximoProcessador { get; set; }

        public ProcessadorRequisicaoPorcento()
        {
            ProximoProcessador = new ProcessadorRequisicaoXML();
        }

        public void Processar(Requisicao requisicao, Contabancaria conta)
        {
            if (requisicao.Formato == EFormatoRelatorioConta.PORCENTO)
            {
                Console.WriteLine("%{0}%  %{1}%",
                    conta.NomeTitular, conta.Saldo);
            }

            if (ProximoProcessador != null)
                ProximoProcessador.Processar(requisicao, conta);
            else
                return;
        }
    }
}
