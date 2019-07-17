using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Cofre
{
    class Dinheiro
    {
        public List<ICedulas> cedulas;
        public void addDinheiro(String nome, int valor, int quantidade)
        {
            cedulas.Add(new ICedulas(50, "Macoratti"));
        }
    }
}
