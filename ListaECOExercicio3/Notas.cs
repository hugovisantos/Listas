using System;
using System.Collections.Generic;
using System.Text;

namespace ListaECO
{
    public class Notas
    {
        public double CalculoDaMediaFinal(double notaPrimeiroSemestre, double notaSegundoSemestre, double TCC)
        {
            var mediaSemestral = (notaPrimeiroSemestre + notaSegundoSemestre) / 2;
            var mediaTCC = TCC / 10;
            var notaFinal = mediaSemestral + mediaTCC;
            return notaFinal;
        }
    }
}
