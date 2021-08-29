using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public abstract class ContaRendimento : Conta
    {
        protected ContaRendimento()
        {
        }

        protected ContaRendimento(double depositoInicial) : base(depositoInicial)
        {
        }

        public double PorcentagemRendimento { get; set; }

        public void Render()
        {
            base.Saldo *= PorcentagemRendimento;
        }
    }
}
