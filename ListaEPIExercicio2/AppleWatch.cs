using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEPIExercicio2
{
    public class AppleWatch
    {
        public void ExibirSistemaOperacional()
        {
            Console.WriteLine("Apple");
        }
        public void ExibirHoras()
        {
            Console.WriteLine(DateTime.Now);
        }
        public void ExibirEmail()
        {
            Console.WriteLine("AppleWatch@AppleWatch.com.br");
        }
        public void CarregarBateria()
        {
            Console.WriteLine("23% Carregando...");
        }
    }
}
