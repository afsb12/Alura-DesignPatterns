using System;
using System.Collections.Generic;
using System.Text;

namespace Investimento
{
    public class RealizadorDeInvestimentos
    {
        public void Investir(Contabancaria contabancaria, EstrategiaDeInsvestimento estrategia)
        {
            contabancaria.Deposita(estrategia.CalculaInvestimento(contabancaria));
            Console.WriteLine(contabancaria.Saldo);
        }
    }
}
