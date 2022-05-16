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
            //Encontro_027();
            //Encontro_027_Codigo_02();
            Encontro_027_Codigo_03();

            Console.ReadLine();
        }
        
        public static void Encontro_027()
        {
            Aluno aluno = new Aluno();
            aluno.Codigo = 1;
            aluno.Nome = "Luiz";
            aluno.Idade = 48;
            aluno.Altura = 1.70;

            Aluno aluno2 = new Aluno();
            aluno2.Codigo = 2;
            aluno2.Nome = "Kali";
            aluno2.Idade = 17;
            aluno2.Altura = 1.68;

            Aluno aluno3 = new Aluno();
            aluno3.Codigo = 3;
            aluno3.Nome = "Nélio";
            aluno3.Idade = 26;
            aluno3.Altura = 1.69;

            Console.WriteLine("Codigo - Nome - Idade - Altura");
            //Console.WriteLine("{0} - {1} - {2} -{3} ", aluno.Codigo, aluno.Nome, aluno.Idade, aluno.Altura);
            //Console.WriteLine("{0} - {1} - {2} -{3} ", aluno2.Codigo, aluno2.Nome, aluno2.Idade, aluno2.Altura);
            //Console.WriteLine("{0} - {1} - {2} -{3} ", aluno3.Codigo, aluno3.Nome, aluno3.Idade, aluno3.Altura);

            aluno.Imprimir();
            aluno2.Imprimir();
            aluno3.Imprimir();
        }

        public static void Encontro_027_Codigo_02()
        {
            Aluno aluno1 = new Aluno(1, "Luiz", 48, 1.70);
            Aluno aluno2 = new Aluno(2, "Kali", 17, 1.68);
            Aluno aluno3 = new Aluno(3, "Nélio", 26, 1.69);

            aluno1.Imprimir();
            aluno2.Imprimir();
            aluno3.Imprimir();
        }

        public static void Encontro_027_Codigo_03()
        {
           List<Aluno> lista = new List<Aluno>();

           Aluno mateus = new Aluno(1, "Mateus", 18, 1.70);
           lista.Add(mateus);

           lista.Add(new Aluno(2, "Lucas", 17, 1.84));
           lista.Add(new Aluno(3, "Andressa", 25, 1.63));
           lista.Add(new Aluno(4, "Kali", 17, 1.68));
           lista.Add(new Aluno(5, "Nélio", 26, 1.69));
           lista.Add(new Aluno(6, "Luiz", 48, 1.70));

            foreach (Aluno item in lista)
            {
                item.Imprimir();
            }
        }

    }
}
    
