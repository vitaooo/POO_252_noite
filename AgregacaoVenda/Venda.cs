using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Comprador comp;
        public Vendedor vend;
        public Produto vetProd;

        void venda()
        {
            
        }

        MostrarAtributos()
        {
            return comp + " " +
            vend + " " +
            vetProd;
        }
    }
} 