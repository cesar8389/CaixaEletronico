using System;

namespace CaixaEletronico
{
    public class Principal
    {

        public static void Main(string[] args)
        {
            //Chamar objetos
            var menuPrincipal = new MenuPrincipal();
            var opMenuPrincipal = new Back.OpMenu();
            //Imprimir
            Console.WriteLine(menuPrincipal.txtMenu());
            opMenuPrincipal.op(Convert.ToInt32(Console.ReadLine()));
        }
    }
    }

