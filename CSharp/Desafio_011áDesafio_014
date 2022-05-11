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
            //Desafio_011();
            //Desafio_012();
/// <summary>
        /// Desafio 011 – um professor quer armazenas o nome dos seus alunos para realizar algumas tarefas. 
        /// Faça um programa que ajude ele,  
        /// lendo o nome deles e escrevendo todos os nomes armazenados.
        /// </summary>
        public static void Desafio_011()
        {

            List<string> listaDeNomes = new List<string>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Qtde de alunos na lista: {0}.", listaDeNomes.Count());
                Console.Write("Informe o nome do aluno: ");
                string nome = Console.ReadLine();
                listaDeNomes.Add(nome);
                Console.Write("Deseja terminar (S/N) ?");
                string opcao = Console.ReadLine();
                if (opcao.ToUpper() == "S")
                {
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("Qtde de alunos na lista: {0}.", listaDeNomes.Count());
            Console.WriteLine("Imprimindo a lista...");
            foreach (string nome in listaDeNomes)
            {
                Console.WriteLine("--> {0}", nome);
            }

        }
        /// <summary>
        /// Desafio 012 – o mesmo professor quer agora, além de exibir, ordenar a lista.Faça um programa que ajude ele, 
        /// lendo o nome deles e escrevendo todos os nomes armazenados, de forma ordenada.
        /// </summary>

        public static void Desafio_012()
        {
            List<string> listaDeNomes = new List<string>();
            while (true)
            {
                Console.Clear();
                Console.Write("Informe o nome do aluno: ");
                string nome = Console.ReadLine();
                listaDeNomes.Add(nome);
                Console.Write("Deseja terminar (S/N) ? ");
                string opcao = Console.ReadLine();
                if (opcao.ToUpper() == "S")
                {
                    break;
                }    
            }
            Console.Clear();
            listaDeNomes.Sort();
            Console.WriteLine("Imprimindo lista de Nomes... ");
            foreach (string nome in listaDeNomes)
            {
                Console.WriteLine("--> {0}", nome);
            }
        }
                /// <summary>
        /// Desafio 013 – o mesmo professor quer
        ///sortear um dos seus alunos para apagar o quadro.Faça um programa que
        ///ajude ele, lendo o nome deles e escrevendo o nome do escolhido.
        /// </summary>
        public static void Desafio_013()
        {
            List<string> lista = CriarListaDeNomes();
            Random rand = new Random();
            int indice = rand.Next(lista.Count());
            Console.WriteLine("Índice sorteado: {0}", indice);
            Console.WriteLine("O escolhido da vez será: {0}.", lista[indice]);
            
        }
        /// <summary>
        /// Desafio 014 – o mesmo professor quer sortear a ordem de apresentação de trabalhos dos alunos. 
        /// Faça um programa que leia o nome dos quatro alunos e a ordem sorteada.
        /// </summary>
        public static void Desafio_014()
        {
            List<string> lista = CriarListaDeNomes();
            Console.WriteLine("ORIGINAL");
            foreach (string str in lista)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("--------------------------------------");
            Random rand = new Random();
            List<string> listaEmbaralhada = lista.OrderBy(x => rand.Next()).ToList();
            Console.WriteLine("EMBARALHADA");
            foreach (string str in listaEmbaralhada)
            {
                Console.WriteLine(str);
            }

        }
        }  

      
}
