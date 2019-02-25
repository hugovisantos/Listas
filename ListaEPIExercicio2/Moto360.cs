using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEPIExercicio2
{
    public class Moto360 : ISmartWatch
    {
        public void ExibirSistemaOperacional()
        {
            Console.WriteLine("Android");
        }
        public void ExibirHoras()
        {
            Console.WriteLine("23% Carregando...");
            Console.WriteLine(DateTime.Now);
        }
        public void ExibirEmail()
        {
            Console.WriteLine("Moto360@Moto360.com.br");
        }
        public void CarregarBateria()
        {
            Console.WriteLine("23% Carregando...");
        }
    }
}
