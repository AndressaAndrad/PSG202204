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
            //Encontro21_Codigo01();
            //Encontro21_Codigo02();
            //Desafio_001();
            //Desafio_002();
            //Desafio_003();
            //Desafio_004();
            Desafio_005();

            Console.ReadLine();
        }
        
        public static void Desafio_003()
        {
            Console.Write("Digite um valor em metros: ");
            string metro = Console.ReadLine();
            double valor = Convert.ToDouble(metro);
            double cent = valor * 100 ;
            double milim = valor * 1000;

            Console.WriteLine("O centimetro de {0} vale {1}cm.", valor, cent);
            Console.WriteLine("O milimetro de {0} vale {1}mm.", valor, milim);
                       
        }

        /// <summary>
        /// 004 - Faça um programa que leia um número inteiro e mostre na sua tela a sua tabuada.
        /// </summary>
        public static void Desafio_004()
        {
            Console.Write("Digite um valor que deseja da Tabuada: ");
            string num = Console.ReadLine();
            int tab = Convert.ToInt32(num);

            for (int i = 1; i < 11; i++)
            {
                int resul = tab * i;
                Console.WriteLine("{0} x {1} = {2} ",i,tab, resul);
            }
         
        }
        /// <summary>
        /// 005 - Crie um programa que leia o quanto uma pessoa tem na carteira e mostre quantos dólares ela pode comprar. Considere US$ 1,00 = R$ 5,00
        /// </summary>
        public static void Desafio_005()
        {
            Console.Write("Digite o valor em reais R$ ");
            string num = Console.ReadLine();
            double real = Convert.ToDouble(num);
            double dolar = real * 5;

            Console.WriteLine("O valor {0} vale em Dolar US$ {1}", real, dolar);
        }

    }
}
