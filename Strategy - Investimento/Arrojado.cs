using System;
using System.Collections.Generic;
using System.Text;

namespace Investimento
{
    public class Arrojado : EstrategiaDeInsvestimento
    {
        private Random random;

        public Arrojado()
        {
            this.random = new Random();
        }

        public double CalculaInvestimento(Contabancaria contabancaria)
        {
            int chance = random.Next(10);
            if (chance >= 0 && chance <= 1)
                return contabancaria.Saldo * 0.05;
            else if (chance >= 2 && chance <= 4 )
                return contabancaria.Saldo * 0.03;
            else
                return contabancaria.Saldo * 0.006;
        }
    }
}
