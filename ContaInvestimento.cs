using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class ContaInvestimento : ContaRendimento, IContaInvestimento
    {
        public ContaInvestimento(double depositoInicial) : base(depositoInicial)
        {
            RenderCashBack();
        }

        public double PorcentagemCashBack { get; set; }

        public void RenderCashBack()
        {
            base.Saldo *= PorcentagemCashBack;
        }
    }
}
