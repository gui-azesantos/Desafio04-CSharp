using System;
using System.Collections;
using System.Collections.Generic;

namespace Desafio04_CSharp
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Livro l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
			Livro l2 = new Livro("Senhor dos Anéis", 60, 30, "J. J. R Tolkein", "fantasia", 500);
			Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

			VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
			VideoGame ps4Usado = new VideoGame("PS4Usado", 1000, 7, "Sony", "Slim", true);
			VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

			List<Livro> livros = new List<Livro>
			{
			l1,
			l2,
			l3
			};

			List<VideoGame> games = new List<VideoGame>
			{
			ps4,
			ps4Usado,
			xbox
			};
			
			Loja americanas = new Loja("Americanas","12345678",livros,games,0);

			// OUTPUT
			l2.Calcularimposto();
			l3.Calcularimposto();
			ps4Usado.Calcularimposto();
			ps4.Calcularimposto();
			americanas.livro();
			americanas.videogame();
			americanas.calculapatrimonio();

		}
    }
}
