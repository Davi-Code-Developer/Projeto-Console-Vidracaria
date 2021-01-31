using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Console
{
    [Serializable]
    class Porta : Produto, I_Produto
    {
        public Porta(int id, string nome, double valor, int quantidade, float espessura, float altura, float largura, string tipo, string resistencia) :
            base(id, valor, nome, quantidade)
        {
            this.altura = altura;
            this.largura = largura;
            this.espessura = espessura;
            tipo_vidro = tipo;
            resistencia_vidro = resistencia;
        }
        public void Exibir()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"valor: {valor}");
            Console.WriteLine($"Quantidade no estoque: {quantidade}");
            Console.WriteLine($"Espessura da porta: {espessura}mm");
            Console.WriteLine($"Altura da porta: {altura}");
            Console.WriteLine($"Largura da porta: {largura}");
            Console.WriteLine($"Tipo do vidro: {tipo_vidro}");
            Console.WriteLine($"Resistencia do vidro: {resistencia_vidro}");
        }
    }
}
