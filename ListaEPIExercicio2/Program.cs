using System;

namespace ListaEPIExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto360 moto360 = new Moto360();
            AppleWatch appleWatch = new AppleWatch();

            Console.WriteLine("Moto360");
            moto360.ExibirSistemaOperacional();
            moto360.ExibirHoras();
            moto360.ExibirEmail();
            moto360.CarregarBateria();
            Console.ReadKey();

            Console.WriteLine("AppleWatch ");
            appleWatch.ExibirSistemaOperacional();
            appleWatch.ExibirHoras();
            appleWatch.ExibirEmail();
            appleWatch.CarregarBateria();
            Console.ReadKey();
        }
    }
}
