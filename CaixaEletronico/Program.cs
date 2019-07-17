using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------Objetos
            var cofre = new Cofre.Saldo();
            var menuPrincipal = new MenuPrincipal();
            var menuSaldo = new MenuSaldo();
            var menuDeposito = new MenuDeposito();
            var menuSaque = new MenuSaque();
            var regrasSaque = new RegrasSaque();
            //---------------------------

            //-------------------Variaveis
            int op;
            int saque;
            //---------------------------
            //Imprimir menu principal

            do
            {
                Console.Clear();
                Console.WriteLine(menuPrincipal.txtMenu());
                op = Convert.ToInt32(Console.ReadLine());
                int caso1;
                switch (op)
                {
                    case 1:
                        //Deposito
                        /*Console.Clear();
                        Console.WriteLine(menuDeposito.txtMenuDeposito());
                        caso1 = Convert.ToInt32(Console.ReadLine());
                        int valor = menuDeposito.txtSubMenuDeposito(caso1);
                        if (caso1 == 1) { cofre.cinquenta += valor; }
                        else if (caso1 == 2) { cofre.vinte += valor; }
                        else if (caso1 == 3) { cofre.dez += valor; }
                        Console.WriteLine("Deposito efetuado com sucesso!");
                        Console.ReadLine();*/
                        break;
                    case 2:
                        //Saque
                        /*Console.Clear();
                        Console.WriteLine(menuSaque.txtMenuSaque());
                        saque = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(regrasSaque.Saque(saque, cofre.cinquenta, cofre.vinte, cofre.dez));
                        Console.ReadLine();*/
                        break;
                    case 3:
                        //saldo
                        /*Console.Clear();
                        Console.WriteLine(menuSaldo.txtMenuSaldo((cofre.cinquenta * 50) + (cofre.vinte * 20) + (cofre.dez * 10),
                            cofre.cinquenta,
                            cofre.vinte,
                            cofre.dez));
                        Console.ReadLine();*/
                        break;
                    case 0:
                        break;
                }

            } while (op != 0);
        }
    }
}
