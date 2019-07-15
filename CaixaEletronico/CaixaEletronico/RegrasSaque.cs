using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    class RegrasSaque:Saldo
    {
        public Boolean disponivel (int valor) {
            return valor <= saldo;
        }
        public Boolean nCinquenta(int valor) {
            return valor <= notasCinquenta;
        }
        public Boolean nVinte(int valor)
        {
            return valor <= notasVinte;
        }
        public Boolean nDez(int valor)
        {
            return valor <= notasDez;
        }
        public Boolean multiploDez(int valor)
        {
            return valor % 10 == 0;
        }
    }
}
