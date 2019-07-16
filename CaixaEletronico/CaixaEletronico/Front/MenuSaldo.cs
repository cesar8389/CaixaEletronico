using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Front
{
    class MenuSaldo
    {
        public String txtSaldo(int a, int b, int c, int d)
        {
            return  "________________________\n" +
                    "Banco Central Lateral Direito\n" +
                    $"Saldo atual: R${a},00.\n" +
                    "Contagem individual de notas: " +
                    $"{b} - 50 reais" +
                    $"{c} - 20 reais" +
                    $"{d} - 10 reais" +
                    "________________________\n";
        }
    }
}
