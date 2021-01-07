using System;
using System.Collections.Generic;
using System.Text;

namespace Investimento
{
    public interface EstrategiaDeInsvestimento
    {
        double CalculaInvestimento(Contabancaria contabancaria);
    }
}
