using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class ContaPoupanca : ContaRendimento
    {
        public ContaPoupanca()
        {
        }

        public ContaPoupanca(double depositoInicial, double bonus) : base(depositoInicial)
        {
            base.Saldo += bonus;
        }
    }
}
