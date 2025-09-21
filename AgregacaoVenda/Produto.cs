using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;

        public MostrarAtributos()
        {
            return codigo + " " + nome + " " + preco;
        }

    }
}