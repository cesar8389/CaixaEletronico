using System;

namespace CaixaEletronico
{
    public class Principal
    {
        static void Main (string[] args)
        {
            var mensagens = new Mensagens();
            var opcoesmenu = new OpcoesMenu();
            Console.WriteLine(mensagens.BemVindo);
            mensagens.Menu();
        }
    }
}
