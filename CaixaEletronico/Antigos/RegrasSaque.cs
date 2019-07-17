using System;

namespace CaixaEletronico
{
    class RegrasSaque
    {

        public String Saque(int saque, int cinquenta, int vinte, int dez)
        {
            int saldo = (cinquenta * 50) + (vinte * 20) + (dez * 10);
            int resto = saldo;
            int sacaCinquenta = 0;
            int sacaVinte = 0;
            int sacaDez = 0;

            if (resto <= saldo)
            {
                if (cinquenta >= 0 && resto >= 50)
                {
                    sacaCinquenta = resto % 50;
                    resto -= sacaCinquenta * 50;
                }
                if (vinte >= 0 && resto >= 20)
                {
                    sacaVinte = resto % 20;
                    resto -= sacaVinte * 20;
                }
                if (dez >= 0 && resto >= 10)
                {
                    sacaDez = resto % 10;
                    resto -= sacaDez * 10;
                }
                if (resto == 0)
                {
                    return "Seu dinheito sera entregue:\n" +
                            $"{sacaCinquenta} notas de 50 reais\n" +
                            $"{sacaVinte} notas de 20 reais\n" +
                            $"{sacaDez} notas de 10 reais\n"; ;
                }
                else { return "Não há notas disponiveis para esse saque"; }
            }
            return "benes";
        }
    }
}


