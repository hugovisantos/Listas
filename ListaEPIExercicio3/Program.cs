using System;

namespace ListaEPIExercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TabletA tabletA = new TabletA();
            tabletA.Informacoes();
            Console.WriteLine("\n");
            PhabletX phabletX = new PhabletX();
            phabletX.Informacoes();

            Console.ReadKey();
            
        }
    }
}
