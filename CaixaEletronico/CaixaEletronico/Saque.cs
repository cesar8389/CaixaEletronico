using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    class Saque : Saldo
    {
        public void sacar()
        {
            int saque;
            int sCinquenta = 0;
            int sVinte = 0;
            int sDez = 0;
            int resto;
            var rs = new RegrasSaque();

            Console.WriteLine("Esse caixa opera apenas com notas de 10, 20 e 50 reais");
            Console.WriteLine(saldo);
            Console.WriteLine("Qual o valor desejado:");
            saque = Convert.ToInt32(Console.ReadLine());
            resto = saque;
            //verificar se é multiplo de 10
            if (rs.multiploDez(saque))
            {
                // verifica se o valor está disponivel
                if (rs.disponivel(saque))
                {
                    //Calcular quantidade de notas
                    if (rs.nCinquenta(resto))
                    {
                        while (notasCinquenta > 0 && resto > 0)
                        {
                            resto -= 50;
                            retiraCinquenta(1);
                            sCinquenta += 1;
                        }
                    }
                    else if (rs.nVinte(resto))
                    {
                        while (notasVinte > 0 && resto > 0)
                        {
                            resto -= 20;
                            retiraVinte(1);
                            sVinte += 1;
                        }
                    }
                    else if (rs.nDez(resto))
                    {
                        while (notasDez > 0 && resto > 0)
                        {
                            resto -= 10;
                            retiraDez(1);
                            sDez += 1;
                        }
                    }

                    //imprimir a quantidade de notas
                    Console.WriteLine("Será liberado:");
                    Console.WriteLine("-" + sCinquenta + "notas de cinquenta reais");
                    Console.WriteLine("-" + sVinte + "notas de vinte reais");
                    Console.WriteLine("-" + sDez + "notas de dez reais");
                }
                else { Console.WriteLine("Valor indisponivel. Saldo atual: R$" + saldo + ",00."); }
            }
            else { Console.WriteLine("Esse caixa só aceita saque de valores multiplos de 10"); }
        }
    }
}