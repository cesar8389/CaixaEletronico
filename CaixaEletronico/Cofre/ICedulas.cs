using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Cofre
{
    interface ICedulas
    {
        String Nome(String nome);
        int Valor(int valor);
        int Quantidade(int quantidade);
    }
}
