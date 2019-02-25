using ListaEPIExercicio1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEPIExercicio1
{
    public abstract class Animal
    {        
        public string Nome{ get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public TipoDeAlimentacaoEnum TipoDeAlimentacao { get; set; }
        public TipoDeSomEmitidoEnum TipoDeSomEmitido { get; set; }
        public NumeroDePatasEnum NumeroDePatas { get; set; }

        public Animal(string nome, int idade, double altura, double peso, TipoDeAlimentacaoEnum tipoDeAlimentacao , TipoDeSomEmitidoEnum tipoDeSomEmitido, NumeroDePatasEnum numeroDePatas)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Altura = altura;
            this.Peso = peso;
            this.NumeroDePatas = numeroDePatas;
            this.TipoDeAlimentacao = tipoDeAlimentacao;
            this.TipoDeSomEmitido = tipoDeSomEmitido;
        }
        

        
        

    }
}
