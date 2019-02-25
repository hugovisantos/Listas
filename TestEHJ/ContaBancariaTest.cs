using ListaEHJ;
using System;
using Xunit;

namespace TestEHJ
{
    public class ContaBancariaTest
    {
        [Fact(DisplayName ="Dado um valor de saque deve reduzir do " +
                            "valor atual de saldo")]

        public void DeveSacarEReduzirOSaldoAtual()
        {
            var valorDeSaque = 100;
            var valorDeSaldo = 300;
            
            var contaBancaria = new ContaBancaria();

            //Act 
            var saldo = contaBancaria.Sacar(valorDeSaque);

            Assert.True();
        }
    }
}
