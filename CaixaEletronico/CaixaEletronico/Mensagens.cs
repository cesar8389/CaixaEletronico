using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    class Mensagens : Saldo
    {
        //Saldo valores = new Saldo();
        OpcoesMenu opMenu = new OpcoesMenu();
        public String BemVindo
        {
            get { return "Seja bem vindo ao Banco Central Lateral"; }
        }
        public void Menu()
        {
            do
            {
                Console.WriteLine("______________________________");
                Console.WriteLine("Escolha a opção desejada");
                Console.WriteLine("Carregar Notas");
                Console.WriteLine(" * (1) 50 reais");
                Console.WriteLine(" * (2) 20 reais");
                Console.WriteLine(" * (3) 10 reais");
                Console.WriteLine("(4) Saque");
                Console.WriteLine("(5) Saldo");
                Console.WriteLine("(6) Sair");
                Console.WriteLine("______________________________");
                opMenu.op(Convert.ToInt32(Console.ReadLine()));
                opMenu.Operacoes();
            } while (opMenu.getop != 6);
        }

        public void txtSaldo()
        {
            Console.WriteLine("O caixa atualmente conta com as seguintes notas:\n" +
                   Convert.ToString(notasCinquenta) + " notas de cinquenta reais \n" +
                   Convert.ToString(notasVinte) + " notas de vinte reais \n" +
                   Convert.ToString(notasDez) + " notas de dez reais\n" +
                   "Totalizando R$" + saldo + ",00");
        }

    }
}
