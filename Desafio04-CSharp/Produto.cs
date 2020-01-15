using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04_CSharp
{
    public abstract class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;


        public Produto(string nome, double preco, int qtd)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
        }


    }
}





