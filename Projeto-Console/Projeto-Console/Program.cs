using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Projeto_Console
{
    class Program
    {
        protected static List<I_Produto> produtos = new List<I_Produto>(); //Criando uma lista de i_Produto
        enum Menu { Venda = 1, Produto, Usuario, Cliente, Sair }
        enum Menu_Produto { Visualizar = 1, Cadastrar, Atualizar, Excluir }
        enum Menu_Usuario { Visualizar = 1, Cadastrar, Atualizar, Excluir }
        enum Menu_Cliente { Visualizar = 1, Cadastrar, Atualizar, Excluir }
        protected enum Menu_Produto_Cadastro { Janela = 1, Porta, Espelho, Box, Acessorio }
        static void Main(string[] args)
        {
            Carregar_Produto();
            bool sair = false;
            while (sair == false)
            {
                Console.Clear();
                Console.WriteLine("===Sistema de vendas Vidraçaria===");
                Console.WriteLine("1-Venda N CLIKA AQUI" +
                                "\n2-Produto" +
                                "\n3-Usuario N CLIKA AQUI" +
                                "\n4-Cliente N CLIKA AQUI" +
                                "\n5-Sair");
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case Menu.Venda:
                        break;
                    case Menu.Produto:
                        Console.Clear();
                        Console.WriteLine("===Produto===");
                        Console.WriteLine("1-Visualizar estoque" +
                                        "\n2-Adicionar novo produto" +
                                        "\n3-Atualizar produto N CLIKA AQUI" +
                                        "\n4-Excluir produto existente");
                        Menu_Produto menu_produto = (Menu_Produto)int.Parse(Console.ReadLine());
                        switch (menu_produto)
                        {
                            case Menu_Produto.Visualizar:
                                Listar_Produto();
                                break;
                            case Menu_Produto.Atualizar:
                                break;
                            case Menu_Produto.Cadastrar:
                                Cadastro.Cadastrar_Produto();
                                break;
                            case Menu_Produto.Excluir:
                                Remover_produto();
                                break;
                        }
                        break;
                    case Menu.Usuario:
                        Console.Clear();
                        Console.WriteLine("===Usuario===");
                        Console.WriteLine("1-Visualizar" +
                                        "\n2-Atualizar" +
                                        "\n3-Adicionar" +
                                        "\n4-Excluir");
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
                        Console.WriteLine("1-Visualizar" +
                                        "\n2-Atualizar" +
                                        "\n3-Adicionar" +
                                        "\n4-Excluir");
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
        protected static void Salvar()
        {
            FileStream stream = new FileStream("Produtos.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();
            encoder.Serialize(stream,produtos);
            stream.Close();
        }
        static void Carregar_Produto()
        {
            FileStream stream = new FileStream("Produtos.dat",FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();
            try
            {
                produtos = (List<I_Produto>)encoder.Deserialize(stream);
                if(produtos == null)
                {
                    produtos = new List<I_Produto>();
                }
            }
            catch (Exception e)
            {
                produtos = new List<I_Produto>();
            }
            stream.Close();
        }        
        static void Listar_Produto()
        {
            Console.Clear();
            int i = 0;
            Console.WriteLine("====Lista de produtos cadastrados====");
            foreach(I_Produto entrada in produtos)
            {
                Console.WriteLine($"Op: [{i}]");
                Console.WriteLine("____________________________________");
                entrada.Exibir();
                Console.WriteLine("____________________________________");
                i++;
            }
            Console.WriteLine("Aperte enter para continuar");
            Console.ReadLine();
        }
        static void Remover_produto()
        {
            Listar_Produto();
            Console.WriteLine("Digite a OP do produto para ser apagado:");
            int op = int.Parse(Console.ReadLine());
            if(op < produtos.Count || op > produtos.Count)
            {
                produtos.RemoveAt(op);
                Salvar();
                Console.WriteLine("Produto removido com exito!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Opção invalida!");
                Console.ReadLine();
            }
            
            
        }
        static void Atualizar_produto()
        {
            Listar_Produto();
            Console.WriteLine("Digite a OP do produto para ser atualizado:");
            int op = int.Parse(Console.ReadLine());
            if (op < produtos.Count || op > produtos.Count)
            {
                Salvar();
                Console.WriteLine("Produto Atualizado com sucesso!");
                Console.ReadLine();
            }
        }
    }
}
