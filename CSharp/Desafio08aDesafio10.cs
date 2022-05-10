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
            
            //Desafio_008();
            //Desafio_009();
            Desafio_010();

            Console.ReadLine();
        }
        
        /// <summary>
        /// Desafio 008 – Faça um programa que leia o salário de um funcionário, e mostre seu novo salário, com 15% de aumento.
        /// </summary>
        
        public static void Desafio_008()
        {
            Console.Write("Digite o valor do seu salário: R$");
            double salario = Convert.ToDouble(Console.ReadLine());
            double adicional = (salario * 0.15);

            Console.WriteLine("O seu salário é R${0}, 15% sobre seu salário é R${1}", salario, adicional);
            Console.WriteLine(" O seu salário bruto será de R${0}", (salario+adicional));

        }
        /// <summary>
        /// Desafio 009 – escreva um programa que converta uma temperatura digitada em graus celsius para farenheit.
        /// </summary>
        
        public static void Desafio_009()
        {
            Console.Write("Digite a temperatura em grau Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("A temperatura {0} graus Celsius equivalem a {1} graus Fahrenheit", celsius, fahrenheit);
        }
        /// <summary>
        /// Desafio 010 – Escreva um programa que pergunte a quantidade de km percorridos por um carro alugado, 
        /// e a quantidade de dias pelos quais ele foi alugado. Calcule o preço a pagar, sabendo que o carro custa 
        /// R$ 60,00 por dia e R$ 0,15 por km rodado.
        /// </summary>
        
        public static void Desafio_010()
        {
            Console.Write("Por quantos dias foi alugado? ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantos km percorridos? ");
            double km = Convert.ToDouble(Console.ReadLine());
            int total_dia = dia * 60;
            double total_km = km * 0.15;

            Console.WriteLine("O valor por {0} dias alugado é R${1}.", dia, total_dia);
            Console.WriteLine("O valor por {0} km rodados é R${1}.", km,total_km);
            Console.WriteLine(" O valor final é R${0}.", total_dia+total_km);
        }
    }
}
