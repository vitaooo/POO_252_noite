using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNF
{
    public class ItemNotaFiscal
    {
        public int QtdeProduto { get; set;}
        public void ItemNotaFiscal ( int qtdeProduto) {
            QtdeProduto = qtdeProduto;
        }

        public void Mostrar() {
            System.Console.WriteLine("Quantidade de produto: ");

        }
    }
}