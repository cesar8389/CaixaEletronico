using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Front
{
    class MenuSaldo:Cofre
    {
        public void txtSaldo()
        {
            aSaldo();
            Console.WriteLine("________________________\n" +
                    "Banco Central Lateral Direito\n" +
                    $"Saldo atual: R${valorSaldo},00.\n" +
                    "Contagem individual de notas: \n" +
                    $"{notasCinquenta} - 50 reais\n" +
                    $"{notasVinte} - 20 reais\n" +
                    $"{notasDez} - 10 reais\n" +
                    "________________________\n");
            Console.ReadLine();
            
        }
    }
}
