using ListaEPIExercicio1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEPIExercicio1
{
    public class Vaca : Animal
    {
        public Vaca(string nome, int idade, double altura, double peso, TipoDeAlimentacaoEnum tipoDeAlimentacao, TipoDeSomEmitidoEnum tipoDeSomEmitido, NumeroDePatasEnum numeroDePatas)
            : base(nome, idade, altura, peso, tipoDeAlimentacao, tipoDeSomEmitido, numeroDePatas)
        {
            nome = "Tosca";
            idade = 10;
            altura = 78;
            peso = 200;
            tipoDeAlimentacao = Enums.TipoDeAlimentacaoEnum.HERBIVORO;
            tipoDeSomEmitido = Enums.TipoDeSomEmitidoEnum.MUGIDO;
            numeroDePatas = Enums.NumeroDePatasEnum.QUATRO_PATAS;
        }
    }
}
