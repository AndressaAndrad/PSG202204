using Cap202204ConsoleApp.FakeDB;
using Cap202204ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap202204ConsoleApp.Desafio
{
    public class Desafio045
    {
        private List<Pessoa> listaDePessoas;
        private List<Pessoa> listaDeNascidos;
        private List<Pessoa> listadeNascidos55a60;
        private List<Pessoa> listadeNascidosMes;
        private List<Pessoa> listaNomesLetraA;
        private List<Pessoa> listaNomes;
        private List<Pessoa> listaProcuraDataDeNascimento;
        private List<Pessoa> listaMasculinaDecada60;
        private List<Pessoa> listaFemininaAno55a60;


        public Desafio045()
        {
            this.listaDePessoas = PessoaFakeDB.Pessoas;
            this.listaDeNascidos = new List<Pessoa>();
            this.listadeNascidos55a60 = new List<Pessoa>();
            this.listadeNascidosMes = new List<Pessoa>();
            this.listaNomesLetraA = new List<Pessoa>();
            this.listaNomes = new List<Pessoa>();
            this.listaProcuraDataDeNascimento = new List<Pessoa>();
            this.listaMasculinaDecada60 = new List<Pessoa>();
            this.listaFemininaAno55a60 = new List<Pessoa>();
        }

        public void Executar()
        {
            this.NascidosDecada60();
            this.Nascidosano55Ate60();
            this.NascidosMes();
            this.NomesLetraA();
            this.ProcuraPeloNome();
            this.ProcuraDataDeNascimento();
            this.ListaMasculinoDecada60();
            this.ListaFemininaAno55a60();
        }
        /// <summary>
        /// 1 - crie um método que produza uma lista paralela com todos nascidos na década de 1960.
        /// </summary>
        private void NascidosDecada60()
        {
            DateTime janeiro60 = Convert.ToDateTime("01-01-1960");
            DateTime dezembro69 = Convert.ToDateTime("31-12-1969");
            this.listaDeNascidos = PessoaFakeDB.Pessoas.Where(pes => pes.DtNascimento > janeiro60 && pes.DtNascimento < dezembro69 ).ToList();
            Console.WriteLine(" Lista década de 60");
            Console.WriteLine("Qtde de pessoa: {0}", this.listaDeNascidos.Count());
            Console.ReadLine();

        }
        /// <summary>
        /// 2 - crie um método que produza uma lista paralela com todos nascidos entre 1955 e 1960.
        /// </summary>
        private void Nascidosano55Ate60()
        {
            Console.Clear();
            DateTime ano55 = Convert.ToDateTime("01/01/1955");
            DateTime ano60 = Convert.ToDateTime("31/12/1960");
            this.listadeNascidos55a60 = PessoaFakeDB.Pessoas.Where(pes => pes.DtNascimento >= ano55 && pes.DtNascimento < ano60).ToList();
            Console.WriteLine("Lista de nascidos entre 1955 e 1960. ");
            Console.WriteLine("Qtde de pessoas: {0}", this.listadeNascidos55a60.Count());
            Console.ReadLine();

        }
        /// <summary>
        /// 3 - crie um método que produza uma lista paralela com todos nascidos em determinado mês.
        /// </summary>

        private void NascidosMes()
        {
            Console.Clear();
            int mes = 0;
            while (true)
            {
                Console.WriteLine("Digite o mês que deseja visualizar: ");
                string resposta = Console.ReadLine(); 
                if (int.TryParse(resposta, out mes )== false)
                {
                     Console.WriteLine("Mês incorreto, tente novamente.");
                }
                else
                {
                    break;
                }
            }
            this.listadeNascidosMes = PessoaFakeDB.Pessoas.Where(pes => pes.DtNascimento.Month == mes).ToList();
            if (this.listadeNascidosMes.Count == 0)
            {
                Console.WriteLine("Não existem dados a serem exibidos.");
            }
            else
            {
                foreach (Pessoa item in this.listadeNascidosMes)
                {
                    Console.WriteLine("Código: {0} | Nome Completo: {1} {2} | Data de Nascimento {3}",
                        item.Codigo, item.Nome, item.SobreNome, item.DtNascimento);
                }
            }
            Console.WriteLine("Qtde de nascidos do mês {0} são {1}.", mes, this.listadeNascidosMes.Count());
            Console.ReadLine();


        }
        /// <summary>
        /// 4 - crie um método que produza uma lista paralela com todos cujo nome comece com a letra A.
        /// </summary>

        private void NomesLetraA()
        {
            Console.Clear();
            this.listaNomesLetraA = PessoaFakeDB.Pessoas.Where(pes => pes.Nome[0] == 'A').ToList();
          Console.WriteLine("Qtde que incia com a letra A: ", this.listaNomesLetraA);
            foreach (Pessoa item in this.listaNomesLetraA)
            {
                Console.WriteLine(item.Nome);
            }
            Console.ReadLine();
        }
    /// <summary>
    /// 5 - crie um método que pesquise pessoas pelo nome e exiba o resultado.
    /// </summary>
    private void ProcuraPeloNome()
        {
            Console.Clear();
            Console.WriteLine("Digite um Nome: ");
            string nome = Console.ReadLine();
            this.listaNomes = PessoaFakeDB.Pessoas.Where(pes => pes.Nome == nome).ToList();
            foreach(Pessoa item in this.listaNomes)
            {
                Console.WriteLine("Nome Completo {0} {1}| Data de Nascimento: {2} | Telefone {3}.",
                    item.Nome, item.SobreNome, item.DtNascimento, item.Telefone);
            }
            
            Console.ReadLine();
        }
        /// <summary>
        /// 6 - crie um método que pesquise pessoas pelo ano de nascimento.
        /// </summary>

        private void ProcuraDataDeNascimento()
        {
            Console.Clear();
           
            int ano = 0;
            while (true)
            {
                Console.WriteLine("Digite o ano de nascimento (ex.1960): ");
                string data = Console.ReadLine();
                if (int.TryParse(data, out ano) == false)
                {
                    Console.WriteLine("Ano incorreto, tente novamente.");
                }
                else
                {
                    if (data.Length < 4)
                    {
                        Console.WriteLine("Ano incorreto, tente novamente.");
                    }
                    else
                    {
                        break;
                    }
                } 
            }
            this.listaProcuraDataDeNascimento = PessoaFakeDB.Pessoas.Where(pes => pes.DtNascimento.Year == ano).ToList();
            if (this.listaProcuraDataDeNascimento.Count() == 0)
            {
                Console.WriteLine("Não existem dados a serem exibidos.");
            }
            else
            {
                foreach (Pessoa item in this.listaProcuraDataDeNascimento)
                {
                    Console.WriteLine("Nome: {0} {1} ", item.Nome, item.SobreNome);
                }
            }

            Console.ReadLine();

        }
        /// <summary>
        /// 7 - crie um método que utilize a lista 1, e exiba somente os homens.
        /// </summary>
        private void  ListaMasculinoDecada60()
        {
            Console.Clear();
            this.listaMasculinaDecada60 = this.listaDeNascidos.Where(pes => pes.Sexo == "M").ToList();
            foreach (Pessoa item in this.listaMasculinaDecada60)
            {
              Console.WriteLine("Nome Masculinos: {0}", item.Nome); 
            }
            Console.ReadLine();
        }
        /// <summary>
        /// 8 - crie um método que utilize a lista 2, e exiba somente as mulheres.
        /// </summary>
        private void ListaFemininaAno55a60()
        {
            Console.Clear();
            this.listaFemininaAno55a60 = this.listadeNascidos55a60.Where(pes => pes.Sexo == "F").ToList();
            foreach (Pessoa item in this.listaFemininaAno55a60) 
            {
                Console.WriteLine("Nome Femininos: {0}", item.Nome);
            }
        }
    }

}
