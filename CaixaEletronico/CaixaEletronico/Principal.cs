using System;

namespace CaixaEletronico
{
    public class Principal
    {
        Saldo valores = new Saldo();

        public static void Main(string[] args)
        {
            /*Mensagens mensagens = new Mensagens();
            Console.WriteLine(mensagens.BemVindo);
            mensagens.Menu();*/
            
            OpcoesMenu opMenu = new OpcoesMenu();
            Console.WriteLine("Seja bem vindo ao Banco Central Lateral");
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
    }
    }

