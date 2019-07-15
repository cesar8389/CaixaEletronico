using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    class OpcoesMenu
    {

        private int _op;
        Saldo cofre = new Saldo();

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
            int saque;
            int sCinquenta;
            int sVinte;
            int sDez;
            int resto;
            switch (this._op)
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
                    cofre.retiraCinquenta(sCinquenta);
                    cofre.retiraVinte(sVinte);
                    cofre.retiraDez(sDez);
                    break;
                case 5:
                    cofre.calculaSaldo();
                    Console.WriteLine(cofre.saldo);
                    break;
                default:
                    break;
            }
        }
    }
}
