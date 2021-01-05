using System;

namespace CursoDesingPattners
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();


            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCaulculo(orcamento, iss);
            calculador.RealizaCaulculo(orcamento, icms);
            Console.ReadKey();
        }
    }
}
