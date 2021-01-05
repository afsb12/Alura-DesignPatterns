using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy___Investimento
{
    public class Contabancaria
    {
        public double Saldo { get; set; }

        public Contabancaria(double saldo)
        {
            this.Saldo = saldo;
        }
    }
}
