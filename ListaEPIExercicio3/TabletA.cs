using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEPIExercicio3
{
    public class TabletA : Produto , IOperacoesLegislacaoEstadual , IOperacoesLegislacaoMunicipal
    {
        public decimal Imposto => (decimal) 0.05;
        public int DiasGarantia => 30;
        public void InformarCentroDistribuicao()
        {
            Console.WriteLine("Cajamar");
        }        
        public decimal RetornarPrecoDolar(decimal dolar)
        {
            return base.Valor / dolar;
        }
        public bool IsIndustrializado()
        {
            throw new NotImplementedException();
        }
        public override string Funcionalidades()
        {
            return "Funcionalidades: Tela 14 polegadas\nConectividade Wi-Fi e 4G, leitor de impressões digitais.";
        }
        public void Informacoes()
        {            
            Nome = "Tablet A 64 GB";
            Console.WriteLine("Produto: " + Nome);
            Console.WriteLine(this.Funcionalidades());
            InformarCentroDistribuicao();
            Console.WriteLine("Garantia de " + this.DiasGarantia + " dias");
            Console.WriteLine("Digite o valor do produto");
            base.Valor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O valor sem imposto é: R$" + base.ValorSemImposto());
            Console.WriteLine("O valor com imposto é: R$" + (base.ValorSemImposto() * Imposto + base.ValorSemImposto()));
            Console.WriteLine("O valor em dolar é: U$" + RetornarPrecoDolar((decimal)3.20));
        }
        
    }
}
