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
           
            Encontro24_Codigo02();

            Console.ReadLine();
        }
 public static void Encontro24_Codigo02()
        {
            Random rand = new Random();
            //rand.Next();
            //rand.Next(100);
            //rand.Next(1, 100);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Número gerado = {0}", rand.Next(10));
            }
        }
    }
      
}
