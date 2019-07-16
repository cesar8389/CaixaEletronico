using System;

namespace CaixaEletronico
{
    class MenuSaldo : Program
    {
        public String txtMenuSaldo(int a, int b, int c, int d)
        {
            return "________________________\n" +
                    "Banco Central Lateral Direito\n" +
                    $"Saldo atual: R${a},00.\n" +
                    "Contagem individual de notas: \n" +
                    $"{b} - 50 reais\n" +
                    $"{c} - 20 reais\n" +
                    $"{d} - 10 reais\n" +
                    "________________________\n";
        }
    }
}
