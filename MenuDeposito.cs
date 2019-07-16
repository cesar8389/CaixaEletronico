using System;

namespace CaixaEletronico
{
    class MenuDeposito : Program
    {
        public String txtMenuDeposito()
        {
            return "________________________\n" +
                    "Banco Central Lateral Direito\n" +
                    "Escolha a nota que será adiconada: \n" +
                    "1 - 50 reais\n" +
                    "2 - 20 reais\n" +
                    "3 - 10 reais\n" +
                    "________________________\n";
        }
        public int txtSubMenuDeposito(int a)
        {
            Console.WriteLine("Quantas notas serão depositadas?\n");
            a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
    }
}

