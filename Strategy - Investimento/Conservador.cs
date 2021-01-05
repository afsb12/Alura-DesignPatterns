using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy___Investimento
{
    public class Conservador : EstrategiaDeInsvestimento
    {
        public double CalculaInvestimento(Contabancaria contabancaria)
        {
            return contabancaria.Saldo += contabancaria.Saldo * 0.008;
        }
    }
}
