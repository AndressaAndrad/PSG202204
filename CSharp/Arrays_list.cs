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
           
            Encontro24_Codigo01();

            Console.ReadLine();
        }
public static void Encontro24_Codigo01()
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6 };
            numeros.Add(7);
            numeros.Add(8);
            numeros.Add(9);
            numeros.Add(10);
           
            for (int i = 0; i < numeros.Count(); i++) //--de uma forma--//
            {
                Console.WriteLine(i);
            }

            foreach (int i in numeros) //--outra forma--/
            {
                Console.WriteLine(i);
            }
        }
        --------------------------------------------------------------------------------------------------------------------------------------------------------------
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
            Console.WriteLine("Imprim,indo a lista...");
            foreach (string nome in listaDeNomes)
            {
                Console.WriteLine("--> {0}", nome);
            }



        }
                
        
    }
      
}
    }
    
      
}
