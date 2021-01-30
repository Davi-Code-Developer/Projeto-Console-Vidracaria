using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Console
{
    class Espelho : Produto, I_Produto
    {
        //O espelho tem que ter 2,3 ou 4 mm OBRIGATORIAMENTE
        public void exibir()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"valor: {valor}");
            Console.WriteLine($"Quantidade no estoque: {quantidade}");
        }
    }
}
