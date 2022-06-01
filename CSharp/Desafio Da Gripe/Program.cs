using Atacado.FakeDB.RH;
using Atacado.Modelo.RH;
using DesaafioDaGripe01;
using DesafiosDaGripe01;
using static DesaafioDaGripe01.ProblemasMatematicos;

namespace DesafioDaGripe
{
   public class Program
    {   
        public static void Main(string[] args)
        {
            ExecutarExercicio01();
            ExecutarExercicio02();
            ExecutarExercicio03();
            Console.ReadLine();
        }
        ///1.1 - Desenvolva um método genérico que realize a operação matemática entre dois números e retorne o resultado.
        ///A operação e os dois números devem ser passados por parâmetro no método.

        public static void ExecutarExercicio01()
        {
            Impressoes.ImprimirCabecalho("-- EXERCÍCIO 01 --");
            Console.WriteLine("Qual a operação matemática? 0 - Adição, 1 - Subtração, 2 - Multiplicãção, 3 - Divisão.");
            int menu = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Informe o primeiro valor: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resul = 0;
            switch (menu)
            {
                case 0:
                    resul = ProblemasMatematicos.Exercicio01(Operacoes.Adicao, num1, num2);
                    break;
                 case 1:
                    resul = ProblemasMatematicos.Exercicio01(Operacoes.Subtracao, num1, num2);
                    break;
                case 2:
                    resul = ProblemasMatematicos.Exercicio01(Operacoes.Multipiolicacao, num1, num2);
                    break;
                case 3:
                    resul = ProblemasMatematicos.Exercicio01(Operacoes.Divisao, num1, num2);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Resultado da operação é {0}.", resul);
            Impressoes.ImprimirRodape("-- FIM EXERCÍCIO 04 --");
        }

        ///1.2 - Desenvolva um método genérico que calcule e retorne o volume de uma caixa d'água retangular. 
        ///Os valores devem ser passados por parâmetro no método.
        ///
        public static void ExecutarExercicio02()
        {
            Impressoes.ImprimirCabecalho("-- EXERCÍCIO 02 --");
            Console.WriteLine("Calculo do volume de uma caixa d´agua retangular");
            Console.Write("Informe o comprimento: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a largura: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double resul = 0;
            resul = ProblemasMatematicos.Exercicio02(comprimento, largura, altura);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O volume da caixa d´agua é {0} cm³", resul);
            Console.ResetColor();
            Impressoes.ImprimirRodape("-- FIM EXERCÍCIO 02 --");
        }
        /// <summary>
        /// 1.3 - Desenvolva um método genérico que calcule e retorne o volume de um Cilindro qualquer. 
        /// Os valores devem ser passados por parâmetro no método.
        /// </summary>
        public static void ExecutarExercicio03()
        {
            Impressoes.ImprimirCabecalho("-- EXERCÍCIO 03 --");
            Console.WriteLine("Calculo de um volume de um Cilindro.");
            Console.Write("Informe a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o raio da base: ");
            double raiobase = Convert.ToDouble(Console.ReadLine());
            double resul = 0;
            resul = ProblemasMatematicos.Exercicio03(altura, raiobase);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O volume do cilindro é {0} cm³", resul);
            Console.ResetColor();
            Impressoes.ImprimirRodape("-- FIM EXERCÍCIO 03 --");
        }
        /// <summary>
        /// 1.4 - Desenvolva um método genérico que calcule e retorne o volume de uma esfera.
        /// Os valores devem ser passados por parâmetro no método.
        /// </summary>
        public static void ExecutarExercicio4()
        {
            Impressoes.ImprimirCabecalho("-- EXERCÍCIO 04 --");
            Console.Write("Informe o raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            double resul = 0;
            resul = ProblemasMatematicos.Exercicio04(raio);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O volume da esfera é {0} cm³", resul);
            Console.ResetColor();
            Impressoes.ImprimirRodape("-- FIM EXERCÍCIO 04 --");
        }
        /// <summary>
        /// 2.1 - Desenvolva um método genérico que realize a apresentação do funcionário. 
        /// A instância do funcionário deve ser repassada por parâmetro no método.
        /// </summary>
        public static void ExecutarExercicio05()
        {
            Impressoes.ImprimirCabecalho("-- EXERCÍCIO 05 --");
            Console.WriteLine("Informe o código do funcionário (1 até 100): ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            List<Funcionario> funcionario = FuncionarioFakeDB.Funcionarios.Where(empregado => empregado.Codigo == codigo).ToList();
            foreach (Funcionario i in funcionario)
            {   
                Console.ForegroundColor = ConsoleColor.Green;
                ProblemasFuncionario.Exercicio01(i);
                Console.ResetColor();
            }
            Impressoes.ImprimirRodape("-- FIM EXERCÍCIO 05 --");
        }

        public static void ExecutarExercicio06()
        {
            Impressoes.ImprimirCabecalho("-- EXERCÍCIO 06--");
            Console.WriteLine("Informe o peso do funcionário: ");
            float peso = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe a altura do funcionário: ");
            float altura = Convert.ToSingle(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            ProblemasFuncionario.Exercicio02(peso, altura);
            Console.ResetColor();
            Impressoes.ImprimirRodape("-- FIM EXERCÍCIO 06 --");
        }

        public static void ExecutarExercicio07()
        {
            Impressoes.ImprimirCabecalho("-- EXERCÍCIO 07--");
            Console.WriteLine("Informe o código do funcionário (1 até 100): ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            List<Funcionario> funcionario = FuncionarioFakeDB.Funcionarios.Where(pes => pes.Codigo == codigo).ToList();
            foreach (Funcionario i in funcionario)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                ProblemasFuncionario.Exercicio03(i);
                Console.ResetColor();
            }
            Impressoes.ImprimirRodape("-- FIM EXERCÍCIO 07 --");
        }

        public static void ExecutarExercicio08()
        {
            Impressoes.ImprimirCabecalho("-- EXERCÍCIO 08--");
            Console.WriteLine("Informe o código do funcionário (1 até 100): ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            List<Funcionario> funcionario = FuncionarioFakeDB.Funcionarios.Where(pes => pes.Codigo == codigo).ToList();
            foreach (Funcionario i in funcionario)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                ProblemasFuncionario.Exercicio04(i);
                Console.ResetColor() ;
            }
            Impressoes.ImprimirRodape("-- FIM EXERCÍCIO 08 --");
        }

    }
}
