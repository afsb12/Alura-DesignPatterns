using System;
using System.Collections.Generic;
using System.Text;

namespace Investimento
{
    public class Moderado : EstrategiaDeInsvestimento
    {
        private Random random;

        public Moderado()
        {
            this.random = new Random();
        }

        public double CalculaInvestimento(Contabancaria contabancaria)
        {
            
            if (random.Next(2) == 0)
                return contabancaria.Saldo * 0.025;

            else
                return contabancaria.Saldo * 0.007;
        }
    }
}
