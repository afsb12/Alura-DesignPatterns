using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy___Investimento
{
    public class Arrojado : EstrategiaDeInsvestimento
    {
        public double CalculaInvestimento(Contabancaria contabancaria)
        {
            int chance = new Random().Next(101);
            if (chance <= 20)
            {
                return contabancaria.Saldo += contabancaria.Saldo * 0.05;
            }
            else if (chance > 20 && chance <= 30 )
            {
                return contabancaria.Saldo += contabancaria.Saldo * 0.03;
            }
            else
            {
                return contabancaria.Saldo += contabancaria.Saldo * 0.006;
            }
        }
    }
}
