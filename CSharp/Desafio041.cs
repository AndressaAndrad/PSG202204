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
              Desafio_041();

              Console.ReadLine();
        }
        /// <summary>
        /// Desafio 41 - Crie uma classe para funcionários, com código, nome, e salário. Em seguida, crie uma lista de 
        /// funcionários previamente carregada. Desenvolva um método que calcule e exiba o salário reajustado, de cada 
        /// funcionário, de acordo com a seguinte regra: Salário até R$ 1000,00, reajuste de 50%; Salários maiores que
        /// R$ 1000,00, reajuste de 30%.
        /// </summary>
        public static void Desafio_041()
        {
            List<Encontro_027.Funcionario> funcionarios = Cap202204ConsoleApp.Encontro_027.FuncionarioFakeDB.Funcionarios;
            foreach (Encontro_027.Funcionario item in funcionarios)
            {
                double salarioReajustado = CalcularReajuste(item.Salario);
                Console.WriteLine("Nome: {0} - Salário atual {1} - Salário reajustado: {2}", 
                    item.Nome, item.Salario, salarioReajustado);
            }
        }

        public static double CalcularReajuste(double salarioAtual)
        {
            double salarioReajustado = 0;
           if (salarioAtual > 1000)
            {
                salarioReajustado = salarioAtual * 1.5;
            }
           else
            {
                salarioReajustado = salarioAtual * 1.3;
            }
           return salarioReajustado;
        }

    }
}
