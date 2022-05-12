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

                Desafio_016();


                Console.ReadLine();
            }
             /// <summary>
            /// Desafio 16 - Desenvolva um método que solicite a entrada de um número e calcule se o número é par ou impar.
            /// </summary>
            public static void Desafio_016()
            {
                Console.Write("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Número {0} é par.", numero);
                }
                else
                    if (numero % 2 == 1) 
                {
                    Console.WriteLine("Número {0} é impar.", numero);
                }
                
