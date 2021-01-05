using System;

namespace CursoDesingPattners
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();


            Orcamento orcamento = new Orcamento(5000.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCaulculo(orcamento, iss);
            calculador.RealizaCaulculo(orcamento, icms);
            calculador.RealizaCaulculo(orcamento, iccc);
            Console.ReadKey();
        }
    }
}
