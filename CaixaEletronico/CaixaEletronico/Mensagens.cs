using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    class Mensagens
    {
        public String BemVindo
        {
            get { return "Seja bem vindo ao Banco Central Lateral"; }
        }
        public void Menu()
        {
            var escolha = new OpcoesMenu();
            do
            {
                Console.WriteLine("");
                Console.WriteLine("################");
                Console.WriteLine("Banco Itaku");
                Console.WriteLine("Escolha a opção desejada");
                Console.WriteLine("Carregar Notas");
                Console.WriteLine(" * (1) 50 reais");
                Console.WriteLine(" * (2) 20 reais");
                Console.WriteLine(" * (3) 10 reais");
                Console.WriteLine("(4) Saque");
                Console.WriteLine("(5) Saldo");
                Console.WriteLine("(6) Sair");
                Console.WriteLine("################");
                escolha.op(Convert.ToInt32(Console.ReadLine()));
                escolha.Operacoes();
            } while (escolha.getop != 6);
        }

    }
}
