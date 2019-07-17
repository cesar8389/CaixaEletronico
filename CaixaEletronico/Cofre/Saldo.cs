using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Cofre
{
    class Saldo
    {
        public static List<Cedulas> GetLivros()
        {
            var listaCedulas = new List<Cedulas>()
            {
                new Cedulas { Valor=50,Nome="cinquenta", Quantidade=0},
                new Cedulas { Valor=20,Nome="vinte", Quantidade=0},
                new Cedulas { Valor=10,Nome="dez", Quantidade=0},
            };
            return listaCedulas;
        }
    }
}
