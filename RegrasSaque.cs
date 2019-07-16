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

            if (saque % 10 == 0 && saque <= saldo)
            {
                while (cinquenta >= 0 && resto >= 50)
                {
                    resto -= 50;
                    cinquenta -= 1;
                    sacaCinquenta += 1;
                    while (vinte >= 0 && resto >= 20)
                    {
                        resto -= 20;
                        vinte -= 1;
                        sacaVinte += 1;
                        while (dez >= 0 && resto >= 20)
                        {
                            resto -= 10;
                            dez -= 1;
                            sacaDez += 1;
                        }
                    }
                }
                
                
                
                
            }
            if (resto != 0)
            {
                return "Seu dinheito sera entregue:\n" +
                        $"{sacaCinquenta} notas de 50 reais\n" +
                        $"{sacaVinte} notas de 20 reais\n" +
                        $"{sacaDez} notas de 10 reais\n"; ;
            }
            else { return "Não há notas disponiveis para esse saque"; }
        }
    }
}

