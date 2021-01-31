using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Console
{
    [Serializable]
    class Box : Produto, I_Produto
    {
        public Box(int id, string nome, double valor, int quantidade, float altura, float largura,string tipo, string resistencia) :
            base(id, valor, nome, quantidade)
        {
            this.altura = altura;
            this.largura = largura;
            espessura = 8; //Box tem que ter obrigatoriamente 8mm
            tipo_vidro = tipo;
            resistencia_vidro = resistencia;
        }
        public void Exibir()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"valor: {valor}");
            Console.WriteLine($"Quantidade no estoque: {quantidade}");
            Console.WriteLine($"Espessura do box: {espessura}mm");
            Console.WriteLine($"Altura do box: {altura}");
            Console.WriteLine($"Largura do box: {largura}");
            Console.WriteLine($"Tipo do vidro: {tipo_vidro}");
            Console.WriteLine($"Resistencia do vidro: {resistencia_vidro}");

        }
    }
}
