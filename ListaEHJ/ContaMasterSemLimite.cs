using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEHJ
{
    public class ContaMasterSemLimite : ContaBancaria
    {
        public ContaMasterSemLimite()
        {
            Random rdn = new Random();
            NumeroDaConta = rdn.Next(0, 99999);

        }
        

        public override bool Sacar(decimal valorDeSaque)
        {
            base.Saldo -= valorDeSaque;
            return true;
        }
       


    }
}
