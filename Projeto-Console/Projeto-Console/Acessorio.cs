using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Console
{
    [Serializable]
    class Acessorio : Produto, I_Produto
    {
        public Acessorio(int id, string nome, double valor, int quantidade): 
            base(id, valor, nome, quantidade)
        {
        }
        public void Exibir()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"valor: {valor}");
            Console.WriteLine($"Quantidade no estoque: {quantidade}");
        }
    }
}
