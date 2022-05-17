        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cap202204ConsoleApp.Models;

namespace Cap202204ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Encontro_027();
            //Encontro_027_Codigo_02();
            //Encontro_027_Codigo_03();
            // Desafio_041();
            Desafio_042();

            Console.ReadLine();
        }
        
        /// <summary>
        /// Desafio 42 - Utilizando o FakeDB de Pessoa, desenvolva um método que verifique a idade de cada Pessoa na lista, e 
        /// se for menor que 65 anos exiba na cor vermelha “Sem permissão”, caso seja maior ou igual a 65 anos
        ///exiba na cor verde “Permissão concedida”. Para tanto, pesquise como 
        ///funciona a propriedade Console.ForegroundColor.
        /// </summary>
        /// 
        public static int CalcularIdade (DateTime dtNascimento)
        {
            int idade = 0;
            idade = DateTime.Today.Year - dtNascimento.Year;
            if (DateTime.Today.DayOfYear < dtNascimento.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }
        public static void Desafio_042()
        {
            List<Models.Pessoa> pessoas = FakeDB.PessoaFakeDB.Pessoas;
            foreach (Models.Pessoa pessoa in pessoas)
            {
                int idade = CalcularIdade(pessoa.DtNascimento);
                Console.Write("O Funcionario {0} {1} , tem {2} anos. Status ", pessoa.Nome,pessoa.SobreNome, idade);
                if (idade < 65)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Sem permissão \n");
                   
                }
                else
                {
                                
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" Permissão Concedida \n");
                   
                }
                Console.ResetColor();
            }
            

        }
    }
}
