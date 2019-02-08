using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEHJ
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca()
        {
            Random rdn = new Random();
            NumeroDaConta = rdn.Next(0, 99999);

        }

        
        protected bool AniversarioParaRendimento(DateTime aniversario, int idade)
        {            
            double rendimentoAniversario = idade * 0.05;

            if (aniversario.Date == DateTime.Now.Date)
            {                
                base.Saldo += (decimal)rendimentoAniversario;
            }
            return false;
        }
    }
}
