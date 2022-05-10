using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap202204ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Desafio_006();
            Desafio_007();

            Console.ReadLine();
        }
        
        public static void Desafio_006()
        {
            Console.Write("Digite a altura da parade que deseja pintar: ");
            double parede = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a largura da parede que deseja pintar: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            double tinta = parede * largura / 2;
            Console.WriteLine("A quantidade de tinta para pintar {0}m² é {1} litros.", parede*largura,tinta);
        }
        /// <summary>
        /// Desafio 007 - Faça um programa que leia o preço de um produto, e mostre seu novo preço, com 5% de desconto.
        /// </summary>
        public static void Desafio_007()
        {
            Console.Write("Qual é o valor? ");
            double produto = Convert.ToDouble(Console.ReadLine());
            double desconto = produto * 0.05;

            Console.WriteLine("O produto com o valor R${0}, com 5% de desconto é de R${1}.", produto,(produto-desconto));

        }
    }
}
