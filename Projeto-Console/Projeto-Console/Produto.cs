using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Console
{
    [Serializable]
    abstract class Produto
    {
        protected int id;
        protected double valor;
        protected string nome;
        protected int quantidade;
        protected float espessura;
        protected float largura;
        protected float altura;
        protected string tipo_vidro;
        protected string resistencia_vidro;

        public Produto(int id, double valor, string nome, int quantidade)
        {
            this.id = id;
            this.valor = valor;
            this.nome = nome;
            this.quantidade = quantidade;
        }
    }
}
