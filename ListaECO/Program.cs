using System;

namespace ListaECO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            
        }
        public bool SituacaoDoAluno()
        {
            Notas notas = new Notas();
            if (notas.CalculoDaMediaFinal() > 5.5)
            {
                return true;
            }                
            else
            {
                return false;
            }
            

        }
        
    }
}
