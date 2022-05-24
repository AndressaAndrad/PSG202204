using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Estado : Pais
    {
        private int codigoEstado;
        private string nomeEstado;




        public int CodigoEstado { get => codigoEstado; set => codigoEstado = value; }
        public string NomeEstado { get => nomeEstado; set => nomeEstado = value; }

        public Estado()
        { }

        public Estado(int codigoEstado, string nomeEstado, string siglauf, string nomeRegiao) : base(siglauf, nomeRegiao)
        {
            this.codigoEstado = codigoEstado;
            this.nomeEstado = nomeEstado;
        }

        public override void ImprimirSigla()
        {
            Console.WriteLine("Código: {0}", this.codigoEstado);
            Console.WriteLine("Estado: {0}", this.nomeEstado);
            base.ImprimirSigla();
        }

        public override void ImprimirRegiao()
        {
            base.ImprimirRegiao();
        }
    }
}
