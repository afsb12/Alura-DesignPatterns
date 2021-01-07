using System;
using System.Collections.Generic;
using System.Text;

namespace Investimento
{
    public class Contabancaria
    {
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public void Deposita (double saldo)
        {
            this.Saldo += saldo;
        }
    }
}
