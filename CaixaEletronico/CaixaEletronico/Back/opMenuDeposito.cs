using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Back
{
    class opMenuDeposito:Cofre
    {
        public String depositoCinquenta(int a)
        {
            addCinquenta(a);
            return $"Depositado {a} notas de 50 reais com sucesso.\n";
        }
        public String depositoVinte(int a)
        {
            addVinte(a);
            return $"Depositado {a} notas de 20 reais com sucesso.\n";
        }
        public String depositoDez(int a)
        {
            addDez(a);

            return $"Depositado {a} notas de 10 reais com sucesso.\n";
        }
    }
}
