using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public abstract class Pais
    {
        protected string siglauf;
        protected string nomeRegiao;

        public string Siglauf { get => siglauf; set => siglauf = value; }
        public string NomeRegiao { get => nomeRegiao; set => nomeRegiao = value; }

        public Pais()
        { }

        public Pais(string siglauf, string nomeRegiao)
        {
            this.siglauf = siglauf;
            this.nomeRegiao = nomeRegiao;
        }

        protected Pais(string siglauf)
        {
            this.siglauf = siglauf;
        }

        public virtual void ImprimirSigla()
        {
            Console.WriteLine("Sigla: {0}", this.siglauf);
        }

        public virtual void ImprimirRegiao()
        {
            Console.WriteLine("Região: {0}", this.nomeRegiao);
        }

    }
}
