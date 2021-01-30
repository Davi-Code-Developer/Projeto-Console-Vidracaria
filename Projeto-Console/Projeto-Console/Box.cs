using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Console
{
    class Box : Produto, I_Produto
    {
        //Box tem que obrigar o vidro a ter 8mm
        public void exibir()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"valor: {valor}");
            Console.WriteLine($"Quantidade no estoque: {quantidade}");

        }
    }
}
