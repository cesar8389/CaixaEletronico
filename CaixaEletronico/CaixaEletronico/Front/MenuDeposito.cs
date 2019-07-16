using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Front
{
    class MenuDeposito:Cofre
    {
        public void txtMenuDeposito()
        {
            int d;
            Console.WriteLine(  "________________________\n" +
                                "Banco Central Lateral Direito\n" +
                                "Escolha a nota que será adiconada: \n" +
                                "1 - 50 reais\n" +
                                "2 - 20 reais\n" +
                                "3 - 10 reais\n" +
                                "________________________\n");
            d= Convert.ToInt32(Console.ReadLine());
            txtSubMenuDeposito(d);
        }
        public void txtSubMenuDeposito(int a)
        {
            int quantidade;
            switch (a) {
                case 1:
                Console.WriteLine("Quantas notas de 50 serão depositadas?\n");
                addCinquenta(Convert.ToInt32(Console.ReadLine()));
                Console.ReadLine();
                    break;

                case 2:
                Console.WriteLine("Quantas notas de 20 serão depositadas?\n");
                quantidade = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(depositoVinte(quantidade));
                Console.ReadLine();
                    break;
                case 3:
                Console.WriteLine("Quantas notas de 10 serão depositadas?\n");
                quantidade = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(depositoDez(quantidade));
                Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opção invalida.");
                    break;
            } 
        
        }
    }   
}
