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

                    double maior = 0;
                    double menor = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("Informe um número: ");
                        double numero = Convert.ToDouble(Console.ReadLine());
                        if (i == 0)
                        {
                            maior = numero;
                            menor = numero;
                        }
                        else
                            if (numero > maior)
                        {
                            maior = numero;
                        }
                        else
                            if (numero < menor)
                        {
                            menor = numero;
                        }

                    }
                    Console.WriteLine("O maior é {0}", maior);
                    Console.WriteLine("O menor é {0}", menor);
                }
            }
        }

