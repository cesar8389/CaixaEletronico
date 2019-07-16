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
            int val;
            do
            {
                Console.Clear();
                //Imprimir
                Console.WriteLine(menuPrincipal.txtMenu());
                val = Convert.ToInt32(Console.WriteLine());
                opMenuPrincipal.oMenu(val);
            } while (val != 5);
        }
    }
    }

