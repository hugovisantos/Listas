using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEPIExercicio3
{
    public interface IOperacoesLegislacaoMunicipal
    {
        void InformarCentroDistribuicao();
        decimal RetornarPrecoDolar(decimal dolar);
        int DiasGarantia { get; }
        
    }
}
