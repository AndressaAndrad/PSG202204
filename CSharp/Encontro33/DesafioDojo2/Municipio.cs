using System;


namespace Modelos
{
    public class Municipio : Pais
    {
        private int codigoMunicipio;
        private string nomeMunicipio;
        private int ibge;
        private int ibge7;
        private int populacao;
        private int cep;

        public int CodigoMunicipio { get => codigoMunicipio; set => codigoMunicipio = value; }
        public string NomeMunicipio { get => nomeMunicipio; set => nomeMunicipio = value; }
        public int Ibge { get => ibge; set => ibge = value; }
        public int Ibge7 { get => ibge7; set => ibge7 = value; }
        public int Populacao { get => populacao; set => populacao = value; }
        public int Cep { get => cep; set => cep = value; }

        public Municipio() : base()
        { }

        public Municipio(int codigoMunicipio, string nomeMunicipio, string siglauf, int ibge, int ibge7, int populacao, int cep) : base(siglauf)
        {
            this.codigoMunicipio = codigoMunicipio;
            this.nomeMunicipio = nomeMunicipio;
            this.ibge = ibge;
            this.ibge7 = ibge7;
            this.populacao = populacao;
            this.cep = cep;
        }

        public override void ImprimirSigla()
        {
            Console.WriteLine("Código: {0}", this.codigoMunicipio);
            Console.WriteLine("Município: {0}", this.NomeMunicipio);
            base.ImprimirSigla();
            Console.WriteLine("IBGE: {0}", this.ibge);
            Console.WriteLine("IBGE7: {0}", this.ibge7);
            Console.WriteLine("População: {0}", this.populacao);
            Console.WriteLine("CEP: {0}", this.cep);
        }

    }
}
