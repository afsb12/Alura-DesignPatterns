using Investimento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Investimento
{
    public class ProcessadorRequisicaoCSV : IProcessadorDeRequisicao
    {
        public IProcessadorDeRequisicao ProximoProcessador { get ; set ; }

        public ProcessadorRequisicaoCSV()
        {
            ProximoProcessador = new ProcessadorRequisicaoPorcento();
        }

        public void Processar(Requisicao requisicao, Contabancaria conta)
        {
            if (requisicao.Formato == EFormatoRelatorioConta.CSV)
            {
                Console.WriteLine("{0};{1};",
                    conta.NomeTitular, conta.Saldo);
            }

            if (ProximoProcessador != null)
                ProximoProcessador.Processar(requisicao, conta);
            else
                return;
        }
    }
}
