using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Console
{
    [Serializable]
    class Cadastro : Program
    {
        public static void Cadastrar_Produto()
        {
            Console.Clear();
            Console.WriteLine("===Produto===");
            Console.WriteLine("1-Janela" +
                            "\n2-Porta" +
                            "\n3-Espelho" +
                            "\n4-Box" +
                            "\n5-Acessorio");
            Menu_Produto_Cadastro menu_produto_cadastro = (Menu_Produto_Cadastro)int.Parse(Console.ReadLine());
            switch (menu_produto_cadastro)
            {
                case Menu_Produto_Cadastro.Janela:
                    Cadastrar_Produto_Janela();
                    break;
                case Menu_Produto_Cadastro.Porta:
                    Cadastrar_Produto_Porta();
                    break;
                case Menu_Produto_Cadastro.Espelho:
                    Cadastrar_Produto_Espelho();
                    break;
                case Menu_Produto_Cadastro.Box:
                    Cadastrar_Produto_Box();
                    break;
                case Menu_Produto_Cadastro.Acessorio:
                    Cadastrar_Produto_Acessorio();
                    break;
            }
        }
        static void Cadastrar_Produto_Janela()
        {
            Console.Clear();
            Console.WriteLine("===Cadastro de janela====");
            Console.WriteLine("ID da janela:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome da janela:");
            string nome = Console.ReadLine();
            Console.WriteLine("Valor da janela:");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Espessura da janela:");
            float espessura = float.Parse(Console.ReadLine());
            Console.WriteLine("Altura da janela:");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Largura da janela:");
            float largura = float.Parse(Console.ReadLine());
            Console.WriteLine("Tipo do vidro da janela:");
            string tipo = Console.ReadLine();
            Console.WriteLine("Resistencia do vidro da janela:");
            string resistencia = Console.ReadLine();
            Janela janela = new Janela(id,
                                       nome,
                                       valor,
                                       quantidade,
                                       espessura,
                                       altura,
                                       largura,
                                       tipo,
                                       resistencia);
            produtos.Add(janela);
            Salvar();
        }
        static void Cadastrar_Produto_Porta()
        {
            Console.Clear();
            Console.WriteLine("===Cadastro de porta====");
            Console.WriteLine("ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Valor:");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Espessura:");
            float espessura = float.Parse(Console.ReadLine());
            Console.WriteLine("Altur:");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Largura:");
            float largura = float.Parse(Console.ReadLine());
            Console.WriteLine("Tipo do vidro:");
            string tipo = Console.ReadLine();
            Console.WriteLine("Resistencia do vidro:");
            string resistencia = Console.ReadLine();
            Porta porta = new Porta(id, nome, valor, quantidade, espessura, altura, largura, tipo, resistencia);
            produtos.Add(porta);
            Salvar();
        }
        static void Cadastrar_Produto_Espelho()
        {
            Console.Clear();
            Console.WriteLine("===Cadastro de espelho====");
            Console.WriteLine("ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Valor:");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Espessura:");
            float espessura = float.Parse(Console.ReadLine());
            Console.WriteLine("Altur:");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Largura:");
            float largura = float.Parse(Console.ReadLine());
            Espelho espelho = new Espelho(id, nome, valor, quantidade, espessura, altura, largura);
            produtos.Add(espelho);
            Salvar();
        }
        static void Cadastrar_Produto_Box()
        {
            Console.Clear();
            Console.WriteLine("===Cadastro do Box====");
            Console.WriteLine("ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Valor:");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Espessura:");
            float espessura = float.Parse(Console.ReadLine());
            Console.WriteLine("Altur:");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Largura:");
            float largura = float.Parse(Console.ReadLine());
            Console.WriteLine("Tipo do vidro:");
            string tipo = Console.ReadLine();
            Console.WriteLine("Resistencia do vidro:");
            string resistencia = Console.ReadLine();
            Box box = new Box(id, nome, valor, quantidade, altura, largura, tipo, resistencia);
            produtos.Add(box);
            Salvar();
        }
        static void Cadastrar_Produto_Acessorio()
        {
            Console.Clear();
            Console.WriteLine("===Cadastro de acessorio====");
            Console.WriteLine("ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Valor:");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            Acessorio acessorio = new Acessorio(id, nome, valor, quantidade);
            produtos.Add(acessorio);
            Salvar();
        }
    }
}
