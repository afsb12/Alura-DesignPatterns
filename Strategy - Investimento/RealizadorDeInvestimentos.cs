using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy___Investimento
{
    public class RealizadorDeInvestimentos
    {
        public void Investir(Contabancaria contabancaria, EstrategiaDeInsvestimento estrategia)
        {
            contabancaria.Saldo = estrategia.CalculaInvestimento(contabancaria);
            Console.WriteLine(contabancaria.Saldo);
        }
    }
}
