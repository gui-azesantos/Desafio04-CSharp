using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04_CSharp
{
    public class Livro: Produto
    {
        public String Autor;
        public String Tema;
        public int QtdPag;

        public Livro(string nome, int preco, int qtd, string autor, string tema, int qtdPag):base (nome, preco, qtd)
        {
            this.Autor = autor;
            this.Tema = tema;
            this.QtdPag = qtdPag;
        }

        
        public double Calcularimposto() {
            if (Tema == "educativo")
            {
                Console.WriteLine("Livro educativo não tem imposto: " + this.Nome);
                return (0);
            }
            else
            {
                Console.WriteLine("R$ " + this.Preco * 0.10 + " sobre o livro " + this.Nome);
                return (0);
            }
        }
    }

}
