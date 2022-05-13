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
            // Desafio_031();
            Desafio_036();
            Console.ReadLine();
        }
        /// <summary>
        /// Desafio 31 - Desenvolva um método que verifique se um número informado é:
        /// Se é par ou ímpar
        ///Se é multiplo de 2
        ///Se é multiplo de 3
        /// Se é multiplo de 5
        /// Dica: if(numero % 2 == 0)
        /// </summary>
        public static void Desafio_031()
        {
            Console.Write("Informe um número: ");
            double numero =Convert.ToDouble(Console.ReadLine());
         
            if (numero % 2 == 0)
            {
                Console.WriteLine(" O numero {0} é par. ", numero);
            }
            else 
                if (numero % 2 == 1)
            {
                Console.WriteLine("O número {0} é impar.", numero);
            }
            for (int i = 0; i < 1 ; i++)
            {
                if (numero % 2 == 0)
                    Console.WriteLine("O número {0} é multiplo de 2.", numero);
            
            
             else 
                if (numero % 3 == 0)
                    Console.WriteLine("O número {0} é multiplo de 3.", numero);
            
           
             else
                if (numero % 5 == 0)
                    Console.WriteLine("O número {0} é multiplo de 5.", numero);
            }
        }

        public static List<string> CriarListaDeNomesAlunos()
        {
            List<string> listaDeNomesAlunos = new List<string>();
            listaDeNomesAlunos.Add("Mateus");
            listaDeNomesAlunos.Add("Lucas");
            listaDeNomesAlunos.Add("João");
            listaDeNomesAlunos.Add("Judas");
            listaDeNomesAlunos.Add("Tadeu");
            listaDeNomesAlunos.Add("Tiago");
            listaDeNomesAlunos.Add("Marcos");
            listaDeNomesAlunos.Add("André");
            listaDeNomesAlunos.Add("Simão");
            listaDeNomesAlunos.Add("Pedro");
            listaDeNomesAlunos.Add("Andressa");
            listaDeNomesAlunos.Add("Kali");
            listaDeNomesAlunos.Add("Nélio");
            listaDeNomesAlunos.Add("Matheus");
            listaDeNomesAlunos.Add("Josi");
            listaDeNomesAlunos.Add("Luiz");
            listaDeNomesAlunos.Add("Breno");
            listaDeNomesAlunos.Add("Rafael");
            listaDeNomesAlunos.Add("Maria");
            listaDeNomesAlunos.Add("Fernanda");
            return listaDeNomesAlunos;
        }
        /// <summary>
        /// Desafio 32 - Crie uma lista com os nomes de uma turma de 20 alunos. Em seguida, elabore um método que solicite a
        /// idade de cada um, e armazene em uma lista paralela. Por fim, calcule a idade média da turma.
        /// </summary>
        public static void Desafio_032()
        {
            List<string> aluno = CriarListaDeNomesAlunos();
            List<int> idade = new List<int>();
            
            for (int i = 0; i < aluno.Count(); i++)
            {
                Console.WriteLine("Digite a idade de {0} : ", aluno[i]);
                 idade.Add(Convert.ToInt32(Console.ReadLine()));
            }
            double total = 0;
            foreach (int i in idade)
            {
                total=total+i;
            }

            double media= total / aluno.Count();
            Console.WriteLine("A média das idades é {0} ", media);
           }
        /// <summary>
        /// Desafio 33 - Utilizando uma lista com nomes de pessoas, previamente carregada, elabore um método solicite a idade de cada um, 
        /// armazene na mesma ordem em outra lista, 
        /// e exiba quantas pessoas possuem mais de 18 anos. Seu código deverá ler a idade de 10 pessoas.
        /// </summary>
        public static void Desafio_033()
        {
            List<string> aluno = CriarListaDeNomesAlunos();
            List<int> idade = new List<int>();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Digite a idade de {0} : ", aluno[i]);
                idade.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int maior = 0;
            foreach (int i in idade)
            {
               if (i >= 18)
                {
                    maior = maior + 1;
                }
            }
            Console.WriteLine("Maiores de 18 anos são: {0} pessoas.", maior);
        }
        /// <summary>
        /// Desafio 34 - Desenvolva um método que imprima a soma dos números de 1 até 1000.
        /// </summary>
        public static void Desafio_034()
        {
            int min = 1;
            int max = 1000;
            int media = (min + max) * ((max - min + 1) / 2);
            Console.WriteLine( media);
        }
        /// <summary>
        /// Desafio 35 - Desenvolva um método que imprima todos os múltiplos de 3, entre 1 e 100. 
        /// Dica: para saber se um número é múltiplo de 3, você pode fazer if(numero % 3 == 0).
        /// </summary>
        public static void Desafio_035()
        {
            for (int i = 3; i < 100; i = i+3 )
            {
                Console.Write("{0} - ",i);
            }
        }
        /// <summary>
        /// Desafio 36 - Uma pessoa só pode votar em eleições brasileiras se ela for maior que 16 anos e for cidadã brasileira. Desenvolva um método que 
        /// leia uma lista previamente carregada com o nome de 10 pessoas. Em seguida, solicite a idade da pessoa, e sua nacionalidade, 
        /// armazenando em listas paralelas. 
        /// Por fim, verifique quantas pessoas estão aptas a votar ou não, de acordo com os dados armazenados.
        /// </summary>
        public static void Desafio_036()
        {
            List<string> aluno = CriarListaDeNomesAlunos();
            List<int> idade = new List<int>();
            List<string> cidadania = new List<string>();
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("Digite a idade de {0} : ", aluno[i]);
                idade.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Write("É brasileiro?  (S/N) ");
                cidadania.Add(Console.ReadLine());
            }
            int aptos = 0;
            foreach (int i in idade)
            {  
                if (i >= 16 && cidadania[i].ToUpper() == "S")
                {
                    aptos = aptos + 1;
                    
                }
            }
            Console.WriteLine("Maiores de 16 anos e cidadão brasileiro são: {0} pessoas.", aptos);
        }
    }
}

