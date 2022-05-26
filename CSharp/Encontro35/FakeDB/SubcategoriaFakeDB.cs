using Atacado.Modelo.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.FakeDB.Estoque
{
    public static class SubcategoriaFakeDB
    {
        private static List<Subcategoria> subcategorias = new List<Subcategoria>();

        public static List<Subcategoria> Subcategorias
        {
            get
            {
                if (subcategorias.Count() == 0)
                {
                    AdicionarSubcategorias();
                }
                return subcategorias;
            }
        }

        private static void AdicionarSubcategorias()
        {

        }
    }
}
