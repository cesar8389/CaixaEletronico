using System;
using System.Collections.Generic;
using System.Text;


namespace CaixaEletronico.Back
{
    class OpMenu:Cofre
    {
        public OpMenu(int op)
        {
            var mDeposito = new Front.MenuDeposito();
            var mSaldo = new Front.MenuSaldo();
            do
            {
                switch (op)
                {
                    case 1:
                        //deposito
                        Console.Clear();
                        Console.WriteLine(mDeposito.txtMenuDeposito());
                        break;
                    case 2:
                        //saque
                        Console.Clear();
                        break;
                    case 3:
                        //saldo
                        Console.Clear();
                        mSaldo.txtSaldo(valorSaldo, notasCinquenta, notasVinte, notasDez);
                        break;
                    case 4:
                        //log
                        break;
                    case 5:
                        //sair
                        break;
                    default:
                        break;
                }
            } while (op != 5);
        }
    }
}
