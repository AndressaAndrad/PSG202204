using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDB.IBGE
{
    public static class RegiaoFakeDB
    {
        private static List<Regiao> regiao = new List<Regiao>();

        public static List<Regiao> Regiao
        {
            get
            {
                if (regiao.Count() == 0)
                {
                    AdicionarRegiao();
                }
                return regiao;
            }
        }

            public static void AdicionarRegiao()
            {
                regiao.Add(new Regiao(1, "Norte"));
                regiao.Add(new Regiao(2, "Nordeste"));
                regiao.Add(new Regiao(3, "Centro-Oeste"));
                regiao.Add(new Regiao(4, "Sudeste"));
                regiao.Add(new Regiao(5, "Sul"));

            }
        
    }
}
