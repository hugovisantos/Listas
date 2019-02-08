using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEHJ
{
    public class ContaBancaria
    {
        

        public string NomeCliente { get; set; }
        public long CPF { get; set; }
        public int NumeroDaConta { get; set; }
        public static int QuantidadeDeContas;////////////////////////        
        public decimal Saldo { get; protected set; }
        public int QuantidadeDeChequesDisponiveis { get; private set; }
        public DateTime Aniversario { get; set; }

        public virtual bool Sacar(decimal valorDeSaque)
        {
            if (this.Saldo > valorDeSaque)
            {
                 this.Saldo -= valorDeSaque;
                return true;
            }
            return false;
        }

        public virtual void Depositar(decimal valorDeDeposito)
        {
            this.Saldo += valorDeDeposito;
        }

        public decimal ConsultarSaldo()
        {
            return this.Saldo;
        }
    }
}
