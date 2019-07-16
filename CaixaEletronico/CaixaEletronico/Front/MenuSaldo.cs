using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Front
{
    class MenuSaldo
    {
        public void txtSaldo(int a, int b, int c, int d)
        {
            Console.WriteLine("________________________\n" +
                    "Banco Central Lateral Direito\n" +
                    $"Saldo atual: R${a},00.\n" +
                    "Contagem individual de notas: \n" +
                    $"{b} - 50 reais\n" +
                    $"{c} - 20 reais\n" +
                    $"{d} - 10 reais\n" +
                    "________________________\n");
            Console.ReadLine();
            
        }
    }
}
