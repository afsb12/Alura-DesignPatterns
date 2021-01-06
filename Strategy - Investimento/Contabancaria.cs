using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy___Investimento
{
    public class Contabancaria
    {
        public double Saldo { get; private set; }

        public void Deposita (double saldo)
        {
            this.Saldo += saldo;
        }
    }
}
