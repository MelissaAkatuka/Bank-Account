using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Rodar();
        }
        private static void Rodar()
        {
            var conta = new ContaCorrente(20);
            var contaConvertida = ConverterConta<ContaCorrente, ContaInvestimento>(conta); //entrada é conta corrente e saida é conta investimento
            Console.WriteLine(contaConvertida.Saldo);
        }
        public static B ConverterConta<A, B>(A contaOrigem) where A : Conta where B : Conta
        {
            var contaConvertida = Activator.CreateInstance<B>(); //criar instancia a partir de um obj generico

            contaConvertida.Agencia = contaOrigem.Agencia; //criou uma conta nova
            contaConvertida.Numero = contaOrigem.Numero;

            contaConvertida.Depositar(contaOrigem.Saldo);
            contaOrigem = null; //pra matar a antiga 
            return contaConvertida;
        }
    }
}
