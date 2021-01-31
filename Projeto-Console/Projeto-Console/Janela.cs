using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Console
{
    [Serializable]
    class Janela : Produto, I_Produto
    {
        public float Espessura
        {
            get
            {
                return espessura;
            }
            set
            {
                if (value >= 6)
                {
                    espessura = value;
                }
                Console.WriteLine("Espessura tem que ser maior que 6mm");
            }
        }
        public float Altura
        {
            get
            {
                return altura;
            }
            set
            {
                if (value >= 1.10f)
                {
                    altura = value;
                }
                else
                {
                    Console.WriteLine("Altura tem que ser maior que 1,10m");
                }
            }
        }
        public Janela(int id, string nome, double valor, int quantidade, float espessura, float altura, float largura, string tipo, string resistencia) :
            base(id, valor, nome, quantidade)
        {
            Altura = altura;
            this.largura = largura;
            Espessura = espessura;
            tipo_vidro = tipo;
            resistencia_vidro = resistencia;
        }
        public void Exibir()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"valor: {valor}");
            Console.WriteLine($"Quantidade no estoque: {quantidade}");
            Console.WriteLine($"Espessura da janela: {espessura}mm");
            Console.WriteLine($"Altura do janela: {altura}");
            Console.WriteLine($"Largura do janela: {largura}");
            Console.WriteLine($"Tipo do vidro: {tipo_vidro}");
            Console.WriteLine($"Resistencia do vidro: {resistencia_vidro}");
        }
    }
}
