using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04_CSharp
{
    class Loja
    {
        String Nome;
        String Cnpj;
        List<Livro> Livro;
        List<VideoGame> Videogame;

        public Loja(string nome, string cnpj, List<Livro> livro, List<VideoGame> videogame, int v)
        {
            Nome = nome;
            Cnpj = cnpj;
            Livro = livro;
            Videogame = videogame;
        }
        public void livro()
        {

            Console.WriteLine(
                    "------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Livros disponiveis nas lojas americanas:");
            if (Livro.Count == 0)
            {
                Console.WriteLine("A loja não tem livro disponiveis  no estoque");
            }
            for (int i = 0; i < Livro.Count; i++)
            {
                Console.WriteLine("\t Titulo: " + Livro[i].Nome + ", preço: R$" + Livro[i].Preco + " e "
                        + Livro[i].Preco + " produtos em estoque");

            }
        }

        public void videogame()
        {
            Console.WriteLine(
                    "------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Jogos disponiveis nas lojas americanas:");
            if (Livro.Count == 0)
            {
                Console.WriteLine("A loja não tem jogos disponiveis no estoque");
            }

            for (int i = 0; i < Videogame.Count; i++)
            {
                Console.WriteLine("\t VideoGame: " + Videogame[i].Nome + ", preço: R$" + Videogame[i].Preco + " e "
                        + Videogame[i].Qtd + " produtos em estoque");

            }
        }

        public double calculapatrimonio()
        {

            double result = 0;
            double result1 = 0;

            for (int i = 0; i < Livro.Count; i++)
            {
                result += (int)Videogame[i].Preco * Videogame[i].Qtd;
            }
            for (int i = 0; i < Livro.Count; i++)
            {
                result1 += (int)Livro[i].Preco * Livro[i].Qtd;
            }

            Console.WriteLine("Total de patrimonio: R$" + (result + result1));
            return result + result1;
        }
    }
}
