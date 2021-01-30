using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Console
{
    class Janela : Produto, I_Produto
    {
        public void exibir()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"valor: {valor}");
            Console.WriteLine($"Quantidade no estoque: {quantidade}");
        }
    }
}
