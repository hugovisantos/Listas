using System;
using System.Collections.Generic;
using System.Text;

namespace ListaECO
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string DocumentoDeRegistroGeral { get; set; }
        public string Genero { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Idade { get; set; }
        
        public void VerificarFaixaEtaria()
        {            
            if( Idade < 12)
            {
                Console.WriteLine("Criança"); 
            }
            if (13 <= Idade && Idade <18)
            {
                Console.WriteLine("Adolescente");
            }
            if(19 <= Idade  && Idade <= 40)
            {
                Console.WriteLine("Adulto");
            }
            if(Idade >= 41)
            {
                Console.WriteLine("Adolescente");
            }
        }

        public int NumeroDeDiasDeVida(int idade)
        {            
            
            var diasDeVida = Idade * 360;
            return diasDeVida;
        }

    }
}
