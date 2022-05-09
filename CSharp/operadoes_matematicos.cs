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
            Desafio_002();
            Console.ReadLine();
        }

        public static void Encontro21_Codigo01()
        {
            Console.WriteLine("Testando o laço While ...");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Testando o laço do..while...");
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
        }

        public static void Encontro21_Codigo02()
        {
            int parada = 45;
            for (int i = 0; i < parada; i++)
            {
                Console.WriteLine("Mensagem {0} de {1}.", i, parada);
            }
            Console.WriteLine("Laço for terminou.");
        }

        /// <summary>
        /// 001 - Crie um programa que leia um número e mostre o seu dobro, seu triplo e sua raiz quadrada.
        /// </summary>
        public static void Desafio_001()
        {
            Console.Write("Informe um valor ");
            string valor = Console.ReadLine();
            int num = Convert.ToInt32(valor);
            int dobro = num * 2;
            int triplo = num * 3;
            double raiz = Math.Sqrt(num);

            Console.WriteLine("O Dobro de {0} vale {1}.",valor, dobro);
            Console.WriteLine("O Triplo de {0} vale {1}.", valor, triplo);
            Console.WriteLine("A raiz de {0} vale {1}.", valor, raiz);
        }

        /// <summary>
        /// 002 - Desenvolva um programa que leia as duas notas de um aluno,  calcule e mostre a sua média.
        /// </summary>
        public static void Desafio_002()
        {
            Console.Write("Digite um numero: ");
            string valor1 = Console.ReadLine();
            Console.Write("Digite um numero: ");
            string valor2 = Console.ReadLine();
            int num1= Convert.ToInt32(valor1);
            int num2 = Convert.ToInt32(valor2);
            double media = (num1 + num2) / 2;

            Console.WriteLine("A média é: {0}",media);

        }
    }
}
