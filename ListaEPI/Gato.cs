using ListaEPIExercicio1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEPIExercicio1
{
    public class Gato: Animal
    {

        public Gato(string nome, int idade, double altura, double peso, TipoDeAlimentacaoEnum tipoDeAlimentacao, TipoDeSomEmitidoEnum tipoDeSomEmitido, NumeroDePatasEnum numeroDePatas)
            : base(nome, idade, altura, peso, tipoDeAlimentacao, tipoDeSomEmitido, numeroDePatas)
        {
            nome = "Doente";
            idade = 7;
            altura = 30;
            peso = 20;
            tipoDeAlimentacao = Enums.TipoDeAlimentacaoEnum.ONIVORO;
            tipoDeSomEmitido = Enums.TipoDeSomEmitidoEnum.MIADO;
            numeroDePatas = Enums.NumeroDePatasEnum.QUATRO_PATAS;
        }
    }
}
