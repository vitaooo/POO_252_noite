using System;
using System.Collections.Generic;

namespace AgregacaoVenda
{
    public class Venda
    {
        private Comprador comp;
        private Vendedor vend;
        private List<Produto> vetProd;

        public Venda(Comprador comprador, Vendedor vendedor, List<Produto> produtos)
        {
            this.comp = comprador;
            this.vend = vendedor;
            this.vetProd = produtos;
        }

        public void RealizarVenda()
        {
            double totalVenda = 0;


            foreach (var produto in vetProd)
            {
                totalVenda += produto.Preco;
            }

            System.Console.WriteLine("Processando Venda no valor total de: " + totalVenda);

            if (comp.Verba >= totalVenda)
            {
                comp.RetirarVerba(totalVenda);

                foreach (var produto in vetProd)
                {
                    vend.AdicionarComissao(produto.Preco);
                }
                System.Console.WriteLine("venda APROVADA e finalizada com sucesso!");
            }
            else
            {
                System.Console.WriteLine("Venda REPROVADA. Saldo insuficiente!");
            }
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("\nDetalhes da Venda");
            System.Console.WriteLine(comp.MostrarAtributo());
            System.Console.WriteLine(vend.MostrarAtributo());
            System.Console.WriteLine("Produtos vendidos: ");
            foreach (var produto in vetProd)
            {
                System.Console.WriteLine($"\t- {produto.MostrarAtributos()}");
            }
        }
    }
} 