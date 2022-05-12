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
            //Encontro21_Codigo01();
            //Encontro21_Codigo02();
            //Desafio_001();
            //Desafio_002();
            //Desafio_003();
            //Desafio_004();
            //Desafio_005();
            //Desafio_006();
            //Desafio_007();
            //Desafio_008();
            //Desafio_009();
            //Desafio_010();
            //Encontro24_Codigo01();
            //Desafio_011();
            //Desafio_012();
            //Encontro24_Codigo02();
            //Desafio_013();
            //Desafio_014();
            //Desafio_015();
            //Desafio_016();
            //Desafio_017();
            //Desafio_018();
            //Desafio_019();
            //Desafio_020();
            // Desafio_021();
            //Desafio_022();
            //Desafio_023();
            // Desafio_024();
            // Desafio_025();
            //Desafio_026();
            //Desafio_027();
            //Desafio_028();
            Desafio_030();

            Console.ReadLine();
        }

        public static void Encontro21_Codigo01()
        {
            Console.WriteLine("Testando o laço While ...");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Testando o laço do..while...");
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
        }

        public static void Encontro21_Codigo02()
        {
            int parada = 45;
            for (int i = 0; i < parada; i++)
            {
                Console.WriteLine("Mensagem {0} de {1}.", i, parada);
            }
            Console.WriteLine("Laço for terminou.");
        }

        /// <summary>
        /// 001 - Crie um programa que leia um número e mostre o seu dobro, seu triplo e sua raiz quadrada.
        /// </summary>
        public static void Desafio_001()
        {
            Console.Write("Informe um valor ");
            string valor = Console.ReadLine();
            int num = Convert.ToInt32(valor);
            int dobro = num * 2;
            int triplo = num * 3;
            double raiz = Math.Sqrt(num);

            Console.WriteLine("O Dobro de {0} vale {1}.", valor, dobro);
            Console.WriteLine("O Triplo de {0} vale {1}.", valor, triplo);
            Console.WriteLine("A raiz de {0} vale {1}.", valor, raiz);
        }

        /// <summary>
        /// 002 - Desenvolva um programa que leia as duas notas de um aluno,  calcule e mostre a sua média.
        /// </summary>
        public static void Desafio_002()
        {
            Console.Write("Digite um numero: ");
            string valor1 = Console.ReadLine();
            Console.Write("Digite um numero: ");
            string valor2 = Console.ReadLine();
            double num1 = Convert.ToInt32(valor1);
            double num2 = Convert.ToInt32(valor2);
            double media = (num1 + num2) / 2;

            Console.WriteLine("A média é: {0}", media);

        }
        /// <summary>
        /// 003 - Escreva um programa que leia, um valor em metros e o exiba convertido em centímetros e milímetros.
        /// </summary>
        public static void Desafio_003()
        {
            Console.Write("Digite um valor em metros: ");
            string metro = Console.ReadLine();
            double valor = Convert.ToDouble(metro);
            double cent = valor * 100;
            double milim = valor * 1000;

            Console.WriteLine("O valor de {0}m vale {1}cm.", valor, cent);
            Console.WriteLine("O valor de {0}m vale {1}mm.", valor, milim);

        }

        /// <summary>
        /// 004 - Faça um programa que leia um número inteiro e mostre na sua tela a sua tabuada.
        /// </summary>
        public static void Desafio_004()
        {
            Console.Write("Digite um valor que deseja da Tabuada: ");
            string num = Console.ReadLine();
            int tab = Convert.ToInt32(num);

            for (int i = 1; i < 11; i++)
            {
                int resul = tab * i;
                Console.WriteLine("{0} x {1} = {2} ", i, tab, resul);
            }

        }
        /// <summary>
        /// 005 - Crie um programa que leia o quanto uma pessoa tem na carteira e mostre quantos dólares ela pode comprar. Considere US$ 1,00 = R$ 5,00
        /// </summary>
        public static void Desafio_005()
        {
            Console.Write("Digite o valor em reais R$ ");
            string num = Console.ReadLine();
            decimal real = Convert.ToDecimal(num);
            decimal dolar = real / 5;

            Console.WriteLine("O valor {0} vale em Dolar US$ {1}", real, dolar);
        }
        /// <summary>
        /// Desafio 006 - Faça um programa que leia a largura e a altura de uma parede em metros, e calcule a sua área e a 
        /// quantidade de tinta necessária para pintá-la, sabendo que cada litro de tinta pinta uma área de 2 metros quadrados.
        /// </summary>
        public static void Desafio_006()
        {
            Console.Write("Digite a altura da parade que deseja pintar: ");
            double parede = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a largura da parede que deseja pintar: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            double tinta = parede * largura / 2;
            Console.WriteLine("A quantidade de tinta para pintar {0}m² é {1} litros.", parede * largura, tinta);
        }
        /// <summary>
        /// Desafio 007 - Faça um programa que leia o preço de um produto, e mostre seu novo preço, com 5% de desconto.
        /// </summary>
        public static void Desafio_007()
        {
            Console.Write("Qual é o valor? ");
            double produto = Convert.ToDouble(Console.ReadLine());
            double desconto = produto * 0.05;

            Console.WriteLine("O produto com o valor R${0}, com 5% de desconto é de R${1}.", produto, (produto - desconto));

        }
        /// <summary>
        /// Desafio 008 – Faça um programa que leia o salário de um funcionário, e mostre seu novo salário, com 15% de aumento.
        /// </summary>
        public static void Desafio_008()
        {
            Console.Write("Digite o valor do seu salário: R$");
            double salario = Convert.ToDouble(Console.ReadLine());
            double adicional = (salario * 0.15);

            Console.WriteLine("O seu salário é R${0}, 15% sobre seu salário é R${1}", salario, adicional);
            Console.WriteLine(" O seu salário bruto será de R${0}", (salario + adicional));

        }
        /// <summary>
        /// Desafio 009 – escreva um programa que converta uma temperatura digitada em graus celsius para farenheit.
        /// </summary>
        public static void Desafio_009()
        {
            Console.Write("Digite a temperatura em grau Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("A temperatura {0} graus Celsius equivalem a {1} graus Fahrenheit", celsius, fahrenheit);
        }
        /// <summary>
        /// Desafio 010 – Escreva um programa que pergunte a quantidade de km percorridos por um carro alugado, 
        /// e a quantidade de dias pelos quais ele foi alugado. Calcule o preço a pagar, sabendo que o carro custa 
        /// R$ 60,00 por dia e R$ 0,15 por km rodado.
        /// </summary>
        public static void Desafio_010()
        {
            Console.Write("Por quantos dias foi alugado? ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantos km percorridos? ");
            double km = Convert.ToDouble(Console.ReadLine());
            int total_dia = dia * 60;
            double total_km = km * 0.15;

            Console.WriteLine("O valor por {0} dias alugado é R${1}.", dia, total_dia);
            Console.WriteLine("O valor por {0} km rodados é R${1}.", km, total_km);
            Console.WriteLine(" O valor final é R${0}.", total_dia + total_km);
        }

        public static void Encontro24_Codigo01()
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6 };
            numeros.Add(7);
            numeros.Add(8);
            numeros.Add(9);
            numeros.Add(10);

            for (int i = 0; i <= numeros.Count(); i++)
            {
                Console.WriteLine(i);
            }

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }

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

        public static List<string> CriarListaDeNomes()
        {
            List<string> listaDeNomes = new List<string>();
            listaDeNomes.Add("Mateus");
            listaDeNomes.Add("Lucas");
            listaDeNomes.Add("João");
            listaDeNomes.Add("Judas");
            listaDeNomes.Add("Tadeu");
            listaDeNomes.Add("Tiago");
            listaDeNomes.Add("Marcos");
            listaDeNomes.Add("André");
            listaDeNomes.Add("Simão");
            listaDeNomes.Add("Pedro");
            listaDeNomes.Add("Tomé");
            return listaDeNomes;
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
        /// <summary>
        /// Desafio 16 - Desenvolva um método que solicite a entrada de um número e calcule se o número é par ou impar.
        /// </summary>
        public static void Desafio_016()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Número {0} é par.", numero);
            }
            else
                if (numero % 2 == 1)
            {
                Console.WriteLine("Número {0} é impar.", numero);
            }
        }

        /// <summary>
        /// Desafio 17 - Desenvolva um método que permita a entrada do nome do usuário e exiba
        /// Imprima a frase “Olá meu nome é: {nome recebido}”.
        /// O nome com todas as letras maiúsculas e minúsculas.
        /// Quantas letras ao todo (sem considerar espaços).
        /// Quantas letras tem o primeiro nome.
        /// </summary>
        public static void Desafio_017()
        {
            Console.Write("Qual é seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("Qual é o seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Olá meu nome é: {0} {1} ", nome.ToUpper(), sobrenome.ToUpper());
            Console.WriteLine("Olá meu nome é: {0} {1}", nome.ToLower(), sobrenome.ToLower());
            Console.WriteLine("Com total de letras de : {0}.", nome.Count() + sobrenome.Count());
            Console.WriteLine("O nome {0} tem {1} letras.", nome, nome.Count());


        }
        /// <summary>
        /// Desafio 18 - Desenvolva uma calculadora, onde será necessário entrar com a operação, primeiro e segundo valor, exiba o resultado na tela.
        /// </summary>
        public static void Desafio_018()
        {
            Console.Write("Digite (1) para Adicão, (2) para Subtração, (3) para Multiplicação ou (4) para Divisão.");
            int operacao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um número: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um número: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    Console.WriteLine("{0} + {1} = {2}", valor1, valor2, valor1 + valor2);
                    break;
                case 2:
                    Console.WriteLine("{0} - {1} = {2}", valor1, valor2, valor1 - valor2);
                    break;
                case 3:
                    Console.WriteLine("{0} x {1} = {2}", valor1, valor2, valor1 * valor2);
                    break;
                case 4:
                    Console.WriteLine("{0} / {1} = {2}", valor1, valor2, valor1 / valor2);
                    break;
            }

        }
        /// <summary>
        /// Desafio 19 - Desenvolva um método que solicite a entrada da idade de um determinado usuário, 
        /// se for menor que 18 anos exiba na cor vermelha “Sem permissão”, caso seja maior ou igual a 18 anos exiba na cor verde “Permissão concedida”.
        /// Para tanto, pesquise como funciona a propriedade Console.ForegroundColor.
        /// </summary>
        public static void Desafio_019()
        {
            Console.Write("Digite a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            if (idade < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem permissão");
            }
            else
                if (idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão concedida");
            }


        }
        /// <summary>
        /// Desafio 20 - Desenvolva um método que solicite a entrada de uma frase, 
        /// após isto troque todas as letras A ou a por &. Para tanto, pesquise como funciona o método String.Replace().
        /// </summary>
        public static void Desafio_020()
        {
            Console.WriteLine("Digite uma Frase ");
            string frase = Console.ReadLine();
            Console.WriteLine("Frase original: {0}", frase);
            Console.WriteLine("Frase modificada: {0}", frase.Replace('A', '&').Replace('a', '&'));
        }
        /// <summary>
        /// Desafio 21 - Desenvolva um método que calcule o reajuste salarial. 
        /// Se o salário for abaixo de 1.700 o ajuste é de R$300.00, se maior o reajuste é de R$ 200.00. Para finalizar, exiba o novo salário na tela.
        /// </summary>
        public static void Desafio_021()
        {
            Console.Write("Digite o seu salario: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());
            decimal ajuste300 = salario + 300;
            decimal ajuste200 = salario + 200;
            if (salario < 1700)
            {
                Console.WriteLine("O seu salario é {0} ", ajuste300);
            }
            else
                if (salario >= 1700)
            {
                Console.WriteLine("O O seu salario é {0} ", ajuste200);
            }
        }
        /// <summary>
        /// Desafio 22 - Desenvolva um método que calcule o IMC de uma determinada pessoa. Para tanto, pesquise como funciona o cálculo do IMC.
        /// </summary>
        public static void Desafio_022()
        {
            Console.Write("Digite a sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            double imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é {0}", imc);

        }
        /// <summary>
        /// Desafio 23 - Desenvolva um método que calcule o volume de uma caixa d'água retangular. Para tanto, 
        /// pesquise como calcular o volume de um retângulo.
        /// </summary>
        public static void Desafio_023()
        {
            Console.Write("Digite a largura: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o Comprimento: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double retangulo = largura * comprimento * altura;

            Console.WriteLine("O comprimento é {0} metros, a largura {1} metros e a altura {2}, o volume dessa caixa é {3}", comprimento, largura, altura, retangulo);
        }
        /// <summary>
        /// Desafio 24 - Desenvolva um método que calcule o volume de um Cilindro qualquer. 
        /// Para tanto, pesquise como calcular o volume de um cilindro.
        /// </summary>
        public static void Desafio_024()
        {
            Console.Write("Digite a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            double cilindro = 3.1 * ((raio * raio) * 5);

            Console.WriteLine("O volume do cilindro é : {0}cm³", cilindro);
        }
        /// <summary>
        /// Desafio 25 - Desenvolva um método que calcule o quadrado da diferença entre dois números quaisquer. 
        /// Para tanto, pesquise como funciona o método Math.Pow.
        /// </summary>
        public static void Desafio_025()
        {
            Console.Write("Digite um numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            double resultado1 = Math.Pow(numero1, 2);
            Console.Write("Digite um numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            double resultado2 = Math.Pow(numero2, 2);
            double direfenca = resultado1 - resultado2;
            Console.WriteLine("A diferença de {0} a {1} é {2}.", resultado1, resultado2, direfenca);



        }
        /// <summary>
        /// Desafio 26 - Desenvolva um método que calcule o volume de uma esfera. Para tanto, pesquise como calcular o volume de uma esfera.
        /// </summary>
        public static void Desafio_026()
        {
            Console.Write("Digite o raio da esfera: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            double raio1 = Math.Pow(raio, 3);
            double esfera = (4 * 3.14 * raio1) / 3;

            Console.WriteLine("O volume da esfera é: {0}", esfera);
        }
        /// <summary>
        /// Desafio 27 - Desenvolva um método que leia dois números reais e efetue as quatro operações entre eles.
        /// </summary>
        public static void Desafio_027()
        {
            Console.Write("Digite um número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite um número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            double soma = numero1 + numero2;
            double subtracao = numero1 - numero2;
            double multiplicacao = numero1 * numero2;
            double divisao = numero1 / numero2;

            Console.WriteLine("A soma é: {0}", soma);
            Console.WriteLine("A subtracao é: {0}", subtracao);
            Console.WriteLine("A multiplicação é: {0} ", multiplicacao);
            Console.WriteLine("A divisão é: {0}  ", divisao);
        }
        /// <summary>
        /// Desafio 28 - Desenvolva um método que calcule o consumo de combustível, ou seja a quantidade de litros consumidos em uma viagem de veículo.
        /// </summary>
        public static void Desafio_028()
        {
            Console.Write("Informe quantos quilometros foi rodado na sua viagem: ");
            double km = Convert.ToDouble(Console.ReadLine());
            double litro = km / 12;

            Console.WriteLine("O Consume de gasolina é {0} litros.", litro);
        }
        /// <summary>
        /// Desafio 29 - Desenvolva um método que calcule o valor de uma prestação em atraso, baseado em uma taxa de juros informada pelo usuário.
        /// </summary>

        public static void Desafio_029()
        {
            Console.Write("Digite o valor da parcela: ");
            double parcela = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a taxa de juros por dia: ");
            double juros = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe os dias de atraso: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            double prestacao = parcela + (juros * dia);

            Console.WriteLine("O valor da sua prestação é {0} reais.", prestacao);
        }
        /// <summary>
        /// Desafio 30 - Desenvolva um método que identifique o maior e o menor número dentre 5 números fornecidos pelo usuário.
        /// </summary>
        public static void Desafio_030()
        {
            
            List<int> listaDeNumeros = new List<int>();
            
                
                int numero1 = 5;
            for (int i = 0; i < numero1; i++)
            {
                Console.WriteLine("Informe um numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                listaDeNumeros.Add(numero);
             }
       
            foreach (int numero in listaDeNumeros)
            {
                Console.WriteLine("Números informados : {0}", numero);
            }
            int numeromaximo = numero()
            
            

        }
    }
}

