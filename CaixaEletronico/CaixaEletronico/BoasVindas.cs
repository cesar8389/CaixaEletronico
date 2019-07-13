using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public class BoasVindas
    {
        public BoasVindas()
        {
            int op = 0;
            var dinheiro = new MoneyAdd();
            var saldo = new Saldo();
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
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Insira a quantidade de notas de 50 reais");
                        dinheiro.Cinquenta(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Insira a quantidade de notas de 20 reais");
                        dinheiro.Vinte(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Insira a quantidade de notas de 10 reais");
                        dinheiro.Dez(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        Console.WriteLine("Saldo de R$" + )
                        break;
                    default:
                        break;
                }
            } while (op != 6);
        }
        

    }
}
