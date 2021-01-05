using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy___Investimento
{
    public class Moderado : EstrategiaDeInsvestimento
    {

        public double CalculaInvestimento(Contabancaria contabancaria)
        {
            bool chance = new Random().Next(101) <= 50;
            if (chance)
            {
                return contabancaria.Saldo += contabancaria.Saldo * 0.025;
            }
            else
            {
                return contabancaria.Saldo += contabancaria.Saldo * 0.007;
            }
        }
    }
}
