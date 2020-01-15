using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04_CSharp
{
    public class VideoGame : Produto
    {
        public string modelo;
        public string marca;
        public Boolean isUsado;


        public VideoGame(string nome, int preco, int qtd, string modelo, string marca, bool isUsado) : base(nome, preco, qtd)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.isUsado = isUsado;
        }
        public double Calcularimposto()
        {
            if (isUsado == true)
            {
                double imposto = this.Preco * 0.25;
                Console.WriteLine("Imposto " + this.Nome+ ", " + imposto);
                return (0);
            }
            else
            {
                double imposto = this.Preco * 0.45;
                Console.WriteLine("Imposto " + this.Nome + ", " + imposto);
                return (0);
            }
        }
    }
}
        





    
