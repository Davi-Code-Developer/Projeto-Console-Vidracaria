using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Console
{
    class Program
    {
        enum Menu { Venda = 1, Estoque, Usuario, Cliente, Sair }
        enum Menu_Produto { Visualizar = 1, Cadastrar, Atualizar, Excluir }
        enum Menu_Usuario { Visualizar = 1, Cadastrar, Atualizar, Excluir }
        enum Menu_Cliente { Visualizar = 1, Cadastrar, Atualizar, Excluir }
        static void Main(string[] args)
        {
            bool sair = false;
            while (sair == false)
            {
                Console.Clear();
                Console.WriteLine("===Sistema de vendas Vidraçaria===");
                Console.WriteLine("1-Venda\n2-Estoque\n3-Usuario\n4-Cliente\n5-Sair");
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case Menu.Venda:
                        break;
                    case Menu.Estoque:
                        Console.Clear();
                        Console.WriteLine("===Estoque===");
                        Console.WriteLine("1-Visualizar\n2-Atualizar\n3-Adicionar\n4-Excluir");
                        Menu_Produto menu_produto = (Menu_Produto)int.Parse(Console.ReadLine());
                        switch (menu_produto)
                        {
                            case Menu_Produto.Visualizar:
                                break;
                            case Menu_Produto.Atualizar:
                                break;
                            case Menu_Produto.Cadastrar:
                                break;
                            case Menu_Produto.Excluir:
                                break;
                        }
                        break;
                    case Menu.Usuario:
                        Console.Clear();
                        Console.WriteLine("===Usuario===");
                        Console.WriteLine("1-Visualizar\n2-Atualizar\n3-Adicionar\n4-Excluir");
                        Menu_Usuario menu_usuario = (Menu_Usuario)int.Parse(Console.ReadLine());
                        switch (menu_usuario)
                        {
                            case Menu_Usuario.Visualizar:
                                break;
                            case Menu_Usuario.Atualizar:
                                break;
                            case Menu_Usuario.Cadastrar:
                                break;
                            case Menu_Usuario.Excluir:
                                break;
                        }
                        break;
                    case Menu.Cliente:
                        Console.Clear();
                        Console.WriteLine("===Cliente===");
                        Console.WriteLine("1-Visualizar\n2-Atualizar\n3-Adicionar\n4-Excluir");
                        Menu_Cliente menu_cliente = (Menu_Cliente)int.Parse(Console.ReadLine());
                        switch (menu_cliente)
                        {
                            case Menu_Cliente.Visualizar:
                                break;
                            case Menu_Cliente.Atualizar:
                                break;
                            case Menu_Cliente.Cadastrar:
                                break;
                            case Menu_Cliente.Excluir:
                                break;
                        }
                        break;
                    case Menu.Sair:
                        sair = true;
                        break;
                }
            }
        }
    }
}
