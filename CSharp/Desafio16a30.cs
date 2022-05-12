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

                //Desafio_016();
                Desafio_017();

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
                
                 /// <summary>
        /// Desafio 17 - Desenvolva um método que permita a entrada do nome do usuário e exiba
        /// Imprima a frase “Olá meu nome é: {nome recebido}”.
        /// O nome com todas as letras maiúsculas e minúsculas.
        /// Quantas letras ao todo (sem considerar espaços).
        /// Quantas letras tem o primeiro nome.
        /// </summary>
        public static void Desafio_017()
        {
            Console.Write("Qual é seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("Qual é o seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Olá meu nome é: {0} {1} ", nome.ToUpper(), sobrenome.ToUpper());
            Console.WriteLine("Olá meu nome é: {0} {1}", nome.ToLower(), sobrenome.ToLower());
            Console.WriteLine("Com total de letras de : {0}.", nome.Count() + sobrenome.Count());
            Console.WriteLine("O nome {0} tem {1} letras.", nome, nome.Count());


        }
