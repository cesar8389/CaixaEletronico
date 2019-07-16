using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Front
{
    class MenuDeposito
    {
        public MenuDeposito()
        {
            Console.WriteLine(  "________________________\n" +
                                "Banco Central Lateral Direito\n" +
                                "Escolha a nota que será adiconada: \n" +
                                "1 - 50 reais" +
                                "2 - 20 reais" +
                                "3 - 10 reais" +
                                "________________________\n");
        }
        public string txtMenuDeposito()
        {
            return "________________________\n" +
                    "Banco Central Lateral Direito\n" +
                    "Escolha a nota que será adiconada: \n" +
                    "1 - 50 reais" +
                    "2 - 20 reais" +
                    "3 - 10 reais" +
                    "________________________\n"; 
        }
    }
}
