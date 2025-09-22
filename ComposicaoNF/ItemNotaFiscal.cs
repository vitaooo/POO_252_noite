using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNF
{
    public class ItemNotaFiscal
    {
        public int QtdeProduto { get; set;}
        public ItemNotaFiscal ( int qtdeProduto) {
            QtdeProduto = qtdeProduto;
        }

        ~ItemNotaFiscal(){ // destrutor da classe
            System.Console.WriteLine("Destruindo a Item Nota Fiscal");
        }
        public void Mostrar() {
            System.Console.WriteLine("Quantidade de produto: " + QtdeProduto);
        }
    }
}