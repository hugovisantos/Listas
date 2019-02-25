using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEPIExercicio3
{
    public interface IOperacoesLegislacaoEstadual
    {
        bool IsIndustrializado();
        decimal Imposto { get; }
    }
}
