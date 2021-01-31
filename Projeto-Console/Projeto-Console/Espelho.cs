using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Console
{
    [Serializable]
    class Espelho : Produto, I_Produto
    {
        //O espelho tem que ter 2,3 ou 4 mm OBRIGATORIAMENTE
        public float Espessura
        {
            get
            { 
                return espessura; 
            }
            set
            { 
                if(value==2|| value == 3|| value == 4)
                {
                    espessura = value;
                }
                Console.WriteLine("Valor invalido (2,3,4)");
            }
        }
        public Espelho(int id, string nome, double valor, int quantidade, float espessura,float altura,float largura) : 
            base(id, valor, nome, quantidade)
        {
            this.altura = altura;
            this.largura = largura;
            Espessura = espessura;
        }

        public void Exibir()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"valor: {valor}");
            Console.WriteLine($"Quantidade no estoque: {quantidade}");
            Console.WriteLine($"Espessura do espelho: {espessura}mm");
            Console.WriteLine($"Altura do espelho: {altura}m");
            Console.WriteLine($"Largura do espelho: {largura}m");
        }
    }
}
