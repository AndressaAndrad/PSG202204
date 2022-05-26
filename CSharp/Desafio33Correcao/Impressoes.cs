using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapConsoleApp2.Desafios
{
    public static class Impressoes
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        public static void ImprimirCabecalho(string mensagem)
        {
            Console.Clear();
            Console.WriteLine(mensagem);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        public static void ImprimirRodape(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("-- Tecle <ENTER> para seguir. --");
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="est"></param>
        public static void ImprimirEstado(Estado est)
        {
            Console.Write("Código: {0} | ", est.Codigo);
            Console.Write("Nome: {0} | ", est.Descricao);
            Console.Write("Sigla: {0} | ", est.SiglaUF);
            Console.WriteLine("Região: {0} ", est.RegiaoBrasil);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="estados"></param>
        public static void ImprimirEstados(List<Estado> estados)
        {
            foreach (Estado estado in estados)
            {
                ImprimirEstado(estado);
            }
            Console.WriteLine("Total de Registros: {0}", estados.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mun"></param>
        public static void ImprimirMunicipio(Municipio mun)
        {
            Console.Write("Código: {0} | ", mun.Codigo);
            Console.Write("Nome: {0} | ", mun.Descricao);
            Console.Write("Sigla: {0} | ", mun.SiglaUF);
            Console.WriteLine("Cód. IBGE 7: {0} ", mun.CodigoIBGE7);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="municipios"></param>
        public static void ImprimirMunicipios(List<Municipio> municipios)
        {
            foreach (Municipio mun in municipios)
            {
                ImprimirMunicipio(mun);
            }
        }
    }
}
