using System;
using System.Collections.Generic;
using System.Text;

namespace Investimento
{
    public class ProcessadorRequisicaoXML : IProcessadorDeRequisicao
    {
        public IProcessadorDeRequisicao ProximoProcessador { get ; set ; }

        public void Processar(Requisicao requisicao, Contabancaria conta)
        {
            if(requisicao.Formato == EFormatoRelatorioConta.XML)
            {
                Console.WriteLine("<ContaBancaria>\n    <NomeTitular>{0}</NomeTitular>\n    <Saldo>{1}</Saldo>\n</ContaBancaria>",
                    conta.NomeTitular,conta.Saldo);
            }

            if (ProximoProcessador != null)
                ProximoProcessador.Processar(requisicao, conta);
            else
                return;
        }
    }
}
