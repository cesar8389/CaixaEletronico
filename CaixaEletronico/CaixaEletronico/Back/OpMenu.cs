using System;
using System.Collections.Generic;
using System.Text;


namespace CaixaEletronico.Back
{
    class OpMenu
    {
        public void oMenu(int op)
        {
            var mDeposito = new Front.MenuDeposito();
            var mSaldo = new Front.MenuSaldo();
                switch (op)
                {
                    case 1:
                        //deposito
                        Console.Clear();
                        mDeposito.txtMenuDeposito();
                        break;
                    case 2:
                        //saque
                        Console.Clear();
                        break;
                    case 3:
                        //saldo
                        Console.Clear();
                        mSaldo.txtSaldo();
                        break;
                    case 4:
                        //log
                        break;
                    default:
                        break;
                }
        }
    }
}
