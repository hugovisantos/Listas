using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEHJ
{
    public class ContaMasterEspecial : ContaBancaria
    {
        public ContaMasterEspecial()
        {
            Random rdn = new Random();
            NumeroDaConta = rdn.Next(0, 99999);
                        
        }        


        public decimal valorLimiteDeSaldo = 10_000;
                        
        public override bool Sacar(decimal valorDeSaque)
        {          
            if(LimiteDeSaldo(valorDeSaque))
            {
                base.Saldo -= valorDeSaque;
                return true;
                
            }
            return false;                            
        }

        private bool LimiteDeSaldo(decimal valor)
        {
            if (base.Saldo + valorLimiteDeSaldo < valor)
            {
                return true;
            }
            return false;
        }

        public decimal ExibirLimite()
        {
            return valorLimiteDeSaldo;
        }



    }
}
