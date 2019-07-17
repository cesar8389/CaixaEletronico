using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Cofre
{
    class Cedulas
    {
        public int Valor { get; set; }
        public String Nome { get; set; }
        public int Quantidade { get; set; }

        public Cedulas()
        {

        }
        public Cedulas(int aValor, String aNome, int aQuantidade)
        {
            Valor = aValor;
            Nome = aNome;
            Quantidade = aQuantidade;
        }
    }
}   
