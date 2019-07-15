using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    class OpcoesMenu : Saldo
    {

        private int _op;
        

        public void op(int a)
        {
            this._op = a;
        }
        public int getop
        {
            get { return this._op; }
        }
        public void Operacoes()
        {
            //var cofre = new Saldo();
            Mensagens mensagens = new Mensagens();
            int saque;
            int sCinquenta;
            int sVinte;
            int sDez;
            int resto;
            switch (this._op)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Insira a quantidade de notas de 50 reais");
                    addCinquenta((Convert.ToInt32(Console.ReadLine())));
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Insira a quantidade de notas de 20 reais");
                    addVinte(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Insira a quantidade de notas de 10 reais");
                    addDez(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Esse caixa opera apenas com notas de 10, 20 e 50 reais");
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
                    retiraCinquenta(sCinquenta);
                    retiraVinte(sVinte);
                    retiraDez(sDez);
                    break;
                case 5:
                    Console.Clear();
                    calculaSaldo();
                    Console.WriteLine("O caixa atualmente conta com as seguintes notas:\n" +
                    notasCinquenta + " notas de cinquenta reais \n" +
                    notasVinte + " notas de vinte reais \n" +
                    notasDez + " notas de dez reais\n" +
                    "Totalizando R$" + saldo + ",00");
                    //mensagens.txtSaldo();
                    
                    break;
                default:
                    break;
            }
        }
    }
}
