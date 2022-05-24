
using CapConsoleApp2.EstudoPOO;
using Modelos;
using FakeDB.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap202204ConsoleApp.Desafios
{
    public class DesafioDojo2
    {
        private List<Estado> listaEstadosRegiaoSelecionada;
        private List<Municipio> listaConsultarMunicipioPeloNome;
        private List<Estado> estados;
        private List<Estado> sigla;
        private List<Municipio> listaMunicipioPorEstado;
        private List<Municipio> pesquisarMunicipioPorIBGE7;
        private List<Municipio> pesquisarMunicipioPorCep;

        public DesafioDojo2()
        {

        }

        public void Executar()
        {
            this.Exercicio01();
            this.Exercicio02();
            this.Exercicio03();
            this.Exercicio04();
            this.Exercicio05();
            this.Exercicio06();
            this.Exercicio07();
        }

       
        private void Exercicio01()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("--EXERCÍCIO 01--");
                Console.Write("Digite o nome de um Estado: ");
                string nome = Console.ReadLine();
                this.estados = FakeDB.IBGE.EstadoFakeDB.Estados.Where(pes => pes.NomeEstado.StartsWith(nome)).ToList();
                Console.WriteLine("número de estados encontrados: {0}.", this.estados.Count());
                foreach (Estado item in this.estados)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("- Estado encontrado -");
                    item.ImprimirSigla();
                    item.ImprimirRegiao();
                    Console.ResetColor();
                }
                if (this.estados.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Estado não encontrado. ");
                    Console.ResetColor();
                }
                Console.Write("Deseja passar para o proximo exercicio (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
             
            }
        }
       
        

        private void Exercicio02()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("-- EXERCÍCIO 02--");
                Console.Write("Digite uma Sigla de Estado: ");
                string nome = Console.ReadLine();
                if (nome.Length != 2)
                {
                    Console.WriteLine("Sigla não encontrada, digite novamente!");
                }
                this.sigla = FakeDB.IBGE.EstadoFakeDB.Estados.Where(pes => pes.Siglauf == nome).ToList();
                Console.WriteLine("número de Siglas encontradas: {0}.", this.sigla.Count());
                foreach (Estado item in this.sigla)
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("- Sigla encontrada -");
                    item.ImprimirSigla();
                    item.ImprimirRegiao();
                    Console.ResetColor();
                }
                if (this.sigla.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sigla não encontrada.");
                    Console.ResetColor();
                }
                Console.Write("Deseja passar para o proximo exercicio (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
            }
           
        }

        
        private void Exercicio03()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("--EXERCÍCIO 03--");
                Console.WriteLine("-Lista para mostrar todos os estados da região desejada-");
                Console.Write("Escolha a região desejada: ");
                string regiao = Console.ReadLine();
                this.listaEstadosRegiaoSelecionada = FakeDB.IBGE.EstadoFakeDB.Estados
                    .Where(pes => pes.NomeRegiao.ToUpper() == regiao || pes.NomeRegiao.ToLower() == regiao || pes.NomeRegiao == regiao)
                    .ToList();
                Console.WriteLine("Estados da regiao {0}:", regiao);
                foreach (Estado item in this.listaEstadosRegiaoSelecionada)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    item.ImprimirSigla();
                    item.ImprimirRegiao();
                    Console.ResetColor();
                }
                if (this.listaEstadosRegiaoSelecionada.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Essa região não existe.");
                    Console.ResetColor();
                }
                Console.Write("Deseja passar para o proximo exercicio (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
            }
           
        }

        
        private void Exercicio04()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("--EXERCÍCIO 04--");
                Console.Write("Consultar o município que você procura? ");
                string nomem = Convert.ToString(Console.ReadLine());

                this.listaConsultarMunicipioPeloNome = MunicipioFakeDB.Municipios.Where(pes => pes.NomeMunicipio.ToLower() == nomem).ToList();
                foreach (Municipio item in this.listaConsultarMunicipioPeloNome)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    item.ImprimirSigla();
                    Console.ResetColor();

                }
                if (this.listaConsultarMunicipioPeloNome.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não encontrado.");
                    Console.ResetColor();
                }

                Console.Write("Deseja passar para o proximo exercicio (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
            }
           
           
        }

      
        public void Exercicio05()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("-- EXERCÍCIO  5");
                Console.WriteLine("Digite a sigla do estado (ex: RO): ");
                string opcao = Console.ReadLine();
                this.listaMunicipioPorEstado = MunicipioFakeDB.Municipios.Where(pes => pes.Siglauf.StartsWith(opcao)).ToList();
                if (this.listaMunicipioPorEstado.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não existem dados a serem exibidos.");
                    Console.ResetColor();
                }
                else
                {
                    foreach (Municipio item in this.listaMunicipioPorEstado)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        item.ImprimirSigla();
                        Console.ResetColor();
                    }
                }
                Console.Write("Deseja passar para o proximo exercicio (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
                Console.WriteLine("Total de Registros: {0}", this.listaMunicipioPorEstado.Count());
               
              
            }
          
        }

      
        public void Exercicio06()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("-- EXERCÍCIO 06 --");
                Console.WriteLine("Digite o Código do IBGE: ");
                int resposta = Convert.ToInt32(Console.ReadLine());
                this.pesquisarMunicipioPorIBGE7 = MunicipioFakeDB.Municipios.Where(pes => pes.Ibge7 == resposta).ToList();
                if (this.pesquisarMunicipioPorIBGE7.Count() == 0)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Não existem dados a serem exibidos.");
                    Console.ResetColor();
                }
                else
                {
                    foreach (Municipio item in this.pesquisarMunicipioPorIBGE7)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        item.ImprimirSigla();
                        Console.ResetColor();
                    }
                }
                Console.Write("Deseja passar para o proximo exercicio (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
                Console.WriteLine("Total de Registros: {0}", this.pesquisarMunicipioPorIBGE7.Count());
                Console.WriteLine(); 
            }
        }

        public void Exercicio07()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("-- EXERCÍCIO 10 --");
                Console.WriteLine("Digite o CEP: ");
                int resposta = Convert.ToInt32(Console.ReadLine());
                this.pesquisarMunicipioPorCep = MunicipioFakeDB.Municipios.Where(pes => pes.Cep == resposta).ToList();
                if (this.pesquisarMunicipioPorCep.Count() == 0)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Não existem dados a serem exibidos.");
                    Console.ResetColor();
                }
                else
                {
                    foreach (Municipio item in this.pesquisarMunicipioPorCep)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        item.ImprimirSigla();
                        Console.ResetColor();
                    }

                }
                Console.Write("Deseja passar para o proximo exercicio (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
                Console.WriteLine("Total de Registros: {0}", this.pesquisarMunicipioPorCep.Count());
                Console.WriteLine("-- FIM DOS EXERCÍCIOS --"); 
            }

        }
       
    }
}
