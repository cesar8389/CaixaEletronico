using System;

namespace CaixaEletronico
{
    public class Principal
    {
        static void Main(string[] args)
        {
            //Variaveis para armazenar o que tem em caixa
            var cofre = new Saldo();
            //Variaveis para calculo do saque
            int saque;
            int sCinquenta;
            int sVinte;
            int sDez;
            int resto;
            //para armazenar o que tem no caixa
            //int saldo = 0;

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
                        cofre.addCinquenta((Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 2:
                        Console.WriteLine("Insira a quantidade de notas de 20 reais");
                        cofre.addVinte(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Insira a quantidade de notas de 10 reais");
                        cofre.addDez(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Qual o valor desejado:");
                        saque = Convert.ToInt32(Console.ReadLine());
                        //Calcular quantidade de notas
                        sCinquenta = saque / 50;
                        resto = saque - (sCinquenta * 50);
                        sVinte = resto / 20;
                        resto = resto - (sVinte * 20);
                        sDez = resto / 10;
                        resto = resto - (sDez * 10);
                        //imprimir a quantidade de notas
                        Console.WriteLine("Será liberado:");
                        Console.WriteLine("-" + sCinquenta + "notas de cinquenta reais");
                        Console.WriteLine("-" + sVinte + "notas de vinte reais");
                        Console.WriteLine("-" + sDez + "notas de dez reais");
                        //Atualizar saldo do caixa eletronico
                        //cofre.addCinquenta -= sCinquenta;
                        //cofre.vinte -= sVinte;
                        //cofre.dez -= sDez;
                        break;
                    case 5:                        
                        //saldo = (cinquenta * 50) + (vinte * 20) + (dez * 20);
                        Console.WriteLine(cofre.notasCinquenta);
                        break;
                    default:
                        break;
                }
            } while (op != 6);
        }
    }
}
