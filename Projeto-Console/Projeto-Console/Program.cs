using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Console
{
    class Program
    {
        enum Menu {Venda=1,Produto,Usuario,Cliente,Sair}
        static void Main(string[] args)
        {
            bool sair = false;
            while (sair == false)
            {
                Console.WriteLine("===Sistema de vendas Vidraçaria===");
                Console.WriteLine("1-Venda\n2-Produto\n3-Usuario\n4-Cliente\n5-Sair");
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case Menu.Venda:
                        break;
                    case Menu.Produto:
                        break;
                    case Menu.Usuario:
                        break;
                    case Menu.Cliente:
                        break;
                    case Menu.Sair:
                        sair = true;
                        break;
                }
            }

        }
    }
}
