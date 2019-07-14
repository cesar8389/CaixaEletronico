using System;

namespace CaixaEletronico
{
    public class Principal
    {
        static void Main(string[] args)
        {
            //valores
            int cinquenta = 0;
            int vinte = 0;
            int dez = 0;
            //para armazenar o que tem no caixa
            int saldo = 0;

            int op = 0;
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
                        cinquenta = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Insira a quantidade de notas de 20 reais");
                        vinte = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Insira a quantidade de notas de 10 reais");
                        dez = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:

                        break;
                    case 5:
                        saldo = (cinquenta * 50) + (vinte * 20) + (dez * 20);
                        Console.WriteLine("Saldo de R$" + saldo + ",00");
                        break;
                    default:
                        break;
                }
            } while (op != 6);
        }
    }
}
