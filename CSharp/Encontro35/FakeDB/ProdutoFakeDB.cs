using Atacado.Modelo.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.FakeDB.Estoque
{
    public static class ProdutoFakeDB
    {
        private static List<Produto> produtos = new List<Produto>();

        public static List<Produto> Produtos
        {
            get
            {
                if (produtos.Count() == 0)
                {
                    AdicionarProdutos();
                }
                return produtos;
            }
        }

        private static void AdicionarProdutos()
        {

        }
    }
}
