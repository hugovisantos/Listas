using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEPIExercicio3
{
    public abstract class Produto
    {
       
        public string Nome {get;set;}
        public decimal Valor{ get; set; }        
        public abstract String Funcionalidades();

        public decimal ValorSemImposto()
        {
            return this.Valor;
        }
        public decimal ValorComImposto()
        {
            return this.Valor;
        }
        

        
    }
}
