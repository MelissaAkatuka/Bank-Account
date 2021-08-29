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
            var conta = new ContaCorrente(10);
            var contaConvertida = ConverterConta<ContaCorrente, ContaInvestimento>(conta); //entrada é conta corrente e saida é conta investimento
            Console.WriteLine(contaConvertida);
        }

        public static void Transferencia<A, B>(int valor, A contaOrigem, A contaDestino) where A : Conta where B : Conta
        {
            contaOrigem.Transferir(valor, contaDestino);
            contaDestino.Depositar(valor);
        }

        public static B ConverterConta<A, B>(A contaOrigem) where A : Conta where B : Conta
        {
            var contaConvertida = Activator.CreateInstance<B>(); //criar instancia a partir de um obj generico

            contaConvertida.Agencia = contaOrigem.Agencia; //criou uma conta nova
            contaConvertida.Saldo = contaOrigem.Saldo;
            contaConvertida.Numero = contaOrigem.Numero;

            contaConvertida.Depositar(contaOrigem.Saldo);
            contaOrigem = null;
            return contaConvertida;
        }
    }
}
