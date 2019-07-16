using System;

namespace CaixaEletronico
{
    class RegrasSaque
    {
        String a;
        public String Saque(int saque, int cinquenta, int vinte, int dez)
        {
            int saldo = (cinquenta * 50) + (vinte * 20) + (dez * 10);
            int resto = saldo;
            int sacaCinquenta = 0;
            int sacaVinte = 0;
            int sacaDez = 0;
            if (saque % 10 > 0 || saque > saldo)
            {
                while (resto % 10 == 0)
                {
                    while (cinquenta >= 0 && resto >= 50)
                    {
                        resto -= 50;
                        cinquenta -= 1;
                        sacaCinquenta += 1;
                    }
                    while (vinte >= 0 && resto >= 20)
                    {
                        resto -= 20;
                        vinte -= 1;
                        sacaVinte += 1;
                    }
                    while (dez >= 0 && resto >= 20)
                    {
                        resto -= 10;
                        dez -= 1;
                        sacaDez += 1;
                    }
                    a = "Seu dinheito sera entregue:\n" +
                               $"{sacaCinquenta} notas de 50 reais" +
                               $"{sacaVinte} notas de 20 reais" +
                               $"{sacaDez} notas de 10 reais";
                }
            }
            else { a = "Não há notas disponiveis para atender seu pedido"; }
            return a;
        }
    }
}

