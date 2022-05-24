using System;


namespace Modelos
{
    public class Regiao : Pais
    {
        private int codigo;
        private string siglaRegiao;

        public int Codigo { get => codigo; set => codigo = value; }
        public string SiglaRegiao { get => siglaRegiao; set => siglaRegiao = value; }

        public Regiao()
        { }

        public Regiao(int codigo, string nomeRegiao, string siglaRegiao) : base(nomeRegiao)
        {
            this.codigo = codigo;
            this.siglaRegiao = siglaRegiao;
        }

        public override void ImprimirRegiao()
        {
            Console.WriteLine("Código:{0}", this.codigo);
            Console.WriteLine("Região: {0}", this.nomeRegiao);
            Console.WriteLine("Sigla da região: {0}", this.siglaRegiao);
            base.ImprimirRegiao();
        }

    }
}
