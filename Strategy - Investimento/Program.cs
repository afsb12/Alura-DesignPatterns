using System;

namespace Investimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Contabancaria conta = new Contabancaria();
            conta.NomeTitular = "Alisson";
            conta.Deposita(1000);

            Requisicao requisicao = new Requisicao(EFormatoRelatorioConta.XML);

            GerenciadorDeRequisicoes gerenciador =  new GerenciadorDeRequisicoes();
            IProcessadorDeRequisicao p1 = new ProcessadorRequisicaoCSV();


            p1.Processar(requisicao, conta);

            Console.ReadKey();
        }
    }
}
