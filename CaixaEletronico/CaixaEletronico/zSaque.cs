using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{/*
    class Saque
    {
        public void sacar(int sSaldo, int sCinquenta, int sVinte, int sDez)
        {
            var saldo = new Saldo();
            //saldo aparece zero nessa classe
            int saque;
            /*int sCinquenta = saldo.notasCinquenta;
            int sVinte = saldo.notasVinte;
            int sDez = saldo.notasDez;
            int sSaldo = saldo.saldo;
            int resto;
            var rs = new RegrasSaque();
            saldo.calculaSaldo();
            Console.WriteLine("Esse caixa opera apenas com notas de 10, 20 e 50 reais");
            Console.WriteLine(sSaldo);
            Console.WriteLine("Qual o valor desejado:");
            saque = Convert.ToInt32(Console.ReadLine());
            resto = saque;
            //verificar se é multiplo de 10
            if (rs.multiploDez(saque))
            {
                // verifica se o valor está disponivel
                if (rs.disponivel(sSaldo, resto))
                {
                    //Calcular quantidade de notas
                    if (rs.nCinquenta(resto, sCinquenta))
                    {
                        while (sCinquenta >= 0 && resto >= 0)
                        {
                            resto -= 50;
                            saldo.retiraCinquenta(1);
                            sCinquenta += 1;
                        }
                    }
                    else if (rs.nVinte(resto, sVinte))
                    {
                        while (sVinte >= 0 && resto >= 0)
                        {
                            resto -= 20;
                            saldo.retiraVinte(1);
                            sVinte += 1;
                        }
                    }
                    else if (rs.nDez(resto, sDez))
                    {
                        while (sDez >= 0 && resto >= 0)
                        {
                            resto -= 10;
                            saldo.retiraDez(1);
                            sDez += 1;
                        }
                    }

                    //imprimir a quantidade de notas
                    Console.WriteLine("Será liberado:");
                    Console.WriteLine("-" + sCinquenta + "notas de cinquenta reais");
                    Console.WriteLine("-" + sVinte + "notas de vinte reais");
                    Console.WriteLine("-" + sDez + "notas de dez reais");
                }
                else { Console.WriteLine("Valor indisponivel. Saldo atual: R$" + sSaldo + ",00."); }
            }
            else { Console.WriteLine("Esse caixa só aceita saque de valores multiplos de 10"); }
        }
    }*/
}