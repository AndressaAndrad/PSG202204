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
