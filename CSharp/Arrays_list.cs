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
    }
      
}
