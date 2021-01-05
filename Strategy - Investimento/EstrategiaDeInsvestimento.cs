using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy___Investimento
{
    public interface EstrategiaDeInsvestimento
    {
        double CalculaInvestimento(Contabancaria contabancaria);
    }
}
