using ListaEPIExercicio1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEPIExercicio1
{
    public class Cachorro :Animal
    {
        public Cachorro(string nome, int idade, double altura, double peso, TipoDeAlimentacaoEnum tipoDeAlimentacao, TipoDeSomEmitidoEnum tipoDeSomEmitido, NumeroDePatasEnum numeroDePatas)
            : base(nome, idade, altura, peso, tipoDeAlimentacao, tipoDeSomEmitido, numeroDePatas)
        {
            nome = "Abestado";
            idade = 5;
            altura = 57;
            peso = 30;
            tipoDeAlimentacao = Enums.TipoDeAlimentacaoEnum.ONIVORO;
            tipoDeSomEmitido = Enums.TipoDeSomEmitidoEnum.LATIDO;
            numeroDePatas = Enums.NumeroDePatasEnum.QUATRO_PATAS;
        }
    }
}
