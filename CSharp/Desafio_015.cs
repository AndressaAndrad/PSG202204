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
           
            Desafio_015();

            Console.ReadLine();
        }
        
        /// <summary>
        /// Desafio 015 – agora, o professor deseja sortear da lista embaralha quem será o primeiro apresentar o trabalho. 
        /// Faça um programa que leia o nome dos alunos, 
        /// embaralhe a ordem de apresentação e sorteie um destes alunos para apresentar primeiro.
        /// </summary>
        public static void Desafio_015()
        {
            List<string> lista = CriarListaDeNomes();
            Console.WriteLine("Alunos");
            foreach (string str in lista)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("----------------------------------------------------------");
            Random rand = new Random();
            List<string> listaEmbaralhada = lista.OrderBy(x => rand.Next()).ToList();
            Console.WriteLine("EMBALHARADA");
            foreach (string str in listaEmbaralhada)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("----------------------------------------------------------");
            int indice = rand.Next(listaEmbaralhada.Count());
            Console.WriteLine("Numero sorteado: {0}", indice);
            Console.WriteLine("O escolhido será: {0}", lista[indice]);
        }
    }  

      
}
