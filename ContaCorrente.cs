using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(double depositoInicial) : base(depositoInicial)
        {
        }

        public void Sacar(double valor)
        {
            if (valor < Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
            }

        }
    }
}
